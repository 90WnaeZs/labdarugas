
namespace Labdarugas
{
    partial class Kilistázás
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combo_csapatnev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_tagok = new System.Windows.Forms.Button();
            this.btn_meccsek = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(523, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // combo_csapatnev
            // 
            this.combo_csapatnev.FormattingEnabled = true;
            this.combo_csapatnev.Location = new System.Drawing.Point(83, 28);
            this.combo_csapatnev.Name = "combo_csapatnev";
            this.combo_csapatnev.Size = new System.Drawing.Size(159, 21);
            this.combo_csapatnev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Csapatnév";
            // 
            // btn_tagok
            // 
            this.btn_tagok.Location = new System.Drawing.Point(269, 28);
            this.btn_tagok.Name = "btn_tagok";
            this.btn_tagok.Size = new System.Drawing.Size(148, 23);
            this.btn_tagok.TabIndex = 3;
            this.btn_tagok.Text = "Tagok listázása";
            this.btn_tagok.UseVisualStyleBackColor = true;
            this.btn_tagok.Click += new System.EventHandler(this.btn_tagok_Click);
            // 
            // btn_meccsek
            // 
            this.btn_meccsek.Location = new System.Drawing.Point(269, 66);
            this.btn_meccsek.Name = "btn_meccsek";
            this.btn_meccsek.Size = new System.Drawing.Size(148, 23);
            this.btn_meccsek.TabIndex = 4;
            this.btn_meccsek.Text = "Meccsek listázása";
            this.btn_meccsek.UseVisualStyleBackColor = true;
            this.btn_meccsek.Click += new System.EventHandler(this.btn_meccsek_Click);
            // 
            // Kilistázás
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_meccsek);
            this.Controls.Add(this.btn_tagok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_csapatnev);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Kilistázás";
            this.Text = "Kilistázás";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_csapatnev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tagok;
        private System.Windows.Forms.Button btn_meccsek;
    }
}