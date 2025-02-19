namespace lanches_damaju
{
    partial class produtos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.richTextBox_descricao = new System.Windows.Forms.RichTextBox();
            this.textBox_cat = new System.Windows.Forms.TextBox();
            this.maskedTextBox_valor = new System.Windows.Forms.MaskedTextBox();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_imagem = new System.Windows.Forms.PictureBox();
            this.button_escolher_imagem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(206, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(206, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_nome.Location = new System.Drawing.Point(590, 128);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(210, 20);
            this.textBox_nome.TabIndex = 5;
            // 
            // richTextBox_descricao
            // 
            this.richTextBox_descricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox_descricao.Location = new System.Drawing.Point(590, 210);
            this.richTextBox_descricao.Name = "richTextBox_descricao";
            this.richTextBox_descricao.Size = new System.Drawing.Size(210, 39);
            this.richTextBox_descricao.TabIndex = 8;
            this.richTextBox_descricao.Text = "";
            // 
            // textBox_cat
            // 
            this.textBox_cat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_cat.Location = new System.Drawing.Point(590, 390);
            this.textBox_cat.Name = "textBox_cat";
            this.textBox_cat.Size = new System.Drawing.Size(210, 20);
            this.textBox_cat.TabIndex = 9;
            // 
            // maskedTextBox_valor
            // 
            this.maskedTextBox_valor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox_valor.Location = new System.Drawing.Point(590, 172);
            this.maskedTextBox_valor.Mask = "$000,00";
            this.maskedTextBox_valor.Name = "maskedTextBox_valor";
            this.maskedTextBox_valor.Size = new System.Drawing.Size(210, 20);
            this.maskedTextBox_valor.TabIndex = 10;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_cadastrar.Location = new System.Drawing.Point(571, 457);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 11;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_fechar.Location = new System.Drawing.Point(686, 457);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(75, 23);
            this.button_fechar.TabIndex = 12;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_limpar.Location = new System.Drawing.Point(782, 457);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(105, 23);
            this.button_limpar.TabIndex = 13;
            this.button_limpar.Text = "limpar campos ";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(206, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Imagem do produto ";
            // 
            // pictureBox_imagem
            // 
            this.pictureBox_imagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_imagem.Location = new System.Drawing.Point(590, 272);
            this.pictureBox_imagem.Name = "pictureBox_imagem";
            this.pictureBox_imagem.Size = new System.Drawing.Size(210, 50);
            this.pictureBox_imagem.TabIndex = 15;
            this.pictureBox_imagem.TabStop = false;
            // 
            // button_escolher_imagem
            // 
            this.button_escolher_imagem.Location = new System.Drawing.Point(590, 328);
            this.button_escolher_imagem.Name = "button_escolher_imagem";
            this.button_escolher_imagem.Size = new System.Drawing.Size(108, 23);
            this.button_escolher_imagem.TabIndex = 16;
            this.button_escolher_imagem.Text = "Escolher a Imagem";
            this.button_escolher_imagem.UseVisualStyleBackColor = true;
            this.button_escolher_imagem.Click += new System.EventHandler(this.button_escolher_imagem_Click);
            // 
            // produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lanches_damaju.Properties.Resources.menu_lanche;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 535);
            this.Controls.Add(this.button_escolher_imagem);
            this.Controls.Add(this.pictureBox_imagem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.maskedTextBox_valor);
            this.Controls.Add(this.textBox_cat);
            this.Controls.Add(this.richTextBox_descricao);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "produtos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "produtos";
            this.Load += new System.EventHandler(this.produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.RichTextBox richTextBox_descricao;
        private System.Windows.Forms.TextBox textBox_cat;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_valor;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox_imagem;
        private System.Windows.Forms.Button button_escolher_imagem;
    }
}

