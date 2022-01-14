
namespace LogisticApp2
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnAdminCust = new System.Windows.Forms.Button();
            this.btnAdminBar = new System.Windows.Forms.Button();
            this.btnAdminSupp = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TampilkanAdmin = new System.Windows.Forms.TabPage();
            this.btnTampilkanAdmin = new System.Windows.Forms.Button();
            this.lvwAdmin = new System.Windows.Forms.ListView();
            this.TambahAdmin = new System.Windows.Forms.TabPage();
            this.btnInputAdmin = new System.Windows.Forms.Button();
            this.txtIdOfficeInput = new System.Windows.Forms.TextBox();
            this.txtPassAdminInput = new System.Windows.Forms.TextBox();
            this.txtIdAdminInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HapusAdmin = new System.Windows.Forms.TabPage();
            this.btnCariHapusAdmin = new System.Windows.Forms.Button();
            this.btnDelAdmin = new System.Windows.Forms.Button();
            this.txtIdOfficeDel = new System.Windows.Forms.TextBox();
            this.txtPassAdminDel = new System.Windows.Forms.TextBox();
            this.txtIdAdminDel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdminMenu = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TampilkanAdmin.SuspendLayout();
            this.TambahAdmin.SuspendLayout();
            this.HapusAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdminCust
            // 
            this.btnAdminCust.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdminCust.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminCust.ForeColor = System.Drawing.Color.White;
            this.btnAdminCust.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminCust.Location = new System.Drawing.Point(592, 238);
            this.btnAdminCust.Name = "btnAdminCust";
            this.btnAdminCust.Size = new System.Drawing.Size(130, 40);
            this.btnAdminCust.TabIndex = 5;
            this.btnAdminCust.Text = " CUSTOMER";
            this.btnAdminCust.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdminCust.UseCompatibleTextRendering = true;
            this.btnAdminCust.UseVisualStyleBackColor = false;
            this.btnAdminCust.Click += new System.EventHandler(this.btnAdminCust_Click);
            // 
            // btnAdminBar
            // 
            this.btnAdminBar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdminBar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminBar.ForeColor = System.Drawing.Color.White;
            this.btnAdminBar.Location = new System.Drawing.Point(592, 192);
            this.btnAdminBar.Name = "btnAdminBar";
            this.btnAdminBar.Size = new System.Drawing.Size(130, 40);
            this.btnAdminBar.TabIndex = 4;
            this.btnAdminBar.Text = " BARANG";
            this.btnAdminBar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminBar.UseCompatibleTextRendering = true;
            this.btnAdminBar.UseVisualStyleBackColor = false;
            this.btnAdminBar.Click += new System.EventHandler(this.btnAdminBar_Click);
            // 
            // btnAdminSupp
            // 
            this.btnAdminSupp.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAdminSupp.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminSupp.ForeColor = System.Drawing.Color.White;
            this.btnAdminSupp.Location = new System.Drawing.Point(592, 146);
            this.btnAdminSupp.Name = "btnAdminSupp";
            this.btnAdminSupp.Size = new System.Drawing.Size(130, 40);
            this.btnAdminSupp.TabIndex = 3;
            this.btnAdminSupp.Text = " SUPPLIER";
            this.btnAdminSupp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminSupp.UseCompatibleTextRendering = true;
            this.btnAdminSupp.UseVisualStyleBackColor = false;
            this.btnAdminSupp.Click += new System.EventHandler(this.btnAdminSupp_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TampilkanAdmin);
            this.tabControl1.Controls.Add(this.TambahAdmin);
            this.tabControl1.Controls.Add(this.HapusAdmin);
            this.tabControl1.Location = new System.Drawing.Point(11, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 366);
            this.tabControl1.TabIndex = 6;
            // 
            // TampilkanAdmin
            // 
            this.TampilkanAdmin.Controls.Add(this.btnTampilkanAdmin);
            this.TampilkanAdmin.Controls.Add(this.lvwAdmin);
            this.TampilkanAdmin.Location = new System.Drawing.Point(4, 22);
            this.TampilkanAdmin.Name = "TampilkanAdmin";
            this.TampilkanAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.TampilkanAdmin.Size = new System.Drawing.Size(549, 340);
            this.TampilkanAdmin.TabIndex = 0;
            this.TampilkanAdmin.Text = "Tampilkan Admin";
            this.TampilkanAdmin.UseVisualStyleBackColor = true;
            // 
            // btnTampilkanAdmin
            // 
            this.btnTampilkanAdmin.Location = new System.Drawing.Point(6, 8);
            this.btnTampilkanAdmin.Name = "btnTampilkanAdmin";
            this.btnTampilkanAdmin.Size = new System.Drawing.Size(101, 28);
            this.btnTampilkanAdmin.TabIndex = 71;
            this.btnTampilkanAdmin.Text = "Tampilkan Admin";
            this.btnTampilkanAdmin.UseVisualStyleBackColor = true;
            this.btnTampilkanAdmin.Click += new System.EventHandler(this.btnTampilkanAdmin_Click);
            // 
            // lvwAdmin
            // 
            this.lvwAdmin.HideSelection = false;
            this.lvwAdmin.Location = new System.Drawing.Point(3, 47);
            this.lvwAdmin.Name = "lvwAdmin";
            this.lvwAdmin.Size = new System.Drawing.Size(543, 271);
            this.lvwAdmin.TabIndex = 0;
            this.lvwAdmin.UseCompatibleStateImageBehavior = false;
            // 
            // TambahAdmin
            // 
            this.TambahAdmin.Controls.Add(this.btnInputAdmin);
            this.TambahAdmin.Controls.Add(this.txtIdOfficeInput);
            this.TambahAdmin.Controls.Add(this.txtPassAdminInput);
            this.TambahAdmin.Controls.Add(this.txtIdAdminInput);
            this.TambahAdmin.Controls.Add(this.label2);
            this.TambahAdmin.Controls.Add(this.label3);
            this.TambahAdmin.Controls.Add(this.label4);
            this.TambahAdmin.Location = new System.Drawing.Point(4, 22);
            this.TambahAdmin.Name = "TambahAdmin";
            this.TambahAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.TambahAdmin.Size = new System.Drawing.Size(549, 340);
            this.TambahAdmin.TabIndex = 1;
            this.TambahAdmin.Text = "Tambah Admin";
            this.TambahAdmin.UseVisualStyleBackColor = true;
            // 
            // btnInputAdmin
            // 
            this.btnInputAdmin.Location = new System.Drawing.Point(137, 105);
            this.btnInputAdmin.Name = "btnInputAdmin";
            this.btnInputAdmin.Size = new System.Drawing.Size(101, 28);
            this.btnInputAdmin.TabIndex = 71;
            this.btnInputAdmin.Text = "Tambahkan";
            this.btnInputAdmin.UseVisualStyleBackColor = true;
            this.btnInputAdmin.Click += new System.EventHandler(this.btnInputAdmin_Click);
            // 
            // txtIdOfficeInput
            // 
            this.txtIdOfficeInput.Location = new System.Drawing.Point(103, 67);
            this.txtIdOfficeInput.Name = "txtIdOfficeInput";
            this.txtIdOfficeInput.Size = new System.Drawing.Size(135, 20);
            this.txtIdOfficeInput.TabIndex = 63;
            // 
            // txtPassAdminInput
            // 
            this.txtPassAdminInput.Location = new System.Drawing.Point(103, 39);
            this.txtPassAdminInput.Name = "txtPassAdminInput";
            this.txtPassAdminInput.Size = new System.Drawing.Size(135, 20);
            this.txtPassAdminInput.TabIndex = 62;
            // 
            // txtIdAdminInput
            // 
            this.txtIdAdminInput.Location = new System.Drawing.Point(103, 13);
            this.txtIdAdminInput.Name = "txtIdAdminInput";
            this.txtIdAdminInput.Size = new System.Drawing.Size(135, 20);
            this.txtIdAdminInput.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Id Office";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Password Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Id Admin";
            // 
            // HapusAdmin
            // 
            this.HapusAdmin.Controls.Add(this.btnCariHapusAdmin);
            this.HapusAdmin.Controls.Add(this.btnDelAdmin);
            this.HapusAdmin.Controls.Add(this.txtIdOfficeDel);
            this.HapusAdmin.Controls.Add(this.txtPassAdminDel);
            this.HapusAdmin.Controls.Add(this.txtIdAdminDel);
            this.HapusAdmin.Controls.Add(this.label5);
            this.HapusAdmin.Controls.Add(this.label6);
            this.HapusAdmin.Controls.Add(this.label7);
            this.HapusAdmin.Location = new System.Drawing.Point(4, 22);
            this.HapusAdmin.Name = "HapusAdmin";
            this.HapusAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.HapusAdmin.Size = new System.Drawing.Size(549, 340);
            this.HapusAdmin.TabIndex = 2;
            this.HapusAdmin.Text = "Hapus Admin";
            this.HapusAdmin.UseVisualStyleBackColor = true;
            // 
            // btnCariHapusAdmin
            // 
            this.btnCariHapusAdmin.Location = new System.Drawing.Point(261, 8);
            this.btnCariHapusAdmin.Name = "btnCariHapusAdmin";
            this.btnCariHapusAdmin.Size = new System.Drawing.Size(101, 28);
            this.btnCariHapusAdmin.TabIndex = 71;
            this.btnCariHapusAdmin.Text = "Cari";
            this.btnCariHapusAdmin.UseVisualStyleBackColor = true;
            this.btnCariHapusAdmin.Click += new System.EventHandler(this.btnCariHapusAdmin_Click);
            // 
            // btnDelAdmin
            // 
            this.btnDelAdmin.Location = new System.Drawing.Point(139, 105);
            this.btnDelAdmin.Name = "btnDelAdmin";
            this.btnDelAdmin.Size = new System.Drawing.Size(101, 28);
            this.btnDelAdmin.TabIndex = 70;
            this.btnDelAdmin.Text = "Hapus";
            this.btnDelAdmin.UseVisualStyleBackColor = true;
            this.btnDelAdmin.Click += new System.EventHandler(this.btnDelAdmin_Click);
            // 
            // txtIdOfficeDel
            // 
            this.txtIdOfficeDel.Enabled = false;
            this.txtIdOfficeDel.Location = new System.Drawing.Point(105, 67);
            this.txtIdOfficeDel.Name = "txtIdOfficeDel";
            this.txtIdOfficeDel.Size = new System.Drawing.Size(135, 20);
            this.txtIdOfficeDel.TabIndex = 69;
            // 
            // txtPassAdminDel
            // 
            this.txtPassAdminDel.Enabled = false;
            this.txtPassAdminDel.Location = new System.Drawing.Point(105, 39);
            this.txtPassAdminDel.Name = "txtPassAdminDel";
            this.txtPassAdminDel.Size = new System.Drawing.Size(135, 20);
            this.txtPassAdminDel.TabIndex = 68;
            // 
            // txtIdAdminDel
            // 
            this.txtIdAdminDel.Location = new System.Drawing.Point(105, 13);
            this.txtIdAdminDel.Name = "txtIdAdminDel";
            this.txtIdAdminDel.Size = new System.Drawing.Size(135, 20);
            this.txtIdAdminDel.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "Id Office";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Password Admin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Id Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kontrol Admin";
            // 
            // btnAdminMenu
            // 
            this.btnAdminMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btnAdminMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminMenu.ForeColor = System.Drawing.Color.White;
            this.btnAdminMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdminMenu.Location = new System.Drawing.Point(611, 101);
            this.btnAdminMenu.Name = "btnAdminMenu";
            this.btnAdminMenu.Size = new System.Drawing.Size(90, 40);
            this.btnAdminMenu.TabIndex = 8;
            this.btnAdminMenu.Text = "Menu";
            this.btnAdminMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminMenu.UseCompatibleTextRendering = true;
            this.btnAdminMenu.UseVisualStyleBackColor = false;
            this.btnAdminMenu.Click += new System.EventHandler(this.btnAdminMenu_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnAdminMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdminCust);
            this.Controls.Add(this.btnAdminBar);
            this.Controls.Add(this.btnAdminSupp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.Text = "Form Admin";
            this.tabControl1.ResumeLayout(false);
            this.TampilkanAdmin.ResumeLayout(false);
            this.TambahAdmin.ResumeLayout(false);
            this.TambahAdmin.PerformLayout();
            this.HapusAdmin.ResumeLayout(false);
            this.HapusAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminCust;
        private System.Windows.Forms.Button btnAdminBar;
        private System.Windows.Forms.Button btnAdminSupp;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TampilkanAdmin;
        private System.Windows.Forms.TabPage TambahAdmin;
        private System.Windows.Forms.TabPage HapusAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTampilkanAdmin;
        private System.Windows.Forms.ListView lvwAdmin;
        private System.Windows.Forms.Button btnInputAdmin;
        private System.Windows.Forms.TextBox txtIdOfficeInput;
        private System.Windows.Forms.TextBox txtPassAdminInput;
        private System.Windows.Forms.TextBox txtIdAdminInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelAdmin;
        private System.Windows.Forms.TextBox txtIdOfficeDel;
        private System.Windows.Forms.TextBox txtPassAdminDel;
        private System.Windows.Forms.TextBox txtIdAdminDel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCariHapusAdmin;
        private System.Windows.Forms.Button btnAdminMenu;
    }
}