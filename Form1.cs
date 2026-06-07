using System.IO;

namespace SistemPelaporanFasilitas_K10
{
    public partial class FormUtama : Form
    {
        private string pathFoto = "";

        public FormUtama()
        {
            InitializeComponent();
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            InisialisasiComboBox();
            InisialisasiListView();

            txtPassword.PasswordChar = '*';

            tabMain.TabPages.Remove(tabAdmin);

            LoadDashboard();
        }

        // INISIALISASI UI
        private void InisialisasiComboBox()
        {
            // Kategori
            cbKategori.Items.Add("Elektronik");
            cbKategori.Items.Add("Furniture");
            cbKategori.Items.Add("Bangunan");
            cbKategori.Items.Add("Lainnya");
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;

            // Gedung
            cbGedung.Items.Add("Gedung D4");
            cbGedung.Items.Add("Gedung D3");
            cbGedung.Items.Add("Pascasarjana");
            cbGedung.Items.Add("SAW");
            cbGedung.DropDownStyle = ComboBoxStyle.DropDownList;

            // Prioritas
            cbPrioritas.Items.Add("Penting");
            cbPrioritas.Items.Add("Sedang");
            cbPrioritas.Items.Add("Cukup");
            cbPrioritas.DropDownStyle = ComboBoxStyle.DropDownList;

            // Status Admin
            cbStatusBaru.Items.Add("Menunggu");
            cbStatusBaru.Items.Add("Diverifikasi");
            cbStatusBaru.Items.Add("Diproses");
            cbStatusBaru.Items.Add("Selesai");
            cbStatusBaru.Items.Add("Ditolak");
            cbStatusBaru.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InisialisasiListView()
        {
            lvLaporan.View = View.Details;
            lvLaporan.GridLines = true;
            lvLaporan.FullRowSelect = true;

            lvLaporan.Columns.Clear();

            lvLaporan.Columns.Add("Kode", 80);
            lvLaporan.Columns.Add("Tanggal", 100);
            lvLaporan.Columns.Add("Nama", 120);
            lvLaporan.Columns.Add("Gedung", 100);
            lvLaporan.Columns.Add("Ruangan", 100);
            lvLaporan.Columns.Add("Fasilitas", 120);
            lvLaporan.Columns.Add("Kategori", 100);
            lvLaporan.Columns.Add("Prioritas", 100);
            lvLaporan.Columns.Add("Status", 100);
        }

        // GENERATE KODE LAPORAN
        private string GenerateKode()
        {
            string folderData = Application.StartupPath + "\\data";
            string fileLaporan = folderData + "\\laporan.txt";

            if (!Directory.Exists(folderData))
                Directory.CreateDirectory(folderData);

            if (!File.Exists(fileLaporan))
                return "LP0001";

            int jumlah = File.ReadAllLines(fileLaporan).Length + 1;
            return "LP" + jumlah.ToString("0000");
        }

        // UPLOAD GAMBAR
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.png;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathFoto = ofd.FileName;
                picFoto.Image = Image.FromFile(pathFoto);
                picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // KIRIM LAPORAN
        private void btnKirim_Click(object sender, EventArgs e)
        {
            // Validasi input
            if (txtNama.Text == "" ||
                txtRuangan.Text == "" ||
                txtFasilitas.Text == "" ||
                txtDeskripsi.Text == "" ||
                cbGedung.SelectedIndex == -1 ||
                cbKategori.SelectedIndex == -1 ||
                cbPrioritas.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi semua data terlebih dahulu!");
                return;
            }

            string folderData = Application.StartupPath + "\\data";
            string folderGambar = Application.StartupPath + "\\gambar";

            if (!Directory.Exists(folderData))
                Directory.CreateDirectory(folderData);

            if (!Directory.Exists(folderGambar))
                Directory.CreateDirectory(folderGambar);

            string kode = GenerateKode();
            string namaFoto = "";

            // Copy gambar jika ada
            if (pathFoto != "")
            {
                namaFoto = kode + Path.GetExtension(pathFoto);

                File.Copy(
                    pathFoto,
                    Path.Combine(folderGambar, namaFoto),
                    true
                );
            }

            string fileLaporan = Path.Combine(folderData, "laporan.txt");

            string data =
                kode + "|" +
                dtTanggal.Value.ToShortDateString() + "|" +
                txtNama.Text + "|" +
                cbGedung.Text + "|" +
                txtRuangan.Text + "|" +
                txtFasilitas.Text + "|" +
                cbKategori.Text + "|" +
                cbPrioritas.Text + "|" +
                txtDeskripsi.Text + "|" +
                "Menunggu" + "|" +
                namaFoto;

            File.AppendAllText(fileLaporan, data + Environment.NewLine);

            MessageBox.Show("Laporan berhasil dikirim!");

            BersihkanForm();
            LoadDataLaporan();
            LoadRekap();
            LoadDashboard();
        }

        // RESET FORM
        private void BersihkanForm()
        {
            txtNama.Clear();
            txtRuangan.Clear();
            txtFasilitas.Clear();
            txtDeskripsi.Clear();

            cbGedung.SelectedIndex = -1;
            cbKategori.SelectedIndex = -1;
            cbPrioritas.SelectedIndex = -1;

            picFoto.Image = null;
            pathFoto = "";

            dtTanggal.Value = DateTime.Now;
        }

        // LOGIN ADMIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string fileAdmin = Path.Combine(Application.StartupPath, "data", "admin.txt");

            if (!File.Exists(fileAdmin))
            {
                MessageBox.Show("File admin tidak ditemukan!");
                return;
            }

            string[] dataAdmin = File.ReadAllLines(fileAdmin);
            bool loginBerhasil = false;

            foreach (string baris in dataAdmin)
            {
                string[] data = baris.Split('|');

                if (data.Length >= 2)
                {
                    if (txtUsername.Text == data[0] &&
                        txtPassword.Text == data[1])
                    {
                        loginBerhasil = true;
                        break;
                    }
                }
            }

            if (loginBerhasil)
            {
                MessageBox.Show("Login berhasil!");

                if (!tabMain.TabPages.Contains(tabAdmin))
                    tabMain.TabPages.Add(tabAdmin);

                LoadDataLaporan();
                LoadComboBoxID();

                tabMain.SelectedTab = tabAdmin;

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!");
            }
        }

