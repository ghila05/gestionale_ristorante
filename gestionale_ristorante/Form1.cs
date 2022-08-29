using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; //libreria importata


namespace gestionale_ristorante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //button switch to admin
        {
            pictureBox2.Visible = true;
            label2.Visible = true;
            iconPictureBox1.Visible = true;
            
            button1.Visible = false; // ricorda ci sono 2 bottoni di sign in uno per l'user e uno per l'admin (questo user)
            button3.Visible = true;
           
            textBox1.Visible = true;
            textBox1.Clear();
            butn_switchUS.Visible = true;
        }
        private void butn_switchUS_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            iconPictureBox1.Visible = false;
            textBox1.Visible = false;
            butn_switchUS.Visible = false;
            label2.Visible = false;
            button1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != " ")
            { 
                if (sha256(textBox1.Text) == "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918") // passwd: "admin"
                {
                    Form2_Admin admin = new Form2_Admin();

                    admin.ShowDialog(); // i form dialogano dimodo che non si crei un altro form identico che crei conflitti 

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3_User user = new Form3_User();

            user.ShowDialog(); // i form dialogano dimodo che non si crei un altro form identico che crei conflitti 

        }


        static string sha256(string randomString) //FUNZIONE GENERA HASH CON SHA256
        {
            var crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.ASCII.GetBytes(randomString));
            foreach (byte theByte in crypto)
            {
                hash += theByte.ToString("x2");
            }
            return hash;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
