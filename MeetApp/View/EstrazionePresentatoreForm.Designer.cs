using System.Windows.Forms;

namespace MeetApp.View
{
    partial class EstrazionePresentatoreForm
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonEstrazione = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPresentatore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleziona un incontro:";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(43, 107);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(694, 404);
            this.listBox.TabIndex = 7;
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(43, 554);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(222, 78);
            this.buttonAnnulla.TabIndex = 6;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            // 
            // buttonEstrazione
            // 
            this.buttonEstrazione.Location = new System.Drawing.Point(492, 554);
            this.buttonEstrazione.Name = "buttonEstrazione";
            this.buttonEstrazione.Size = new System.Drawing.Size(245, 78);
            this.buttonEstrazione.TabIndex = 5;
            this.buttonEstrazione.Text = "Estrai presentatore random";
            this.buttonEstrazione.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.17801F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(810, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Presentatore Estratto:";
            // 
            // labelPresentatore
            // 
            this.labelPresentatore.AutoSize = true;
            this.labelPresentatore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.06283F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresentatore.Location = new System.Drawing.Point(816, 238);
            this.labelPresentatore.Name = "labelPresentatore";
            this.labelPresentatore.Size = new System.Drawing.Size(297, 38);
            this.labelPresentatore.TabIndex = 10;
            this.labelPresentatore.Text = "............................";
            // 
            // EstrazionePresentatoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 781);
            this.ControlBox = false;
            this.Controls.Add(this.labelPresentatore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonAnnulla);
            this.Controls.Add(this.buttonEstrazione);
            this.Name = "EstrazionePresentatoreForm";
            this.Text = "EstrazionePresentatoreForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Button buttonEstrazione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPresentatore;

        public ListBox ListBox { get => listBox; set => listBox = value; }
        public Button ButtonAnnulla { get => buttonAnnulla; set => buttonAnnulla = value; }
        public Button ButtonEstrazione { get => buttonEstrazione; set => buttonEstrazione = value; }
        public Label LabelPresentatore { get => labelPresentatore; set => labelPresentatore = value; }
    }
}