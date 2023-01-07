
namespace StudioPsicologia
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAggiungiPaziente = new System.Windows.Forms.Button();
            this.btnAggiungiMedico = new System.Windows.Forms.Button();
            this.btnRimuoviMedico = new System.Windows.Forms.Button();
            this.btnAggiungiAppuntamento = new System.Windows.Forms.Button();
            this.cbMedici = new System.Windows.Forms.ComboBox();
            this.cbPazienti = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbArgomentoAppuntamento = new System.Windows.Forms.TextBox();
            this.plAppuntamento = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbOrarioCorrente = new System.Windows.Forms.CheckBox();
            this.cbOrariLiberi = new System.Windows.Forms.ComboBox();
            this.dtpDataAppuntamento = new System.Windows.Forms.DateTimePicker();
            this.plArgomento = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpAppuntamenti = new System.Windows.Forms.DateTimePicker();
            this.cbAppuntamenti = new System.Windows.Forms.ComboBox();
            this.btnRimuoviAppuntamento = new System.Windows.Forms.Button();
            this.plSelezionaAppuntamento = new System.Windows.Forms.Panel();
            this.btnSeleziona = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificaAppuntamento = new System.Windows.Forms.Button();
            this.plInformazioniAppuntamento = new System.Windows.Forms.Panel();
            this.tbArgomentoInfoAppuntamento = new System.Windows.Forms.TextBox();
            this.lblArgomentoAppuntamento = new System.Windows.Forms.Label();
            this.lblOrarioAppuntamento = new System.Windows.Forms.Label();
            this.lblDataAppuntamento = new System.Windows.Forms.Label();
            this.lblPazienteAppuntamento = new System.Windows.Forms.Label();
            this.lblMedicoAppuntamento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRimuoviPaziente = new System.Windows.Forms.Button();
            this.tcPagine = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plInfoMedico = new System.Windows.Forms.Panel();
            this.lblInCaricaMedico = new System.Windows.Forms.Label();
            this.lblOrarioMedico = new System.Windows.Forms.Label();
            this.lblSpecializzazioneMedico = new System.Windows.Forms.Label();
            this.lblCognomeMedico = new System.Windows.Forms.Label();
            this.lblNomeMedico = new System.Windows.Forms.Label();
            this.lblInfoMedico = new System.Windows.Forms.Label();
            this.cbListaMedici = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.plInfoPaziente = new System.Windows.Forms.Panel();
            this.lblIBANPaziente = new System.Windows.Forms.Label();
            this.lblDataDiNascitaPaziente = new System.Windows.Forms.Label();
            this.lblCognomePaziente = new System.Windows.Forms.Label();
            this.lblNomePaziente = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.cbListaPazienti = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.plAppuntamento.SuspendLayout();
            this.plArgomento.SuspendLayout();
            this.plSelezionaAppuntamento.SuspendLayout();
            this.plInformazioniAppuntamento.SuspendLayout();
            this.tcPagine.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.plInfoMedico.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.plInfoPaziente.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAggiungiPaziente
            // 
            this.btnAggiungiPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiPaziente.FlatAppearance.BorderSize = 0;
            this.btnAggiungiPaziente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiPaziente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiPaziente.Location = new System.Drawing.Point(23, 27);
            this.btnAggiungiPaziente.Name = "btnAggiungiPaziente";
            this.btnAggiungiPaziente.Size = new System.Drawing.Size(214, 50);
            this.btnAggiungiPaziente.TabIndex = 0;
            this.btnAggiungiPaziente.Text = "Aggiungi paziente";
            this.btnAggiungiPaziente.UseVisualStyleBackColor = false;
            this.btnAggiungiPaziente.Click += new System.EventHandler(this.btnAggiungiPaziente_Click);
            // 
            // btnAggiungiMedico
            // 
            this.btnAggiungiMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiMedico.FlatAppearance.BorderSize = 0;
            this.btnAggiungiMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiMedico.Location = new System.Drawing.Point(23, 27);
            this.btnAggiungiMedico.Name = "btnAggiungiMedico";
            this.btnAggiungiMedico.Size = new System.Drawing.Size(214, 50);
            this.btnAggiungiMedico.TabIndex = 1;
            this.btnAggiungiMedico.Text = "Aggiungi medico";
            this.btnAggiungiMedico.UseVisualStyleBackColor = false;
            this.btnAggiungiMedico.Click += new System.EventHandler(this.btnAggiungiMedico_Click);
            // 
            // btnRimuoviMedico
            // 
            this.btnRimuoviMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviMedico.FlatAppearance.BorderSize = 0;
            this.btnRimuoviMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviMedico.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviMedico.Location = new System.Drawing.Point(23, 97);
            this.btnRimuoviMedico.Name = "btnRimuoviMedico";
            this.btnRimuoviMedico.Size = new System.Drawing.Size(214, 50);
            this.btnRimuoviMedico.TabIndex = 2;
            this.btnRimuoviMedico.Text = "Rimuovi medico";
            this.btnRimuoviMedico.UseVisualStyleBackColor = false;
            this.btnRimuoviMedico.Click += new System.EventHandler(this.btnRimuoviMedico_Click);
            // 
            // btnAggiungiAppuntamento
            // 
            this.btnAggiungiAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnAggiungiAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnAggiungiAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggiungiAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnAggiungiAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnAggiungiAppuntamento.Location = new System.Drawing.Point(29, 273);
            this.btnAggiungiAppuntamento.Name = "btnAggiungiAppuntamento";
            this.btnAggiungiAppuntamento.Size = new System.Drawing.Size(195, 59);
            this.btnAggiungiAppuntamento.TabIndex = 3;
            this.btnAggiungiAppuntamento.Text = "Salva appuntamento";
            this.btnAggiungiAppuntamento.UseVisualStyleBackColor = false;
            this.btnAggiungiAppuntamento.Click += new System.EventHandler(this.btnAggiungiAppuntamento_Click);
            // 
            // cbMedici
            // 
            this.cbMedici.BackColor = System.Drawing.SystemColors.Window;
            this.cbMedici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMedici.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbMedici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbMedici.FormattingEnabled = true;
            this.cbMedici.Location = new System.Drawing.Point(99, 65);
            this.cbMedici.Name = "cbMedici";
            this.cbMedici.Size = new System.Drawing.Size(327, 21);
            this.cbMedici.TabIndex = 13;
            // 
            // cbPazienti
            // 
            this.cbPazienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPazienti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbPazienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbPazienti.FormattingEnabled = true;
            this.cbPazienti.Location = new System.Drawing.Point(99, 92);
            this.cbPazienti.Name = "cbPazienti";
            this.cbPazienti.Size = new System.Drawing.Size(327, 21);
            this.cbPazienti.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Medico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label2.Location = new System.Drawing.Point(26, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Paziente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label3.Location = new System.Drawing.Point(23, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appuntamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label4.Location = new System.Drawing.Point(26, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Argomento";
            // 
            // tbArgomentoAppuntamento
            // 
            this.tbArgomentoAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.tbArgomentoAppuntamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArgomentoAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbArgomentoAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.tbArgomentoAppuntamento.Location = new System.Drawing.Point(5, 17);
            this.tbArgomentoAppuntamento.Multiline = true;
            this.tbArgomentoAppuntamento.Name = "tbArgomentoAppuntamento";
            this.tbArgomentoAppuntamento.Size = new System.Drawing.Size(322, 70);
            this.tbArgomentoAppuntamento.TabIndex = 19;
            // 
            // plAppuntamento
            // 
            this.plAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plAppuntamento.Controls.Add(this.button1);
            this.plAppuntamento.Controls.Add(this.cbOrarioCorrente);
            this.plAppuntamento.Controls.Add(this.cbOrariLiberi);
            this.plAppuntamento.Controls.Add(this.dtpDataAppuntamento);
            this.plAppuntamento.Controls.Add(this.cbMedici);
            this.plAppuntamento.Controls.Add(this.plArgomento);
            this.plAppuntamento.Controls.Add(this.label5);
            this.plAppuntamento.Controls.Add(this.btnAggiungiAppuntamento);
            this.plAppuntamento.Controls.Add(this.cbPazienti);
            this.plAppuntamento.Controls.Add(this.label3);
            this.plAppuntamento.Controls.Add(this.label4);
            this.plAppuntamento.Controls.Add(this.label1);
            this.plAppuntamento.Controls.Add(this.label2);
            this.plAppuntamento.Location = new System.Drawing.Point(21, 23);
            this.plAppuntamento.Name = "plAppuntamento";
            this.plAppuntamento.Size = new System.Drawing.Size(447, 357);
            this.plAppuntamento.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.button1.Location = new System.Drawing.Point(247, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 59);
            this.button1.TabIndex = 25;
            this.button1.Text = "Salva modifiche";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbOrarioCorrente
            // 
            this.cbOrarioCorrente.AutoSize = true;
            this.cbOrarioCorrente.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbOrarioCorrente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.cbOrarioCorrente.Location = new System.Drawing.Point(176, 121);
            this.cbOrarioCorrente.Name = "cbOrarioCorrente";
            this.cbOrarioCorrente.Size = new System.Drawing.Size(71, 17);
            this.cbOrarioCorrente.TabIndex = 24;
            this.cbOrarioCorrente.Text = "Corrente";
            this.cbOrarioCorrente.UseVisualStyleBackColor = true;
            // 
            // cbOrariLiberi
            // 
            this.cbOrariLiberi.BackColor = System.Drawing.SystemColors.Window;
            this.cbOrariLiberi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrariLiberi.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbOrariLiberi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbOrariLiberi.FormattingEnabled = true;
            this.cbOrariLiberi.Location = new System.Drawing.Point(99, 119);
            this.cbOrariLiberi.Name = "cbOrariLiberi";
            this.cbOrariLiberi.Size = new System.Drawing.Size(71, 21);
            this.cbOrariLiberi.TabIndex = 23;
            // 
            // dtpDataAppuntamento
            // 
            this.dtpDataAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.dtpDataAppuntamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAppuntamento.Location = new System.Drawing.Point(283, 119);
            this.dtpDataAppuntamento.Name = "dtpDataAppuntamento";
            this.dtpDataAppuntamento.Size = new System.Drawing.Size(143, 22);
            this.dtpDataAppuntamento.TabIndex = 22;
            // 
            // plArgomento
            // 
            this.plArgomento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.plArgomento.Controls.Add(this.tbArgomentoAppuntamento);
            this.plArgomento.Location = new System.Drawing.Point(99, 147);
            this.plArgomento.Name = "plArgomento";
            this.plArgomento.Size = new System.Drawing.Size(328, 100);
            this.plArgomento.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Orario";
            // 
            // dtpAppuntamenti
            // 
            this.dtpAppuntamenti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.dtpAppuntamenti.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAppuntamenti.Location = new System.Drawing.Point(14, 49);
            this.dtpAppuntamenti.Name = "dtpAppuntamenti";
            this.dtpAppuntamenti.Size = new System.Drawing.Size(116, 22);
            this.dtpAppuntamenti.TabIndex = 23;
            // 
            // cbAppuntamenti
            // 
            this.cbAppuntamenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppuntamenti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbAppuntamenti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbAppuntamenti.FormattingEnabled = true;
            this.cbAppuntamenti.Location = new System.Drawing.Point(14, 77);
            this.cbAppuntamenti.Name = "cbAppuntamenti";
            this.cbAppuntamenti.Size = new System.Drawing.Size(413, 21);
            this.cbAppuntamenti.TabIndex = 23;
            // 
            // btnRimuoviAppuntamento
            // 
            this.btnRimuoviAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnRimuoviAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnRimuoviAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRimuoviAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnRimuoviAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRimuoviAppuntamento.Location = new System.Drawing.Point(23, 27);
            this.btnRimuoviAppuntamento.Name = "btnRimuoviAppuntamento";
            this.btnRimuoviAppuntamento.Size = new System.Drawing.Size(214, 50);
            this.btnRimuoviAppuntamento.TabIndex = 23;
            this.btnRimuoviAppuntamento.Text = "Rimuovi appuntamento";
            this.btnRimuoviAppuntamento.UseVisualStyleBackColor = false;
            this.btnRimuoviAppuntamento.Click += new System.EventHandler(this.btnRimuoviAppuntamento_Click);
            // 
            // plSelezionaAppuntamento
            // 
            this.plSelezionaAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plSelezionaAppuntamento.Controls.Add(this.btnSeleziona);
            this.plSelezionaAppuntamento.Controls.Add(this.label6);
            this.plSelezionaAppuntamento.Controls.Add(this.dtpAppuntamenti);
            this.plSelezionaAppuntamento.Controls.Add(this.cbAppuntamenti);
            this.plSelezionaAppuntamento.Location = new System.Drawing.Point(21, 393);
            this.plSelezionaAppuntamento.Name = "plSelezionaAppuntamento";
            this.plSelezionaAppuntamento.Size = new System.Drawing.Size(447, 114);
            this.plSelezionaAppuntamento.TabIndex = 24;
            // 
            // btnSeleziona
            // 
            this.btnSeleziona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnSeleziona.FlatAppearance.BorderSize = 0;
            this.btnSeleziona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleziona.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnSeleziona.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnSeleziona.Location = new System.Drawing.Point(136, 49);
            this.btnSeleziona.Name = "btnSeleziona";
            this.btnSeleziona.Size = new System.Drawing.Size(98, 22);
            this.btnSeleziona.TabIndex = 25;
            this.btnSeleziona.Text = "Seleziona";
            this.btnSeleziona.UseVisualStyleBackColor = false;
            this.btnSeleziona.Click += new System.EventHandler(this.btnSeleziona_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Seleziona appuntamento";
            // 
            // btnModificaAppuntamento
            // 
            this.btnModificaAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(93)))), ((int)(((byte)(114)))));
            this.btnModificaAppuntamento.FlatAppearance.BorderSize = 0;
            this.btnModificaAppuntamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificaAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.btnModificaAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnModificaAppuntamento.Location = new System.Drawing.Point(23, 97);
            this.btnModificaAppuntamento.Name = "btnModificaAppuntamento";
            this.btnModificaAppuntamento.Size = new System.Drawing.Size(214, 50);
            this.btnModificaAppuntamento.TabIndex = 24;
            this.btnModificaAppuntamento.Text = "Modifica appuntamento";
            this.btnModificaAppuntamento.UseVisualStyleBackColor = false;
            this.btnModificaAppuntamento.Click += new System.EventHandler(this.btnModificaAppuntamento_Click);
            // 
            // plInformazioniAppuntamento
            // 
            this.plInformazioniAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plInformazioniAppuntamento.Controls.Add(this.tbArgomentoInfoAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblArgomentoAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblOrarioAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblDataAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblPazienteAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.lblMedicoAppuntamento);
            this.plInformazioniAppuntamento.Controls.Add(this.label7);
            this.plInformazioniAppuntamento.Location = new System.Drawing.Point(23, 170);
            this.plInformazioniAppuntamento.Name = "plInformazioniAppuntamento";
            this.plInformazioniAppuntamento.Size = new System.Drawing.Size(214, 264);
            this.plInformazioniAppuntamento.TabIndex = 12;
            // 
            // tbArgomentoInfoAppuntamento
            // 
            this.tbArgomentoInfoAppuntamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.tbArgomentoInfoAppuntamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbArgomentoInfoAppuntamento.Enabled = false;
            this.tbArgomentoInfoAppuntamento.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tbArgomentoInfoAppuntamento.ForeColor = System.Drawing.Color.White;
            this.tbArgomentoInfoAppuntamento.Location = new System.Drawing.Point(21, 163);
            this.tbArgomentoInfoAppuntamento.Multiline = true;
            this.tbArgomentoInfoAppuntamento.Name = "tbArgomentoInfoAppuntamento";
            this.tbArgomentoInfoAppuntamento.Size = new System.Drawing.Size(183, 61);
            this.tbArgomentoInfoAppuntamento.TabIndex = 20;
            // 
            // lblArgomentoAppuntamento
            // 
            this.lblArgomentoAppuntamento.AutoSize = true;
            this.lblArgomentoAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblArgomentoAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblArgomentoAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblArgomentoAppuntamento.Location = new System.Drawing.Point(18, 163);
            this.lblArgomentoAppuntamento.Name = "lblArgomentoAppuntamento";
            this.lblArgomentoAppuntamento.Size = new System.Drawing.Size(0, 13);
            this.lblArgomentoAppuntamento.TabIndex = 28;
            // 
            // lblOrarioAppuntamento
            // 
            this.lblOrarioAppuntamento.AutoSize = true;
            this.lblOrarioAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblOrarioAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrarioAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblOrarioAppuntamento.Location = new System.Drawing.Point(18, 138);
            this.lblOrarioAppuntamento.Name = "lblOrarioAppuntamento";
            this.lblOrarioAppuntamento.Size = new System.Drawing.Size(114, 13);
            this.lblOrarioAppuntamento.TabIndex = 27;
            this.lblOrarioAppuntamento.Text = "lblOrarioAppuntamento";
            // 
            // lblDataAppuntamento
            // 
            this.lblDataAppuntamento.AutoSize = true;
            this.lblDataAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblDataAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDataAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblDataAppuntamento.Location = new System.Drawing.Point(18, 110);
            this.lblDataAppuntamento.Name = "lblDataAppuntamento";
            this.lblDataAppuntamento.Size = new System.Drawing.Size(109, 13);
            this.lblDataAppuntamento.TabIndex = 26;
            this.lblDataAppuntamento.Text = "lblDataAppuntamento";
            // 
            // lblPazienteAppuntamento
            // 
            this.lblPazienteAppuntamento.AutoSize = true;
            this.lblPazienteAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblPazienteAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPazienteAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblPazienteAppuntamento.Location = new System.Drawing.Point(18, 82);
            this.lblPazienteAppuntamento.Name = "lblPazienteAppuntamento";
            this.lblPazienteAppuntamento.Size = new System.Drawing.Size(127, 13);
            this.lblPazienteAppuntamento.TabIndex = 25;
            this.lblPazienteAppuntamento.Text = "lblPazienteAppuntamento";
            // 
            // lblMedicoAppuntamento
            // 
            this.lblMedicoAppuntamento.AutoSize = true;
            this.lblMedicoAppuntamento.BackColor = System.Drawing.Color.Transparent;
            this.lblMedicoAppuntamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblMedicoAppuntamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblMedicoAppuntamento.Location = new System.Drawing.Point(18, 55);
            this.lblMedicoAppuntamento.Name = "lblMedicoAppuntamento";
            this.lblMedicoAppuntamento.Size = new System.Drawing.Size(121, 13);
            this.lblMedicoAppuntamento.TabIndex = 24;
            this.lblMedicoAppuntamento.Text = "lblMedicoAppuntamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label7.Location = new System.Drawing.Point(17, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Info appuntamento";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnRimuoviPaziente.Size = new System.Drawing.Size(214, 50);
            this.btnRimuoviPaziente.TabIndex = 25;
            this.btnRimuoviPaziente.Text = "Rimuovi paziente";
            this.btnRimuoviPaziente.UseVisualStyleBackColor = false;
            this.btnRimuoviPaziente.Click += new System.EventHandler(this.btnRimuoviPaziente_Click);
            // 
            // tcPagine
            // 
            this.tcPagine.Controls.Add(this.tabPage1);
            this.tcPagine.Controls.Add(this.tabPage2);
            this.tcPagine.Controls.Add(this.tabPage3);
            this.tcPagine.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.tcPagine.Location = new System.Drawing.Point(487, 23);
            this.tcPagine.Name = "tcPagine";
            this.tcPagine.SelectedIndex = 0;
            this.tcPagine.Size = new System.Drawing.Size(269, 484);
            this.tcPagine.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage1.Controls.Add(this.plInfoMedico);
            this.tabPage1.Controls.Add(this.cbListaMedici);
            this.tabPage1.Controls.Add(this.btnAggiungiMedico);
            this.tabPage1.Controls.Add(this.btnRimuoviMedico);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(261, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medici";
            // 
            // plInfoMedico
            // 
            this.plInfoMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plInfoMedico.Controls.Add(this.lblInCaricaMedico);
            this.plInfoMedico.Controls.Add(this.lblOrarioMedico);
            this.plInfoMedico.Controls.Add(this.lblSpecializzazioneMedico);
            this.plInfoMedico.Controls.Add(this.lblCognomeMedico);
            this.plInfoMedico.Controls.Add(this.lblNomeMedico);
            this.plInfoMedico.Controls.Add(this.lblInfoMedico);
            this.plInfoMedico.Location = new System.Drawing.Point(23, 214);
            this.plInfoMedico.Name = "plInfoMedico";
            this.plInfoMedico.Size = new System.Drawing.Size(214, 219);
            this.plInfoMedico.TabIndex = 29;
            // 
            // lblInCaricaMedico
            // 
            this.lblInCaricaMedico.AutoSize = true;
            this.lblInCaricaMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblInCaricaMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblInCaricaMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblInCaricaMedico.Location = new System.Drawing.Point(18, 166);
            this.lblInCaricaMedico.Name = "lblInCaricaMedico";
            this.lblInCaricaMedico.Size = new System.Drawing.Size(91, 13);
            this.lblInCaricaMedico.TabIndex = 29;
            this.lblInCaricaMedico.Text = "lblInCaricaMedico";
            // 
            // lblOrarioMedico
            // 
            this.lblOrarioMedico.AutoSize = true;
            this.lblOrarioMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblOrarioMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblOrarioMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblOrarioMedico.Location = new System.Drawing.Point(18, 138);
            this.lblOrarioMedico.Name = "lblOrarioMedico";
            this.lblOrarioMedico.Size = new System.Drawing.Size(80, 13);
            this.lblOrarioMedico.TabIndex = 27;
            this.lblOrarioMedico.Text = "lblOrarioMedico";
            // 
            // lblSpecializzazioneMedico
            // 
            this.lblSpecializzazioneMedico.AutoSize = true;
            this.lblSpecializzazioneMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecializzazioneMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblSpecializzazioneMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblSpecializzazioneMedico.Location = new System.Drawing.Point(18, 110);
            this.lblSpecializzazioneMedico.Name = "lblSpecializzazioneMedico";
            this.lblSpecializzazioneMedico.Size = new System.Drawing.Size(130, 13);
            this.lblSpecializzazioneMedico.TabIndex = 26;
            this.lblSpecializzazioneMedico.Text = "lblSpecializzazioneMedico";
            // 
            // lblCognomeMedico
            // 
            this.lblCognomeMedico.AutoSize = true;
            this.lblCognomeMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblCognomeMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCognomeMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblCognomeMedico.Location = new System.Drawing.Point(18, 82);
            this.lblCognomeMedico.Name = "lblCognomeMedico";
            this.lblCognomeMedico.Size = new System.Drawing.Size(97, 13);
            this.lblCognomeMedico.TabIndex = 25;
            this.lblCognomeMedico.Text = "lblCognomeMedico";
            // 
            // lblNomeMedico
            // 
            this.lblNomeMedico.AutoSize = true;
            this.lblNomeMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNomeMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblNomeMedico.Location = new System.Drawing.Point(18, 55);
            this.lblNomeMedico.Name = "lblNomeMedico";
            this.lblNomeMedico.Size = new System.Drawing.Size(80, 13);
            this.lblNomeMedico.TabIndex = 24;
            this.lblNomeMedico.Text = "lblNomeMedico";
            // 
            // lblInfoMedico
            // 
            this.lblInfoMedico.AutoSize = true;
            this.lblInfoMedico.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoMedico.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lblInfoMedico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblInfoMedico.Location = new System.Drawing.Point(17, 17);
            this.lblInfoMedico.Name = "lblInfoMedico";
            this.lblInfoMedico.Size = new System.Drawing.Size(92, 21);
            this.lblInfoMedico.TabIndex = 23;
            this.lblInfoMedico.Text = "Info medico";
            // 
            // cbListaMedici
            // 
            this.cbListaMedici.BackColor = System.Drawing.SystemColors.Window;
            this.cbListaMedici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaMedici.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbListaMedici.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbListaMedici.FormattingEnabled = true;
            this.cbListaMedici.Location = new System.Drawing.Point(23, 171);
            this.cbListaMedici.Name = "cbListaMedici";
            this.cbListaMedici.Size = new System.Drawing.Size(214, 21);
            this.cbListaMedici.TabIndex = 26;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage2.Controls.Add(this.plInfoPaziente);
            this.tabPage2.Controls.Add(this.cbListaPazienti);
            this.tabPage2.Controls.Add(this.btnRimuoviPaziente);
            this.tabPage2.Controls.Add(this.btnAggiungiPaziente);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(261, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pazienti";
            // 
            // plInfoPaziente
            // 
            this.plInfoPaziente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.plInfoPaziente.Controls.Add(this.lblIBANPaziente);
            this.plInfoPaziente.Controls.Add(this.lblDataDiNascitaPaziente);
            this.plInfoPaziente.Controls.Add(this.lblCognomePaziente);
            this.plInfoPaziente.Controls.Add(this.lblNomePaziente);
            this.plInfoPaziente.Controls.Add(this.lbl);
            this.plInfoPaziente.Location = new System.Drawing.Point(23, 214);
            this.plInfoPaziente.Name = "plInfoPaziente";
            this.plInfoPaziente.Size = new System.Drawing.Size(214, 219);
            this.plInfoPaziente.TabIndex = 30;
            // 
            // lblIBANPaziente
            // 
            this.lblIBANPaziente.AutoSize = true;
            this.lblIBANPaziente.BackColor = System.Drawing.Color.Transparent;
            this.lblIBANPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIBANPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblIBANPaziente.Location = new System.Drawing.Point(18, 138);
            this.lblIBANPaziente.Name = "lblIBANPaziente";
            this.lblIBANPaziente.Size = new System.Drawing.Size(83, 13);
            this.lblIBANPaziente.TabIndex = 27;
            this.lblIBANPaziente.Text = "lblIBANPaziente";
            // 
            // lblDataDiNascitaPaziente
            // 
            this.lblDataDiNascitaPaziente.AutoSize = true;
            this.lblDataDiNascitaPaziente.BackColor = System.Drawing.Color.Transparent;
            this.lblDataDiNascitaPaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDataDiNascitaPaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblDataDiNascitaPaziente.Location = new System.Drawing.Point(18, 110);
            this.lblDataDiNascitaPaziente.Name = "lblDataDiNascitaPaziente";
            this.lblDataDiNascitaPaziente.Size = new System.Drawing.Size(127, 13);
            this.lblDataDiNascitaPaziente.TabIndex = 26;
            this.lblDataDiNascitaPaziente.Text = "lblDataDiNascitaPaziente";
            // 
            // lblCognomePaziente
            // 
            this.lblCognomePaziente.AutoSize = true;
            this.lblCognomePaziente.BackColor = System.Drawing.Color.Transparent;
            this.lblCognomePaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblCognomePaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblCognomePaziente.Location = new System.Drawing.Point(18, 82);
            this.lblCognomePaziente.Name = "lblCognomePaziente";
            this.lblCognomePaziente.Size = new System.Drawing.Size(103, 13);
            this.lblCognomePaziente.TabIndex = 25;
            this.lblCognomePaziente.Text = "lblCognomePaziente";
            // 
            // lblNomePaziente
            // 
            this.lblNomePaziente.AutoSize = true;
            this.lblNomePaziente.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePaziente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNomePaziente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lblNomePaziente.Location = new System.Drawing.Point(18, 55);
            this.lblNomePaziente.Name = "lblNomePaziente";
            this.lblNomePaziente.Size = new System.Drawing.Size(86, 13);
            this.lblNomePaziente.TabIndex = 24;
            this.lblNomePaziente.Text = "lblNomePaziente";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.lbl.Location = new System.Drawing.Point(17, 17);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(99, 21);
            this.lbl.TabIndex = 23;
            this.lbl.Text = "Info paziente";
            // 
            // cbListaPazienti
            // 
            this.cbListaPazienti.BackColor = System.Drawing.SystemColors.Window;
            this.cbListaPazienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListaPazienti.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.cbListaPazienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbListaPazienti.FormattingEnabled = true;
            this.cbListaPazienti.Location = new System.Drawing.Point(23, 171);
            this.cbListaPazienti.Name = "cbListaPazienti";
            this.cbListaPazienti.Size = new System.Drawing.Size(214, 21);
            this.cbListaPazienti.TabIndex = 27;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tabPage3.Controls.Add(this.plInformazioniAppuntamento);
            this.tabPage3.Controls.Add(this.btnModificaAppuntamento);
            this.tabPage3.Controls.Add(this.btnRimuoviAppuntamento);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(261, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Appuntamenti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(776, 527);
            this.Controls.Add(this.tcPagine);
            this.Controls.Add(this.plAppuntamento);
            this.Controls.Add(this.plSelezionaAppuntamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studio di psicologia";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plAppuntamento.ResumeLayout(false);
            this.plAppuntamento.PerformLayout();
            this.plArgomento.ResumeLayout(false);
            this.plArgomento.PerformLayout();
            this.plSelezionaAppuntamento.ResumeLayout(false);
            this.plSelezionaAppuntamento.PerformLayout();
            this.plInformazioniAppuntamento.ResumeLayout(false);
            this.plInformazioniAppuntamento.PerformLayout();
            this.tcPagine.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.plInfoMedico.ResumeLayout(false);
            this.plInfoMedico.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.plInfoPaziente.ResumeLayout(false);
            this.plInfoPaziente.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAggiungiPaziente;
        private System.Windows.Forms.Button btnAggiungiMedico;
        private System.Windows.Forms.Button btnRimuoviMedico;
        private System.Windows.Forms.Button btnAggiungiAppuntamento;
        private System.Windows.Forms.ComboBox cbMedici;
        private System.Windows.Forms.ComboBox cbPazienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbArgomentoAppuntamento;
        private System.Windows.Forms.Panel plAppuntamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel plArgomento;
        private System.Windows.Forms.DateTimePicker dtpDataAppuntamento;
        private System.Windows.Forms.DateTimePicker dtpAppuntamenti;
        private System.Windows.Forms.ComboBox cbAppuntamenti;
        private System.Windows.Forms.Button btnRimuoviAppuntamento;
        private System.Windows.Forms.Panel plSelezionaAppuntamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel plInformazioniAppuntamento;
        private System.Windows.Forms.Label lblMedicoAppuntamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblArgomentoAppuntamento;
        private System.Windows.Forms.Label lblOrarioAppuntamento;
        private System.Windows.Forms.Label lblDataAppuntamento;
        private System.Windows.Forms.Label lblPazienteAppuntamento;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRimuoviPaziente;
        private System.Windows.Forms.Button btnModificaAppuntamento;
        private System.Windows.Forms.TextBox tbArgomentoInfoAppuntamento;
        private System.Windows.Forms.ComboBox cbOrariLiberi;
        private System.Windows.Forms.Button btnSeleziona;
        private System.Windows.Forms.CheckBox cbOrarioCorrente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tcPagine;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cbListaMedici;
        private System.Windows.Forms.Panel plInfoMedico;
        private System.Windows.Forms.Label lblInCaricaMedico;
        private System.Windows.Forms.Label lblOrarioMedico;
        private System.Windows.Forms.Label lblSpecializzazioneMedico;
        private System.Windows.Forms.Label lblCognomeMedico;
        private System.Windows.Forms.Label lblNomeMedico;
        private System.Windows.Forms.Label lblInfoMedico;
        private System.Windows.Forms.Panel plInfoPaziente;
        private System.Windows.Forms.Label lblIBANPaziente;
        private System.Windows.Forms.Label lblDataDiNascitaPaziente;
        private System.Windows.Forms.Label lblCognomePaziente;
        private System.Windows.Forms.Label lblNomePaziente;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.ComboBox cbListaPazienti;
    }
}

