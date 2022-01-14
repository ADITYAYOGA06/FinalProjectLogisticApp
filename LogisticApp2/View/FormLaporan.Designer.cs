
namespace LogisticApp2.View
{
    partial class FormLaporan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaporan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTerkirimMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTampilkanLapBar = new System.Windows.Forms.Button();
            this.lvwLapBar = new System.Windows.Forms.ListView();
            this.rdoBarangTerkirim = new System.Windows.Forms.RadioButton();
            this.rdoBarangTersimpan = new System.Windows.Forms.RadioButton();
            this.rdoBerdasarNama = new System.Windows.Forms.RadioButton();
            this.txtTampilNamaBar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnTerkirimMenu);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 451);
            this.panel1.TabIndex = 1;
            // 
            // btnTerkirimMenu
            // 
            this.btnTerkirimMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btnTerkirimMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerkirimMenu.ForeColor = System.Drawing.Color.White;
            this.btnTerkirimMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTerkirimMenu.Location = new System.Drawing.Point(34, 11);
            this.btnTerkirimMenu.Name = "btnTerkirimMenu";
            this.btnTerkirimMenu.Size = new System.Drawing.Size(90, 40);
            this.btnTerkirimMenu.TabIndex = 6;
            this.btnTerkirimMenu.Text = "Menu";
            this.btnTerkirimMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTerkirimMenu.UseCompatibleTextRendering = true;
            this.btnTerkirimMenu.UseVisualStyleBackColor = false;
            this.btnTerkirimMenu.Click += new System.EventHandler(this.btnTerkirimMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Laporan Barang";
            // 
            // btnTampilkanLapBar
            // 
            this.btnTampilkanLapBar.Location = new System.Drawing.Point(664, 108);
            this.btnTampilkanLapBar.Name = "btnTampilkanLapBar";
            this.btnTampilkanLapBar.Size = new System.Drawing.Size(114, 23);
            this.btnTampilkanLapBar.TabIndex = 4;
            this.btnTampilkanLapBar.Text = "Tampilkan Data";
            this.btnTampilkanLapBar.UseVisualStyleBackColor = true;
            this.btnTampilkanLapBar.Click += new System.EventHandler(this.btnTampilkanBarTerkirim_Click);
            // 
            // lvwLapBar
            // 
            this.lvwLapBar.HideSelection = false;
            this.lvwLapBar.Location = new System.Drawing.Point(180, 142);
            this.lvwLapBar.Name = "lvwLapBar";
            this.lvwLapBar.Size = new System.Drawing.Size(612, 299);
            this.lvwLapBar.TabIndex = 5;
            this.lvwLapBar.UseCompatibleStateImageBehavior = false;
            // 
            // rdoBarangTerkirim
            // 
            this.rdoBarangTerkirim.AutoSize = true;
            this.rdoBarangTerkirim.Location = new System.Drawing.Point(180, 65);
            this.rdoBarangTerkirim.Name = "rdoBarangTerkirim";
            this.rdoBarangTerkirim.Size = new System.Drawing.Size(99, 17);
            this.rdoBarangTerkirim.TabIndex = 6;
            this.rdoBarangTerkirim.TabStop = true;
            this.rdoBarangTerkirim.Text = "Barang Terkirim";
            this.rdoBarangTerkirim.UseVisualStyleBackColor = true;
            // 
            // rdoBarangTersimpan
            // 
            this.rdoBarangTersimpan.AutoSize = true;
            this.rdoBarangTersimpan.Location = new System.Drawing.Point(180, 88);
            this.rdoBarangTersimpan.Name = "rdoBarangTersimpan";
            this.rdoBarangTersimpan.Size = new System.Drawing.Size(111, 17);
            this.rdoBarangTersimpan.TabIndex = 7;
            this.rdoBarangTersimpan.TabStop = true;
            this.rdoBarangTersimpan.Text = "Barang Tersimpan";
            this.rdoBarangTersimpan.UseVisualStyleBackColor = true;
            // 
            // rdoBerdasarNama
            // 
            this.rdoBerdasarNama.AutoSize = true;
            this.rdoBerdasarNama.Location = new System.Drawing.Point(180, 111);
            this.rdoBerdasarNama.Name = "rdoBerdasarNama";
            this.rdoBerdasarNama.Size = new System.Drawing.Size(153, 17);
            this.rdoBerdasarNama.TabIndex = 8;
            this.rdoBerdasarNama.TabStop = true;
            this.rdoBerdasarNama.Text = "Berdasarkan Nama Barang";
            this.rdoBerdasarNama.UseVisualStyleBackColor = true;
            // 
            // txtTampilNamaBar
            // 
            this.txtTampilNamaBar.Location = new System.Drawing.Point(339, 110);
            this.txtTampilNamaBar.Name = "txtTampilNamaBar";
            this.txtTampilNamaBar.Size = new System.Drawing.Size(258, 20);
            this.txtTampilNamaBar.TabIndex = 9;
            // 
            // FormLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTampilNamaBar);
            this.Controls.Add(this.rdoBerdasarNama);
            this.Controls.Add(this.rdoBarangTersimpan);
            this.Controls.Add(this.rdoBarangTerkirim);
            this.Controls.Add(this.lvwLapBar);
            this.Controls.Add(this.btnTampilkanLapBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLaporan";
            this.Text = "Laporan";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTerkirimMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTampilkanLapBar;
        private System.Windows.Forms.ListView lvwLapBar;
        private System.Windows.Forms.RadioButton rdoBarangTerkirim;
        private System.Windows.Forms.RadioButton rdoBarangTersimpan;
        private System.Windows.Forms.RadioButton rdoBerdasarNama;
        private System.Windows.Forms.TextBox txtTampilNamaBar;
    }
}