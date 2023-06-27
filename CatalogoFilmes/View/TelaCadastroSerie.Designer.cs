namespace CatalogoFilmes.View
{
    partial class TelaCadastroSerie
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
            this.cmb_categoriaSERIE = new System.Windows.Forms.ComboBox();
            this.txt_duracaoSERIE = new System.Windows.Forms.TextBox();
            this.txt_estreiaSERIE = new System.Windows.Forms.TextBox();
            this.txt_NomeSERIE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmb_categoriaSERIE
            // 
            this.cmb_categoriaSERIE.FormattingEnabled = true;
            this.cmb_categoriaSERIE.Items.AddRange(new object[] {
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
            this.cmb_categoriaSERIE.Location = new System.Drawing.Point(422, 202);
            this.cmb_categoriaSERIE.Name = "cmb_categoriaSERIE";
            this.cmb_categoriaSERIE.Size = new System.Drawing.Size(121, 23);
            this.cmb_categoriaSERIE.TabIndex = 19;
            // 
            // txt_duracaoSERIE
            // 
            this.txt_duracaoSERIE.Location = new System.Drawing.Point(105, 344);
            this.txt_duracaoSERIE.Name = "txt_duracaoSERIE";
            this.txt_duracaoSERIE.Size = new System.Drawing.Size(124, 23);
            this.txt_duracaoSERIE.TabIndex = 18;
            // 
            // txt_estreiaSERIE
            // 
            this.txt_estreiaSERIE.Location = new System.Drawing.Point(105, 270);
            this.txt_estreiaSERIE.Name = "txt_estreiaSERIE";
            this.txt_estreiaSERIE.Size = new System.Drawing.Size(131, 23);
            this.txt_estreiaSERIE.TabIndex = 17;
            // 
            // txt_NomeSERIE
            // 
            this.txt_NomeSERIE.Location = new System.Drawing.Point(105, 198);
            this.txt_NomeSERIE.Name = "txt_NomeSERIE";
            this.txt_NomeSERIE.Size = new System.Drawing.Size(179, 23);
            this.txt_NomeSERIE.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(422, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 15;
            this.button1.Text = "CADASTRO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(105, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "DURACAO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(422, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "CATEGORIA DA SERIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "ESTREIA DO SERIE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "NOME DO SERIE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 46);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cadastro SERIE";
            // 
            // TelaCadastroSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 450);
            this.Controls.Add(this.cmb_categoriaSERIE);
            this.Controls.Add(this.txt_duracaoSERIE);
            this.Controls.Add(this.txt_estreiaSERIE);
            this.Controls.Add(this.txt_NomeSERIE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroSerie";
            this.Text = "TelaCadastroSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmb_categoriaSERIE;
        private TextBox txt_duracaoSERIE;
        private TextBox txt_estreiaSERIE;
        private TextBox txt_NomeSERIE;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}