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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(396, 86);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(210, 20);
            this.textBox_nome.TabIndex = 5;
            // 
            // richTextBox_descricao
            // 
            this.richTextBox_descricao.Location = new System.Drawing.Point(396, 168);
            this.richTextBox_descricao.Name = "richTextBox_descricao";
            this.richTextBox_descricao.Size = new System.Drawing.Size(210, 148);
            this.richTextBox_descricao.TabIndex = 8;
            this.richTextBox_descricao.Text = "";
            // 
            // textBox_cat
            // 
            this.textBox_cat.Location = new System.Drawing.Point(396, 348);
            this.textBox_cat.Name = "textBox_cat";
            this.textBox_cat.Size = new System.Drawing.Size(210, 20);
            this.textBox_cat.TabIndex = 9;
            // 
            // maskedTextBox_valor
            // 
            this.maskedTextBox_valor.Location = new System.Drawing.Point(396, 130);
            this.maskedTextBox_valor.Mask = "$000,00";
            this.maskedTextBox_valor.Name = "maskedTextBox_valor";
            this.maskedTextBox_valor.Size = new System.Drawing.Size(210, 20);
            this.maskedTextBox_valor.TabIndex = 10;
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Location = new System.Drawing.Point(377, 415);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(75, 23);
            this.button_cadastrar.TabIndex = 11;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Location = new System.Drawing.Point(492, 415);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(75, 23);
            this.button_fechar.TabIndex = 12;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            // 
            // button_limpar
            // 
            this.button_limpar.Location = new System.Drawing.Point(588, 415);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(105, 23);
            this.button_limpar.TabIndex = 13;
            this.button_limpar.Text = "limpar campos ";
            this.button_limpar.UseVisualStyleBackColor = true;
            // 
            // produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lanches_damaju.Properties.Resources.menu_lanche;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 450);
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
            this.Text = "produtos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
    }
}

