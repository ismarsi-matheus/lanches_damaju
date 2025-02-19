namespace lanches_damaju
{
    partial class consulta_prod
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
            this.dgv_prod = new System.Windows.Forms.DataGridView();
            this.button_produto = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_prod
            // 
            this.dgv_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_prod.Location = new System.Drawing.Point(12, 12);
            this.dgv_prod.Name = "dgv_prod";
            this.dgv_prod.Size = new System.Drawing.Size(444, 362);
            this.dgv_prod.TabIndex = 0;
            // 
            // button_produto
            // 
            this.button_produto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_produto.Location = new System.Drawing.Point(550, 44);
            this.button_produto.Name = "button_produto";
            this.button_produto.Size = new System.Drawing.Size(144, 46);
            this.button_produto.TabIndex = 1;
            this.button_produto.Text = "Consultar Produtos";
            this.button_produto.UseVisualStyleBackColor = true;
            this.button_produto.Click += new System.EventHandler(this.button_produto_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_excluir.Location = new System.Drawing.Point(550, 131);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(144, 46);
            this.button_excluir.TabIndex = 2;
            this.button_excluir.Text = "Excluir produtos ";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_fechar.Location = new System.Drawing.Point(550, 217);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(144, 46);
            this.button_fechar.TabIndex = 3;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // consulta_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lanches_damaju.Properties.Resources.menu_lanche;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_produto);
            this.Controls.Add(this.dgv_prod);
            this.Name = "consulta_prod";
            this.Text = "consulta_prod";
            this.Load += new System.EventHandler(this.consulta_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prod)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_prod;
        private System.Windows.Forms.Button button_produto;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_fechar;
    }
}