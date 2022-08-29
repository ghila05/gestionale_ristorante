using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionale_ristorante
{
    public partial class Form3_User : Form
    {
        public Form3_User()
        {
            InitializeComponent();
        }

        public struct Piatto
        {
            public int id;
            public string nome;
            public string ingredienti;
            public double prezzo;
            public string Classificazione;
        }
        
        public string filename = "Piatti.txt";//esplora soluzioni+tasto destro nome barra laterlare+openfolder+bin>debug>creafile
        public Piatto p;
        public double prezzofin = 0;
      
        private void butn_antipasto_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Menù(filename, "antipasto");
        }
        private void butn_primo_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Menù(filename, "primo");
        }
        private void butn_secondi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Menù(filename, "secondo");
        }
        private void butn_dolci_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Menù(filename, "dolce");
        }
        private void butn_contorni_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Menù(filename, "contorni");
        }


       
        private void button_remove_Click(object sender, EventArgs e)
        {

            try
            {
                listBox_ordine.Items[listBox_ordine.SelectedIndex].ToString();
            }
            catch
            {
                throw new ArgumentException("id non valido");
            }

            elimina();

        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = listView1.SelectedItems[0].SubItems[1].Text;

            aggiungi(selected);
        }




        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // INIZIO FUNZIONI by Ghila


        private void elimina()
        {
            Piatto ordine;


            string ultimordime = listBox_ordine.Items[listBox_ordine.SelectedIndex].ToString();


            ordine = cercaSuFilenome(ultimordime, filename);

            if (ordine.nome == "")
            {
                throw new ArgumentException("piatto non trovato o inesistente");
            }

            listBox_ordine.Items.RemoveAt(listBox_ordine.SelectedIndex);

            prezzofin = prezzofin - ordine.prezzo; 
            if (prezzofin < 0)
            {
                prezzofin = 0;
            }

            textBox_prezzofin.Text = (Convert.ToString("totale:    " + prezzofin + "€"));
        }
       
        private void Menù(string filename, string classificazione)
        {
            Piatto v;
            StreamReader sr = new StreamReader(filename);
            
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.Classificazione == classificazione)
                {
                    
                    Riempi(v);
                }

            }

            sr.Close();

        }

        private void Riempi(Piatto v)

        {
            
            if(v.id > 0)
            {
                listView1.Items.Add(Convert.ToString(v.id));
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.nome);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.ingredienti);
                listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString(v.prezzo + " €"));

            }
 

        }

        public static Piatto cercaSuFile(int id, string filename, string sep = ";")
        {
            

            StreamReader sr = new StreamReader(filename);
            string line = "";
            Piatto v;



            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.id == id)
                {
                    sr.Close();
                    return v;
                }

            }

            v.id = 0;
            v.ingredienti = "";
            v.nome = "";
            v.prezzo = 0;
            v.Classificazione = "";

            return v;
        }

        public static Piatto cercaSuFilenome(string name, string filename, string sep = ";")
        {


            StreamReader sr = new StreamReader(filename);
            string line = "";
            Piatto v;



            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.nome == name)
                {
                    sr.Close();
                    return v;
                }

            }

            v.id = 0;
            v.ingredienti = "";
            v.nome = "";
            v.prezzo = 0;
            v.Classificazione = "";

            return v;
        }


        public static Piatto FromString(string votoStringa, string sep = ";")//funzione che da una stringa separa i campi e ritorna una struct associata a i campi di essa
        {
            var ris = votoStringa.Split(';');



            Piatto v;

            v.id = Convert.ToInt32(ris[0]);
            v.nome = ris[1];
            v.ingredienti = ris[2];
            v.prezzo = Convert.ToDouble(ris[3]);
            v.Classificazione = ris[4];

            return v;
        }

        private void aggiungi(string piatto)
        {
            Piatto selezionato;
            selezionato = cercaSuFilenome(piatto, filename);

            if (p.nome == "")
            {
                throw new ArgumentException("piatto non trovato o inesistente");
            }


            listBox_ordine.Items.Add(selezionato.nome);
            prezzofin = prezzofin + selezionato.prezzo;


            textBox_prezzofin.Clear();

            textBox_prezzofin.Text = (Convert.ToString("totale:    " + prezzofin + "€"));




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void listBox_ordine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }






    }

}
