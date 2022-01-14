
namespace LogisticApp2.View
{
    partial class FormKantor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKantor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBarMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTampilkanKantor = new System.Windows.Forms.Button();
            this.lvwOffice = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBarMenu);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 451);
            this.panel1.TabIndex = 0;
            // 
            // btnBarMenu
            // 
            this.btnBarMenu.BackColor = System.Drawing.Color.SlateGray;
            this.btnBarMenu.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarMenu.ForeColor = System.Drawing.Color.White;
            this.btnBarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBarMenu.Location = new System.Drawing.Point(34, 11);
            this.btnBarMenu.Name = "btnBarMenu";
            this.btnBarMenu.Size = new System.Drawing.Size(90, 40);
            this.btnBarMenu.TabIndex = 6;
            this.btnBarMenu.Text = "Menu";
            this.btnBarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBarMenu.UseCompatibleTextRendering = true;
            this.btnBarMenu.UseVisualStyleBackColor = false;
            this.btnBarMenu.Click += new System.EventHandler(this.btnBarMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ARENA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Logistics";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Berikut adalah alamat-alamat kantor.";
            // 
            // btnTampilkanKantor
            // 
            this.btnTampilkanKantor.Location = new System.Drawing.Point(184, 121);
            this.btnTampilkanKantor.Name = "btnTampilkanKantor";
            this.btnTampilkanKantor.Size = new System.Drawing.Size(112, 23);
            this.btnTampilkanKantor.TabIndex = 4;
            this.btnTampilkanKantor.Text = "Tampilkan Kantor";
            this.btnTampilkanKantor.UseVisualStyleBackColor = true;
            this.btnTampilkanKantor.Click += new System.EventHandler(this.btnTampilkanKantor_Click);
            // 
            // lvwOffice
            // 
            this.lvwOffice.HideSelection = false;
            this.lvwOffice.Location = new System.Drawing.Point(175, 154);
            this.lvwOffice.Name = "lvwOffice";
            this.lvwOffice.Size = new System.Drawing.Size(621, 298);
            this.lvwOffice.TabIndex = 5;
            this.lvwOffice.UseCompatibleStateImageBehavior = false;
            // 
            // FormKantor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvwOffice);
            this.Controls.Add(this.btnTampilkanKantor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKantor";
            this.Text = "Data Kantor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBarMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTampilkanKantor;
        private System.Windows.Forms.ListView lvwOffice;
    }
}