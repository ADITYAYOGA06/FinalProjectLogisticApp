
namespace LogisticApp2.View
{
    partial class FormTagihan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTagihan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTghMenu = new System.Windows.Forms.Button();
            this.btnTghAdmin = new System.Windows.Forms.Button();
            this.btnTghCust = new System.Windows.Forms.Button();
            this.btnTghBar = new System.Windows.Forms.Button();
            this.btnTghSupp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.INSERT = new System.Windows.Forms.TabPage();
            this.cmbStatusTagihanInsert = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTampilkanTgh1 = new System.Windows.Forms.Button();
            this.txtIdTagihanInsert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lvwTagihan1 = new System.Windows.Forms.ListView();
            this.btnInsertTagihan = new System.Windows.Forms.Button();
            this.txtBiayaInsert = new System.Windows.Forms.TextBox();
            this.txtIdBarangInsert = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UPDATE = new System.Windows.Forms.TabPage();
            this.cmbStatusTagihanUpdate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdTagihanUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBiayaUpdate = new System.Windows.Forms.TextBox();
            this.txtIdBarangUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTampilkanTgh2 = new System.Windows.Forms.Button();
            this.btnCariTghUpdate = new System.Windows.Forms.Button();
            this.lvwTagihan2 = new System.Windows.Forms.ListView();
            this.btnUpdateTagihan = new System.Windows.Forms.Button();
            this.btnTghTgh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.INSERT.SuspendLayout();
            this.UPDATE.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnTghTgh);
            this.panel1.Controls.Add(this.btnTghMenu);
            this.panel1.Controls.Add(this.btnTghAdmin);
            this.panel1.Controls.Add(this.btnTghCust);
            this.panel1.Controls.Add(this.btnTghBar);
            this.panel1.Controls.Add(this.btnTghSupp);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 460);
            this.panel1.TabIndex = 1;
            // 
            // btnTghMenu
            // 
            this.btnTghMenu.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTghMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTghMenu.ForeColor = System.Drawing.Color.White;
            this.btnTghMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTghMenu.Location = new System.Drawing.Point(32, 10);
            this.btnTghMenu.Name = "btnTghMenu";
            this.btnTghMenu.Size = new System.Drawing.Size(90, 40);
            this.btnTghMenu.TabIndex = 5;
            this.btnTghMenu.Text = "Menu";
            this.btnTghMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTghMenu.UseCompatibleTextRendering = true;
            this.btnTghMenu.UseVisualStyleBackColor = false;
            this.btnTghMenu.Click += new System.EventHandler(this.btnTghMenu_Click);
            // 
            // btnTghAdmin
            // 
            this.btnTghAdmin.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTghAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTghAdmin.ForeColor = System.Drawing.Color.White;
            this.btnTghAdmin.Location = new System.Drawing.Point(25, 361);
            this.btnTghAdmin.Name = "btnTghAdmin";
            this.btnTghAdmin.Size = new System.Drawing.Size(97, 34);
            this.btnTghAdmin.TabIndex = 4;
            this.btnTghAdmin.Text = "Info Admin";
            this.btnTghAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTghAdmin.UseCompatibleTextRendering = true;
            this.btnTghAdmin.UseVisualStyleBackColor = false;
            this.btnTghAdmin.Click += new System.EventHandler(this.btnTghAdmin_Click);
            // 
            // btnTghCust
            // 
            this.btnTghCust.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTghCust.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTghCust.ForeColor = System.Drawing.Color.White;
            this.btnTghCust.Image = ((System.Drawing.Image)(resources.GetObject("btnTghCust.Image")));
            this.btnTghCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTghCust.Location = new System.Drawing.Point(3, 122);
            this.btnTghCust.Name = "btnTghCust";
            this.btnTghCust.Size = new System.Drawing.Size(151, 56);
            this.btnTghCust.TabIndex = 2;
            this.btnTghCust.Text = " CUSTOMER";
            this.btnTghCust.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTghCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTghCust.UseCompatibleTextRendering = true;
            this.btnTghCust.UseVisualStyleBackColor = false;
            this.btnTghCust.Click += new System.EventHandler(this.btnTghCust_Click);
            // 
            // btnTghBar
            // 
            this.btnTghBar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTghBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTghBar.ForeColor = System.Drawing.Color.White;
            this.btnTghBar.Image = ((System.Drawing.Image)(resources.GetObject("btnTghBar.Image")));
            this.btnTghBar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTghBar.Location = new System.Drawing.Point(3, 184);
            this.btnTghBar.Name = "btnTghBar";
            this.btnTghBar.Size = new System.Drawing.Size(151, 56);
            this.btnTghBar.TabIndex = 1;
            this.btnTghBar.Text = " BARANG";
            this.btnTghBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTghBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTghBar.UseCompatibleTextRendering = true;
            this.btnTghBar.UseVisualStyleBackColor = false;
            this.btnTghBar.Click += new System.EventHandler(this.btnTghBar_Click);
            // 
            // btnTghSupp
            // 
            this.btnTghSupp.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTghSupp.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTghSupp.ForeColor = System.Drawing.Color.White;
            this.btnTghSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnTghSupp.Image")));
            this.btnTghSupp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTghSupp.Location = new System.Drawing.Point(3, 60);
            this.btnTghSupp.Name = "btnTghSupp";
            this.btnTghSupp.Size = new System.Drawing.Size(151, 56);
            this.btnTghSupp.TabIndex = 0;
            this.btnTghSupp.Text = " SUPPLIER";
            this.btnTghSupp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTghSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTghSupp.UseCompatibleTextRendering = true;
            this.btnTghSupp.UseVisualStyleBackColor = false;
            this.btnTghSupp.Click += new System.EventHandler(this.btnTghSupp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "DATA TAGIHAN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.INSERT);
            this.tabControl1.Controls.Add(this.UPDATE);
            this.tabControl1.Location = new System.Drawing.Point(166, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(558, 386);
            this.tabControl1.TabIndex = 8;
            // 
            // INSERT
            // 
            this.INSERT.Controls.Add(this.cmbStatusTagihanInsert);
            this.INSERT.Controls.Add(this.label12);
            this.INSERT.Controls.Add(this.btnTampilkanTgh1);
            this.INSERT.Controls.Add(this.txtIdTagihanInsert);
            this.INSERT.Controls.Add(this.label6);
            this.INSERT.Controls.Add(this.lvwTagihan1);
            this.INSERT.Controls.Add(this.btnInsertTagihan);
            this.INSERT.Controls.Add(this.txtBiayaInsert);
            this.INSERT.Controls.Add(this.txtIdBarangInsert);
            this.INSERT.Controls.Add(this.label2);
            this.INSERT.Controls.Add(this.label5);
            this.INSERT.Location = new System.Drawing.Point(4, 22);
            this.INSERT.Name = "INSERT";
            this.INSERT.Padding = new System.Windows.Forms.Padding(3);
            this.INSERT.Size = new System.Drawing.Size(550, 360);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "Masukkan Tagihan";
            this.INSERT.UseVisualStyleBackColor = true;
            // 
            // cmbStatusTagihanInsert
            // 
            this.cmbStatusTagihanInsert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTagihanInsert.FormattingEnabled = true;
            this.cmbStatusTagihanInsert.Items.AddRange(new object[] {
            "Belum Lunas",
            "Lunas"});
            this.cmbStatusTagihanInsert.Location = new System.Drawing.Point(111, 88);
            this.cmbStatusTagihanInsert.Name = "cmbStatusTagihanInsert";
            this.cmbStatusTagihanInsert.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusTagihanInsert.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Status";
            // 
            // btnTampilkanTgh1
            // 
            this.btnTampilkanTgh1.Location = new System.Drawing.Point(410, 106);
            this.btnTampilkanTgh1.Name = "btnTampilkanTgh1";
            this.btnTampilkanTgh1.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanTgh1.TabIndex = 47;
            this.btnTampilkanTgh1.Text = "Tampilkan Data";
            this.btnTampilkanTgh1.UseVisualStyleBackColor = true;
            this.btnTampilkanTgh1.Click += new System.EventHandler(this.btnTampilkanTgh1_Click);
            // 
            // txtIdTagihanInsert
            // 
            this.txtIdTagihanInsert.Location = new System.Drawing.Point(111, 8);
            this.txtIdTagihanInsert.Name = "txtIdTagihanInsert";
            this.txtIdTagihanInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdTagihanInsert.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Id Tagihan";
            // 
            // lvwTagihan1
            // 
            this.lvwTagihan1.HideSelection = false;
            this.lvwTagihan1.Location = new System.Drawing.Point(6, 135);
            this.lvwTagihan1.Name = "lvwTagihan1";
            this.lvwTagihan1.Size = new System.Drawing.Size(539, 219);
            this.lvwTagihan1.TabIndex = 27;
            this.lvwTagihan1.UseCompatibleStateImageBehavior = false;
            // 
            // btnInsertTagihan
            // 
            this.btnInsertTagihan.Location = new System.Drawing.Point(269, 105);
            this.btnInsertTagihan.Name = "btnInsertTagihan";
            this.btnInsertTagihan.Size = new System.Drawing.Size(135, 23);
            this.btnInsertTagihan.TabIndex = 26;
            this.btnInsertTagihan.Text = "Masukkan Tagihan";
            this.btnInsertTagihan.UseVisualStyleBackColor = true;
            this.btnInsertTagihan.Click += new System.EventHandler(this.btnInsertTagihan_Click);
            // 
            // txtBiayaInsert
            // 
            this.txtBiayaInsert.Location = new System.Drawing.Point(111, 60);
            this.txtBiayaInsert.Name = "txtBiayaInsert";
            this.txtBiayaInsert.Size = new System.Drawing.Size(135, 20);
            this.txtBiayaInsert.TabIndex = 23;
            // 
            // txtIdBarangInsert
            // 
            this.txtIdBarangInsert.Location = new System.Drawing.Point(111, 34);
            this.txtIdBarangInsert.Name = "txtIdBarangInsert";
            this.txtIdBarangInsert.Size = new System.Drawing.Size(135, 20);
            this.txtIdBarangInsert.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Biaya Tagihan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Id Barang";
            // 
            // UPDATE
            // 
            this.UPDATE.Controls.Add(this.cmbStatusTagihanUpdate);
            this.UPDATE.Controls.Add(this.label3);
            this.UPDATE.Controls.Add(this.txtIdTagihanUpdate);
            this.UPDATE.Controls.Add(this.label4);
            this.UPDATE.Controls.Add(this.txtBiayaUpdate);
            this.UPDATE.Controls.Add(this.txtIdBarangUpdate);
            this.UPDATE.Controls.Add(this.label7);
            this.UPDATE.Controls.Add(this.label8);
            this.UPDATE.Controls.Add(this.btnTampilkanTgh2);
            this.UPDATE.Controls.Add(this.btnCariTghUpdate);
            this.UPDATE.Controls.Add(this.lvwTagihan2);
            this.UPDATE.Controls.Add(this.btnUpdateTagihan);
            this.UPDATE.Location = new System.Drawing.Point(4, 22);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Padding = new System.Windows.Forms.Padding(3);
            this.UPDATE.Size = new System.Drawing.Size(550, 360);
            this.UPDATE.TabIndex = 1;
            this.UPDATE.Text = "Update Tagihan";
            this.UPDATE.UseVisualStyleBackColor = true;
            // 
            // cmbStatusTagihanUpdate
            // 
            this.cmbStatusTagihanUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusTagihanUpdate.FormattingEnabled = true;
            this.cmbStatusTagihanUpdate.Items.AddRange(new object[] {
            "Belum Lunas",
            "Lunas"});
            this.cmbStatusTagihanUpdate.Location = new System.Drawing.Point(110, 90);
            this.cmbStatusTagihanUpdate.Name = "cmbStatusTagihanUpdate";
            this.cmbStatusTagihanUpdate.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusTagihanUpdate.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Status";
            // 
            // txtIdTagihanUpdate
            // 
            this.txtIdTagihanUpdate.Location = new System.Drawing.Point(110, 10);
            this.txtIdTagihanUpdate.Name = "txtIdTagihanUpdate";
            this.txtIdTagihanUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdTagihanUpdate.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Id Tagihan";
            // 
            // txtBiayaUpdate
            // 
            this.txtBiayaUpdate.Location = new System.Drawing.Point(110, 62);
            this.txtBiayaUpdate.Name = "txtBiayaUpdate";
            this.txtBiayaUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtBiayaUpdate.TabIndex = 54;
            // 
            // txtIdBarangUpdate
            // 
            this.txtIdBarangUpdate.Location = new System.Drawing.Point(110, 36);
            this.txtIdBarangUpdate.Name = "txtIdBarangUpdate";
            this.txtIdBarangUpdate.Size = new System.Drawing.Size(135, 20);
            this.txtIdBarangUpdate.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Biaya Tagihan";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 51;
            this.label8.Text = "Id Barang";
            // 
            // btnTampilkanTgh2
            // 
            this.btnTampilkanTgh2.Location = new System.Drawing.Point(409, 106);
            this.btnTampilkanTgh2.Name = "btnTampilkanTgh2";
            this.btnTampilkanTgh2.Size = new System.Drawing.Size(135, 23);
            this.btnTampilkanTgh2.TabIndex = 48;
            this.btnTampilkanTgh2.Text = "Tampilkan Data";
            this.btnTampilkanTgh2.UseVisualStyleBackColor = true;
            this.btnTampilkanTgh2.Click += new System.EventHandler(this.btnTampilkanTgh2_Click);
            // 
            // btnCariTghUpdate
            // 
            this.btnCariTghUpdate.Location = new System.Drawing.Point(279, 7);
            this.btnCariTghUpdate.Name = "btnCariTghUpdate";
            this.btnCariTghUpdate.Size = new System.Drawing.Size(135, 23);
            this.btnCariTghUpdate.TabIndex = 42;
            this.btnCariTghUpdate.Text = "Cari Data";
            this.btnCariTghUpdate.UseVisualStyleBackColor = true;
            this.btnCariTghUpdate.Click += new System.EventHandler(this.btnCariTghUpdate_Click);
            // 
            // lvwTagihan2
            // 
            this.lvwTagihan2.HideSelection = false;
            this.lvwTagihan2.Location = new System.Drawing.Point(6, 136);
            this.lvwTagihan2.Name = "lvwTagihan2";
            this.lvwTagihan2.Size = new System.Drawing.Size(539, 217);
            this.lvwTagihan2.TabIndex = 39;
            this.lvwTagihan2.UseCompatibleStateImageBehavior = false;
            // 
            // btnUpdateTagihan
            // 
            this.btnUpdateTagihan.Location = new System.Drawing.Point(268, 107);
            this.btnUpdateTagihan.Name = "btnUpdateTagihan";
            this.btnUpdateTagihan.Size = new System.Drawing.Size(135, 23);
            this.btnUpdateTagihan.TabIndex = 38;
            this.btnUpdateTagihan.Text = "Update Barang";
            this.btnUpdateTagihan.UseVisualStyleBackColor = true;
            this.btnUpdateTagihan.Click += new System.EventHandler(this.btnUpdateTagihan_Click);
            // 
            // btnTghTgh
            // 
            this.btnTghTgh.BackColor = System.Drawing.Color.SlateBlue;
            this.btnTghTgh.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTghTgh.ForeColor = System.Drawing.Color.White;
            this.btnTghTgh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTghTgh.Location = new System.Drawing.Point(3, 246);
            this.btnTghTgh.Name = "btnTghTgh";
            this.btnTghTgh.Size = new System.Drawing.Size(151, 56);
            this.btnTghTgh.TabIndex = 8;
            this.btnTghTgh.Text = "TAGIHAN";
            this.btnTghTgh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTghTgh.UseCompatibleTextRendering = true;
            this.btnTghTgh.UseVisualStyleBackColor = false;
            this.btnTghTgh.Click += new System.EventHandler(this.btnTghTgh_Click);
            // 
            // FormTagihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormTagihan";
            this.Text = "FormTagihan";
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
        private System.Windows.Forms.Button btnTghMenu;
        private System.Windows.Forms.Button btnTghAdmin;
        private System.Windows.Forms.Button btnTghCust;
        private System.Windows.Forms.Button btnTghBar;
        private System.Windows.Forms.Button btnTghSupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage INSERT;
        private System.Windows.Forms.ComboBox cmbStatusTagihanInsert;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnTampilkanTgh1;
        private System.Windows.Forms.TextBox txtIdTagihanInsert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lvwTagihan1;
        private System.Windows.Forms.Button btnInsertTagihan;
        private System.Windows.Forms.TextBox txtBiayaInsert;
        private System.Windows.Forms.TextBox txtIdBarangInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage UPDATE;
        private System.Windows.Forms.Button btnTampilkanTgh2;
        private System.Windows.Forms.Button btnCariTghUpdate;
        private System.Windows.Forms.ListView lvwTagihan2;
        private System.Windows.Forms.Button btnUpdateTagihan;
        private System.Windows.Forms.ComboBox cmbStatusTagihanUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdTagihanUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBiayaUpdate;
        private System.Windows.Forms.TextBox txtIdBarangUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTghTgh;
    }
}