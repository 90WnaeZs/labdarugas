
namespace Labdarugas
{
    partial class CS_Modositas
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
            this.gbx_csapat = new System.Windows.Forms.GroupBox();
            this.cmb_osztaly = new System.Windows.Forms.ComboBox();
            this.cmb_csapatnev = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_csapat_modosit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_osszpont = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.gbx_csapat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_osszpont)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_csapat
            // 
            this.gbx_csapat.Controls.Add(this.label3);
            this.gbx_csapat.Controls.Add(this.num_osszpont);
            this.gbx_csapat.Controls.Add(this.cmb_osztaly);
            this.gbx_csapat.Controls.Add(this.cmb_csapatnev);
            this.gbx_csapat.Controls.Add(this.label2);
            this.gbx_csapat.Controls.Add(this.btn_csapat_modosit);
            this.gbx_csapat.Controls.Add(this.label1);
            this.gbx_csapat.Location = new System.Drawing.Point(24, 24);
            this.gbx_csapat.Name = "gbx_csapat";
            this.gbx_csapat.Size = new System.Drawing.Size(386, 321);
            this.gbx_csapat.TabIndex = 3;
            this.gbx_csapat.TabStop = false;
            this.gbx_csapat.Text = "Csapat módosítása";
            // 
            // cmb_osztaly
            // 
            this.cmb_osztaly.FormattingEnabled = true;
            this.cmb_osztaly.Location = new System.Drawing.Point(134, 113);
            this.cmb_osztaly.Name = "cmb_osztaly";
            this.cmb_osztaly.Size = new System.Drawing.Size(184, 21);
            this.cmb_osztaly.TabIndex = 6;
            this.cmb_osztaly.SelectedIndexChanged += new System.EventHandler(this.cmb_osztaly_SelectedIndexChanged);
            this.cmb_osztaly.TextChanged += new System.EventHandler(this.cmb_osztaly_TextChanged);
            // 
            // cmb_csapatnev
            // 
            this.cmb_csapatnev.FormattingEnabled = true;
            this.cmb_csapatnev.Location = new System.Drawing.Point(134, 59);
            this.cmb_csapatnev.Name = "cmb_csapatnev";
            this.cmb_csapatnev.Size = new System.Drawing.Size(184, 21);
            this.cmb_csapatnev.TabIndex = 5;
            this.cmb_csapatnev.SelectedIndexChanged += new System.EventHandler(this.cmb_csapatnev_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Osztály";
            // 
            // btn_csapat_modosit
            // 
            this.btn_csapat_modosit.Location = new System.Drawing.Point(182, 222);
            this.btn_csapat_modosit.Name = "btn_csapat_modosit";
            this.btn_csapat_modosit.Size = new System.Drawing.Size(136, 36);
            this.btn_csapat_modosit.TabIndex = 4;
            this.btn_csapat_modosit.Text = "Módosít";
            this.btn_csapat_modosit.UseVisualStyleBackColor = true;
            this.btn_csapat_modosit.Click += new System.EventHandler(this.btn_csapat_modosit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Csapat neve";
            // 
            // num_osszpont
            // 
            this.num_osszpont.Location = new System.Drawing.Point(134, 158);
            this.num_osszpont.Name = "num_osszpont";
            this.num_osszpont.Size = new System.Drawing.Size(184, 20);
            this.num_osszpont.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Összpontszám";
            // 
            // CS_Modositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 389);
            this.Controls.Add(this.gbx_csapat);
            this.Name = "CS_Modositas";
            this.Text = "Csapat módosítás";
            this.gbx_csapat.ResumeLayout(false);
            this.gbx_csapat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_osszpont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_csapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_csapat_modosit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_osztaly;
        private System.Windows.Forms.ComboBox cmb_csapatnev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_osszpont;
    }
}