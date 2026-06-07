namespace SistemPelaporanFasilitas_K10
{
    partial class FormUtama
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabMain = new TabControl();
            tabDashboard = new TabPage();
            labeltime1 = new Label();
            gbSelesai = new GroupBox();
            lblSelesai = new Label();
            gbProses = new GroupBox();
            lblProses = new Label();
            progressLaporan = new ProgressBar();
            gbMenunggu = new GroupBox();
            lblMenunggu = new Label();
            gbTotal = new GroupBox();
            lblTotal = new Label();
            lblJudulDashboard = new Label();
            tabInput = new TabPage();
            labeltime2 = new Label();
            btnKirim = new Button();
            btnReset = new Button();
            picFoto = new PictureBox();
            btnBrowse = new Button();
            label9 = new Label();
            txtDeskripsi = new RichTextBox();
            cbPrioritas = new ComboBox();
            cbKategori = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            txtFasilitas = new TextBox();
            txtRuangan = new TextBox();
            cbGedung = new ComboBox();
            txtNama = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dtTanggal = new DateTimePicker();
            lblTanggal = new Label();
            label1 = new Label();
            tabStatus = new TabPage();
            labeltime3 = new Label();
            gbDetail = new GroupBox();
            lblDeskripsi = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            lblGedungData = new Label();
            lblPrioritasData = new Label();
            lblStatusData = new Label();
            lblRuanganData = new Label();
            lblNamaData = new Label();
            lblTanggalData = new Label();
            lblFasilitasData = new Label();
            btnCari = new Button();
            txtKodeCari = new TextBox();
            lblKode = new Label();
            label10 = new Label();
            tabLogin = new TabPage();
            labeltime4 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            tabAdmin = new TabPage();
            labeltime5 = new Label();
            label23 = new Label();
            tabControl1 = new TabControl();
            tabDataLaporan = new TabPage();
            label24 = new Label();
            lvLaporan = new ListView();
            lblJumlah = new Label();
            tabKelolaStatus = new TabPage();
            btnUpdate = new Button();
            cbStatusBaru = new ComboBox();
            comboBox1 = new ComboBox();
            lblStatus = new Label();
            lblId = new Label();
            label25 = new Label();
            tabRekap = new TabPage();
            gbPrioritas = new GroupBox();
            lblCukup = new Label();
            lblSedang = new Label();
            lblPenting = new Label();
            label38 = new Label();
            label37 = new Label();
            label36 = new Label();
            gbStatus = new GroupBox();
            lblDitolakR = new Label();
            lblDiprosesR = new Label();
            lblSelesaiR = new Label();
            lblMenungguR = new Label();
            label35 = new Label();
            label34 = new Label();
            lblVerifikasiR = new Label();
            label33 = new Label();
            label32 = new Label();
            label31 = new Label();
            gbGedung = new GroupBox();
            lblSAW = new Label();
            lblD4 = new Label();
            lblPasca = new Label();
            lblD3 = new Label();
            label30 = new Label();
            label29 = new Label();
            label28 = new Label();
            label27 = new Label();
            label26 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tabMain.SuspendLayout();
            tabDashboard.SuspendLayout();
            gbSelesai.SuspendLayout();
            gbProses.SuspendLayout();
            gbMenunggu.SuspendLayout();
            gbTotal.SuspendLayout();
            tabInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            tabStatus.SuspendLayout();
            gbDetail.SuspendLayout();
            tabLogin.SuspendLayout();
            tabAdmin.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDataLaporan.SuspendLayout();
            tabKelolaStatus.SuspendLayout();
            tabRekap.SuspendLayout();
            gbPrioritas.SuspendLayout();
            gbStatus.SuspendLayout();
            gbGedung.SuspendLayout();
            SuspendLayout();
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabDashboard);
            tabMain.Controls.Add(tabInput);
            tabMain.Controls.Add(tabStatus);
            tabMain.Controls.Add(tabLogin);
            tabMain.Controls.Add(tabAdmin);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1127, 610);
            tabMain.TabIndex = 0;
            // 
            // tabDashboard
            // 
            tabDashboard.Controls.Add(labeltime1);
            tabDashboard.Controls.Add(gbSelesai);
            tabDashboard.Controls.Add(gbProses);
            tabDashboard.Controls.Add(progressLaporan);
            tabDashboard.Controls.Add(gbMenunggu);
            tabDashboard.Controls.Add(gbTotal);
            tabDashboard.Controls.Add(lblJudulDashboard);
            tabDashboard.Location = new Point(4, 29);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1119, 577);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // labeltime1
            // 
            labeltime1.AutoSize = true;
            labeltime1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltime1.Location = new Point(0, 0);
            labeltime1.Name = "labeltime1";
            labeltime1.Size = new Size(20, 28);
            labeltime1.TabIndex = 10;
            labeltime1.Text = "-";
            // 
            // gbSelesai
            // 
            gbSelesai.Controls.Add(lblSelesai);
            gbSelesai.Location = new Point(765, 340);
            gbSelesai.Name = "gbSelesai";
            gbSelesai.Size = new Size(250, 125);
            gbSelesai.TabIndex = 8;
            gbSelesai.TabStop = false;
            gbSelesai.Text = "SELESAI";
            // 
            // lblSelesai
            // 
            lblSelesai.AutoSize = true;
            lblSelesai.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelesai.Location = new Point(80, 51);
            lblSelesai.Name = "lblSelesai";
            lblSelesai.Size = new Size(33, 38);
            lblSelesai.TabIndex = 3;
            lblSelesai.Text = "0";
            // 
            // gbProses
            // 
            gbProses.Controls.Add(lblProses);
            gbProses.Location = new Point(765, 148);
            gbProses.Name = "gbProses";
            gbProses.Size = new Size(250, 125);
            gbProses.TabIndex = 7;
            gbProses.TabStop = false;
            gbProses.Text = "PROSES";
            // 
            // lblProses
            // 
            lblProses.AutoSize = true;
            lblProses.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblProses.Location = new Point(106, 55);
            lblProses.Name = "lblProses";
            lblProses.Size = new Size(33, 38);
            lblProses.TabIndex = 4;
            lblProses.Text = "0";
            // 
            // progressLaporan
            // 
            progressLaporan.Location = new Point(505, 436);
            progressLaporan.Name = "progressLaporan";
            progressLaporan.Size = new Size(125, 29);
            progressLaporan.TabIndex = 9;
            // 
            // gbMenunggu
            // 
            gbMenunggu.Controls.Add(lblMenunggu);
            gbMenunggu.Location = new Point(94, 340);
            gbMenunggu.Name = "gbMenunggu";
            gbMenunggu.Size = new Size(250, 125);
            gbMenunggu.TabIndex = 6;
            gbMenunggu.TabStop = false;
            gbMenunggu.Text = "MENUNGGU";
            // 
            // lblMenunggu
            // 
            lblMenunggu.AutoSize = true;
            lblMenunggu.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblMenunggu.Location = new Point(117, 60);
            lblMenunggu.Name = "lblMenunggu";
            lblMenunggu.Size = new Size(33, 38);
            lblMenunggu.TabIndex = 2;
            lblMenunggu.Text = "0";
            // 
            // gbTotal
            // 
            gbTotal.Controls.Add(lblTotal);
            gbTotal.Location = new Point(94, 148);
            gbTotal.Name = "gbTotal";
            gbTotal.Size = new Size(250, 125);
            gbTotal.TabIndex = 5;
            gbTotal.TabStop = false;
            gbTotal.Text = " Total Laporan";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            lblTotal.Location = new Point(113, 57);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 38);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "0";
            // 
            // lblJudulDashboard
            // 
            lblJudulDashboard.AutoSize = true;
            lblJudulDashboard.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudulDashboard.Location = new Point(458, 43);
            lblJudulDashboard.Name = "lblJudulDashboard";
            lblJudulDashboard.Size = new Size(206, 41);
            lblJudulDashboard.TabIndex = 0;
            lblJudulDashboard.Text = "DASHBOARD";
            // 
            // tabInput
            // 
            tabInput.Controls.Add(labeltime2);
            tabInput.Controls.Add(btnKirim);
            tabInput.Controls.Add(btnReset);
            tabInput.Controls.Add(picFoto);
            tabInput.Controls.Add(btnBrowse);
            tabInput.Controls.Add(label9);
            tabInput.Controls.Add(txtDeskripsi);
            tabInput.Controls.Add(cbPrioritas);
            tabInput.Controls.Add(cbKategori);
            tabInput.Controls.Add(label8);
            tabInput.Controls.Add(label7);
            tabInput.Controls.Add(label6);
            tabInput.Controls.Add(txtFasilitas);
            tabInput.Controls.Add(txtRuangan);
            tabInput.Controls.Add(cbGedung);
            tabInput.Controls.Add(txtNama);
            tabInput.Controls.Add(label5);
            tabInput.Controls.Add(label4);
            tabInput.Controls.Add(label3);
            tabInput.Controls.Add(label2);
            tabInput.Controls.Add(dtTanggal);
            tabInput.Controls.Add(lblTanggal);
            tabInput.Controls.Add(label1);
            tabInput.Location = new Point(4, 29);
            tabInput.Name = "tabInput";
            tabInput.Padding = new Padding(3);
            tabInput.Size = new Size(1119, 577);
            tabInput.TabIndex = 1;
            tabInput.Text = "Input Laporan";
            tabInput.UseVisualStyleBackColor = true;
            // 
            // labeltime2
            // 
            labeltime2.AutoSize = true;
            labeltime2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeltime2.Location = new Point(8, 8);
            labeltime2.Name = "labeltime2";
            labeltime2.Size = new Size(20, 28);
            labeltime2.TabIndex = 23;
            labeltime2.Text = "-";
            // 
            // btnKirim
            // 
            btnKirim.Location = new Point(844, 431);
            btnKirim.Name = "btnKirim";
            btnKirim.Size = new Size(123, 29);
            btnKirim.TabIndex = 22;
            btnKirim.Text = "Kirim Laporan";
            btnKirim.UseVisualStyleBackColor = true;
            btnKirim.Click += btnKirim_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(702, 431);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(469, 110);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(180, 180);
            picFoto.SizeMode = PictureBoxSizeMode.Zoom;
            picFoto.TabIndex = 20;
            picFoto.TabStop = false;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(469, 296);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(94, 29);
            btnBrowse.TabIndex = 19;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(469, 84);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 18;
            label9.Text = "Foto Kerusakan";
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(140, 431);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(244, 77);
            txtDeskripsi.TabIndex = 17;
            txtDeskripsi.Text = "";
            // 
            // cbPrioritas
            // 
            cbPrioritas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPrioritas.FormattingEnabled = true;
            cbPrioritas.Location = new Point(140, 362);
            cbPrioritas.Name = "cbPrioritas";
            cbPrioritas.Size = new Size(151, 28);
            cbPrioritas.TabIndex = 16;
            // 
            // cbKategori
            // 
            cbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(140, 320);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(151, 28);
            cbKategori.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 320);
            label8.Name = "label8";
            label8.Size = new Size(66, 20);
            label8.TabIndex = 14;
            label8.Text = "Kategori";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 408);
            label7.Name = "label7";
            label7.Size = new Size(140, 20);
            label7.TabIndex = 13;
            label7.Text = "Deskripsi Kerusakan";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 370);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 12;
            label6.Text = "Prioritas";
            // 
            // txtFasilitas
            // 
            txtFasilitas.Location = new Point(140, 270);
            txtFasilitas.Name = "txtFasilitas";
            txtFasilitas.Size = new Size(125, 27);
            txtFasilitas.TabIndex = 11;
            // 
            // txtRuangan
            // 
            txtRuangan.Location = new Point(140, 222);
            txtRuangan.Name = "txtRuangan";
            txtRuangan.Size = new Size(125, 27);
            txtRuangan.TabIndex = 9;
            // 
            // cbGedung
            // 
            cbGedung.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGedung.FormattingEnabled = true;
            cbGedung.Location = new Point(140, 175);
            cbGedung.Name = "cbGedung";
            cbGedung.Size = new Size(151, 28);
            cbGedung.TabIndex = 8;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(140, 84);
            txtNama.Name = "txtNama";
            txtNama.RightToLeft = RightToLeft.No;
            txtNama.Size = new Size(199, 27);
            txtNama.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 225);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 6;
            label5.Text = "Ruangan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 270);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 5;
            label4.Text = "Fasilitas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 175);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Gedung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 84);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "Nama Pelapor";
            // 
            // dtTanggal
            // 
            dtTanggal.Format = DateTimePickerFormat.Short;
            dtTanggal.Location = new Point(140, 129);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(250, 27);
            dtTanggal.TabIndex = 2;
            // 
            // lblTanggal
            // 
            lblTanggal.AutoSize = true;
            lblTanggal.Location = new Point(8, 129);
            lblTanggal.Name = "lblTanggal";
            lblTanggal.Size = new Size(61, 20);
            lblTanggal.TabIndex = 1;
            lblTanggal.Text = "Tanggal";
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(289, 3);
            label1.Name = "label1";
            label1.Size = new Size(507, 46);
            label1.TabIndex = 0;
            label1.Text = "INPUT LAPORAN KERUSAKAN";
            // 
            // tabStatus
            // 
            tabStatus.Controls.Add(labeltime3);
            tabStatus.Controls.Add(gbDetail);
            tabStatus.Controls.Add(btnCari);
            tabStatus.Controls.Add(txtKodeCari);
            tabStatus.Controls.Add(lblKode);
            tabStatus.Controls.Add(label10);
            tabStatus.Location = new Point(4, 29);
            tabStatus.Name = "tabStatus";
            tabStatus.Padding = new Padding(3);
            tabStatus.Size = new Size(1119, 577);
            tabStatus.TabIndex = 2;
            tabStatus.Text = "Cek Status";
            tabStatus.UseVisualStyleBackColor = true;
            // 
            // labeltime3
            // 
            labeltime3.AutoSize = true;
            labeltime3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeltime3.Location = new Point(8, 8);
            labeltime3.Name = "labeltime3";
            labeltime3.Size = new Size(20, 28);
            labeltime3.TabIndex = 7;
            labeltime3.Text = "-";
            // 
            // gbDetail
            // 
            gbDetail.Controls.Add(lblDeskripsi);
            gbDetail.Controls.Add(label18);
            gbDetail.Controls.Add(label17);
            gbDetail.Controls.Add(label16);
            gbDetail.Controls.Add(label15);
            gbDetail.Controls.Add(label14);
            gbDetail.Controls.Add(label13);
            gbDetail.Controls.Add(label12);
            gbDetail.Controls.Add(label11);
            gbDetail.Controls.Add(lblGedungData);
            gbDetail.Controls.Add(lblPrioritasData);
            gbDetail.Controls.Add(lblStatusData);
            gbDetail.Controls.Add(lblRuanganData);
            gbDetail.Controls.Add(lblNamaData);
            gbDetail.Controls.Add(lblTanggalData);
            gbDetail.Controls.Add(lblFasilitasData);
            gbDetail.Location = new Point(97, 165);
            gbDetail.Name = "gbDetail";
            gbDetail.Size = new Size(880, 387);
            gbDetail.TabIndex = 6;
            gbDetail.TabStop = false;
            gbDetail.Text = "Detail Laporan";
            // 
            // lblDeskripsi
            // 
            lblDeskripsi.AutoSize = true;
            lblDeskripsi.Location = new Point(151, 284);
            lblDeskripsi.Name = "lblDeskripsi";
            lblDeskripsi.Size = new Size(15, 20);
            lblDeskripsi.TabIndex = 23;
            lblDeskripsi.Text = "-";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(63, 192);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 22;
            label18.Text = "Fasilitas :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(49, 284);
            label17.Name = "label17";
            label17.Size = new Size(76, 20);
            label17.TabIndex = 21;
            label17.Text = "Deskripsi :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(57, 162);
            label16.Name = "label16";
            label16.Size = new Size(74, 20);
            label16.TabIndex = 20;
            label16.Text = "Ruangan :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(57, 222);
            label15.Name = "label15";
            label15.Size = new Size(70, 20);
            label15.TabIndex = 19;
            label15.Text = "Prioritas :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(63, 253);
            label14.Name = "label14";
            label14.Size = new Size(56, 20);
            label14.TabIndex = 18;
            label14.Text = "Status :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(63, 131);
            label13.Name = "label13";
            label13.Size = new Size(68, 20);
            label13.TabIndex = 17;
            label13.Text = "Gedung :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(21, 65);
            label12.Name = "label12";
            label12.Size = new Size(110, 20);
            label12.TabIndex = 16;
            label12.Text = "Nama Pelapor :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(63, 96);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 15;
            label11.Text = "Tanggal :";
            // 
            // lblGedungData
            // 
            lblGedungData.AutoSize = true;
            lblGedungData.Location = new Point(148, 131);
            lblGedungData.Name = "lblGedungData";
            lblGedungData.Size = new Size(15, 20);
            lblGedungData.TabIndex = 11;
            lblGedungData.Text = "-";
            // 
            // lblPrioritasData
            // 
            lblPrioritasData.AutoSize = true;
            lblPrioritasData.Location = new Point(152, 222);
            lblPrioritasData.Name = "lblPrioritasData";
            lblPrioritasData.Size = new Size(15, 20);
            lblPrioritasData.TabIndex = 2;
            lblPrioritasData.Text = "-";
            // 
            // lblStatusData
            // 
            lblStatusData.AutoSize = true;
            lblStatusData.Location = new Point(151, 253);
            lblStatusData.Name = "lblStatusData";
            lblStatusData.Size = new Size(15, 20);
            lblStatusData.TabIndex = 10;
            lblStatusData.Text = "-";
            // 
            // lblRuanganData
            // 
            lblRuanganData.AutoSize = true;
            lblRuanganData.Location = new Point(148, 162);
            lblRuanganData.Name = "lblRuanganData";
            lblRuanganData.Size = new Size(15, 20);
            lblRuanganData.TabIndex = 3;
            lblRuanganData.Text = "-";
            // 
            // lblNamaData
            // 
            lblNamaData.AutoSize = true;
            lblNamaData.Location = new Point(148, 65);
            lblNamaData.Name = "lblNamaData";
            lblNamaData.Size = new Size(15, 20);
            lblNamaData.TabIndex = 9;
            lblNamaData.Text = "-";
            // 
            // lblTanggalData
            // 
            lblTanggalData.AutoSize = true;
            lblTanggalData.Location = new Point(148, 96);
            lblTanggalData.Name = "lblTanggalData";
            lblTanggalData.Size = new Size(15, 20);
            lblTanggalData.TabIndex = 7;
            lblTanggalData.Text = "-";
            // 
            // lblFasilitasData
            // 
            lblFasilitasData.AutoSize = true;
            lblFasilitasData.Location = new Point(151, 192);
            lblFasilitasData.Name = "lblFasilitasData";
            lblFasilitasData.Size = new Size(15, 20);
            lblFasilitasData.TabIndex = 8;
            lblFasilitasData.Text = "-";
            // 
            // btnCari
            // 
            btnCari.Location = new Point(175, 116);
            btnCari.Name = "btnCari";
            btnCari.Size = new Size(94, 29);
            btnCari.TabIndex = 5;
            btnCari.Text = "Cari";
            btnCari.UseVisualStyleBackColor = true;
            btnCari.Click += btnCari_Click;
            // 
            // txtKodeCari
            // 
            txtKodeCari.Location = new Point(175, 72);
            txtKodeCari.Name = "txtKodeCari";
            txtKodeCari.Size = new Size(125, 27);
            txtKodeCari.TabIndex = 4;
            // 
            // lblKode
            // 
            lblKode.AutoSize = true;
            lblKode.Location = new Point(47, 75);
            lblKode.Name = "lblKode";
            lblKode.Size = new Size(102, 20);
            lblKode.TabIndex = 1;
            lblKode.Text = "Kode Laporan";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(384, 0);
            label10.Name = "label10";
            label10.Size = new Size(384, 46);
            label10.TabIndex = 0;
            label10.Text = "CEK STATUS LAPORAN";
            // 
            // tabLogin
            // 
            tabLogin.Controls.Add(labeltime4);
            tabLogin.Controls.Add(btnLogin);
            tabLogin.Controls.Add(txtPassword);
            tabLogin.Controls.Add(txtUsername);
            tabLogin.Controls.Add(label22);
            tabLogin.Controls.Add(label21);
            tabLogin.Controls.Add(label20);
            tabLogin.Controls.Add(label19);
            tabLogin.Location = new Point(4, 29);
            tabLogin.Name = "tabLogin";
            tabLogin.Padding = new Padding(3);
            tabLogin.Size = new Size(1119, 577);
            tabLogin.TabIndex = 3;
            tabLogin.Text = "Login";
            tabLogin.UseVisualStyleBackColor = true;
            // 
            // labeltime4
            // 
            labeltime4.AutoSize = true;
            labeltime4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeltime4.Location = new Point(8, 8);
            labeltime4.Name = "labeltime4";
            labeltime4.Size = new Size(20, 28);
            labeltime4.TabIndex = 7;
            labeltime4.Text = "-";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(531, 386);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(531, 285);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(170, 27);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(531, 204);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(170, 27);
            txtUsername.TabIndex = 4;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(406, 200);
            label22.Name = "label22";
            label22.Size = new Size(117, 28);
            label22.TabIndex = 3;
            label22.Text = "Username :";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label21.Location = new Point(411, 281);
            label21.Name = "label21";
            label21.Size = new Size(112, 28);
            label21.TabIndex = 2;
            label21.Text = "Password :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label20.Location = new Point(315, 499);
            label20.Name = "label20";
            label20.Size = new Size(457, 23);
            label20.TabIndex = 1;
            label20.Text = "Hanya Admin Yang Dapat Mengakses Menu Manajemen";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(404, 45);
            label19.Name = "label19";
            label19.Size = new Size(253, 46);
            label19.TabIndex = 0;
            label19.Text = "LOGIN ADMIN";
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(labeltime5);
            tabAdmin.Controls.Add(label23);
            tabAdmin.Controls.Add(tabControl1);
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3);
            tabAdmin.Size = new Size(1119, 577);
            tabAdmin.TabIndex = 4;
            tabAdmin.Text = "Admin";
            tabAdmin.UseVisualStyleBackColor = true;
            // 
            // labeltime5
            // 
            labeltime5.AutoSize = true;
            labeltime5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labeltime5.Location = new Point(8, 8);
            labeltime5.Name = "labeltime5";
            labeltime5.Size = new Size(20, 28);
            labeltime5.TabIndex = 2;
            labeltime5.Text = "-";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label23.Location = new Point(402, 30);
            label23.Name = "label23";
            label23.Size = new Size(254, 46);
            label23.TabIndex = 1;
            label23.Text = "ADMIN PANEL";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDataLaporan);
            tabControl1.Controls.Add(tabKelolaStatus);
            tabControl1.Controls.Add(tabRekap);
            tabControl1.Location = new Point(0, 115);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1116, 462);
            tabControl1.TabIndex = 0;
            // 
            // tabDataLaporan
            // 
            tabDataLaporan.Controls.Add(label24);
            tabDataLaporan.Controls.Add(lvLaporan);
            tabDataLaporan.Controls.Add(lblJumlah);
            tabDataLaporan.Location = new Point(4, 29);
            tabDataLaporan.Name = "tabDataLaporan";
            tabDataLaporan.Padding = new Padding(3);
            tabDataLaporan.Size = new Size(1108, 429);
            tabDataLaporan.TabIndex = 0;
            tabDataLaporan.Text = "Data Laporan";
            tabDataLaporan.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label24.Location = new Point(357, 18);
            label24.Name = "label24";
            label24.Size = new Size(279, 46);
            label24.TabIndex = 6;
            label24.Text = "DATA LAPORAN";
            // 
            // lvLaporan
            // 
            lvLaporan.FullRowSelect = true;
            lvLaporan.GridLines = true;
            lvLaporan.Location = new Point(84, 116);
            lvLaporan.MultiSelect = false;
            lvLaporan.Name = "lvLaporan";
            lvLaporan.Size = new Size(622, 163);
            lvLaporan.TabIndex = 5;
            lvLaporan.UseCompatibleStateImageBehavior = false;
            lvLaporan.View = View.Details;
            // 
            // lblJumlah
            // 
            lblJumlah.AutoSize = true;
            lblJumlah.Location = new Point(16, 116);
            lblJumlah.Name = "lblJumlah";
            lblJumlah.Size = new Size(62, 20);
            lblJumlah.TabIndex = 1;
            lblJumlah.Text = "Jumlah :";
            // 
            // tabKelolaStatus
            // 
            tabKelolaStatus.Controls.Add(btnUpdate);
            tabKelolaStatus.Controls.Add(cbStatusBaru);
            tabKelolaStatus.Controls.Add(comboBox1);
            tabKelolaStatus.Controls.Add(lblStatus);
            tabKelolaStatus.Controls.Add(lblId);
            tabKelolaStatus.Controls.Add(label25);
            tabKelolaStatus.Location = new Point(4, 29);
            tabKelolaStatus.Name = "tabKelolaStatus";
            tabKelolaStatus.Padding = new Padding(3);
            tabKelolaStatus.Size = new Size(1108, 429);
            tabKelolaStatus.TabIndex = 1;
            tabKelolaStatus.Text = "Kelola Status";
            tabKelolaStatus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(545, 280);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cbStatusBaru
            // 
            cbStatusBaru.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatusBaru.FormattingEnabled = true;
            cbStatusBaru.Location = new Point(520, 217);
            cbStatusBaru.Name = "cbStatusBaru";
            cbStatusBaru.Size = new Size(151, 28);
            cbStatusBaru.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(520, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(424, 217);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status Baru :";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(414, 152);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 20);
            lblId.TabIndex = 1;
            lblId.Text = "Masukkan ID :";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label25.Location = new Point(429, 37);
            label25.Name = "label25";
            label25.Size = new Size(276, 46);
            label25.TabIndex = 0;
            label25.Text = "KELOLA STATUS";
            // 
            // tabRekap
            // 
            tabRekap.Controls.Add(gbPrioritas);
            tabRekap.Controls.Add(gbStatus);
            tabRekap.Controls.Add(gbGedung);
            tabRekap.Controls.Add(label26);
            tabRekap.Location = new Point(4, 29);
            tabRekap.Name = "tabRekap";
            tabRekap.Padding = new Padding(3);
            tabRekap.Size = new Size(1108, 429);
            tabRekap.TabIndex = 2;
            tabRekap.Text = "Rekap";
            tabRekap.UseVisualStyleBackColor = true;
            // 
            // gbPrioritas
            // 
            gbPrioritas.Controls.Add(lblCukup);
            gbPrioritas.Controls.Add(lblSedang);
            gbPrioritas.Controls.Add(lblPenting);
            gbPrioritas.Controls.Add(label38);
            gbPrioritas.Controls.Add(label37);
            gbPrioritas.Controls.Add(label36);
            gbPrioritas.Location = new Point(780, 128);
            gbPrioritas.Name = "gbPrioritas";
            gbPrioritas.Size = new Size(303, 198);
            gbPrioritas.TabIndex = 3;
            gbPrioritas.TabStop = false;
            gbPrioritas.Text = "Berdasarkan Prioritas";
            // 
            // lblCukup
            // 
            lblCukup.AutoSize = true;
            lblCukup.Location = new Point(106, 151);
            lblCukup.Name = "lblCukup";
            lblCukup.Size = new Size(15, 20);
            lblCukup.TabIndex = 5;
            lblCukup.Text = "-";
            // 
            // lblSedang
            // 
            lblSedang.AutoSize = true;
            lblSedang.Location = new Point(106, 102);
            lblSedang.Name = "lblSedang";
            lblSedang.Size = new Size(15, 20);
            lblSedang.TabIndex = 4;
            lblSedang.Text = "-";
            // 
            // lblPenting
            // 
            lblPenting.AutoSize = true;
            lblPenting.Location = new Point(106, 53);
            lblPenting.Name = "lblPenting";
            lblPenting.Size = new Size(15, 20);
            lblPenting.TabIndex = 3;
            lblPenting.Text = "-";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(16, 102);
            label38.Name = "label38";
            label38.Size = new Size(66, 20);
            label38.TabIndex = 2;
            label38.Text = "Sedang :";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(16, 151);
            label37.Name = "label37";
            label37.Size = new Size(57, 20);
            label37.TabIndex = 1;
            label37.Text = "Cukup :";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(16, 53);
            label36.Name = "label36";
            label36.Size = new Size(65, 20);
            label36.TabIndex = 0;
            label36.Text = "Penting :";
            // 
            // gbStatus
            // 
            gbStatus.Controls.Add(lblDitolakR);
            gbStatus.Controls.Add(lblDiprosesR);
            gbStatus.Controls.Add(lblSelesaiR);
            gbStatus.Controls.Add(lblMenungguR);
            gbStatus.Controls.Add(label35);
            gbStatus.Controls.Add(label34);
            gbStatus.Controls.Add(lblVerifikasiR);
            gbStatus.Controls.Add(label33);
            gbStatus.Controls.Add(label32);
            gbStatus.Controls.Add(label31);
            gbStatus.Location = new Point(398, 128);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(303, 198);
            gbStatus.TabIndex = 2;
            gbStatus.TabStop = false;
            gbStatus.Text = "Berdasarkan Status";
            // 
            // lblDitolakR
            // 
            lblDitolakR.AutoSize = true;
            lblDitolakR.Location = new Point(123, 165);
            lblDitolakR.Name = "lblDitolakR";
            lblDitolakR.Size = new Size(15, 20);
            lblDitolakR.TabIndex = 6;
            lblDitolakR.Text = "-";
            // 
            // lblDiprosesR
            // 
            lblDiprosesR.AutoSize = true;
            lblDiprosesR.Location = new Point(123, 102);
            lblDiprosesR.Name = "lblDiprosesR";
            lblDiprosesR.Size = new Size(15, 20);
            lblDiprosesR.TabIndex = 7;
            lblDiprosesR.Text = "-";
            // 
            // lblSelesaiR
            // 
            lblSelesaiR.AutoSize = true;
            lblSelesaiR.Location = new Point(123, 134);
            lblSelesaiR.Name = "lblSelesaiR";
            lblSelesaiR.Size = new Size(15, 20);
            lblSelesaiR.TabIndex = 5;
            lblSelesaiR.Text = "-";
            // 
            // lblMenungguR
            // 
            lblMenungguR.AutoSize = true;
            lblMenungguR.Location = new Point(123, 32);
            lblMenungguR.Name = "lblMenungguR";
            lblMenungguR.Size = new Size(15, 20);
            lblMenungguR.TabIndex = 5;
            lblMenungguR.Text = "-";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(43, 165);
            label35.Name = "label35";
            label35.Size = new Size(64, 20);
            label35.TabIndex = 4;
            label35.Text = "Ditolak :";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(33, 102);
            label34.Name = "label34";
            label34.Size = new Size(74, 20);
            label34.TabIndex = 3;
            label34.Text = "Diproses :";
            // 
            // lblVerifikasiR
            // 
            lblVerifikasiR.AutoSize = true;
            lblVerifikasiR.Location = new Point(123, 70);
            lblVerifikasiR.Name = "lblVerifikasiR";
            lblVerifikasiR.Size = new Size(15, 20);
            lblVerifikasiR.TabIndex = 4;
            lblVerifikasiR.Text = "-";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(45, 134);
            label33.Name = "label33";
            label33.Size = new Size(62, 20);
            label33.TabIndex = 2;
            label33.Text = "Selesai :";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(20, 70);
            label32.Name = "label32";
            label32.Size = new Size(89, 20);
            label32.TabIndex = 1;
            label32.Text = "Diverifikasi :";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(20, 32);
            label31.Name = "label31";
            label31.Size = new Size(87, 20);
            label31.TabIndex = 0;
            label31.Text = "Menunggu :";
            // 
            // gbGedung
            // 
            gbGedung.Controls.Add(lblSAW);
            gbGedung.Controls.Add(lblD4);
            gbGedung.Controls.Add(lblPasca);
            gbGedung.Controls.Add(lblD3);
            gbGedung.Controls.Add(label30);
            gbGedung.Controls.Add(label29);
            gbGedung.Controls.Add(label28);
            gbGedung.Controls.Add(label27);
            gbGedung.Location = new Point(19, 128);
            gbGedung.Name = "gbGedung";
            gbGedung.Size = new Size(303, 198);
            gbGedung.TabIndex = 1;
            gbGedung.TabStop = false;
            gbGedung.Text = "Berdasarkan Gedung";
            // 
            // lblSAW
            // 
            lblSAW.AutoSize = true;
            lblSAW.Location = new Point(181, 144);
            lblSAW.Name = "lblSAW";
            lblSAW.Size = new Size(15, 20);
            lblSAW.TabIndex = 4;
            lblSAW.Text = "-";
            // 
            // lblD4
            // 
            lblD4.AutoSize = true;
            lblD4.Location = new Point(181, 32);
            lblD4.Name = "lblD4";
            lblD4.Size = new Size(15, 20);
            lblD4.TabIndex = 5;
            lblD4.Text = "-";
            // 
            // lblPasca
            // 
            lblPasca.AutoSize = true;
            lblPasca.Location = new Point(181, 108);
            lblPasca.Name = "lblPasca";
            lblPasca.Size = new Size(15, 20);
            lblPasca.TabIndex = 5;
            lblPasca.Text = "-";
            // 
            // lblD3
            // 
            lblD3.AutoSize = true;
            lblD3.Location = new Point(181, 70);
            lblD3.Name = "lblD3";
            lblD3.Size = new Size(15, 20);
            lblD3.TabIndex = 4;
            lblD3.Text = "-";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(53, 144);
            label30.Name = "label30";
            label30.Size = new Size(103, 20);
            label30.TabIndex = 3;
            label30.Text = "Gedung SAW :";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(1, 108);
            label29.Name = "label29";
            label29.Size = new Size(155, 20);
            label29.TabIndex = 2;
            label29.Text = "Gedung Pascasarjana :";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(65, 70);
            label28.Name = "label28";
            label28.Size = new Size(91, 20);
            label28.TabIndex = 1;
            label28.Text = "Gedung D3 :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(65, 32);
            label27.Name = "label27";
            label27.Size = new Size(91, 20);
            label27.TabIndex = 0;
            label27.Text = "Gedung D4 :";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label26.Location = new Point(379, 3);
            label26.Name = "label26";
            label26.Size = new Size(298, 46);
            label26.TabIndex = 0;
            label26.Text = "REKAP LAPORAN";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 610);
            Controls.Add(tabMain);
            Name = "FormUtama";
            Text = "Sistem Pelaporan Kerusakan Kampus";
            Load += FormUtama_Load;
            tabMain.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            tabDashboard.PerformLayout();
            gbSelesai.ResumeLayout(false);
            gbSelesai.PerformLayout();
            gbProses.ResumeLayout(false);
            gbProses.PerformLayout();
            gbMenunggu.ResumeLayout(false);
            gbMenunggu.PerformLayout();
            gbTotal.ResumeLayout(false);
            gbTotal.PerformLayout();
            tabInput.ResumeLayout(false);
            tabInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            tabStatus.ResumeLayout(false);
            tabStatus.PerformLayout();
            gbDetail.ResumeLayout(false);
            gbDetail.PerformLayout();
            tabLogin.ResumeLayout(false);
            tabLogin.PerformLayout();
            tabAdmin.ResumeLayout(false);
            tabAdmin.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabDataLaporan.ResumeLayout(false);
            tabDataLaporan.PerformLayout();
            tabKelolaStatus.ResumeLayout(false);
            tabKelolaStatus.PerformLayout();
            tabRekap.ResumeLayout(false);
            tabRekap.PerformLayout();
            gbPrioritas.ResumeLayout(false);
            gbPrioritas.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            gbGedung.ResumeLayout(false);
            gbGedung.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage3;
        private TabControl tabMain;
        private TabPage tabDashboard;
        private TabPage tabInput;
        private ProgressBar progressLaporan;
        private GroupBox gbSelesai;
        private GroupBox gbProses;
        private GroupBox gbMenunggu;
        private GroupBox gbTotal;
        private Label lblProses;
        private Label lblSelesai;
        private Label lblMenunggu;
        private Label lblTotal;
        private Label lblJudulDashboard;
        private TabPage tabStatus;
        private TabPage tabLogin;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private DateTimePicker dtTanggal;
        private Label lblTanggal;
        private TextBox txtNama;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbGedung;
        private TextBox txtFasilitas;
        private TextBox txtRuangan;
        private ComboBox cbPrioritas;
        private ComboBox cbKategori;
        private Label label8;
        private Label label7;
        private Label label6;
        private RichTextBox txtDeskripsi;
        private Button btnKirim;
        private Button btnReset;
        private PictureBox picFoto;
        private Button btnBrowse;
        private Label label9;
        private Label lblRuanganData;
        private Label lblPrioritasData;
        private Label lblKode;
        private Label label10;
        private GroupBox gbDetail;
        private Button btnCari;
        private TextBox txtKodeCari;
        private Label lblGedungData;
        private Label lblStatusData;
        private Label lblNamaData;
        private Label lblTanggalData;
        private Label lblFasilitasData;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label19;
        private TabPage tabAdmin;
        private TabControl tabControl1;
        private TabPage tabDataLaporan;
        private TabPage tabKelolaStatus;
        private TabPage tabRekap;
        private ListView lvLaporan;
        private Label lblJumlah;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Button btnUpdate;
        private ComboBox cbStatusBaru;
        private ComboBox comboBox1;
        private Label lblStatus;
        private Label lblId;
        private GroupBox gbPrioritas;
        private GroupBox gbStatus;
        private GroupBox gbGedung;
        private Label lblDiprosesR;
        private Label lblDitolakR;
        private Label lblSelesaiR;
        private Label lblVerifikasiR;
        private Label lblMenungguR;
        private Label label35;
        private Label label34;
        private Label label33;
        private Label label32;
        private Label label31;
        private Label lblSAW;
        private Label lblD4;
        private Label lblPasca;
        private Label lblD3;
        private Label label30;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label lblCukup;
        private Label lblSedang;
        private Label lblPenting;
        private Label label38;
        private Label label37;
        private Label label36;
        private Label lblDeskripsi;
        private Label labeltime1;
        private Label labeltime2;
        private Label labeltime3;
        private Label labeltime4;
        private Label labeltime5;
    }
}
