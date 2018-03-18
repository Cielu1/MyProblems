// This is simple informational menu for heroes 3 project

namespace WindowsFormsApplication1
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.HelpStworzenia = new System.Windows.Forms.Button();
            this.HelpArtefakty = new System.Windows.Forms.Button();
            this.HelpUmiejetnosci = new System.Windows.Forms.Button();
            this.HelpZmiany = new System.Windows.Forms.Button();
            this.HelpNotes = new System.Windows.Forms.Button();
            this.HelpUmiejetnosciText = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.HelpStworzeniaText = new System.Windows.Forms.RichTextBox();
            this.HelpArtefaktText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // HelpStworzenia
            // 
            this.HelpStworzenia.Font = new System.Drawing.Font("Georgia", 9.25F);
            this.HelpStworzenia.Location = new System.Drawing.Point(0, 0);
            this.HelpStworzenia.Name = "HelpStworzenia";
            this.HelpStworzenia.Size = new System.Drawing.Size(125, 25);
            this.HelpStworzenia.TabIndex = 0;
            this.HelpStworzenia.Text = "Stworzenia";
            this.HelpStworzenia.UseVisualStyleBackColor = true;
            this.HelpStworzenia.Click += new System.EventHandler(this.HelpStworzenia_Click);
            // 
            // HelpArtefakty
            // 
            this.HelpArtefakty.Font = new System.Drawing.Font("Georgia", 9.25F);
            this.HelpArtefakty.Location = new System.Drawing.Point(0, 62);
            this.HelpArtefakty.Name = "HelpArtefakty";
            this.HelpArtefakty.Size = new System.Drawing.Size(125, 25);
            this.HelpArtefakty.TabIndex = 1;
            this.HelpArtefakty.Text = "Artefakty";
            this.HelpArtefakty.UseVisualStyleBackColor = true;
            this.HelpArtefakty.Click += new System.EventHandler(this.HelpArtefakty_Click);
            // 
            // HelpUmiejetnosci
            // 
            this.HelpUmiejetnosci.Font = new System.Drawing.Font("Georgia", 9.25F);
            this.HelpUmiejetnosci.Location = new System.Drawing.Point(0, 31);
            this.HelpUmiejetnosci.Name = "HelpUmiejetnosci";
            this.HelpUmiejetnosci.Size = new System.Drawing.Size(125, 25);
            this.HelpUmiejetnosci.TabIndex = 2;
            this.HelpUmiejetnosci.Text = "Umiejetnosci";
            this.HelpUmiejetnosci.UseVisualStyleBackColor = true;
            this.HelpUmiejetnosci.Click += new System.EventHandler(this.HelpUmiejetnosci_Click);
            // 
            // HelpZmiany
            // 
            this.HelpZmiany.Font = new System.Drawing.Font("Georgia", 9.25F);
            this.HelpZmiany.Location = new System.Drawing.Point(0, 127);
            this.HelpZmiany.Name = "HelpZmiany";
            this.HelpZmiany.Size = new System.Drawing.Size(100, 25);
            this.HelpZmiany.TabIndex = 3;
            this.HelpZmiany.Text = "Lista zmian";
            this.HelpZmiany.UseVisualStyleBackColor = true;
            // 
            // HelpNotes
            // 
            this.HelpNotes.Font = new System.Drawing.Font("Georgia", 9.25F);
            this.HelpNotes.Location = new System.Drawing.Point(0, 158);
            this.HelpNotes.Name = "HelpNotes";
            this.HelpNotes.Size = new System.Drawing.Size(100, 25);
            this.HelpNotes.TabIndex = 4;
            this.HelpNotes.Text = "Patch Notes";
            this.HelpNotes.UseVisualStyleBackColor = true;
            // 
            // HelpUmiejetnosciText
            // 
            this.HelpUmiejetnosciText.Location = new System.Drawing.Point(131, 5);
            this.HelpUmiejetnosciText.Name = "HelpUmiejetnosciText";
            this.HelpUmiejetnosciText.Size = new System.Drawing.Size(362, 282);
            this.HelpUmiejetnosciText.TabIndex = 6;
            this.HelpUmiejetnosciText.Text = resources.GetString("HelpUmiejetnosciText.Text");
            this.HelpUmiejetnosciText.TextChanged += new System.EventHandler(this.HelpUmiejetnosciText_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(131, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(362, 282);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // HelpStworzeniaText
            // 
            this.HelpStworzeniaText.Location = new System.Drawing.Point(131, 3);
            this.HelpStworzeniaText.Name = "HelpStworzeniaText";
            this.HelpStworzeniaText.Size = new System.Drawing.Size(362, 287);
            this.HelpStworzeniaText.TabIndex = 7;
            this.HelpStworzeniaText.Text = resources.GetString("HelpStworzeniaText.Text");
            this.HelpStworzeniaText.TextChanged += new System.EventHandler(this.HelpStworzeniaText_TextChanged);
            // 
            // HelpArtefaktText
            // 
            this.HelpArtefaktText.Location = new System.Drawing.Point(131, 3);
            this.HelpArtefaktText.Name = "HelpArtefaktText";
            this.HelpArtefaktText.Size = new System.Drawing.Size(362, 287);
            this.HelpArtefaktText.TabIndex = 8;
            this.HelpArtefaktText.Text = "SHIFT * A \n\n[A],[D] - poruszanie się między miejscami w ekwipunku\n\nTO DO:\n// [Str" +
    "załki] - poruszanie się między artefaktami";
            this.HelpArtefaktText.TextChanged += new System.EventHandler(this.HelpArtefaktText_TextChanged);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 322);
            this.Controls.Add(this.HelpArtefaktText);
            this.Controls.Add(this.HelpStworzeniaText);
            this.Controls.Add(this.HelpUmiejetnosciText);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.HelpNotes);
            this.Controls.Add(this.HelpZmiany);
            this.Controls.Add(this.HelpUmiejetnosci);
            this.Controls.Add(this.HelpArtefakty);
            this.Controls.Add(this.HelpStworzenia);
            this.Name = "Help";
            this.Text = "Help";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HelpStworzenia;
        private System.Windows.Forms.Button HelpArtefakty;
        private System.Windows.Forms.Button HelpUmiejetnosci;
        private System.Windows.Forms.Button HelpZmiany;
        private System.Windows.Forms.Button HelpNotes;
        private System.Windows.Forms.RichTextBox HelpUmiejetnosciText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox HelpStworzeniaText;
        private System.Windows.Forms.RichTextBox HelpArtefaktText;
    }
}
