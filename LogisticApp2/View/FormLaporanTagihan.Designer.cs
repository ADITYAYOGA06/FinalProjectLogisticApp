
namespace LogisticApp2.View
{
    partial class FormLaporanTagihan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLapTghMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoLunas = new System.Windows.Forms.RadioButton();
            this.rdoBelumLunas = new System.Windows.Forms.RadioButton();
            this.lvwLapTgh = new System.Windows.Forms.ListView();
            this.btnTampilLapTgh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLapTghMenu);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 451);
            this.panel1.TabIndex = 2;
            // 
            // btnLapTghMenu
            // 
            this.btnLapTghMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btnLapTghMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapTghMenu.ForeColor = System.Drawing.Color.White;
            this.btnLapTghMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapTghMenu.Location = new System.Drawing.Point(34, 11);
            this.btnLapTghMenu.Name = "btnLapTghMenu";
            this.btnLapTghMenu.Size = new System.Drawing.Size(90, 40);
            this.btnLapTghMenu.TabIndex = 6;
            this.btnLapTghMenu.Text = "Menu";
            this.btnLapTghMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapTghMenu.UseCompatibleTextRendering = true;
            this.btnLapTghMenu.UseVisualStyleBackColor = false;
            this.btnLapTghMenu.Click += new System.EventHandler(this.btnLapTghMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laporan Tagihan";
            // 
            // rdoLunas
            // 
            this.rdoLunas.AutoSize = true;
            this.rdoLunas.Location = new System.Drawing.Point(198, 85);
            this.rdoLunas.Name = "rdoLunas";
            this.rdoLunas.Size = new System.Drawing.Size(96, 17);
            this.rdoLunas.TabIndex = 9;
            this.rdoLunas.TabStop = true;
            this.rdoLunas.Text = "Tagihan Lunas";
            this.rdoLunas.UseVisualStyleBackColor = true;
            // 
            // rdoBelumLunas
            // 
            this.rdoBelumLunas.AutoSize = true;
            this.rdoBelumLunas.Location = new System.Drawing.Point(198, 62);
            this.rdoBelumLunas.Name = "rdoBelumLunas";
            this.rdoBelumLunas.Size = new System.Drawing.Size(128, 17);
            this.rdoBelumLunas.TabIndex = 8;
            this.rdoBelumLunas.TabStop = true;
            this.rdoBelumLunas.Text = "Tagihan Belum Lunas";
            this.rdoBelumLunas.UseVisualStyleBackColor = true;
            // 
            // lvwLapTgh
            // 
            this.lvwLapTgh.HideSelection = false;
            this.lvwLapTgh.Location = new System.Drawing.Point(176, 139);
            this.lvwLapTgh.Name = "lvwLapTgh";
            this.lvwLapTgh.Size = new System.Drawing.Size(612, 299);
            this.lvwLapTgh.TabIndex = 10;
            this.lvwLapTgh.UseCompatibleStateImageBehavior = false;
            // 
            // btnTampilLapTgh
            // 
            this.btnTampilLapTgh.Location = new System.Drawing.Point(198, 110);
            this.btnTampilLapTgh.Name = "btnTampilLapTgh";
            this.btnTampilLapTgh.Size = new System.Drawing.Size(114, 23);
            this.btnTampilLapTgh.TabIndex = 11;
            this.btnTampilLapTgh.Text = "Tampilkan Data";
            this.btnTampilLapTgh.UseVisualStyleBackColor = true;
            this.btnTampilLapTgh.Click += new System.EventHandler(this.btnTampilLapTgh_Click);
            // 
            // FormLaporanTagihan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTampilLapTgh);
            this.Controls.Add(this.lvwLapTgh);
            this.Controls.Add(this.rdoLunas);
            this.Controls.Add(this.rdoBelumLunas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormLaporanTagihan";
            this.Text = "FormLaporanTagihan";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLapTghMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoLunas;
        private System.Windows.Forms.RadioButton rdoBelumLunas;
        private System.Windows.Forms.ListView lvwLapTgh;
        private System.Windows.Forms.Button btnTampilLapTgh;
    }
}