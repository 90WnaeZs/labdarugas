
namespace Labdarugas
{
    partial class CS_Hozzaadas
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
            this.tbx_csapatnev = new System.Windows.Forms.TextBox();
            this.tbx_osztaly = new System.Windows.Forms.TextBox();
            this.gbx_csapat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_csapat_hozzaad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_veznev = new System.Windows.Forms.TextBox();
            this.tbx_kernev = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_csapat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_tag_hozzaadas = new System.Windows.Forms.Button();
            this.gbx_csapat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_csapatnev
            // 
            this.tbx_csapatnev.Location = new System.Drawing.Point(134, 59);
            this.tbx_csapatnev.Name = "tbx_csapatnev";
            this.tbx_csapatnev.Size = new System.Drawing.Size(180, 20);
            this.tbx_csapatnev.TabIndex = 0;
            // 
            // tbx_osztaly
            // 
            this.tbx_osztaly.Location = new System.Drawing.Point(134, 113);
            this.tbx_osztaly.Name = "tbx_osztaly";
            this.tbx_osztaly.Size = new System.Drawing.Size(180, 20);
            this.tbx_osztaly.TabIndex = 1;
            // 
            // gbx_csapat
            // 
            this.gbx_csapat.Controls.Add(this.label2);
            this.gbx_csapat.Controls.Add(this.btn_csapat_hozzaad);
            this.gbx_csapat.Controls.Add(this.label1);
            this.gbx_csapat.Controls.Add(this.tbx_csapatnev);
            this.gbx_csapat.Controls.Add(this.tbx_osztaly);
            this.gbx_csapat.Location = new System.Drawing.Point(25, 23);
            this.gbx_csapat.Name = "gbx_csapat";
            this.gbx_csapat.Size = new System.Drawing.Size(386, 321);
            this.gbx_csapat.TabIndex = 2;
            this.gbx_csapat.TabStop = false;
            this.gbx_csapat.Text = "Csapat hozzáadása";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Osztály";
            // 
            // btn_csapat_hozzaad
            // 
            this.btn_csapat_hozzaad.Location = new System.Drawing.Point(178, 163);
            this.btn_csapat_hozzaad.Name = "btn_csapat_hozzaad";
            this.btn_csapat_hozzaad.Size = new System.Drawing.Size(136, 36);
            this.btn_csapat_hozzaad.TabIndex = 4;
            this.btn_csapat_hozzaad.Text = "Hozzáadás";
            this.btn_csapat_hozzaad.UseVisualStyleBackColor = true;
            this.btn_csapat_hozzaad.Click += new System.EventHandler(this.btn_csapat_hozzaad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_tag_hozzaadas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmb_csapat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.tbx_kernev);
            this.groupBox1.Controls.Add(this.tbx_veznev);
            this.groupBox1.Location = new System.Drawing.Point(448, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Csapattag hozzáadás";
            // 
            // tbx_veznev
            // 
            this.tbx_veznev.Location = new System.Drawing.Point(189, 51);
            this.tbx_veznev.Name = "tbx_veznev";
            this.tbx_veznev.Size = new System.Drawing.Size(200, 20);
            this.tbx_veznev.TabIndex = 0;
            // 
            // tbx_kernev
            // 
            this.tbx_kernev.Location = new System.Drawing.Point(189, 94);
            this.tbx_kernev.Name = "tbx_kernev";
            this.tbx_kernev.Size = new System.Drawing.Size(200, 20);
            this.tbx_kernev.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(189, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vezetéknév";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Keresztnév";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Születési dátum";
            // 
            // cmb_csapat
            // 
            this.cmb_csapat.FormattingEnabled = true;
            this.cmb_csapat.Location = new System.Drawing.Point(189, 178);
            this.cmb_csapat.Name = "cmb_csapat";
            this.cmb_csapat.Size = new System.Drawing.Size(200, 21);
            this.cmb_csapat.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Csapat";
            // 
            // btn_tag_hozzaadas
            // 
            this.btn_tag_hozzaadas.Location = new System.Drawing.Point(253, 223);
            this.btn_tag_hozzaadas.Name = "btn_tag_hozzaadas";
            this.btn_tag_hozzaadas.Size = new System.Drawing.Size(136, 36);
            this.btn_tag_hozzaadas.TabIndex = 5;
            this.btn_tag_hozzaadas.Text = "Hozzáadás";
            this.btn_tag_hozzaadas.UseVisualStyleBackColor = true;
            this.btn_tag_hozzaadas.Click += new System.EventHandler(this.btn_tag_hozzaadas_Click);
            // 
            // CS_Hozzaadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_csapat);
            this.Name = "CS_Hozzaadas";
            this.Text = "Csapat hozzáadása";
            this.gbx_csapat.ResumeLayout(false);
            this.gbx_csapat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_csapatnev;
        private System.Windows.Forms.TextBox tbx_osztaly;
        private System.Windows.Forms.GroupBox gbx_csapat;
        private System.Windows.Forms.Button btn_csapat_hozzaad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_csapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbx_kernev;
        private System.Windows.Forms.TextBox tbx_veznev;
        private System.Windows.Forms.Button btn_tag_hozzaadas;
    }
}