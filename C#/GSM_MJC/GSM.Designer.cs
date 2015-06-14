namespace GSM_MJC
{
    partial class GSM
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSM));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxBAUD = new System.Windows.Forms.TextBox();
            this.textBoxCOM = new System.Windows.Forms.TextBox();
            this.labelBAUD = new System.Windows.Forms.Label();
            this.labelCOM = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDeconnect = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Etat = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.message = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.textBoxBAUD);
            this.groupBox.Controls.Add(this.textBoxCOM);
            this.groupBox.Controls.Add(this.buttonConnect);
            this.groupBox.Controls.Add(this.buttonDeconnect);
            this.groupBox.Controls.Add(this.labelBAUD);
            this.groupBox.Controls.Add(this.labelCOM);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(405, 67);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Paramètres de connexion";
            // 
            // textBoxBAUD
            // 
            this.textBoxBAUD.Location = new System.Drawing.Point(202, 29);
            this.textBoxBAUD.Name = "textBoxBAUD";
            this.textBoxBAUD.Size = new System.Drawing.Size(66, 20);
            this.textBoxBAUD.TabIndex = 3;
            this.textBoxBAUD.Text = "9600";
            this.textBoxBAUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBAUD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBAUD_KeyDown);
            // 
            // textBoxCOM
            // 
            this.textBoxCOM.Location = new System.Drawing.Point(61, 29);
            this.textBoxCOM.Name = "textBoxCOM";
            this.textBoxCOM.Size = new System.Drawing.Size(66, 20);
            this.textBoxCOM.TabIndex = 2;
            this.textBoxCOM.Text = "COM3";
            this.textBoxCOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCOM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCOM_KeyDown);
            // 
            // labelBAUD
            // 
            this.labelBAUD.AutoSize = true;
            this.labelBAUD.Location = new System.Drawing.Point(149, 32);
            this.labelBAUD.Name = "labelBAUD";
            this.labelBAUD.Size = new System.Drawing.Size(47, 13);
            this.labelBAUD.TabIndex = 1;
            this.labelBAUD.Text = "Vitesse :";
            // 
            // labelCOM
            // 
            this.labelCOM.AutoSize = true;
            this.labelCOM.Location = new System.Drawing.Point(20, 32);
            this.labelCOM.Name = "labelCOM";
            this.labelCOM.Size = new System.Drawing.Size(35, 13);
            this.labelCOM.TabIndex = 0;
            this.labelCOM.Text = "Port : ";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(292, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(91, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connexion";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDeconnect
            // 
            this.buttonDeconnect.Location = new System.Drawing.Point(292, 27);
            this.buttonDeconnect.Name = "buttonDeconnect";
            this.buttonDeconnect.Size = new System.Drawing.Size(91, 23);
            this.buttonDeconnect.TabIndex = 4;
            this.buttonDeconnect.Text = "Déconnexion";
            this.buttonDeconnect.UseVisualStyleBackColor = true;
            this.buttonDeconnect.Visible = false;
            this.buttonDeconnect.Click += new System.EventHandler(this.buttonDeconnect_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Etat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 160);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(431, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Etat
            // 
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(99, 17);
            this.Etat.Text = "État : Déconnecté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eih3Prog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ouvrir l\'afficheur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.message);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numero);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages reçus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numéro :";
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Location = new System.Drawing.Point(79, 20);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(67, 13);
            this.numero.TabIndex = 9;
            this.numero.Text = "0682525241";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Message :";
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Location = new System.Drawing.Point(79, 40);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(81, 13);
            this.message.TabIndex = 11;
            this.message.Text = "FabLab Rutech";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 182);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GSM MJC";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxBAUD;
        private System.Windows.Forms.TextBox textBoxCOM;
        private System.Windows.Forms.Label labelBAUD;
        private System.Windows.Forms.Label labelCOM;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDeconnect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Etat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label label2;
    }
}

