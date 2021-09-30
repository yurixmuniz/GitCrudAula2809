
namespace CrudAula2809
{
    partial class FrmFuncionarios
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.lb_pesquisar = new System.Windows.Forms.Label();
            this.dv_funcionarios = new System.Windows.Forms.DataGridView();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.pnl_campos = new System.Windows.Forms.Panel();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dv_funcionarios)).BeginInit();
            this.pnl_campos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_cancelar.Location = new System.Drawing.Point(476, 286);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(111, 36);
            this.btn_cancelar.TabIndex = 29;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.AutoSize = true;
            this.btn_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_remover.Location = new System.Drawing.Point(476, 244);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(111, 36);
            this.btn_remover.TabIndex = 30;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.AutoSize = true;
            this.btn_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_atualizar.Location = new System.Drawing.Point(476, 202);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(111, 36);
            this.btn_atualizar.TabIndex = 31;
            this.btn_atualizar.Text = "Atualizar";
            this.btn_atualizar.UseVisualStyleBackColor = true;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.AutoSize = true;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_salvar.Location = new System.Drawing.Point(476, 161);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(111, 36);
            this.btn_salvar.TabIndex = 32;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_codigo.Location = new System.Drawing.Point(46, 133);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(81, 26);
            this.lb_codigo.TabIndex = 25;
            this.lb_codigo.Text = "Código";
            // 
            // btn_novo
            // 
            this.btn_novo.AutoSize = true;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btn_novo.Location = new System.Drawing.Point(476, 119);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(111, 36);
            this.btn_novo.TabIndex = 33;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // lb_pesquisar
            // 
            this.lb_pesquisar.AutoSize = true;
            this.lb_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_pesquisar.Location = new System.Drawing.Point(32, 311);
            this.lb_pesquisar.Name = "lb_pesquisar";
            this.lb_pesquisar.Size = new System.Drawing.Size(109, 26);
            this.lb_pesquisar.TabIndex = 26;
            this.lb_pesquisar.Text = "Pesquisar";
            // 
            // dv_funcionarios
            // 
            this.dv_funcionarios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dv_funcionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dv_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dv_funcionarios.Location = new System.Drawing.Point(31, 367);
            this.dv_funcionarios.Name = "dv_funcionarios";
            this.dv_funcionarios.ReadOnly = true;
            this.dv_funcionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dv_funcionarios.Size = new System.Drawing.Size(566, 263);
            this.dv_funcionarios.TabIndex = 34;
            this.dv_funcionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_funcionarios_CellDoubleClick);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_pesquisar.Location = new System.Drawing.Point(147, 311);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(306, 32);
            this.txt_pesquisar.TabIndex = 28;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            this.txt_pesquisar.DoubleClick += new System.EventHandler(this.txt_pesquisar_DoubleClick);
            // 
            // pnl_campos
            // 
            this.pnl_campos.Controls.Add(this.txt_senha);
            this.pnl_campos.Controls.Add(this.txt_login);
            this.pnl_campos.Controls.Add(this.txt_nome);
            this.pnl_campos.Controls.Add(this.lb_senha);
            this.pnl_campos.Controls.Add(this.lb_login);
            this.pnl_campos.Controls.Add(this.lb_nome);
            this.pnl_campos.Location = new System.Drawing.Point(37, 166);
            this.pnl_campos.Name = "pnl_campos";
            this.pnl_campos.Size = new System.Drawing.Size(431, 119);
            this.pnl_campos.TabIndex = 27;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_senha.Location = new System.Drawing.Point(90, 81);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(324, 32);
            this.txt_senha.TabIndex = 1;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_login.Location = new System.Drawing.Point(90, 43);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(324, 32);
            this.txt_login.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txt_nome.Location = new System.Drawing.Point(90, 4);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(324, 32);
            this.txt_nome.TabIndex = 1;
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_senha.Location = new System.Drawing.Point(9, 87);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(75, 26);
            this.lb_senha.TabIndex = 0;
            this.lb_senha.Text = "Senha";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_login.Location = new System.Drawing.Point(19, 49);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(65, 26);
            this.lb_login.TabIndex = 0;
            this.lb_login.Text = "Login";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_nome.Location = new System.Drawing.Point(13, 10);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(71, 26);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome";
            // 
            // FrmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 665);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.lb_pesquisar);
            this.Controls.Add(this.dv_funcionarios);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.pnl_campos);
            this.Name = "FrmFuncionarios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dv_funcionarios)).EndInit();
            this.pnl_campos.ResumeLayout(false);
            this.pnl_campos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Label lb_pesquisar;
        private System.Windows.Forms.DataGridView dv_funcionarios;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.Panel pnl_campos;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_nome;
    }
}

