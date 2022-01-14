
namespace LogisticApp2
{
    partial class FormBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBarang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBarMenu = new System.Windows.Forms.Button();
            this.btnBarAdmin = new System.Windows.Forms.Button();
            this.btnBarCust = new System.Windows.Forms.Button();
            this.btnBarBar = new System.Windows.Forms.Button();
            this.btnBarSupp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.INSERT = new System.Windows.Forms.TabPage();
            this.cmbStatusInsert = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTampilkanBar1 = new System.Windows.Forms.Button();
            this.txtIdAdminInsert = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtIdBarangInsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvwBarang1 = new System.Windows.Forms.ListView();
            this.btnInsertBarang = new System.Windows.Forms.Button();
            this.txtIdCustInsert = new System.Windows.Forms.TextBox();
            this.txtIdSuppInsert = new System.Windows.Forms.TextBox();
            this.txtJenisBarangInsert = new System.Windows.Forms.TextBox();
            this.txtNamaBarangInsert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.TabPage();
            this.cmbStatusUpdate = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTampilkanBar2 = new System.Windows.Forms.Button();
            this.txtIdAdminUpdate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCariBarUpdate = new System.Windows.Forms.Button();
            this.txtIdBarangUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvwBarang2 = new System.Windows.Forms.ListView();
            this.btnUpdateBarang = new System.Windows.Forms.Button();
            this.txtIdCustUpdate = new System.Windows.Forms.TextBox();
            this.txtIdSuppUpdate = new System.Windows.Forms.TextBox();
            this.txtJenisBarangUpdate = new System.Windows.Forms.TextBox();
            this.txtNamaBarangUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarTgh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.INSERT.SuspendLayout();
            this.UPDATE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnBarTgh);
            this.panel1.Controls.Add(this.btnBarMenu);
            this.panel1.Controls.Add(this.btnBarAdmin);
            this.panel1.Controls.Add(this.btnBarCust);
            this.panel1.Controls.Add(this.btnBarBar);
            this.panel1.Controls.Add(this.btnBarSupp);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 460);
            this.panel1.TabIndex = 0;
            // 
            // btnBarMenu
            // 
            this.btnBarMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarMenu.ForeColor = System.Drawing.Color.White;
            this.btnBarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarMenu.Location = new System.Drawing.Point(32, 10);
            this.btnBarMenu.Name = "btnBarMenu";
            this.btnBarMenu.Size = new System.Drawing.Size(90, 40);
            this.btnBarMenu.TabIndex = 5;
            this.btnBarMenu.Text = "Menu";
            this.btnBarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarMenu.UseCompatibleTextRendering = true;
            this.btnBarMenu.UseVisualStyleBackColor = false;
            this.btnBarMenu.Click += new System.EventHandler(this.btnBarMenu_Click);
            // 
            // btnBarAdmin
            // 
            this.btnBarAdmin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarAdmin.ForeColor = System.Drawing.Color.White;
            this.btnBarAdmin.Location = new System.Drawing.Point(25, 361);
            this.btnBarAdmin.Name = "btnBarAdmin";
            this.btnBarAdmin.Size = new System.Drawing.Size(97, 34);
            this.btnBarAdmin.TabIndex = 4;
            this.btnBarAdmin.Text = "Info Admin";
            this.btnBarAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarAdmin.UseCompatibleTextRendering = true;
            this.btnBarAdmin.UseVisualStyleBackColor = false;
            this.btnBarAdmin.Click += new System.EventHandler(this.btnBarAdmin_Click);
            // 
            // btnBarCust
            // 
            this.btnBarCust.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarCust.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarCust.ForeColor = System.Drawing.Color.White;
            this.btnBarCust.Image = ((System.Drawing.Image)(resources.GetObject("btnBarCust.Image")));
            this.btnBarCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarCust.Location = new System.Drawing.Point(3, 122);
            this.btnBarCust.Name = "btnBarCust";
            this.btnBarCust.Size = new System.Drawing.Size(151, 56);
            this.btnBarCust.TabIndex = 2;
            this.btnBarCust.Text = " CUSTOMER";
            this.btnBarCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarCust.UseCompatibleTextRendering = true;
            this.btnBarCust.UseVisualStyleBackColor = false;
            this.btnBarCust.Click += new System.EventHandler(this.btnBarCust_Click);
            // 
            // btnBarBar
            // 
            this.btnBarBar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarBar.ForeColor = System.Drawing.Color.White;
            this.btnBarBar.Image = ((System.Drawing.Image)(resources.GetObject("btnBarBar.Image")));
            this.btnBarBar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarBar.Location = new System.Drawing.Point(3, 184);
            this.btnBarBar.Name = "btnBarBar";
            this.btnBarBar.Size = new System.Drawing.Size(151, 56);
            this.btnBarBar.TabIndex = 1;
            this.btnBarBar.Text = " BARANG";
            this.btnBarBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarBar.UseCompatibleTextRendering = true;
            this.btnBarBar.UseVisualStyleBackColor = false;
            // 
            // btnBarSupp
            // 
            this.btnBarSupp.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarSupp.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarSupp.ForeColor = System.Drawing.Color.White;
            this.btnBarSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnBarSupp.Image")));
            this.btnBarSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarSupp.Location = new System.Drawing.Point(3, 60);
            this.btnBarSupp.Name = "btnBarSupp";
            this.btnBarSupp.Size = new System.Drawing.Size(151, 56);
            this.btnBarSupp.TabIndex = 0;
            this.btnBarSupp.Text = " SUPPLIER";
            this.btnBarSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarSupp.UseCompatibleTextRendering = true;
            this.btnBarSupp.UseVisualStyleBackColor = false;
            this.btnBarSupp.Click += new System.EventHandler(this.btnBarSupp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.INSERT);
            this.tabControl1.Controls.Add(this.UPDATE);
            this.tabControl1.Location = new System.Drawing.Point(164, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 386);
            this.tabControl1.TabIndex = 1;
            // 
            // INSERT
            // 
            this.INSERT.Controls.Add(this.cmbStatusInsert);
            this.INSERT.Controls.Add(this.label12);
            this.INSERT.Controls.Add(this.btnTampilkanBar1);
            this.INSERT.Controls.Add(this.txtIdAdminInsert);
            this.INSERT.Controls.Add(this.label18);
            this.INSERT.Controls.Add(this.txtIdBarangInsert);
            this.INSERT.Controls.Add(this.label6);
            this.INSERT.Controls.Add(this.lvwBarang1);
            this.INSERT.Controls.Add(this.btnInsertBarang);
            this.INSERT.Controls.Add(this.txtIdCustInsert);
            this.INSERT.Controls.Add(this.txtIdSuppInsert);
            this.INSERT.Controls.Add(this.txtJenisBarangInsert);
            this.INSERT.Controls.Add(this.txtNamaBarangInsert);
            this.INSERT.Controls.Add(this.label4);
            this.INSERT.Controls.Add(this.label3);
            this.INSERT.Controls.Add(this.label2);
            this.INSERT.Controls.Add(this.label5);
            this.INSERT.Location = new System.Drawing.Point(4, 22);
            this.INSERT.Name = "INSERT";
            this.INSERT.Padding = new System.Windows.Forms.Padding(3);
            this.INSERT.Size = new System.Drawing.Size(550, 360);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "Masukkan Barang";
            this.INSERT.UseVisualStyleBackColor = true;
            // 
            // cmbStatusInsert
            // 
            this.cmbStatusInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusInsert.FormattingEnabled = true;
            this.cmbStatusInsert.Items.AddRange(new object[] {
            "Tersimpan",
            "Terkirim"});
            this.cmbStatusInsert.Location = new System.Drawing.Point(111, 166);
            this.cmbStatusInsert.Name = "cmbStatusInsert";
            this.cmbStatusInsert.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusInsert.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Status";
            // 
            // btnTampilkanBar1
            // 
            this.btnTampilkanBar1.Location = new System.Drawing.Point(393, 138);
            this.btnTampilkanBar1.Name = "btnTampilkanBar1";
            this.btnTampilkanBar1.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanBar1.TabIndex = 47;
            this.btnTampilkanBar1.Text = "Tampilkan Data";
            this.btnTampilkanBar1.UseVisualStyleBackColor = true;
            this.btnTampilkanBar1.Click += new System.EventHandler(this.btnTampilkanBar1_Click);
            // 
            // txtIdAdminInsert
            // 
            this.txtIdAdminInsert.Location = new System.Drawing.Point(111, 140);
            this.txtIdAdminInsert.Name = "txtIdAdminInsert";
            this.txtIdAdminInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdAdminInsert.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Id Admin";
            // 
            // txtIdBarangInsert
            // 
            this.txtIdBarangInsert.Location = new System.Drawing.Point(111, 8);
            this.txtIdBarangInsert.Name = "txtIdBarangInsert";
            this.txtIdBarangInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdBarangInsert.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Id Barang";
            // 
            // lvwBarang1
            // 
            this.lvwBarang1.HideSelection = false;
            this.lvwBarang1.Location = new System.Drawing.Point(6, 204);
            this.lvwBarang1.Name = "lvwBarang1";
            this.lvwBarang1.Size = new System.Drawing.Size(539, 150);
            this.lvwBarang1.TabIndex = 27;
            this.lvwBarang1.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsertBarang
            // 
            this.btnInsertBarang.Location = new System.Drawing.Point(252, 137);
            this.btnInsertBarang.Name = "btnInsertBarang";
            this.btnInsertBarang.Size = new System.Drawing.Size(135, 23);
            this.btnInsertBarang.TabIndex = 26;
            this.btnInsertBarang.Text = "Masukkan Barang";
            this.btnInsertBarang.UseVisualStyleBackColor = true;
            this.btnInsertBarang.Click += new System.EventHandler(this.btnInsertBarang_Click);
            // 
            // txtIdCustInsert
            // 
            this.txtIdCustInsert.Location = new System.Drawing.Point(111, 114);
            this.txtIdCustInsert.Name = "txtIdCustInsert";
            this.txtIdCustInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdCustInsert.TabIndex = 25;
            // 
            // txtIdSuppInsert
            // 
            this.txtIdSuppInsert.Location = new System.Drawing.Point(111, 88);
            this.txtIdSuppInsert.Name = "txtIdSuppInsert";
            this.txtIdSuppInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdSuppInsert.TabIndex = 24;
            // 
            // txtJenisBarangInsert
            // 
            this.txtJenisBarangInsert.Location = new System.Drawing.Point(111, 60);
            this.txtJenisBarangInsert.Name = "txtJenisBarangInsert";
            this.txtJenisBarangInsert.Size = new System.Drawing.Size(135, 20);
            this.txtJenisBarangInsert.TabIndex = 23;
            // 
            // txtNamaBarangInsert
            // 
            this.txtNamaBarangInsert.Location = new System.Drawing.Point(111, 34);
            this.txtNamaBarangInsert.Name = "txtNamaBarangInsert";
            this.txtNamaBarangInsert.Size = new System.Drawing.Size(135, 20);
            this.txtNamaBarangInsert.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Jenis Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nama Barang";
            // 
            // UPDATE
            // 
            this.UPDATE.Controls.Add(this.cmbStatusUpdate);
            this.UPDATE.Controls.Add(this.label13);
            this.UPDATE.Controls.Add(this.btnTampilkanBar2);
            this.UPDATE.Controls.Add(this.txtIdAdminUpdate);
            this.UPDATE.Controls.Add(this.label17);
            this.UPDATE.Controls.Add(this.btnCariBarUpdate);
            this.UPDATE.Controls.Add(this.txtIdBarangUpdate);
            this.UPDATE.Controls.Add(this.label7);
            this.UPDATE.Controls.Add(this.lvwBarang2);
            this.UPDATE.Controls.Add(this.btnUpdateBarang);
            this.UPDATE.Controls.Add(this.txtIdCustUpdate);
            this.UPDATE.Controls.Add(this.txtIdSuppUpdate);
            this.UPDATE.Controls.Add(this.txtJenisBarangUpdate);
            this.UPDATE.Controls.Add(this.txtNamaBarangUpdate);
            this.UPDATE.Controls.Add(this.label8);
            this.UPDATE.Controls.Add(this.label9);
            this.UPDATE.Controls.Add(this.label10);
            this.UPDATE.Controls.Add(this.label11);
            this.UPDATE.Location = new System.Drawing.Point(4, 22);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Padding = new System.Windows.Forms.Padding(3);
            this.UPDATE.Size = new System.Drawing.Size(550, 360);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = "Update Barang";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // cmbStatusUpdate
            // 
            this.cmbStatusUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusUpdate.FormattingEnabled = true;
            this.cmbStatusUpdate.Items.AddRange(new object[] {
            "Tersimpan",
            "Terkirim"});
            this.cmbStatusUpdate.Location = new System.Drawing.Point(111, 166);
            this.cmbStatusUpdate.Name = "cmbStatusUpdate";
            this.cmbStatusUpdate.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusUpdate.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Status";
            // 
            // btnTampilkanBar2
            // 
            this.btnTampilkanBar2.Location = new System.Drawing.Point(405, 139);
            this.btnTampilkanBar2.Name = "btnTampilkanBar2";
            this.btnTampilkanBar2.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanBar2.TabIndex = 48;
            this.btnTampilkanBar2.Text = "Tampilkan Data";
            this.btnTampilkanBar2.UseVisualStyleBackColor = true;
            this.btnTampilkanBar2.Click += new System.EventHandler(this.btnTampilkanBar2_Click);
            // 
            // txtIdAdminUpdate
            // 
            this.txtIdAdminUpdate.Location = new System.Drawing.Point(111, 139);
            this.txtIdAdminUpdate.Name = "txtIdAdminUpdate";
            this.txtIdAdminUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdAdminUpdate.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 43;
            this.label17.Text = "Id Admin";
            // 
            // btnCariBarUpdate
            // 
            this.btnCariBarUpdate.Location = new System.Drawing.Point(279, 7);
            this.btnCariBarUpdate.Name = "btnCariBarUpdate";
            this.btnCariBarUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnCariBarUpdate.TabIndex = 42;
            this.btnCariBarUpdate.Text = "Cari Data";
            this.btnCariBarUpdate.UseVisualStyleBackColor = true;
            this.btnCariBarUpdate.Click += new System.EventHandler(this.btnCariBarUpdate_Click);
            // 
            // txtIdBarangUpdate
            // 
            this.txtIdBarangUpdate.Location = new System.Drawing.Point(111, 7);
            this.txtIdBarangUpdate.Name = "txtIdBarangUpdate";
            this.txtIdBarangUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdBarangUpdate.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Id Barang";
            // 
            // lvwBarang2
            // 
            this.lvwBarang2.HideSelection = false;
            this.lvwBarang2.Location = new System.Drawing.Point(6, 199);
            this.lvwBarang2.Name = "lvwBarang2";
            this.lvwBarang2.Size = new System.Drawing.Size(539, 154);
            this.lvwBarang2.TabIndex = 39;
            this.lvwBarang2.UseCompatibleStateImageBehavior = false;
            // 
            // btnUpdateBarang
            // 
            this.btnUpdateBarang.Location = new System.Drawing.Point(264, 140);
            this.btnUpdateBarang.Name = "btnUpdateBarang";
            this.btnUpdateBarang.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateBarang.TabIndex = 38;
            this.btnUpdateBarang.Text = "Update Barang";
            this.btnUpdateBarang.UseVisualStyleBackColor = true;
            this.btnUpdateBarang.Click += new System.EventHandler(this.btnUpdateBarang_Click);
            // 
            // txtIdCustUpdate
            // 
            this.txtIdCustUpdate.Location = new System.Drawing.Point(111, 113);
            this.txtIdCustUpdate.Name = "txtIdCustUpdate";
            this.txtIdCustUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdCustUpdate.TabIndex = 37;
            // 
            // txtIdSuppUpdate
            // 
            this.txtIdSuppUpdate.Location = new System.Drawing.Point(111, 87);
            this.txtIdSuppUpdate.Name = "txtIdSuppUpdate";
            this.txtIdSuppUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdSuppUpdate.TabIndex = 36;
            // 
            // txtJenisBarangUpdate
            // 
            this.txtJenisBarangUpdate.Location = new System.Drawing.Point(111, 59);
            this.txtJenisBarangUpdate.Name = "txtJenisBarangUpdate";
            this.txtJenisBarangUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtJenisBarangUpdate.TabIndex = 35;
            // 
            // txtNamaBarangUpdate
            // 
            this.txtNamaBarangUpdate.Location = new System.Drawing.Point(111, 33);
            this.txtNamaBarangUpdate.Name = "txtNamaBarangUpdate";
            this.txtNamaBarangUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtNamaBarangUpdate.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Id Customer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Id Supplier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Jenis Barang";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Nama Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "DATA BARANG";
            // 
            // btnBarTgh
            // 
            this.btnBarTgh.BackColor = System.Drawing.Color.SlateBlue;
            this.btnBarTgh.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarTgh.ForeColor = System.Drawing.Color.White;
            this.btnBarTgh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarTgh.Location = new System.Drawing.Point(3, 246);
            this.btnBarTgh.Name = "btnBarTgh";
            this.btnBarTgh.Size = new System.Drawing.Size(151, 56);
            this.btnBarTgh.TabIndex = 6;
            this.btnBarTgh.Text = "TAGIHAN";
            this.btnBarTgh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarTgh.UseCompatibleTextRendering = true;
            this.btnBarTgh.UseVisualStyleBackColor = false;
            this.btnBarTgh.Click += new System.EventHandler(this.btnBarTgh_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBarang";
            this.Text = "Form Barang";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.INSERT.ResumeLayout(false);
            this.INSERT.PerformLayout();
            this.UPDATE.ResumeLayout(false);
            this.UPDATE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBarCust;
        private System.Windows.Forms.Button btnBarBar;
        private System.Windows.Forms.Button btnBarSupp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage INSERT;
        private System.Windows.Forms.TabPage UPDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertBarang;
        private System.Windows.Forms.TextBox txtIdCustInsert;
        private System.Windows.Forms.TextBox txtIdSuppInsert;
        private System.Windows.Forms.TextBox txtJenisBarangInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamaBarangInsert;
        private System.Windows.Forms.ListView lvwBarang1;
        private System.Windows.Forms.TextBox txtIdBarangInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdBarangUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvwBarang2;
        private System.Windows.Forms.Button btnUpdateBarang;
        private System.Windows.Forms.TextBox txtIdCustUpdate;
        private System.Windows.Forms.TextBox txtIdSuppUpdate;
        private System.Windows.Forms.TextBox txtJenisBarangUpdate;
        private System.Windows.Forms.TextBox txtNamaBarangUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCariBarUpdate;
        private System.Windows.Forms.Button btnBarAdmin;
        private System.Windows.Forms.TextBox txtIdAdminInsert;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtIdAdminUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnTampilkanBar1;
        private System.Windows.Forms.Button btnTampilkanBar2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbStatusInsert;
        private System.Windows.Forms.ComboBox cmbStatusUpdate;
        private System.Windows.Forms.Button btnBarMenu;
        private System.Windows.Forms.Button btnBarTgh;
    }
}

