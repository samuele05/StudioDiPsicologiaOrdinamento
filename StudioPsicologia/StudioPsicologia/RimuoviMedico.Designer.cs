
namespace StudioPsicologia
{
    partial class RimuoviMedico
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRimuoviMedico = new System.Windows.Forms.Button();
            this.cbMedici = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codice medico";
            // 
            // btnRimuoviMedico
            // 
            this.btnRimuoviMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviMedico.FlatAppearance.BorderSize = 0;
            this.btnRimuoviMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviMedico.Location = new System.Drawing.Point(22, 95);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(237, 50);
            this.btnRimuoviMedico.TabIndex = 10;
            this.btnRimuoviMedico.Text = "Rimuovi medico";
            this.btnRimuoviMedico.UseVisualStyleBackColor = false;
            this.btnRimuoviMedico.Click += new System.EventHandler(this.btnRimuoviMedico_Click);
            // 
            // cbMedici
            // 
            this.cbMedici.BackColor = System.Drawing.SystemColors.Window;
            this.cbMedici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedici.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbMedici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbMedici.FormattingEnabled = true;
            this.cbMedici.Location = new System.Drawing.Point(22, 50);
            this.cbMedici.Name = "cbMedici";
            this.cbMedici.Size = new System.Drawing.Size(237, 21);
            this.cbMedici.TabIndex = 14;
            // 
            // RimuoviMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(286, 172);
            this.Controls.Add(this.cbMedici);
            this.Controls.Add(this.btnRimuoviMedico);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RimuoviMedico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RimuoviMedico";
            this.Load += new System.EventHandler(this.RimuoviMedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRimuoviMedico;
        private System.Windows.Forms.ComboBox cbMedici;
    }
}