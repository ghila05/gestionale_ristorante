
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ingredienti = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_prezzo = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_classificazione = new System.Windows.Forms.TextBox();
            this.butn_ricompatta = new System.Windows.Forms.Button();
            this.butn_rispistina = new System.Windows.Forms.Button();
            this.butn_aggiungi_grafica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butn_aggiungi
            // 
            this.butn_aggiungi.Location = new System.Drawing.Point(12, 304);
            this.butn_aggiungi.Name = "butn_aggiungi";
            this.butn_aggiungi.Size = new System.Drawing.Size(125, 50);
            this.butn_aggiungi.TabIndex = 0;
            this.butn_aggiungi.Text = "Aggiungi \r\n";
            this.butn_aggiungi.UseVisualStyleBackColor = true;
            this.butn_aggiungi.Visible = false;
            this.butn_aggiungi.Click += new System.EventHandler(this.butn_aggiungi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(278, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestione menù";
            // 
            // butn_modifica
            // 
            this.butn_modifica.Location = new System.Drawing.Point(879, 492);
            this.butn_modifica.Name = "butn_modifica";
            this.butn_modifica.Size = new System.Drawing.Size(150, 130);
            this.butn_modifica.TabIndex = 2;
            this.butn_modifica.Text = "Modifica Piatto (tramite id)";
            this.butn_modifica.UseVisualStyleBackColor = true;
            this.butn_modifica.Visible = false;
            this.butn_modifica.Click += new System.EventHandler(this.butn_modifica_Click);
            // 
            // butn_ricerca
            // 
            this.butn_ricerca.Location = new System.Drawing.Point(723, 488);
            this.butn_ricerca.Name = "butn_ricerca";
            this.butn_ricerca.Size = new System.Drawing.Size(150, 139);
            this.butn_ricerca.TabIndex = 3;
            this.butn_ricerca.Text = "Ricerca Piatto (tramite nome)";
            this.butn_ricerca.UseVisualStyleBackColor = true;
            this.butn_ricerca.Visible = false;
            this.butn_ricerca.Click += new System.EventHandler(this.butn_ricerca_Click);
            // 
            // butn_visualizza
            // 
            this.butn_visualizza.Location = new System.Drawing.Point(567, 488);
            this.butn_visualizza.Name = "butn_visualizza";
            this.butn_visualizza.Size = new System.Drawing.Size(150, 139);
            this.butn_visualizza.TabIndex = 4;
            this.butn_visualizza.Text = "Visualizza Piatto (con id)";
            this.butn_visualizza.UseVisualStyleBackColor = true;
            this.butn_visualizza.Visible = false;
            this.butn_visualizza.Click += new System.EventHandler(this.butn_visualizza_Click);
            // 
            // butn_elimina
            // 
            this.butn_elimina.Location = new System.Drawing.Point(1035, 488);
            this.butn_elimina.Name = "butn_elimina";
            this.butn_elimina.Size = new System.Drawing.Size(150, 129);
            this.butn_elimina.TabIndex = 5;
            this.butn_elimina.Text = "Elimina Piatto (logicamente)";
            this.butn_elimina.UseVisualStyleBackColor = true;
            this.butn_elimina.Visible = false;
            this.butn_elimina.Click += new System.EventHandler(this.butn_elimina_Click);
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(108, 150);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(162, 22);
            this.textBox_nome.TabIndex = 6;
            this.textBox_nome.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingredienti: ";
            this.label3.Visible = false;
            // 
            // textBox_ingredienti
            // 
            this.textBox_ingredienti.Location = new System.Drawing.Point(108, 182);
            this.textBox_ingredienti.Multiline = true;
            this.textBox_ingredienti.Name = "textBox_ingredienti";
            this.textBox_ingredienti.Size = new System.Drawing.Size(162, 83);
            this.textBox_ingredienti.TabIndex = 9;
            this.textBox_ingredienti.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(340, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prezzo:";
            this.label4.Visible = false;
            // 
            // textBox_prezzo
            // 
            this.textBox_prezzo.Location = new System.Drawing.Point(411, 171);
            this.textBox_prezzo.Multiline = true;
            this.textBox_prezzo.Name = "textBox_prezzo";
            this.textBox_prezzo.Size = new System.Drawing.Size(100, 25);
            this.textBox_prezzo.TabIndex = 11;
            this.textBox_prezzo.Visible = false;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(623, 224);
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(31, 33);
            this.textBox_ID.TabIndex = 12;
            this.textBox_ID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(592, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(300, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Classificazione:";
            this.label6.Visible = false;
            // 
            // textBox_classificazione
            // 
            this.textBox_classificazione.Location = new System.Drawing.Point(411, 224);
            this.textBox_classificazione.Name = "textBox_classificazione";
            this.textBox_classificazione.Size = new System.Drawing.Size(100, 22);
            this.textBox_classificazione.TabIndex = 15;
            this.textBox_classificazione.Visible = false;
            // 
            // butn_ricompatta
            // 
            this.butn_ricompatta.Location = new System.Drawing.Point(411, 633);
            this.butn_ricompatta.Name = "butn_ricompatta";
            this.butn_ricompatta.Size = new System.Drawing.Size(150, 129);
            this.butn_ricompatta.TabIndex = 16;
            this.butn_ricompatta.Text = "Ricompatta file piatti ";
            this.butn_ricompatta.UseVisualStyleBackColor = true;
            this.butn_ricompatta.Visible = false;
            this.butn_ricompatta.Click += new System.EventHandler(this.butn_ricompatta_Click);
            // 
            // butn_rispistina
            // 
            this.butn_rispistina.Location = new System.Drawing.Point(567, 633);
            this.butn_rispistina.Name = "butn_rispistina";
            this.butn_rispistina.Size = new System.Drawing.Size(150, 129);
            this.butn_rispistina.TabIndex = 17;
            this.butn_rispistina.Text = "Ripristina piatto (tramite id)";
            this.butn_rispistina.UseVisualStyleBackColor = true;
            this.butn_rispistina.Visible = false;
            this.butn_rispistina.Click += new System.EventHandler(this.butn_rispistina_Click);
            // 
            // butn_aggiungi_grafica
            // 
            this.butn_aggiungi_grafica.Location = new System.Drawing.Point(15, 48);
            this.butn_aggiungi_grafica.Name = "butn_aggiungi_grafica";
            this.butn_aggiungi_grafica.Size = new System.Drawing.Size(125, 50);
            this.butn_aggiungi_grafica.TabIndex = 18;
            this.butn_aggiungi_grafica.Text = "Aggiungi piatto";
            this.butn_aggiungi_grafica.UseVisualStyleBackColor = true;
            this.butn_aggiungi_grafica.Click += new System.EventHandler(this.butn_aggiungi_grafica_Click);
            // 
            // Form2_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1216, 752);
            this.Controls.Add(this.butn_aggiungi_grafica);
            this.Controls.Add(this.butn_rispistina);
            this.Controls.Add(this.butn_ricompatta);
            this.Controls.Add(this.textBox_classificazione);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.textBox_prezzo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ingredienti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.butn_elimina);
            this.Controls.Add(this.butn_visualizza);
            this.Controls.Add(this.butn_ricerca);
            this.Controls.Add(this.butn_modifica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butn_aggiungi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ingredienti;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_prezzo;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_classificazione;
        private System.Windows.Forms.Button butn_ricompatta;
        private System.Windows.Forms.Button butn_rispistina;
        private System.Windows.Forms.Button butn_aggiungi_grafica;
    }
}