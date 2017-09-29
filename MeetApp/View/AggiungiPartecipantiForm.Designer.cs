using System.Windows.Forms;

namespace MeetApp.View
{
    partial class AggiungiPartecipantiForm
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
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(187, 94);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(625, 498);
            this.checkedListBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(541, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Seleziona dalla lista i partecipanti che vuoi aggiungere:";
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(535, 620);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(125, 51);
            this.buttonAnnulla.TabIndex = 14;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Location = new System.Drawing.Point(687, 620);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(125, 51);
            this.buttonAggiungi.TabIndex = 13;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            // 
            // AggiungiPartecipantiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 831);
            this.ControlBox = false;
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAnnulla);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "AggiungiPartecipantiForm";
            this.Text = "AggiungiPartecipantiForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Button buttonAggiungi;

        public CheckedListBox CheckedListBox { get => checkedListBox; set => checkedListBox = value; }
        public Button ButtonAnnulla { get => buttonAnnulla; set => buttonAnnulla = value; }
        public Button ButtonAggiungi { get => buttonAggiungi; set => buttonAggiungi = value; }
    }
}