using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace GSM_MJC
{
    public partial class GSM : Form
    {
        SerialPort com = null;

        Database sqlite = Database.getInstance();

        Configuration config = Configuration.getInstance();

        Afficheur afficheur = new Afficheur();

        public string PORT;

        public int BAUD;

        public string data;

        public string valeurs;

        public string numeroSMS;

        public string messageSMS;

        public GSM()
        {
            InitializeComponent();
            config.configDatabase();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            connexion();
        }

        void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                data = com.ReadLine();
            }
            catch (Exception) { };

            int longueur;
            int longueur2;
            string date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            valeurs = data;

            longueur = valeurs.Length;
            longueur2 = longueur - 13;

            if (valeurs.StartsWith("|"))
            {
                try
                {
                    numeroSMS = valeurs.Substring(1, 12);
                    messageSMS = valeurs.Substring(13, longueur2);

                    messageSMS = messageSMS.Replace('\'', ' ');
                    messageSMS = messageSMS.Replace('ç', 'c');

                    sqlite.insertConfigTable(numeroSMS, messageSMS, date);

                                                
                }
                catch (Exception) { };
            }
            this.BeginInvoke(new updateAnalogLabel(updateLabel)); 
            

        }

        private delegate void updateAnalogLabel();
        private void updateLabel()
        {
            afficheur.Message(messageSMS);

            numero.Text = numeroSMS;
            message.Text = messageSMS;

            data = null;
        }

        private void buttonDeconnect_Click(object sender, EventArgs e)
        {
            deconnexion();
        }

        public void COMStarted()
        {
            Etat.Text = "État : Connecté";

            buttonConnect.Visible = false;
            buttonDeconnect.Visible = true;

            textBoxBAUD.Enabled = false;
            textBoxCOM.Enabled = false;
        }

        public void COMStoped()
        {
            Etat.Text = "État : Déconnecté";

            buttonConnect.Visible = true;
            buttonDeconnect.Visible = false;
           
            textBoxCOM.Enabled = true;
            textBoxBAUD.Enabled = true;
        }

        public void connexion()
        {
            PORT = textBoxCOM.Text;
            BAUD = Convert.ToInt16(textBoxBAUD.Text);

            com = new SerialPort(PORT, BAUD, Parity.None, 8, StopBits.One);

            try
            {
                com.Open();
                com.Write("#");

                COMStarted();
            }
            catch (Exception) { MessageBox.Show("Le port " + PORT + " n'est pas disponible"); }

            com.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);
        }

        public void deconnexion()
        {
            com.Close();

            COMStoped();
        }

        private void textBoxCOM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) connexion(); 
        }

        private void textBoxBAUD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return) connexion(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            afficheur.Show();
        }
    }
}
