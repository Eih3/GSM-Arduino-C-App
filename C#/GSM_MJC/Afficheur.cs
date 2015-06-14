using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSM_MJC
{
    public partial class Afficheur : Form
    {
        public Afficheur()
        {
            InitializeComponent();
        }

        public void Message(string message)
        {
            messageAfficheur.Text = message;
        }

        private void Afficheur_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.WindowState = System.Windows.Forms.FormWindowState.Normal; 
        }

        private void messageAfficheur_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Normal)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
    }
}