        // LOAD DATA LAPORAN
        private void LoadDataLaporan()
        {
            lvLaporan.Items.Clear();

            string fileLaporan = Path.Combine(Application.StartupPath, "data", "laporan.txt");

            if (!File.Exists(fileLaporan))
                return;

            string[] semuaData = File.ReadAllLines(fileLaporan);

            foreach (string baris in semuaData)
            {
                if (string.IsNullOrWhiteSpace(baris))
                    continue;

                string[] data = baris.Split('|');

                if (data.Length < 11)
                    continue;

                ListViewItem item = new ListViewItem(data[0]);
                item.SubItems.Add(data[1]);
                item.SubItems.Add(data[2]);
                item.SubItems.Add(data[3]);
                item.SubItems.Add(data[4]);
                item.SubItems.Add(data[5]);
                item.SubItems.Add(data[6]);
                item.SubItems.Add(data[7]);
                item.SubItems.Add(data[9]);

                lvLaporan.Items.Add(item);
            }
        }

        // LOAD COMBO BOX ID
        private void LoadComboBoxID()
        {
            comboBox1.Items.Clear();

            string fileLaporan = Path.Combine(Application.StartupPath, "data", "laporan.txt");

            if (!File.Exists(fileLaporan))
                return;

            string[] semuaData = File.ReadAllLines(fileLaporan);

            foreach (string baris in semuaData)
            {
                if (string.IsNullOrWhiteSpace(baris))
                    continue;

                string[] data = baris.Split('|');

                if (data.Length > 0)
                {
                    string kode = data[0];

                    if (!comboBox1.Items.Contains(kode))
                        comboBox1.Items.Add(kode);
                }
            }
        }

        // UPDATE STATUS
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string fileLaporan = Path.Combine(Application.StartupPath, "data", "laporan.txt");

            if (!File.Exists(fileLaporan))
                return;

            string[] semuaData = File.ReadAllLines(fileLaporan);
            string kodeDipilih = comboBox1.Text;
            string statusBaru = cbStatusBaru.Text;

            bool ditemukan = false;

            for (int i = 0; i < semuaData.Length; i++)
            {
                string[] data = semuaData[i].Split('|');

                if (data.Length < 11)
                    continue;

                if (data[0] == kodeDipilih)
                {
                    data[9] = statusBaru;
                    semuaData[i] = string.Join("|", data);

                    ditemukan = true;
                    LoadRekap();
                    break;
                }
            }

            if (ditemukan)
            {
                File.WriteAllLines(fileLaporan, semuaData);
                MessageBox.Show("Status berhasil diupdate!");
                LoadDataLaporan();
            }
            else
            {
                MessageBox.Show("Kode laporan tidak ditemukan!");
                LoadDashboard();
            }
        }

