namespace lanches_damaju
{
    partial class Gerenciamento_Clientes
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
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.button_consultar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(12, 21);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.Size = new System.Drawing.Size(392, 340);
            this.dgv_clientes.TabIndex = 0;
            // 
            // button_consultar
            // 
            this.button_consultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_consultar.Location = new System.Drawing.Point(542, 21);
            this.button_consultar.Name = "button_consultar";
            this.button_consultar.Size = new System.Drawing.Size(113, 49);
            this.button_consultar.TabIndex = 1;
            this.button_consultar.Text = "Consultar Clientes";
            this.button_consultar.UseVisualStyleBackColor = true;
            this.button_consultar.Click += new System.EventHandler(this.button_consultar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_excluir.Location = new System.Drawing.Point(542, 117);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(113, 43);
            this.button_excluir.TabIndex = 2;
            this.button_excluir.Text = "Excluir Clientes";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_fechar
            // 
            this.button_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_fechar.Location = new System.Drawing.Point(542, 212);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(113, 43);
            this.button_fechar.TabIndex = 3;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // Gerenciamento_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lanches_damaju.Properties.Resources.menu_lanche;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_fechar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_consultar);
            this.Controls.Add(this.dgv_clientes);
            this.Name = "Gerenciamento_Clientes";
            this.Text = "Gerenciamento_Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.Button button_consultar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_fechar;
    }
}