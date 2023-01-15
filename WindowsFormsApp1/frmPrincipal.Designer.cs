namespace WindowsFormsApp1
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnAcoes = new System.Windows.Forms.Button();
            this.pnlCadastros = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlMenu.Controls.Add(this.btnPedidos);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnProdutos);
            this.pnlMenu.Controls.Add(this.btnUsuario);
            this.pnlMenu.Controls.Add(this.btnAcoes);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(160, 629);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidos.Location = new System.Drawing.Point(0, 233);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Padding = new System.Windows.Forms.Padding(5, 10, 30, 0);
            this.btnPedidos.Size = new System.Drawing.Size(160, 62);
            this.btnPedidos.TabIndex = 8;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            this.btnPedidos.MouseEnter += new System.EventHandler(this.btnProdutos_MouseEnter);
            this.btnPedidos.MouseLeave += new System.EventHandler(this.btnProdutos_MouseLeave);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 171);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(5, 10, 30, 0);
            this.btnClientes.Size = new System.Drawing.Size(160, 62);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes  ";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            this.btnClientes.MouseEnter += new System.EventHandler(this.btnProdutos_MouseEnter);
            this.btnClientes.MouseLeave += new System.EventHandler(this.btnProdutos_MouseLeave);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProdutos.Location = new System.Drawing.Point(0, 109);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(0);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Padding = new System.Windows.Forms.Padding(5, 10, 30, 0);
            this.btnProdutos.Size = new System.Drawing.Size(160, 62);
            this.btnProdutos.TabIndex = 6;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            this.btnProdutos.MouseEnter += new System.EventHandler(this.btnProdutos_MouseEnter);
            this.btnProdutos.MouseLeave += new System.EventHandler(this.btnProdutos_MouseLeave);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuario.Location = new System.Drawing.Point(0, 47);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Padding = new System.Windows.Forms.Padding(5, 10, 30, 0);
            this.btnUsuario.Size = new System.Drawing.Size(160, 62);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Text = "Usuários";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button5_Click);
            this.btnUsuario.MouseEnter += new System.EventHandler(this.btnProdutos_MouseEnter);
            this.btnUsuario.MouseLeave += new System.EventHandler(this.btnProdutos_MouseLeave);
            // 
            // btnAcoes
            // 
            this.btnAcoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAcoes.FlatAppearance.BorderSize = 0;
            this.btnAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcoes.Image = ((System.Drawing.Image)(resources.GetObject("btnAcoes.Image")));
            this.btnAcoes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAcoes.Location = new System.Drawing.Point(0, 0);
            this.btnAcoes.Margin = new System.Windows.Forms.Padding(0);
            this.btnAcoes.Name = "btnAcoes";
            this.btnAcoes.Size = new System.Drawing.Size(160, 47);
            this.btnAcoes.TabIndex = 1;
            this.btnAcoes.Text = "Ações";
            this.btnAcoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAcoes.UseVisualStyleBackColor = true;
            this.btnAcoes.Click += new System.EventHandler(this.button1_Click);
            this.btnAcoes.MouseEnter += new System.EventHandler(this.btnProdutos_MouseEnter);
            this.btnAcoes.MouseLeave += new System.EventHandler(this.btnProdutos_MouseLeave);
            // 
            // pnlCadastros
            // 
            this.pnlCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlCadastros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCadastros.Location = new System.Drawing.Point(160, 0);
            this.pnlCadastros.Name = "pnlCadastros";
            this.pnlCadastros.Size = new System.Drawing.Size(1006, 629);
            this.pnlCadastros.TabIndex = 1;
            this.pnlCadastros.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1166, 629);
            this.Controls.Add(this.pnlCadastros);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja 1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPrincipal_MouseDown);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAcoes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Panel pnlCadastros;
    }
}