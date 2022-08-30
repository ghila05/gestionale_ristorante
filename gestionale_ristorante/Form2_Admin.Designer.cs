
namespace gestionale_ristorante
{
    partial class Form2_Admin
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.butn_aggiungi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.butn_modifica = new System.Windows.Forms.Button();
            this.butn_ricerca = new System.Windows.Forms.Button();
            this.butn_visualizza = new System.Windows.Forms.Button();
            this.butn_elimina = new System.Windows.Forms.Button();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_ingredienti = new System.Windows.Forms.Label();
            this.textBox_ingredienti = new System.Windows.Forms.TextBox();
            this.label_prezzo = new System.Windows.Forms.Label();
            this.textBox_prezzo = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label_classificazione = new System.Windows.Forms.Label();
            this.butn_ricompatta = new System.Windows.Forms.Button();
            this.butn_rispistina = new System.Windows.Forms.Button();
            this.butn_aggiungi_grafica = new System.Windows.Forms.Button();
            this.butn_visualizza_grafica = new System.Windows.Forms.Button();
            this.butn_ricerca_grafica = new System.Windows.Forms.Button();
            this.butn_modifica_grafica = new System.Windows.Forms.Button();
            this.butn_elimina_grafica = new System.Windows.Forms.Button();
            this.butn_ripristina_grafica = new System.Windows.Forms.Button();
            this.comboBox_classificazione = new System.Windows.Forms.ComboBox();
            this.listBox_ripristina = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // butn_aggiungi
            // 
            this.butn_aggiungi.Location = new System.Drawing.Point(18, 494);
            this.butn_aggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.butn_aggiungi.Name = "butn_aggiungi";
            this.butn_aggiungi.Size = new System.Drawing.Size(188, 78);
            this.butn_aggiungi.TabIndex = 0;
            this.butn_aggiungi.Text = "Aggiungi ";
            this.butn_aggiungi.UseVisualStyleBackColor = true;
            this.butn_aggiungi.Visible = false;
            this.butn_aggiungi.Click += new System.EventHandler(this.butn_aggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(417, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestione menù";
            // 
            // butn_modifica
            // 
            this.butn_modifica.Location = new System.Drawing.Point(614, 494);
            this.butn_modifica.Margin = new System.Windows.Forms.Padding(4);
            this.butn_modifica.Name = "butn_modifica";
            this.butn_modifica.Size = new System.Drawing.Size(185, 78);
            this.butn_modifica.TabIndex = 2;
            this.butn_modifica.Text = "Modifica ";
            this.butn_modifica.UseVisualStyleBackColor = true;
            this.butn_modifica.Visible = false;
            this.butn_modifica.Click += new System.EventHandler(this.butn_modifica_Click);
            // 
            // butn_ricerca
            // 
            this.butn_ricerca.Location = new System.Drawing.Point(420, 494);
            this.butn_ricerca.Margin = new System.Windows.Forms.Padding(4);
            this.butn_ricerca.Name = "butn_ricerca";
            this.butn_ricerca.Size = new System.Drawing.Size(186, 78);
            this.butn_ricerca.TabIndex = 3;
            this.butn_ricerca.Text = "Ricerca ";
            this.butn_ricerca.UseVisualStyleBackColor = true;
            this.butn_ricerca.Visible = false;
            this.butn_ricerca.Click += new System.EventHandler(this.butn_ricerca_Click);
            // 
            // butn_visualizza
            // 
            this.butn_visualizza.Location = new System.Drawing.Point(225, 494);
            this.butn_visualizza.Margin = new System.Windows.Forms.Padding(4);
            this.butn_visualizza.Name = "butn_visualizza";
            this.butn_visualizza.Size = new System.Drawing.Size(187, 78);
            this.butn_visualizza.TabIndex = 4;
            this.butn_visualizza.Text = "Visualizza";
            this.butn_visualizza.UseVisualStyleBackColor = true;
            this.butn_visualizza.Visible = false;
            this.butn_visualizza.Click += new System.EventHandler(this.butn_visualizza_Click);
            // 
            // butn_elimina
            // 
            this.butn_elimina.Location = new System.Drawing.Point(807, 494);
            this.butn_elimina.Margin = new System.Windows.Forms.Padding(4);
            this.butn_elimina.Name = "butn_elimina";
            this.butn_elimina.Size = new System.Drawing.Size(185, 78);
            this.butn_elimina.TabIndex = 5;
            this.butn_elimina.Text = "Elimina ";
            this.butn_elimina.UseVisualStyleBackColor = true;
            this.butn_elimina.Visible = false;
            this.butn_elimina.Click += new System.EventHandler(this.butn_elimina_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(195, 234);
            this.textBox_nome.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(241, 30);
            this.textBox_nome.TabIndex = 6;
            this.textBox_nome.Visible = false;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_nome.Location = new System.Drawing.Point(18, 239);
            this.label_nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(70, 25);
            this.label_nome.TabIndex = 7;
            this.label_nome.Text = "Nome:";
            this.label_nome.Visible = false;
            // 
            // label_ingredienti
            // 
            this.label_ingredienti.AutoSize = true;
            this.label_ingredienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ingredienti.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_ingredienti.Location = new System.Drawing.Point(14, 398);
            this.label_ingredienti.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ingredienti.Name = "label_ingredienti";
            this.label_ingredienti.Size = new System.Drawing.Size(113, 25);
            this.label_ingredienti.TabIndex = 8;
            this.label_ingredienti.Text = "Ingredienti: ";
            this.label_ingredienti.Visible = false;
            // 
            // textBox_ingredienti
            // 
            this.textBox_ingredienti.Location = new System.Drawing.Point(195, 361);
            this.textBox_ingredienti.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ingredienti.Multiline = true;
            this.textBox_ingredienti.Name = "textBox_ingredienti";
            this.textBox_ingredienti.Size = new System.Drawing.Size(241, 60);
            this.textBox_ingredienti.TabIndex = 9;
            this.textBox_ingredienti.Visible = false;
            // 
            // label_prezzo
            // 
            this.label_prezzo.AutoSize = true;
            this.label_prezzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prezzo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_prezzo.Location = new System.Drawing.Point(609, 237);
            this.label_prezzo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_prezzo.Name = "label_prezzo";
            this.label_prezzo.Size = new System.Drawing.Size(79, 25);
            this.label_prezzo.TabIndex = 10;
            this.label_prezzo.Text = "Prezzo:";
            this.label_prezzo.Visible = false;
            // 
            // textBox_prezzo
            // 
            this.textBox_prezzo.Location = new System.Drawing.Point(707, 234);
            this.textBox_prezzo.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_prezzo.Multiline = true;
            this.textBox_prezzo.Name = "textBox_prezzo";
            this.textBox_prezzo.Size = new System.Drawing.Size(148, 30);
            this.textBox_prezzo.TabIndex = 11;
            this.textBox_prezzo.Visible = false;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(195, 294);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(241, 39);
            this.textBox_ID.TabIndex = 12;
            this.textBox_ID.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_id.Location = new System.Drawing.Point(38, 306);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(37, 25);
            this.label_id.TabIndex = 13;
            this.label_id.Text = "ID:";
            this.label_id.Visible = false;
            // 
            // label_classificazione
            // 
            this.label_classificazione.AutoSize = true;
            this.label_classificazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_classificazione.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_classificazione.Location = new System.Drawing.Point(549, 361);
            this.label_classificazione.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_classificazione.Name = "label_classificazione";
            this.label_classificazione.Size = new System.Drawing.Size(149, 25);
            this.label_classificazione.TabIndex = 14;
            this.label_classificazione.Text = "Classificazione:";
            this.label_classificazione.Visible = false;
            // 
            // butn_ricompatta
            // 
            this.butn_ricompatta.Location = new System.Drawing.Point(982, 743);
            this.butn_ricompatta.Margin = new System.Windows.Forms.Padding(4);
            this.butn_ricompatta.Name = "butn_ricompatta";
            this.butn_ricompatta.Size = new System.Drawing.Size(211, 52);
            this.butn_ricompatta.TabIndex = 16;
            this.butn_ricompatta.Text = "Ricompatta file \"piatti\" ";
            this.butn_ricompatta.UseVisualStyleBackColor = true;
            this.butn_ricompatta.Click += new System.EventHandler(this.butn_ricompatta_Click);
            // 
            // butn_rispistina
            // 
            this.butn_rispistina.Location = new System.Drawing.Point(1000, 494);
            this.butn_rispistina.Margin = new System.Windows.Forms.Padding(4);
            this.butn_rispistina.Name = "butn_rispistina";
            this.butn_rispistina.Size = new System.Drawing.Size(185, 78);
            this.butn_rispistina.TabIndex = 17;
            this.butn_rispistina.Text = "Ripristina piatto";
            this.butn_rispistina.UseVisualStyleBackColor = true;
            this.butn_rispistina.Visible = false;
            this.butn_rispistina.Click += new System.EventHandler(this.butn_rispistina_Click);
            // 
            // butn_aggiungi_grafica
            // 
            this.butn_aggiungi_grafica.Location = new System.Drawing.Point(22, 75);
            this.butn_aggiungi_grafica.Margin = new System.Windows.Forms.Padding(4);
            this.butn_aggiungi_grafica.Name = "butn_aggiungi_grafica";
            this.butn_aggiungi_grafica.Size = new System.Drawing.Size(188, 78);
            this.butn_aggiungi_grafica.TabIndex = 18;
            this.butn_aggiungi_grafica.Text = "Aggiungi piatto";
            this.butn_aggiungi_grafica.UseVisualStyleBackColor = true;
            this.butn_aggiungi_grafica.Click += new System.EventHandler(this.butn_aggiungi_grafica_Click);
            // 
            // butn_visualizza_grafica
            // 
            this.butn_visualizza_grafica.Location = new System.Drawing.Point(225, 75);
            this.butn_visualizza_grafica.Name = "butn_visualizza_grafica";
            this.butn_visualizza_grafica.Size = new System.Drawing.Size(187, 78);
            this.butn_visualizza_grafica.TabIndex = 19;
            this.butn_visualizza_grafica.Text = "Visualizza piatto";
            this.butn_visualizza_grafica.UseVisualStyleBackColor = true;
            this.butn_visualizza_grafica.Click += new System.EventHandler(this.butn_visualizza_grafica_Click);
            // 
            // butn_ricerca_grafica
            // 
            this.butn_ricerca_grafica.Location = new System.Drawing.Point(418, 75);
            this.butn_ricerca_grafica.Name = "butn_ricerca_grafica";
            this.butn_ricerca_grafica.Size = new System.Drawing.Size(187, 78);
            this.butn_ricerca_grafica.TabIndex = 20;
            this.butn_ricerca_grafica.Text = "Ricerca piatto";
            this.butn_ricerca_grafica.UseVisualStyleBackColor = true;
            this.butn_ricerca_grafica.Click += new System.EventHandler(this.butn_ricerca_grafica_Click);
            // 
            // butn_modifica_grafica
            // 
            this.butn_modifica_grafica.Location = new System.Drawing.Point(614, 75);
            this.butn_modifica_grafica.Name = "butn_modifica_grafica";
            this.butn_modifica_grafica.Size = new System.Drawing.Size(187, 78);
            this.butn_modifica_grafica.TabIndex = 21;
            this.butn_modifica_grafica.Text = "Modifica piatto";
            this.butn_modifica_grafica.UseVisualStyleBackColor = true;
            this.butn_modifica_grafica.Click += new System.EventHandler(this.butn_modifica_grafica_Click);
            // 
            // butn_elimina_grafica
            // 
            this.butn_elimina_grafica.Location = new System.Drawing.Point(807, 75);
            this.butn_elimina_grafica.Name = "butn_elimina_grafica";
            this.butn_elimina_grafica.Size = new System.Drawing.Size(187, 78);
            this.butn_elimina_grafica.TabIndex = 22;
            this.butn_elimina_grafica.Text = "Elimina piatto";
            this.butn_elimina_grafica.UseVisualStyleBackColor = true;
            this.butn_elimina_grafica.Click += new System.EventHandler(this.butn_elimina_grafica_Click);
            // 
            // butn_ripristina_grafica
            // 
            this.butn_ripristina_grafica.Location = new System.Drawing.Point(1000, 75);
            this.butn_ripristina_grafica.Name = "butn_ripristina_grafica";
            this.butn_ripristina_grafica.Size = new System.Drawing.Size(187, 78);
            this.butn_ripristina_grafica.TabIndex = 23;
            this.butn_ripristina_grafica.Text = "Ripristina piatto";
            this.butn_ripristina_grafica.UseVisualStyleBackColor = true;
            this.butn_ripristina_grafica.Click += new System.EventHandler(this.butn_ripristina_grafica_Click);
            // 
            // comboBox_classificazione
            // 
            this.comboBox_classificazione.FormattingEnabled = true;
            this.comboBox_classificazione.Items.AddRange(new object[] {
            "antipasto",
            "primo",
            "secondo",
            "dolce",
            "contorni"});
            this.comboBox_classificazione.Location = new System.Drawing.Point(707, 358);
            this.comboBox_classificazione.Name = "comboBox_classificazione";
            this.comboBox_classificazione.Size = new System.Drawing.Size(148, 33);
            this.comboBox_classificazione.TabIndex = 24;
            this.comboBox_classificazione.Visible = false;
            // 
            // listBox_ripristina
            // 
            this.listBox_ripristina.FormattingEnabled = true;
            this.listBox_ripristina.ItemHeight = 25;
            this.listBox_ripristina.Location = new System.Drawing.Point(953, 181);
            this.listBox_ripristina.Name = "listBox_ripristina";
            this.listBox_ripristina.Size = new System.Drawing.Size(234, 254);
            this.listBox_ripristina.TabIndex = 25;
            this.listBox_ripristina.Visible = false;
            // 
            // Form2_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1206, 808);
            this.Controls.Add(this.listBox_ripristina);
            this.Controls.Add(this.comboBox_classificazione);
            this.Controls.Add(this.butn_ripristina_grafica);
            this.Controls.Add(this.butn_elimina_grafica);
            this.Controls.Add(this.butn_modifica_grafica);
            this.Controls.Add(this.butn_ricerca_grafica);
            this.Controls.Add(this.butn_visualizza_grafica);
            this.Controls.Add(this.butn_aggiungi_grafica);
            this.Controls.Add(this.butn_rispistina);
            this.Controls.Add(this.butn_ricompatta);
            this.Controls.Add(this.label_classificazione);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_prezzo);
            this.Controls.Add(this.label_prezzo);
            this.Controls.Add(this.textBox_ingredienti);
            this.Controls.Add(this.label_ingredienti);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.butn_elimina);
            this.Controls.Add(this.butn_visualizza);
            this.Controls.Add(this.butn_ricerca);
            this.Controls.Add(this.butn_modifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butn_aggiungi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form2_Admin";
            this.Text = "Welcome Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butn_aggiungi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butn_modifica;
        private System.Windows.Forms.Button butn_ricerca;
        private System.Windows.Forms.Button butn_visualizza;
        private System.Windows.Forms.Button butn_elimina;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Label label_ingredienti;
        private System.Windows.Forms.TextBox textBox_ingredienti;
        private System.Windows.Forms.Label label_prezzo;
        private System.Windows.Forms.TextBox textBox_prezzo;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_classificazione;
        private System.Windows.Forms.Button butn_ricompatta;
        private System.Windows.Forms.Button butn_rispistina;
        private System.Windows.Forms.Button butn_aggiungi_grafica;
        private System.Windows.Forms.Button butn_visualizza_grafica;
        private System.Windows.Forms.Button butn_ricerca_grafica;
        private System.Windows.Forms.Button butn_modifica_grafica;
        private System.Windows.Forms.Button butn_elimina_grafica;
        private System.Windows.Forms.Button butn_ripristina_grafica;
        private System.Windows.Forms.ComboBox comboBox_classificazione;
        private System.Windows.Forms.ListBox listBox_ripristina;
    }
}