namespace lanches_damaju
{
    partial class Menu
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
            this.button_fechar = new System.Windows.Forms.Button();
            this.cad_pro = new System.Windows.Forms.Button();
            this.consultar_prod = new System.Windows.Forms.Button();
            this.consultar_clientes = new System.Windows.Forms.Button();
            this.cad_clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_fechar
            // 
            this.button_fechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_fechar.Location = new System.Drawing.Point(316, 389);
            this.button_fechar.Name = "button_fechar";
            this.button_fechar.Size = new System.Drawing.Size(115, 49);
            this.button_fechar.TabIndex = 0;
            this.button_fechar.Text = "Fechar";
            this.button_fechar.UseVisualStyleBackColor = true;
            this.button_fechar.Click += new System.EventHandler(this.button_fechar_Click);
            // 
            // cad_pro
            // 
            this.cad_pro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cad_pro.Location = new System.Drawing.Point(175, 75);
            this.cad_pro.Name = "cad_pro";
            this.cad_pro.Size = new System.Drawing.Size(117, 42);
            this.cad_pro.TabIndex = 1;
            this.cad_pro.Text = "Cadastro de Produtos";
            this.cad_pro.UseVisualStyleBackColor = true;
            this.cad_pro.Click += new System.EventHandler(this.cad_pro_Click);
            // 
            // consultar_prod
            // 
            this.consultar_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consultar_prod.Location = new System.Drawing.Point(175, 181);
            this.consultar_prod.Name = "consultar_prod";
            this.consultar_prod.Size = new System.Drawing.Size(117, 42);
            this.consultar_prod.TabIndex = 2;
            this.consultar_prod.Text = "Consultar Produtos";
            this.consultar_prod.UseVisualStyleBackColor = true;
            this.consultar_prod.Click += new System.EventHandler(this.consultar_prod_Click);
            // 
            // consultar_clientes
            // 
            this.consultar_clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consultar_clientes.Location = new System.Drawing.Point(432, 181);
            this.consultar_clientes.Name = "consultar_clientes";
            this.consultar_clientes.Size = new System.Drawing.Size(117, 42);
            this.consultar_clientes.TabIndex = 3;
            this.consultar_clientes.Text = "Consultar Clientes";
            this.consultar_clientes.UseVisualStyleBackColor = true;
            this.consultar_clientes.Click += new System.EventHandler(this.consultar_clientes_Click);
            // 
            // cad_clientes
            // 
            this.cad_clientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cad_clientes.Location = new System.Drawing.Point(432, 75);
            this.cad_clientes.Name = "cad_clientes";
            this.cad_clientes.Size = new System.Drawing.Size(117, 42);
            this.cad_clientes.TabIndex = 4;
            this.cad_clientes.Text = "Cadastro de Clientes";
            this.cad_clientes.UseVisualStyleBackColor = true;
            this.cad_clientes.Click += new System.EventHandler(this.cad_clientes_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lanches_damaju.Properties.Resources.menu_lanche;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cad_clientes);
            this.Controls.Add(this.consultar_clientes);
            this.Controls.Add(this.consultar_prod);
            this.Controls.Add(this.cad_pro);
            this.Controls.Add(this.button_fechar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_fechar;
        private System.Windows.Forms.Button cad_pro;
        private System.Windows.Forms.Button consultar_prod;
        private System.Windows.Forms.Button consultar_clientes;
        private System.Windows.Forms.Button cad_clientes;
    }
}