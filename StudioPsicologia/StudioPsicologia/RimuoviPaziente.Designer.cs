
namespace StudioPsicologia
{
    partial class RimuoviPaziente
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
            this.btnRimuoviPaziente = new System.Windows.Forms.Button();
            this.tbCodicePaziente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRimuoviPaziente
            // 
            this.btnRimuoviPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviPaziente.FlatAppearance.BorderSize = 0;
            this.btnRimuoviPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviPaziente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviPaziente.Location = new System.Drawing.Point(23, 97);
            this.btnRimuoviPaziente.Name = "btnRimuoviPaziente";
            this.btnRimuoviPaziente.Size = new System.Drawing.Size(237, 50);
            this.btnRimuoviPaziente.TabIndex = 11;
            this.btnRimuoviPaziente.Text = "Rimuovi paziente";
            this.btnRimuoviPaziente.UseVisualStyleBackColor = false;
            this.btnRimuoviPaziente.Click += new System.EventHandler(this.btnRimuoviPaziente_Click);
            // 
            // tbCodicePaziente
            // 
            this.tbCodicePaziente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbCodicePaziente.Location = new System.Drawing.Point(24, 50);
            this.tbCodicePaziente.Name = "tbCodicePaziente";
            this.tbCodicePaziente.Size = new System.Drawing.Size(236, 22);
            this.tbCodicePaziente.TabIndex = 11;
            this.tbCodicePaziente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCodicePaziente_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codice paziente";
            // 
            // RimuoviPaziente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(286, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodicePaziente);
            this.Controls.Add(this.btnRimuoviPaziente);
            this.Name = "RimuoviPaziente";
            this.Text = "RimuoviPaziente";
            this.Load += new System.EventHandler(this.RimuoviPaziente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRimuoviPaziente;
        private System.Windows.Forms.TextBox tbCodicePaziente;
        private System.Windows.Forms.Label label1;
    }
}