﻿
namespace gestionale_ristorante
{
    partial class Form3_User
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
            this.label1 = new System.Windows.Forms.Label();
            this.butn_antipasto = new System.Windows.Forms.Button();
            this.butn_primo = new System.Windows.Forms.Button();
            this.butn_secondi = new System.Windows.Forms.Button();
            this.butn_dolci = new System.Windows.Forms.Button();
            this.butn_contorni = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordina il tuo piatto ";
            // 
            // butn_antipasto
            // 
            this.butn_antipasto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butn_antipasto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_antipasto.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_antipasto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butn_antipasto.Location = new System.Drawing.Point(29, 78);
            this.butn_antipasto.Margin = new System.Windows.Forms.Padding(0);
            this.butn_antipasto.Name = "butn_antipasto";
            this.butn_antipasto.Size = new System.Drawing.Size(262, 94);
            this.butn_antipasto.TabIndex = 1;
            this.butn_antipasto.Text = "Antipasto";
            this.butn_antipasto.UseVisualStyleBackColor = false;
            this.butn_antipasto.Click += new System.EventHandler(this.butn_antipasto_Click);
            // 
            // butn_primo
            // 
            this.butn_primo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.butn_primo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_primo.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_primo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butn_primo.Location = new System.Drawing.Point(29, 175);
            this.butn_primo.Name = "butn_primo";
            this.butn_primo.Size = new System.Drawing.Size(262, 94);
            this.butn_primo.TabIndex = 2;
            this.butn_primo.Text = "Prima portata";
            this.butn_primo.UseVisualStyleBackColor = false;
            this.butn_primo.Click += new System.EventHandler(this.butn_primo_Click);
            // 
            // butn_secondi
            // 
            this.butn_secondi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_secondi.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_secondi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butn_secondi.Location = new System.Drawing.Point(29, 275);
            this.butn_secondi.Name = "butn_secondi";
            this.butn_secondi.Size = new System.Drawing.Size(262, 94);
            this.butn_secondi.TabIndex = 3;
            this.butn_secondi.Text = "Seconda portata";
            this.butn_secondi.UseVisualStyleBackColor = true;
            this.butn_secondi.Click += new System.EventHandler(this.butn_secondi_Click);
            // 
            // butn_dolci
            // 
            this.butn_dolci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_dolci.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_dolci.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butn_dolci.Location = new System.Drawing.Point(29, 375);
            this.butn_dolci.Name = "butn_dolci";
            this.butn_dolci.Size = new System.Drawing.Size(262, 94);
            this.butn_dolci.TabIndex = 4;
            this.butn_dolci.Text = "Dolci";
            this.butn_dolci.UseVisualStyleBackColor = true;
            this.butn_dolci.Click += new System.EventHandler(this.butn_dolci_Click);
            // 
            // butn_contorni
            // 
            this.butn_contorni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butn_contorni.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butn_contorni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butn_contorni.Location = new System.Drawing.Point(29, 475);
            this.butn_contorni.Name = "butn_contorni";
            this.butn_contorni.Size = new System.Drawing.Size(262, 94);
            this.butn_contorni.TabIndex = 5;
            this.butn_contorni.Text = "Contorni ";
            this.butn_contorni.UseVisualStyleBackColor = true;
            this.butn_contorni.Click += new System.EventHandler(this.butn_contorni_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(366, 78);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(644, 491);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ingredienti";
            this.columnHeader3.Width = 188;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Prezzo";
            this.columnHeader4.Width = 108;
            // 
            // Form3_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1124, 647);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.butn_contorni);
            this.Controls.Add(this.butn_dolci);
            this.Controls.Add(this.butn_secondi);
            this.Controls.Add(this.butn_primo);
            this.Controls.Add(this.butn_antipasto);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3_User";
            this.Text = "Welcome User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butn_antipasto;
        private System.Windows.Forms.Button butn_primo;
        private System.Windows.Forms.Button butn_secondi;
        private System.Windows.Forms.Button butn_dolci;
        private System.Windows.Forms.Button butn_contorni;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}