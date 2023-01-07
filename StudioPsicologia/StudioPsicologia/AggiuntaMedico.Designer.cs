
namespace StudioPsicologia
{
    partial class AggiuntaMedico
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
            this.tbCognomeMedico = new System.Windows.Forms.TextBox();
            this.tbNomeMedico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSpecializzazioneMedico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAggiungiMedico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudInizioOrario = new System.Windows.Forms.NumericUpDown();
            this.nudFineOrario = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudInizioOrario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineOrario)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCognomeMedico
            // 
            this.tbCognomeMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbCognomeMedico.Location = new System.Drawing.Point(127, 60);
            this.tbCognomeMedico.Name = "tbCognomeMedico";
            this.tbCognomeMedico.Size = new System.Drawing.Size(175, 22);
            this.tbCognomeMedico.TabIndex = 8;
            this.tbCognomeMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCognomeMedico_KeyPress);
            // 
            // tbNomeMedico
            // 
            this.tbNomeMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbNomeMedico.Location = new System.Drawing.Point(127, 25);
            this.tbNomeMedico.Name = "tbNomeMedico";
            this.tbNomeMedico.Size = new System.Drawing.Size(175, 22);
            this.tbNomeMedico.TabIndex = 7;
            this.tbNomeMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNomeMedico_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cognome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // tbSpecializzazioneMedico
            // 
            this.tbSpecializzazioneMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbSpecializzazioneMedico.Location = new System.Drawing.Point(127, 95);
            this.tbSpecializzazioneMedico.Name = "tbSpecializzazioneMedico";
            this.tbSpecializzazioneMedico.Size = new System.Drawing.Size(175, 22);
            this.tbSpecializzazioneMedico.TabIndex = 10;
            this.tbSpecializzazioneMedico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSpecializzazioneMedico_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(23, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Specializzazione";
            // 
            // btnAggiungiMedico
            // 
            this.btnAggiungiMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiMedico.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiMedico.Location = new System.Drawing.Point(173, 162);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(129, 55);
            this.btnAggiungiMedico.TabIndex = 11;
            this.btnAggiungiMedico.Text = "Aggiungi medico";
            this.btnAggiungiMedico.UseVisualStyleBackColor = false;
            this.btnAggiungiMedico.Click += new System.EventHandler(this.btnAggiungiMedico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(23, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Orario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(23, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Inizio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(23, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Fine";
            // 
            // nudInizioOrario
            // 
            this.nudInizioOrario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudInizioOrario.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nudInizioOrario.Location = new System.Drawing.Point(69, 164);
            this.nudInizioOrario.Name = "nudInizioOrario";
            this.nudInizioOrario.Size = new System.Drawing.Size(74, 22);
            this.nudInizioOrario.TabIndex = 15;
            // 
            // nudFineOrario
            // 
            this.nudFineOrario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudFineOrario.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.nudFineOrario.Location = new System.Drawing.Point(69, 197);
            this.nudFineOrario.Name = "nudFineOrario";
            this.nudFineOrario.Size = new System.Drawing.Size(74, 22);
            this.nudFineOrario.TabIndex = 16;
            // 
            // AggiuntaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(333, 246);
            this.Controls.Add(this.nudInizioOrario);
            this.Controls.Add(this.nudFineOrario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAggiungiMedico);
            this.Controls.Add(this.tbSpecializzazioneMedico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCognomeMedico);
            this.Controls.Add(this.tbNomeMedico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AggiuntaMedico";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aggiunta medico";
            this.Load += new System.EventHandler(this.AggiuntaMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudInizioOrario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFineOrario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCognomeMedico;
        private System.Windows.Forms.TextBox tbNomeMedico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSpecializzazioneMedico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAggiungiMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudInizioOrario;
        private System.Windows.Forms.NumericUpDown nudFineOrario;
    }
}