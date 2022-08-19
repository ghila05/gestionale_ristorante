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

        private void Riempi(Piatto v)
        {
            listView1.Items.Add(Convert.ToString(v.id));
            listView1.Items[listView1.Items.Count -1].SubItems.Add(v.nome);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(v.ingredienti);
            listView1.Items[listView1.Items.Count - 1].SubItems.Add(Convert.ToString(v.prezzo + " €"));
        }
        private void button_aggiungi_Click(object sender, EventArgs e)
        {
            
            Piatto v;
            v = cercaSuFile(Convert.ToInt32(textBox_id_ordine.Text), filename);

            if (v.nome == "")
            {
                throw new ArgumentException("piatto non trovato o inesistente");
            }

            listBox_ordine.Items.Add(v.nome);
            prezzofin = prezzofin + v.prezzo;

            textBox_id_ordine.Clear();
            textBox_prezzofin.Clear();

            textBox_prezzofin.Text=(Convert.ToString("totale    " + prezzofin + "€"));
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // INIZIO FUNZIONI by Ghila

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


    }

}