        // REKAP DATA
        private void LoadRekap()
        {
            string fileLaporan = Path.Combine(Application.StartupPath, "data", "laporan.txt");

            if (!File.Exists(fileLaporan))
                return;

            string[] dataLaporan = File.ReadAllLines(fileLaporan);

            int menunggu = 0, diverifikasi = 0, diproses = 0, selesai = 0, ditolak = 0;
            int d4 = 0, d3 = 0, pasca = 0, saw = 0;
            int penting = 0, sedang = 0, cukup = 0;

            foreach (string baris in dataLaporan)
            {
                if (string.IsNullOrWhiteSpace(baris))
                    continue;

                string[] d = baris.Split('|');

                if (d.Length < 11)
                    continue;

                string gedung = d[3];
                string prioritas = d[7];
                string status = d[9];

                // status
                if (status == "Menunggu") menunggu++;
                else if (status == "Diverifikasi") diverifikasi++;
                else if (status == "Diproses") diproses++;
                else if (status == "Selesai") selesai++;
                else if (status == "Ditolak") ditolak++;

                // gedung
                if (gedung == "Gedung D4") d4++;
                else if (gedung == "Gedung D3") d3++;
                else if (gedung == "Pascasarjana") pasca++;
                else if (gedung == "SAW") saw++;

                // prioritas
                if (prioritas == "Penting") penting++;
                else if (prioritas == "Sedang") sedang++;
                else if (prioritas == "Cukup") cukup++;
            }

            lblMenungguR.Text = menunggu.ToString();
            lblVerifikasiR.Text = diverifikasi.ToString();
            lblDiprosesR.Text = diproses.ToString();
            lblSelesaiR.Text = selesai.ToString();
            lblDitolakR.Text = ditolak.ToString();

            lblD4.Text = d4.ToString();
            lblD3.Text = d3.ToString();
            lblPasca.Text = pasca.ToString();
            lblSAW.Text = saw.ToString();

            lblPenting.Text = penting.ToString();
            lblSedang.Text = sedang.ToString();
            lblCukup.Text = cukup.ToString();

            lblTotal.Text = dataLaporan.Length.ToString();
        }

        // DASHBOARD
        private void LoadDashboard()
        {
            string file = Path.Combine(Application.StartupPath, "data", "laporan.txt");

            if (!File.Exists(file))
            {
                lblTotal.Text = "0";
                lblMenunggu.Text = "0";
                lblProses.Text = "0";
                lblSelesai.Text = "0";
                return;
            }

            string[] data = File.ReadAllLines(file);

            int total = 0, menunggu = 0, verifikasi = 0, diproses = 0, selesai = 0, ditolak = 0;

            foreach (var line in data)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] d = line.Split('|');
                if (d.Length < 10) continue;

                total++;

                string status = d[9];

                if (status == "Menunggu") menunggu++;
                else if (status == "Diverifikasi") verifikasi++;
                else if (status == "Diproses") diproses++;
                else if (status == "Selesai") selesai++;
                else if (status == "Ditolak") ditolak++;
            }

            lblTotal.Text = total.ToString();
            lblMenunggu.Text = menunggu.ToString();
            lblProses.Text = diproses.ToString();
            lblSelesai.Text = selesai.ToString();
        }

        // CARI LAPORAN
        private void btnCari_Click(object sender, EventArgs e)
        {
            string file = Path.Combine(Application.StartupPath, "data", "laporan.txt");

            if (!File.Exists(file))
            {
                MessageBox.Show("Data laporan tidak ditemukan!");
                return;
            }

            string kode = txtKodeCari.Text.Trim();

            if (kode == "")
            {
                MessageBox.Show("Masukkan kode laporan!");
                return;
            }

            string[] data = File.ReadAllLines(file);
            bool ketemu = false;

            foreach (string line in data)
            {
                string[] d = line.Split('|');

                if (d.Length < 10) continue;

                if (d[0] == kode)
                {
                    lblNamaData.Text = d[2];
                    lblTanggalData.Text = d[1];
                    lblGedungData.Text = d[3];
                    lblRuanganData.Text = d[4];
                    lblFasilitasData.Text = d[5];
                    lblPrioritasData.Text = d[7];
                    lblStatusData.Text = d[9];
                    lblDeskripsi.Text = d[8];

                    ketemu = true;
                    break;
                }
            }

            if (!ketemu)
                MessageBox.Show("Laporan tidak ditemukan!");
        }

        // TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("HH.mm.ss");

            labeltime1.Text = time;
            labeltime2.Text = time;
            labeltime3.Text = time;
            labeltime4.Text = time;
            labeltime5.Text = time;
        }
    }
}