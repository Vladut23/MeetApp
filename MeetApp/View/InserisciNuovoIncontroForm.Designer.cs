using System.Windows.Forms;

namespace MeetApp.View
{
    partial class InserisciNuovoIncontroForm
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
            this.textBoxDescrizione = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLuogo = new System.Windows.Forms.TextBox();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // textBoxDescrizione
            // 
            this.textBoxDescrizione.Location = new System.Drawing.Point(462, 26);
            this.textBoxDescrizione.Name = "textBoxDescrizione";
            this.textBoxDescrizione.Size = new System.Drawing.Size(418, 31);
            this.textBoxDescrizione.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrizione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(462, 96);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(418, 31);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ora (hh:mm)";
            // 
            // textBoxOra
            // 
            this.textBoxOra.Location = new System.Drawing.Point(462, 165);
            this.textBoxOra.Name = "textBoxOra";
            this.textBoxOra.Size = new System.Drawing.Size(140, 31);
            this.textBoxOra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Luogo";
            // 
            // textBoxLuogo
            // 
            this.textBoxLuogo.Location = new System.Drawing.Point(462, 228);
            this.textBoxLuogo.Name = "textBoxLuogo";
            this.textBoxLuogo.Size = new System.Drawing.Size(418, 31);
            this.textBoxLuogo.TabIndex = 7;
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(755, 708);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(125, 51);
            this.buttonInserisci.TabIndex = 8;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(603, 708);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(125, 51);
            this.buttonAnnulla.TabIndex = 9;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 26);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleziona dalla lista i partecipanti all\'incontro:";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(255, 354);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(625, 316);
            this.checkedListBox.TabIndex = 12;
            // 
            // InserisciNuovoIncontroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 831);
            this.ControlBox = false;
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAnnulla);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.textBoxLuogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescrizione);
            this.Name = "InserisciNuovoIncontroForm";
            this.Text = "InserisciNuovoIncontroForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescrizione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLuogo;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox;

        public TextBox TextBoxDescrizione { get => textBoxDescrizione; set => textBoxDescrizione = value; }
        public DateTimePicker DateTimePicker { get => dateTimePicker; set => dateTimePicker = value; }
        public TextBox TextBoxOra { get => textBoxOra; set => textBoxOra = value; }
        public TextBox TextBoxLuogo { get => textBoxLuogo; set => textBoxLuogo = value; }
        public Button ButtonInserisci { get => buttonInserisci; set => buttonInserisci = value; }
        public Button ButtonAnnulla { get => buttonAnnulla; set => buttonAnnulla = value; }
        public CheckedListBox CheckedListBox { get => checkedListBox; set => checkedListBox = value; }
    }
}