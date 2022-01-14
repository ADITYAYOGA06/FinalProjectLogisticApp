
namespace LogisticApp2
{
    partial class FormCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCustMenu = new System.Windows.Forms.Button();
            this.btnCustAdmin = new System.Windows.Forms.Button();
            this.btnCustCust = new System.Windows.Forms.Button();
            this.btnCustBar = new System.Windows.Forms.Button();
            this.btnCustSupp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.INSERT = new System.Windows.Forms.TabPage();
            this.btnTampilkanCust1 = new System.Windows.Forms.Button();
            this.lvwCust1 = new System.Windows.Forms.ListView();
            this.txtTelpCustInsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsertCust = new System.Windows.Forms.Button();
            this.txtPosCustInsert = new System.Windows.Forms.TextBox();
            this.txtKotaCustInsert = new System.Windows.Forms.TextBox();
            this.txtNamaCustInsert = new System.Windows.Forms.TextBox();
            this.txtIdCustInsert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.TabPage();
            this.btnTampilkanCust2 = new System.Windows.Forms.Button();
            this.btnCariCustUpdate = new System.Windows.Forms.Button();
            this.lvwCust2 = new System.Windows.Forms.ListView();
            this.txtTelpCustUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.txtPosCustUpdate = new System.Windows.Forms.TextBox();
            this.txtKotaCustUpdate = new System.Windows.Forms.TextBox();
            this.txtNamaCustUpdate = new System.Windows.Forms.TextBox();
            this.txtIdCustUpdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.TabPage();
            this.btnTampilkanCust3 = new System.Windows.Forms.Button();
            this.btnCariCustDelete = new System.Windows.Forms.Button();
            this.lvwCust3 = new System.Windows.Forms.ListView();
            this.txtTelpCustDelete = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnHapusCust = new System.Windows.Forms.Button();
            this.txtPosCustDelete = new System.Windows.Forms.TextBox();
            this.txtKotaCustDelete = new System.Windows.Forms.TextBox();
            this.txtNamaCustDelete = new System.Windows.Forms.TextBox();
            this.txtIdCustDelete = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustTgh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.INSERT.SuspendLayout();
            this.UPDATE.SuspendLayout();
            this.DELETE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnCustTgh);
            this.panel1.Controls.Add(this.btnCustMenu);
            this.panel1.Controls.Add(this.btnCustAdmin);
            this.panel1.Controls.Add(this.btnCustCust);
            this.panel1.Controls.Add(this.btnCustBar);
            this.panel1.Controls.Add(this.btnCustSupp);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 460);
            this.panel1.TabIndex = 2;
            // 
            // btnCustMenu
            // 
            this.btnCustMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustMenu.ForeColor = System.Drawing.Color.White;
            this.btnCustMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustMenu.Location = new System.Drawing.Point(31, 9);
            this.btnCustMenu.Name = "btnCustMenu";
            this.btnCustMenu.Size = new System.Drawing.Size(90, 40);
            this.btnCustMenu.TabIndex = 6;
            this.btnCustMenu.Text = "Menu";
            this.btnCustMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustMenu.UseCompatibleTextRendering = true;
            this.btnCustMenu.UseVisualStyleBackColor = false;
            this.btnCustMenu.Click += new System.EventHandler(this.btnCustMenu_Click);
            // 
            // btnCustAdmin
            // 
            this.btnCustAdmin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCustAdmin.Location = new System.Drawing.Point(31, 361);
            this.btnCustAdmin.Name = "btnCustAdmin";
            this.btnCustAdmin.Size = new System.Drawing.Size(97, 34);
            this.btnCustAdmin.TabIndex = 5;
            this.btnCustAdmin.Text = "Info Admin";
            this.btnCustAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustAdmin.UseCompatibleTextRendering = true;
            this.btnCustAdmin.UseVisualStyleBackColor = false;
            this.btnCustAdmin.Click += new System.EventHandler(this.btnCustAdmin_Click);
            // 
            // btnCustCust
            // 
            this.btnCustCust.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustCust.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustCust.ForeColor = System.Drawing.Color.White;
            this.btnCustCust.Image = ((System.Drawing.Image)(resources.GetObject("btnCustCust.Image")));
            this.btnCustCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustCust.Location = new System.Drawing.Point(3, 122);
            this.btnCustCust.Name = "btnCustCust";
            this.btnCustCust.Size = new System.Drawing.Size(151, 56);
            this.btnCustCust.TabIndex = 2;
            this.btnCustCust.Text = " CUSTOMER";
            this.btnCustCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustCust.UseCompatibleTextRendering = true;
            this.btnCustCust.UseVisualStyleBackColor = false;
            // 
            // btnCustBar
            // 
            this.btnCustBar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustBar.ForeColor = System.Drawing.Color.White;
            this.btnCustBar.Image = ((System.Drawing.Image)(resources.GetObject("btnCustBar.Image")));
            this.btnCustBar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustBar.Location = new System.Drawing.Point(3, 184);
            this.btnCustBar.Name = "btnCustBar";
            this.btnCustBar.Size = new System.Drawing.Size(151, 56);
            this.btnCustBar.TabIndex = 1;
            this.btnCustBar.Text = " BARANG";
            this.btnCustBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustBar.UseCompatibleTextRendering = true;
            this.btnCustBar.UseVisualStyleBackColor = false;
            this.btnCustBar.Click += new System.EventHandler(this.btnCustBar_Click);
            // 
            // btnCustSupp
            // 
            this.btnCustSupp.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustSupp.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustSupp.ForeColor = System.Drawing.Color.White;
            this.btnCustSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnCustSupp.Image")));
            this.btnCustSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustSupp.Location = new System.Drawing.Point(3, 60);
            this.btnCustSupp.Name = "btnCustSupp";
            this.btnCustSupp.Size = new System.Drawing.Size(151, 56);
            this.btnCustSupp.TabIndex = 0;
            this.btnCustSupp.Text = " SUPPLIER";
            this.btnCustSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustSupp.UseCompatibleTextRendering = true;
            this.btnCustSupp.UseVisualStyleBackColor = false;
            this.btnCustSupp.Click += new System.EventHandler(this.btnCustSupp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.INSERT);
            this.tabControl1.Controls.Add(this.UPDATE);
            this.tabControl1.Controls.Add(this.DELETE);
            this.tabControl1.Location = new System.Drawing.Point(164, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 386);
            this.tabControl1.TabIndex = 3;
            // 
            // INSERT
            // 
            this.INSERT.Controls.Add(this.btnTampilkanCust1);
            this.INSERT.Controls.Add(this.lvwCust1);
            this.INSERT.Controls.Add(this.txtTelpCustInsert);
            this.INSERT.Controls.Add(this.label6);
            this.INSERT.Controls.Add(this.btnInsertCust);
            this.INSERT.Controls.Add(this.txtPosCustInsert);
            this.INSERT.Controls.Add(this.txtKotaCustInsert);
            this.INSERT.Controls.Add(this.txtNamaCustInsert);
            this.INSERT.Controls.Add(this.txtIdCustInsert);
            this.INSERT.Controls.Add(this.label4);
            this.INSERT.Controls.Add(this.label3);
            this.INSERT.Controls.Add(this.label2);
            this.INSERT.Controls.Add(this.label5);
            this.INSERT.Location = new System.Drawing.Point(4, 22);
            this.INSERT.Name = "INSERT";
            this.INSERT.Padding = new System.Windows.Forms.Padding(3);
            this.INSERT.Size = new System.Drawing.Size(550, 360);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = true;
            // 
            // btnTampilkanCust1
            // 
            this.btnTampilkanCust1.Location = new System.Drawing.Point(398, 111);
            this.btnTampilkanCust1.Name = "btnTampilkanCust1";
            this.btnTampilkanCust1.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanCust1.TabIndex = 21;
            this.btnTampilkanCust1.Text = "Tampilkan Data";
            this.btnTampilkanCust1.UseVisualStyleBackColor = true;
            this.btnTampilkanCust1.Click += new System.EventHandler(this.btnTampilkanCust1_Click);
            // 
            // lvwCust1
            // 
            this.lvwCust1.HideSelection = false;
            this.lvwCust1.Location = new System.Drawing.Point(5, 151);
            this.lvwCust1.Name = "lvwCust1";
            this.lvwCust1.Size = new System.Drawing.Size(539, 206);
            this.lvwCust1.TabIndex = 20;
            this.lvwCust1.UseCompatibleStateImageBehavior = false;
            // 
            // txtTelpCustInsert
            // 
            this.txtTelpCustInsert.Location = new System.Drawing.Point(107, 115);
            this.txtTelpCustInsert.Name = "txtTelpCustInsert";
            this.txtTelpCustInsert.Size = new System.Drawing.Size(135, 20);
            this.txtTelpCustInsert.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "No Telp";
            // 
            // btnInsertCust
            // 
            this.btnInsertCust.Location = new System.Drawing.Point(257, 112);
            this.btnInsertCust.Name = "btnInsertCust";
            this.btnInsertCust.Size = new System.Drawing.Size(135, 23);
            this.btnInsertCust.TabIndex = 17;
            this.btnInsertCust.Text = "Tambahkan";
            this.btnInsertCust.UseVisualStyleBackColor = true;
            this.btnInsertCust.Click += new System.EventHandler(this.btnInsertCust_Click);
            // 
            // txtPosCustInsert
            // 
            this.txtPosCustInsert.Location = new System.Drawing.Point(107, 89);
            this.txtPosCustInsert.Name = "txtPosCustInsert";
            this.txtPosCustInsert.Size = new System.Drawing.Size(135, 20);
            this.txtPosCustInsert.TabIndex = 16;
            // 
            // txtKotaCustInsert
            // 
            this.txtKotaCustInsert.Location = new System.Drawing.Point(107, 63);
            this.txtKotaCustInsert.Name = "txtKotaCustInsert";
            this.txtKotaCustInsert.Size = new System.Drawing.Size(135, 20);
            this.txtKotaCustInsert.TabIndex = 15;
            // 
            // txtNamaCustInsert
            // 
            this.txtNamaCustInsert.Location = new System.Drawing.Point(107, 35);
            this.txtNamaCustInsert.Name = "txtNamaCustInsert";
            this.txtNamaCustInsert.Size = new System.Drawing.Size(135, 20);
            this.txtNamaCustInsert.TabIndex = 14;
            // 
            // txtIdCustInsert
            // 
            this.txtIdCustInsert.Location = new System.Drawing.Point(107, 9);
            this.txtIdCustInsert.Name = "txtIdCustInsert";
            this.txtIdCustInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdCustInsert.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kode Pos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nama Customer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id Customer";
            // 
            // UPDATE
            // 
            this.UPDATE.Controls.Add(this.btnTampilkanCust2);
            this.UPDATE.Controls.Add(this.btnCariCustUpdate);
            this.UPDATE.Controls.Add(this.lvwCust2);
            this.UPDATE.Controls.Add(this.txtTelpCustUpdate);
            this.UPDATE.Controls.Add(this.label7);
            this.UPDATE.Controls.Add(this.btnUpdateCust);
            this.UPDATE.Controls.Add(this.txtPosCustUpdate);
            this.UPDATE.Controls.Add(this.txtKotaCustUpdate);
            this.UPDATE.Controls.Add(this.txtNamaCustUpdate);
            this.UPDATE.Controls.Add(this.txtIdCustUpdate);
            this.UPDATE.Controls.Add(this.label8);
            this.UPDATE.Controls.Add(this.label9);
            this.UPDATE.Controls.Add(this.label10);
            this.UPDATE.Controls.Add(this.label11);
            this.UPDATE.Location = new System.Drawing.Point(4, 22);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Padding = new System.Windows.Forms.Padding(3);
            this.UPDATE.Size = new System.Drawing.Size(550, 360);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // btnTampilkanCust2
            // 
            this.btnTampilkanCust2.Location = new System.Drawing.Point(398, 110);
            this.btnTampilkanCust2.Name = "btnTampilkanCust2";
            this.btnTampilkanCust2.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanCust2.TabIndex = 34;
            this.btnTampilkanCust2.Text = "Tampilkan Data";
            this.btnTampilkanCust2.UseVisualStyleBackColor = true;
            this.btnTampilkanCust2.Click += new System.EventHandler(this.btnTampilkanCust2_Click);
            // 
            // btnCariCustUpdate
            // 
            this.btnCariCustUpdate.Location = new System.Drawing.Point(291, 6);
            this.btnCariCustUpdate.Name = "btnCariCustUpdate";
            this.btnCariCustUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnCariCustUpdate.TabIndex = 33;
            this.btnCariCustUpdate.Text = "Cari Data";
            this.btnCariCustUpdate.UseVisualStyleBackColor = true;
            this.btnCariCustUpdate.Click += new System.EventHandler(this.btnCariCustUpdate_Click);
            // 
            // lvwCust2
            // 
            this.lvwCust2.HideSelection = false;
            this.lvwCust2.Location = new System.Drawing.Point(6, 148);
            this.lvwCust2.Name = "lvwCust2";
            this.lvwCust2.Size = new System.Drawing.Size(539, 206);
            this.lvwCust2.TabIndex = 32;
            this.lvwCust2.UseCompatibleStateImageBehavior = false;
            // 
            // txtTelpCustUpdate
            // 
            this.txtTelpCustUpdate.Location = new System.Drawing.Point(108, 112);
            this.txtTelpCustUpdate.Name = "txtTelpCustUpdate";
            this.txtTelpCustUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtTelpCustUpdate.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "No Telp";
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.Location = new System.Drawing.Point(257, 110);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateCust.TabIndex = 29;
            this.btnUpdateCust.Text = "Update";
            this.btnUpdateCust.UseVisualStyleBackColor = true;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // txtPosCustUpdate
            // 
            this.txtPosCustUpdate.Location = new System.Drawing.Point(108, 86);
            this.txtPosCustUpdate.Name = "txtPosCustUpdate";
            this.txtPosCustUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtPosCustUpdate.TabIndex = 28;
            // 
            // txtKotaCustUpdate
            // 
            this.txtKotaCustUpdate.Location = new System.Drawing.Point(108, 60);
            this.txtKotaCustUpdate.Name = "txtKotaCustUpdate";
            this.txtKotaCustUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtKotaCustUpdate.TabIndex = 27;
            // 
            // txtNamaCustUpdate
            // 
            this.txtNamaCustUpdate.Location = new System.Drawing.Point(108, 32);
            this.txtNamaCustUpdate.Name = "txtNamaCustUpdate";
            this.txtNamaCustUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtNamaCustUpdate.TabIndex = 26;
            // 
            // txtIdCustUpdate
            // 
            this.txtIdCustUpdate.Location = new System.Drawing.Point(108, 6);
            this.txtIdCustUpdate.Name = "txtIdCustUpdate";
            this.txtIdCustUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdCustUpdate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Kode Pos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Kota";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Nama Customer";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Id Customer";
            // 
            // DELETE
            // 
            this.DELETE.Controls.Add(this.btnTampilkanCust3);
            this.DELETE.Controls.Add(this.btnCariCustDelete);
            this.DELETE.Controls.Add(this.lvwCust3);
            this.DELETE.Controls.Add(this.txtTelpCustDelete);
            this.DELETE.Controls.Add(this.label12);
            this.DELETE.Controls.Add(this.btnHapusCust);
            this.DELETE.Controls.Add(this.txtPosCustDelete);
            this.DELETE.Controls.Add(this.txtKotaCustDelete);
            this.DELETE.Controls.Add(this.txtNamaCustDelete);
            this.DELETE.Controls.Add(this.txtIdCustDelete);
            this.DELETE.Controls.Add(this.label13);
            this.DELETE.Controls.Add(this.label14);
            this.DELETE.Controls.Add(this.label15);
            this.DELETE.Controls.Add(this.label16);
            this.DELETE.Location = new System.Drawing.Point(4, 22);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(550, 360);
            this.DELETE.TabIndex = 2;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            // 
            // btnTampilkanCust3
            // 
            this.btnTampilkanCust3.Location = new System.Drawing.Point(398, 109);
            this.btnTampilkanCust3.Name = "btnTampilkanCust3";
            this.btnTampilkanCust3.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanCust3.TabIndex = 47;
            this.btnTampilkanCust3.Text = "Tampilkan Data";
            this.btnTampilkanCust3.UseVisualStyleBackColor = true;
            this.btnTampilkanCust3.Click += new System.EventHandler(this.btnTampilkanCust3_Click);
            // 
            // btnCariCustDelete
            // 
            this.btnCariCustDelete.Location = new System.Drawing.Point(291, 6);
            this.btnCariCustDelete.Name = "btnCariCustDelete";
            this.btnCariCustDelete.Size = new System.Drawing.Size(135, 23);
            this.btnCariCustDelete.TabIndex = 46;
            this.btnCariCustDelete.Text = "Cari Data";
            this.btnCariCustDelete.UseVisualStyleBackColor = true;
            this.btnCariCustDelete.Click += new System.EventHandler(this.btnCariCustDelete_Click);
            // 
            // lvwCust3
            // 
            this.lvwCust3.HideSelection = false;
            this.lvwCust3.Location = new System.Drawing.Point(6, 148);
            this.lvwCust3.Name = "lvwCust3";
            this.lvwCust3.Size = new System.Drawing.Size(539, 206);
            this.lvwCust3.TabIndex = 45;
            this.lvwCust3.UseCompatibleStateImageBehavior = false;
            // 
            // txtTelpCustDelete
            // 
            this.txtTelpCustDelete.Enabled = false;
            this.txtTelpCustDelete.Location = new System.Drawing.Point(108, 112);
            this.txtTelpCustDelete.Name = "txtTelpCustDelete";
            this.txtTelpCustDelete.Size = new System.Drawing.Size(135, 20);
            this.txtTelpCustDelete.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "No Telp";
            // 
            // btnHapusCust
            // 
            this.btnHapusCust.Location = new System.Drawing.Point(257, 110);
            this.btnHapusCust.Name = "btnHapusCust";
            this.btnHapusCust.Size = new System.Drawing.Size(135, 23);
            this.btnHapusCust.TabIndex = 42;
            this.btnHapusCust.Text = "Hapus";
            this.btnHapusCust.UseVisualStyleBackColor = true;
            this.btnHapusCust.Click += new System.EventHandler(this.btnHapusCust_Click);
            // 
            // txtPosCustDelete
            // 
            this.txtPosCustDelete.Enabled = false;
            this.txtPosCustDelete.Location = new System.Drawing.Point(108, 86);
            this.txtPosCustDelete.Name = "txtPosCustDelete";
            this.txtPosCustDelete.Size = new System.Drawing.Size(135, 20);
            this.txtPosCustDelete.TabIndex = 41;
            // 
            // txtKotaCustDelete
            // 
            this.txtKotaCustDelete.Enabled = false;
            this.txtKotaCustDelete.Location = new System.Drawing.Point(108, 60);
            this.txtKotaCustDelete.Name = "txtKotaCustDelete";
            this.txtKotaCustDelete.Size = new System.Drawing.Size(135, 20);
            this.txtKotaCustDelete.TabIndex = 40;
            // 
            // txtNamaCustDelete
            // 
            this.txtNamaCustDelete.Enabled = false;
            this.txtNamaCustDelete.Location = new System.Drawing.Point(108, 32);
            this.txtNamaCustDelete.Name = "txtNamaCustDelete";
            this.txtNamaCustDelete.Size = new System.Drawing.Size(135, 20);
            this.txtNamaCustDelete.TabIndex = 39;
            // 
            // txtIdCustDelete
            // 
            this.txtIdCustDelete.Location = new System.Drawing.Point(108, 6);
            this.txtIdCustDelete.Name = "txtIdCustDelete";
            this.txtIdCustDelete.Size = new System.Drawing.Size(135, 20);
            this.txtIdCustDelete.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Kode Pos";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Kota";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 35;
            this.label15.Text = "Nama Customer";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Id Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "DATA CUSTOMER";
            // 
            // btnCustTgh
            // 
            this.btnCustTgh.BackColor = System.Drawing.Color.SlateBlue;
            this.btnCustTgh.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustTgh.ForeColor = System.Drawing.Color.White;
            this.btnCustTgh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustTgh.Location = new System.Drawing.Point(3, 246);
            this.btnCustTgh.Name = "btnCustTgh";
            this.btnCustTgh.Size = new System.Drawing.Size(151, 56);
            this.btnCustTgh.TabIndex = 7;
            this.btnCustTgh.Text = "TAGIHAN";
            this.btnCustTgh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustTgh.UseCompatibleTextRendering = true;
            this.btnCustTgh.UseVisualStyleBackColor = false;
            this.btnCustTgh.Click += new System.EventHandler(this.btnCustTgh_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCustomer";
            this.Text = "Form Customer";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.INSERT.ResumeLayout(false);
            this.INSERT.PerformLayout();
            this.UPDATE.ResumeLayout(false);
            this.UPDATE.PerformLayout();
            this.DELETE.ResumeLayout(false);
            this.DELETE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCustCust;
        private System.Windows.Forms.Button btnCustBar;
        private System.Windows.Forms.Button btnCustSupp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage INSERT;
        private System.Windows.Forms.TabPage UPDATE;
        private System.Windows.Forms.TabPage DELETE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsertCust;
        private System.Windows.Forms.TextBox txtPosCustInsert;
        private System.Windows.Forms.TextBox txtKotaCustInsert;
        private System.Windows.Forms.TextBox txtNamaCustInsert;
        private System.Windows.Forms.TextBox txtIdCustInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelpCustInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvwCust1;
        private System.Windows.Forms.Button btnCariCustUpdate;
        private System.Windows.Forms.ListView lvwCust2;
        private System.Windows.Forms.TextBox txtTelpCustUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.TextBox txtPosCustUpdate;
        private System.Windows.Forms.TextBox txtKotaCustUpdate;
        private System.Windows.Forms.TextBox txtNamaCustUpdate;
        private System.Windows.Forms.TextBox txtIdCustUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCariCustDelete;
        private System.Windows.Forms.ListView lvwCust3;
        private System.Windows.Forms.TextBox txtTelpCustDelete;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHapusCust;
        private System.Windows.Forms.TextBox txtPosCustDelete;
        private System.Windows.Forms.TextBox txtKotaCustDelete;
        private System.Windows.Forms.TextBox txtNamaCustDelete;
        private System.Windows.Forms.TextBox txtIdCustDelete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnCustAdmin;
        private System.Windows.Forms.Button btnTampilkanCust1;
        private System.Windows.Forms.Button btnTampilkanCust2;
        private System.Windows.Forms.Button btnTampilkanCust3;
        private System.Windows.Forms.Button btnCustMenu;
        private System.Windows.Forms.Button btnCustTgh;
    }
}