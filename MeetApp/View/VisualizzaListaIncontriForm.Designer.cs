using System.Windows.Forms;

namespace MeetApp.View
{
    partial class VisualizzaListaIncontriForm
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
            this.buttonGestione = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGestione
            // 
            this.buttonGestione.Location = new System.Drawing.Point(439, 674);
            this.buttonGestione.Name = "buttonGestione";
            this.buttonGestione.Size = new System.Drawing.Size(289, 85);
            this.buttonGestione.TabIndex = 1;
            this.buttonGestione.Text = "Gestisci partecipanti";
            this.buttonGestione.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(230, 140);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(694, 479);
            this.listBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleziona un incontro:";
            // 
            // VisualizzaListaIncontriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 831);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.buttonGestione);
            this.Name = "VisualizzaListaIncontriForm";
            this.Text = "VisualizzaListaIncontriForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGestione;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;

        public Button ButtonGestione { get => buttonGestione; set => buttonGestione = value; }
        public ListBox ListBox { get => listBox; set => listBox = value; }
    }
}