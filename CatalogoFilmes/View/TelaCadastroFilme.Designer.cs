namespace CatalogoFilmes.View
{
    partial class TelaCadastroFilme
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Nomefilme = new System.Windows.Forms.TextBox();
            this.txt_estreiafilme = new System.Windows.Forms.TextBox();
            this.txt_duracaofilme = new System.Windows.Forms.TextBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro FILME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOME DO FILME:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(83, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "ESTREIA DO FILME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(400, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "CATEGORIA DO FILME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "DURACAO:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(400, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "CADASTRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Nomefilme
            // 
            this.txt_Nomefilme.Location = new System.Drawing.Point(83, 159);
            this.txt_Nomefilme.Name = "txt_Nomefilme";
            this.txt_Nomefilme.Size = new System.Drawing.Size(179, 23);
            this.txt_Nomefilme.TabIndex = 6;
            // 
            // txt_estreiafilme
            // 
            this.txt_estreiafilme.Location = new System.Drawing.Point(83, 231);
            this.txt_estreiafilme.Name = "txt_estreiafilme";
            this.txt_estreiafilme.Size = new System.Drawing.Size(131, 23);
            this.txt_estreiafilme.TabIndex = 7;
            // 
            // txt_duracaofilme
            // 
            this.txt_duracaofilme.Location = new System.Drawing.Point(83, 305);
            this.txt_duracaofilme.Name = "txt_duracaofilme";
            this.txt_duracaofilme.Size = new System.Drawing.Size(124, 23);
            this.txt_duracaofilme.TabIndex = 8;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Items.AddRange(new object[] {
            "Terror",
            "",
            "Romance",
            "",
            "Comédia",
            "",
            "Ficção",
            "",
            "Ação",
            "",
            "Suspense",
            "",
            "Drama",
            "",
            "Animação"});
            this.cmb_categoria.Location = new System.Drawing.Point(400, 163);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(121, 23);
            this.cmb_categoria.TabIndex = 9;
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.txt_duracaofilme);
            this.Controls.Add(this.txt_estreiafilme);
            this.Controls.Add(this.txt_Nomefilme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroFilme";
            this.Text = "TelaCadastroFilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox txt_Nomefilme;
        private TextBox txt_estreiafilme;
        private TextBox txt_duracaofilme;
        private ComboBox cmb_categoria;
    }
}