using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Windows.Forms;


namespace WinFormApp
{
    public partial class Form1 : Form
    {               
        ServiceReference1.ContractClient client;

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {

        }               
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
       
                if (radioButtonString.Checked)
                    lblResponseResult.Text = client.ReversString(textBox1.Text);

                if (radioButtonNumeric.Checked)            
                    lblResponseResult.Text = client.CalcFactorial(int.Parse(textBox1.Text)).ToString();

                if (radioButtonClass.Checked)
                {
                    Player player = client.GetPlayer(int.Parse(textBoxIDPlayer.Text));
                    viewPlayer(player);
                }
                  
        }        
       

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new ServiceReference1.ContractClient("SecuredByMessageEndpointSelfHost");
                    
            client.ClientCredentials.UserName.UserName = GetUserName();
            client.ClientCredentials.UserName.Password = GetPassword();

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate
                (object s, System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                System.Security.Cryptography.X509Certificates.X509Chain chain,
                System.Net.Security.SslPolicyErrors sslPolicyErrors)
            { return true; };

            //sh.Credentials.ClientCertificate.Authentication.CertificateValidationMode =
            //     X509CertificateValidationMode.PeerOrChainTrust;

            try
            {
                client.Open();
                btnCalculate.Enabled = true;
            }
            catch (System.ServiceModel.Security.MessageSecurityException ex)
            {
                MessageBox.Show("Incorrect login/password " + ex);
            }

        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            client.Close();
            btnCalculate.Enabled = false;
        }

        private string GetUserName()
        {
            return textBoxUserName.Text;
        }

        private string GetPassword()
        {
            return textBoxPassword.Text;
        }

        private void viewPlayer(Player player)
        {
            textBoxIDPlayer.Text = Convert.ToString(player.ID);
            textBoxfName.Text = Convert.ToString(player.FirstName);
            textBoxLName.Text = Convert.ToString(player.LastName);
            textBoxLevel.Text = Convert.ToString(player.Level);
        }
    }
}
