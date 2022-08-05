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
    public partial class Form2_Admin : Form
    {
        public Form2_Admin()
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



        private void butn_aggiungi_Click(object sender, EventArgs e) // AGGIUNTA
        {
            Piatto p;
            p.id = 0;
            p.nome = "";
            p.ingredienti = "";
            p.prezzo = 0;

            p.id = RecuperaContatore(filename);

            p.nome = textBox_nome.Text;

            p.ingredienti = textBox_ingredienti.Text;

            p.prezzo = Convert.ToDouble(textBox_prezzo.Text);

            p.Classificazione = textBox_classificazione.Text;

            AggiungiSuFile(p, filename);

        }

        private void butn_visualizza_Click(object sender, EventArgs e) // VISUALIZZAZIONE
        {
            int id = 0;
            id = Convert.ToInt32(textBox_ID.Text);

            MessageBox.Show(cercaSuFile(id, filename));
        }

        private void butn_ricerca_Click(object sender, EventArgs e) // RICERCA CON NOME
        {
            string nomepiatto = "";
            nomepiatto = textBox_nome.Text;

            MessageBox.Show(cercaSuFileNome(nomepiatto, filename));
        }

        private void butn_modifica_Click(object sender, EventArgs e)// MODIFICA 
        {
            Piatto p;
            p.id = 0;
            p.nome = "";
            p.ingredienti = "";
            p.prezzo = 0;

            int id = Convert.ToInt32(textBox_ID.Text);


            p.nome = textBox_nome.Text;

            p.ingredienti = textBox_ingredienti.Text;

            p.prezzo = Convert.ToDouble(textBox_prezzo.Text);

            p.Classificazione = textBox_classificazione.Text;

            string newline = "";
            newline = ToString(p);

            Modifica(id, filename, newline);

        }
        private void butn_elimina_Click(object sender, EventArgs e) // ELIMINAZIONE LOGICA TRAMITE ID
        {
            int id = 0;
            id = Convert.ToInt32(textBox_ID.Text);


            EliminaLogica(id, filename);
        }

        private void butn_ricompatta_Click(object sender, EventArgs e) // RICOMPATTA FILE 
        {
            Ricompatta(filename);
        }



        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // INIZIO FUNZIONI by Ghila


        public static void AggiungiSuFile(Piatto v, string filename)
        {

            scriviAppend(ToString(v), filename);

        }

        public static void scriviAppend(string content, string filename) //scrivi sul foglio
        {
            MessageBox.Show(content);
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);

            sw.WriteLine(content);
            sw.Close();
        }

        public static string ToString(Piatto v, string sep = ";") //Converti in stringa la struct
        {

            return v.id + sep + v.nome + sep + v.ingredienti + sep + v.prezzo + sep + v.Classificazione;

        }


       
        public static string cercaSuFile(int id, string filename, string sep = ";")
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
                    return Convert.ToString("NOME: " +v.nome +" INGREDIENTI: " + v.ingredienti + " PREZZO: "+ v.prezzo + "€" + " CLASSIFICAZIONE: " + v.Classificazione);  // analizzo l'id di ogni riga e se trovo una corrispondenza ritorno il voto associato
                }

            }



            return "piatto non trovato o inesistente";
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

       
        public static string cercaSuFileNome(string nome, string filename, string sep = ";")
        {
            StreamReader sr = new StreamReader(filename);
            string line = "";
            Piatto v;
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.id < 0)
                {
                    return "piatto non trovato o inesistente";
                }
                if (v.nome == nome)
                {
                    sr.Close();
                    return Convert.ToString("NOME: " + v.nome + " INGREDIENTI: " + v.ingredienti + " PREZZO: " + v.prezzo + "€" + " CLASSIFICAZIONE: "+ v.Classificazione);  // analizzo l'id di ogni riga e se trovo una corrispondenza ritorno il voto associato
                }

            }



            return "piatto non trovato o inesistente";
        }

        


        public static void Modifica(int id, string filename, string newline)
        {

            Piatto v;
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@"./tmp.txt");
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.id == id)
                {
                    sw.WriteLine(newline);
                }
                else
                {
                    sw.WriteLine(line);
                }
               

            }
            sw.Close();
            sr.Close();

            File.Delete(filename);
            File.Move(@"./tmp.txt", filename);

           
   


        }
        public static int RecuperaContatore(string filename) // l'idea è quella di analizzare le singole righe e trovare il contatore più alto per poi partire da lì l'incremento
        {
            int id = 0;
            StreamReader r = new StreamReader(filename);
            string line = "";
            Piatto v;
            while (!r.EndOfStream)
            {
                line = r.ReadLine();
                v = FromString(line);
                if (v.id > id)
                {
                    id = v.id;



                }

            }
            id++;
            r.Close();
            return id;
        }

        public static void EliminaLogica(int id, string filename)
        {
            
            Piatto v;
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@"./tmp.txt");
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.id == id)
                {
                    sw.WriteLine("-"+ line);
                }
                else
                {
                    sw.WriteLine(line);
                }

            }
            sw.Close();
            sr.Close();

            File.Delete(filename);
            File.Move(@"./tmp.txt", filename);




        }


        public static void Ricompatta(string filename)
        {

            Piatto v;
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@"./tmp.txt");
            string line = "";
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                v = FromString(line);
                if (v.id > 0)
                {
                    sw.WriteLine(line);
                }



            }
            sw.Close();
            sr.Close();

            File.Delete(filename);
            File.Move(@"./tmp.txt", filename);





        }


    }
}
