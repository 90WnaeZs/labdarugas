
namespace Labdarugas
{
    partial class Eredmény_rögzítés
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
            this.combo_csapat1 = new System.Windows.Forms.ComboBox();
            this.combo_csapat2 = new System.Windows.Forms.ComboBox();
            this.num_gol1 = new System.Windows.Forms.NumericUpDown();
            this.num_gol2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Rogzit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_gol1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gol2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_csapat1
            // 
            this.combo_csapat1.FormattingEnabled = true;
            this.combo_csapat1.Location = new System.Drawing.Point(100, 51);
            this.combo_csapat1.Name = "combo_csapat1";
            this.combo_csapat1.Size = new System.Drawing.Size(121, 21);
            this.combo_csapat1.TabIndex = 0;
            // 
            // combo_csapat2
            // 
            this.combo_csapat2.FormattingEnabled = true;
            this.combo_csapat2.Location = new System.Drawing.Point(100, 51);
            this.combo_csapat2.Name = "combo_csapat2";
            this.combo_csapat2.Size = new System.Drawing.Size(121, 21);
            this.combo_csapat2.TabIndex = 1;
            // 
            // num_gol1
            // 
            this.num_gol1.Location = new System.Drawing.Point(100, 94);
            this.num_gol1.Name = "num_gol1";
            this.num_gol1.Size = new System.Drawing.Size(120, 20);
            this.num_gol1.TabIndex = 2;
            // 
            // num_gol2
            // 
            this.num_gol2.Location = new System.Drawing.Point(100, 94);
            this.num_gol2.Name = "num_gol2";
            this.num_gol2.Size = new System.Drawing.Size(120, 20);
            this.num_gol2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_csapat1);
            this.groupBox1.Controls.Add(this.num_gol1);
            this.groupBox1.Location = new System.Drawing.Point(39, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 197);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Csapat 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.combo_csapat2);
            this.groupBox2.Controls.Add(this.num_gol2);
            this.groupBox2.Location = new System.Drawing.Point(293, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Csapat 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Csapatnév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Csapatnév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rúgott gól";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rúgott gól";
            // 
            // btn_Rogzit
            // 
            this.btn_Rogzit.Location = new System.Drawing.Point(580, 43);
            this.btn_Rogzit.Name = "btn_Rogzit";
            this.btn_Rogzit.Size = new System.Drawing.Size(172, 50);
            this.btn_Rogzit.TabIndex = 6;
            this.btn_Rogzit.Text = "Rögzítés";
            this.btn_Rogzit.UseVisualStyleBackColor = true;
            this.btn_Rogzit.Click += new System.EventHandler(this.btn_Rogzit_Click);
            // 
            // Eredmény_rögzítés
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Rogzit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Eredmény_rögzítés";
            this.Text = "Eredmény rögzítés";
            ((System.ComponentModel.ISupportInitialize)(this.num_gol1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_gol2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_csapat1;
        private System.Windows.Forms.ComboBox combo_csapat2;
        private System.Windows.Forms.NumericUpDown num_gol1;
        private System.Windows.Forms.NumericUpDown num_gol2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Rogzit;
    }
}