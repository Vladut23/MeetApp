using System.Windows.Forms;

namespace MeetApp.View
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.inserisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciNuovoIncontroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaListaIncontriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estrazionePresentatoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1174, 47);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // inserisciToolStripMenuItem
            // 
            this.inserisciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserisciNuovoIncontroToolStripMenuItem,
            this.visualizzaListaIncontriToolStripMenuItem,
            this.estrazionePresentatoreToolStripMenuItem});
            this.inserisciToolStripMenuItem.Name = "inserisciToolStripMenuItem";
            this.inserisciToolStripMenuItem.Size = new System.Drawing.Size(112, 39);
            this.inserisciToolStripMenuItem.Text = "Incontri";
            // 
            // inserisciNuovoIncontroToolStripMenuItem
            // 
            this.inserisciNuovoIncontroToolStripMenuItem.Name = "inserisciNuovoIncontroToolStripMenuItem";
            this.inserisciNuovoIncontroToolStripMenuItem.Size = new System.Drawing.Size(380, 40);
            this.inserisciNuovoIncontroToolStripMenuItem.Text = "Inserisci nuovo incontro";
            // 
            // visualizzaListaIncontriToolStripMenuItem
            // 
            this.visualizzaListaIncontriToolStripMenuItem.Name = "visualizzaListaIncontriToolStripMenuItem";
            this.visualizzaListaIncontriToolStripMenuItem.Size = new System.Drawing.Size(380, 40);
            this.visualizzaListaIncontriToolStripMenuItem.Text = "Visualizza lista incontri";
            // 
            // estrazionePresentatoreToolStripMenuItem
            // 
            this.estrazionePresentatoreToolStripMenuItem.Name = "estrazionePresentatoreToolStripMenuItem";
            this.estrazionePresentatoreToolStripMenuItem.Size = new System.Drawing.Size(380, 40);
            this.estrazionePresentatoreToolStripMenuItem.Text = "Estrazione presentatore";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 931);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem inserisciToolStripMenuItem;
        private ToolStripMenuItem inserisciNuovoIncontroToolStripMenuItem;
        private ToolStripMenuItem visualizzaListaIncontriToolStripMenuItem;
        private ToolStripMenuItem estrazionePresentatoreToolStripMenuItem;

        public MenuStrip MenuStrip { get => menuStrip; set => menuStrip = value; }
        public ToolStripMenuItem VisualizzaListaIncontriToolStripMenuItem { get => visualizzaListaIncontriToolStripMenuItem; set => visualizzaListaIncontriToolStripMenuItem = value; }
    }
}



