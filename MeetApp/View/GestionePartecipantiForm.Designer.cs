using System.Windows.Forms;

namespace MeetApp.View
{
    partial class GestionePartecipantiForm
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
            this.buttonEscludi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAssenza = new System.Windows.Forms.Button();
            this.listBoxPartecipanti = new System.Windows.Forms.ListBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxEsclusi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxAssenti = new System.Windows.Forms.ListBox();
            this.labelIncontro = new System.Windows.Forms.Label();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.buttonRimuovi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEscludi
            // 
            this.buttonEscludi.Location = new System.Drawing.Point(897, 373);
            this.buttonEscludi.Name = "buttonEscludi";
            this.buttonEscludi.Size = new System.Drawing.Size(250, 91);
            this.buttonEscludi.TabIndex = 1;
            this.buttonEscludi.Text = "Escludi partecipanti in base alla selezione preliminare";
            this.buttonEscludi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Partecipanti:";
            // 
            // buttonAssenza
            // 
            this.buttonAssenza.Location = new System.Drawing.Point(897, 491);
            this.buttonAssenza.Name = "buttonAssenza";
            this.buttonAssenza.Size = new System.Drawing.Size(250, 75);
            this.buttonAssenza.TabIndex = 4;
            this.buttonAssenza.Text = "Registra assenze";
            this.buttonAssenza.UseVisualStyleBackColor = true;
            // 
            // listBoxPartecipanti
            // 
            this.listBoxPartecipanti.FormattingEnabled = true;
            this.listBoxPartecipanti.ItemHeight = 25;
            this.listBoxPartecipanti.Location = new System.Drawing.Point(17, 180);
            this.listBoxPartecipanti.Name = "listBoxPartecipanti";
            this.listBoxPartecipanti.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPartecipanti.Size = new System.Drawing.Size(372, 479);
            this.listBoxPartecipanti.TabIndex = 5;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(897, 584);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(250, 75);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Torna indietro";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // listBoxEsclusi
            // 
            this.listBoxEsclusi.Enabled = false;
            this.listBoxEsclusi.FormattingEnabled = true;
            this.listBoxEsclusi.ItemHeight = 25;
            this.listBoxEsclusi.Location = new System.Drawing.Point(421, 180);
            this.listBoxEsclusi.Name = "listBoxEsclusi";
            this.listBoxEsclusi.Size = new System.Drawing.Size(452, 204);
            this.listBoxEsclusi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Partecipanti esclusi(con data di esclusione):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Partecipanti assenti:";
            // 
            // listBoxAssenti
            // 
            this.listBoxAssenti.Enabled = false;
            this.listBoxAssenti.FormattingEnabled = true;
            this.listBoxAssenti.ItemHeight = 25;
            this.listBoxAssenti.Location = new System.Drawing.Point(421, 455);
            this.listBoxAssenti.Name = "listBoxAssenti";
            this.listBoxAssenti.Size = new System.Drawing.Size(452, 204);
            this.listBoxAssenti.TabIndex = 9;
            // 
            // labelIncontro
            // 
            this.labelIncontro.AutoSize = true;
            this.labelIncontro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.93194F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncontro.ForeColor = System.Drawing.Color.SlateBlue;
            this.labelIncontro.Location = new System.Drawing.Point(12, 9);
            this.labelIncontro.Name = "labelIncontro";
            this.labelIncontro.Size = new System.Drawing.Size(585, 36);
            this.labelIncontro.TabIndex = 11;
            this.labelIncontro.Text = "Talk aziendale, 30/09/2017, 17:00, Atrio";
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(897, 180);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(250, 75);
            this.buttonAggiungi.TabIndex = 12;
            this.buttonAggiungi.Text = "Aggiungi altri partecipanti";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            // 
            // buttonRimuovi
            // 
            this.buttonRimuovi.Location = new System.Drawing.Point(897, 275);
            this.buttonRimuovi.Name = "buttonRimuovi";
            this.buttonRimuovi.Size = new System.Drawing.Size(250, 75);
            this.buttonRimuovi.TabIndex = 13;
            this.buttonRimuovi.Text = "Rimuovi i partecipanti selezionati";
            this.buttonRimuovi.UseVisualStyleBackColor = true;
            // 
            // GestionePartecipantiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 781);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRimuovi);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.labelIncontro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxAssenti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEsclusi);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listBoxPartecipanti);
            this.Controls.Add(this.buttonAssenza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonEscludi);
            this.Name = "GestionePartecipantiForm";
            this.Text = "GestionePartecipantiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEscludi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAssenza;
        private System.Windows.Forms.ListBox listBoxPartecipanti;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxEsclusi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxAssenti;
        private System.Windows.Forms.Label labelIncontro;
        private Button buttonAggiungi;
        private Button buttonRimuovi;

        public Button ButtonEscludi { get => buttonEscludi; set => buttonEscludi = value; }
        public Button ButtonAssenza { get => buttonAssenza; set => buttonAssenza = value; }
        public ListBox ListBoxPartecipanti { get => listBoxPartecipanti; set => listBoxPartecipanti = value; }
        public Button ButtonBack { get => buttonBack; set => buttonBack = value; }
        public ListBox ListBoxEsclusi { get => listBoxEsclusi; set => listBoxEsclusi = value; }
        public ListBox ListBoxAssenti { get => listBoxAssenti; set => listBoxAssenti = value; }
        public Label LabelIncontro { get => labelIncontro; set => labelIncontro = value; }
        public Button ButtonAggiungi { get => buttonAggiungi; set => buttonAggiungi = value; }
        public Button ButtonRimuovi { get => buttonRimuovi; set => buttonRimuovi = value; }
    }
}