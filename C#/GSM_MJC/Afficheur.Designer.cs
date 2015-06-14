namespace GSM_MJC
{
    partial class Afficheur
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
            //base.Dispose(disposing);
            this.Hide();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afficheur));
            this.messageAfficheur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messageAfficheur
            // 
            this.messageAfficheur.BackColor = System.Drawing.Color.Transparent;
            this.messageAfficheur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageAfficheur.Font = new System.Drawing.Font("Impact", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageAfficheur.ForeColor = System.Drawing.Color.White;
            this.messageAfficheur.Location = new System.Drawing.Point(0, 0);
            this.messageAfficheur.Name = "messageAfficheur";
            this.messageAfficheur.Size = new System.Drawing.Size(939, 393);
            this.messageAfficheur.TabIndex = 0;
            this.messageAfficheur.Text = "FabLab Rutech GSM";
            this.messageAfficheur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.messageAfficheur.DoubleClick += new System.EventHandler(this.messageAfficheur_DoubleClick);
            // 
            // Afficheur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GSM_MJC.Properties.Resources.img_01_preset_22;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 393);
            this.Controls.Add(this.messageAfficheur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Afficheur";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Afficheur SMS";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Afficheur_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label messageAfficheur;
    }
}