using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudAula2809
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }
        private void LimparTextBoxes(Control.ControlCollection controles)
        {
            foreach(Control ctrl in controles)
            {
                if(ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }

        public void Disable()
        {
            pnl_campos.Enabled = false;
            btn_atualizar.Enabled = false;
            btn_cancelar.Enabled = false;
            btn_remover.Enabled = false;
            btn_salvar.Enabled = false;
        }
        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            Disable();
        }
        private void dv_funcionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarAtendente();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            pnl_campos.Enabled = true;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            txt_nome.Focus();

            //SqlConnection connection = Conexao.ObterConexao();

            //if (connection == null)
            //{
            //    MessageBox.Show("impossivel obter conexão.");
            //}
            //else
            //{
            //    MessageBox.Show("conexão feita com sucesso.");
            //}

            //Conexao.FecharConexao();


        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Conexao.ObterConexao();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            btn_novo.Enabled = false;
            if(txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("há campos vazios.");
            }
            else
            {
                try
                {
                    string strSql = $"Insert into tbl_atendente (ds_login, ds_senha, nm_atendente) values ('{txt_login.Text}', '{txt_senha.Text}', '{txt_nome.Text}')";
                    command = new SqlCommand(strSql, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("ERRO!");
                    connection.Close();
                }
                finally
                {
                    connection.Close();
                    
                }
            }
            LimparTextBoxes(pnl_campos.Controls);
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = Conexao.ObterConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            if (txt_pesquisar.Text != "")
            {
                try
                {
                    command.CommandText = $"Select * from tbl_atendente where nm_atendente like '%{txt_pesquisar.Text}%' or ds_login like '%{txt_pesquisar.Text}%'";


                    SqlDataAdapter adapter = new SqlDataAdapter();

                    DataTable table = new DataTable();

                    adapter.SelectCommand = command;
                    adapter.Fill(table);

                    dv_funcionarios.DataSource = table;
                }
                catch (Exception erro)
                {
                    MessageBox.Show("\n" + erro);
                    connection.Close();
                }
                finally
                {
                    connection.Close();
                }
            }
            else if(txt_pesquisar.Text == "")
            {
                Seleciona();
            }
            else
            {
                dv_funcionarios.DataSource = null;
                connection.Close();
            }
        
        }

        private void CarregarAtendente()
        {
            lb_codigo.Text = dv_funcionarios.SelectedRows[0].Cells[0].Value.ToString();
            txt_nome.Text = dv_funcionarios.SelectedRows[0].Cells[3].Value.ToString();
            txt_login.Text = dv_funcionarios.SelectedRows[0].Cells[1].Value.ToString();
            txt_senha.Text = dv_funcionarios.SelectedRows[0].Cells[2].Value.ToString();
            pnl_campos.Enabled = true;
            btn_atualizar.Enabled = true;
            btn_remover.Enabled = true;
            btn_cancelar.Enabled = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparTextBoxes(pnl_campos.Controls);
            dv_funcionarios.CurrentRow.Selected = false;
            txt_pesquisar.Clear();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Conexao.ObterConexao();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;
            if (txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("há campos vazios.");
            }
            else
            {
                if (DialogResult.OK == MessageBox.Show($"Tem certeza de que quer alterar o registro de {txt_nome.Text} ?", "ALERTA!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    try
                    {
                        string strSql = $"update tbl_atendente set ds_login = '{txt_login.Text}' , ds_senha = '{txt_senha.Text}', nm_atendente = '{txt_nome.Text}' where cd_atendente = '{Convert.ToInt32(lb_codigo.Text)}'";
                        command = new SqlCommand(strSql, connection);
                        command.ExecuteNonQuery();
                        Disable();
                        btn_novo.Enabled = true;
                        btn_atualizar.Enabled = false;
                        btn_remover.Enabled = false;
                        btn_salvar.Enabled = false;
                        
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("ERRO!");
                        connection.Close();
                    }
                    finally
                    {
                        connection.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Tome mais cuidado!");
                    connection.Close();
                }

            }
            LimparTextBoxes(pnl_campos.Controls);

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Conexao.ObterConexao();
            SqlCommand command = new SqlCommand();
            

            command.Connection = connection;
            
            if (txt_nome.Text == "" || txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("há campos vazios.");
            }
            else
            {
                if(DialogResult.OK == MessageBox.Show($"Tem certeza de que quer excluir o registro de {txt_nome.Text} ?", "ALERTA!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {

                    try
                    {
                        string strSql = $"delete tbl_atendente  where cd_atendente = '{Convert.ToInt32(lb_codigo.Text)}'";
                        command = new SqlCommand(strSql, connection);
                        command.ExecuteNonQuery();
                        txt_pesquisar.Clear();
                        Disable();
                        btn_novo.Enabled = true;
                        btn_atualizar.Enabled = false;
                        btn_remover.Enabled = false;
                        btn_salvar.Enabled = false;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("ERRO!");
                        connection.Close();
                    }
                    finally
                    {
                        connection.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Tome mais cuidado!");
                    connection.Close();
                }
            }
            LimparTextBoxes(pnl_campos.Controls);
        }
        private void txt_pesquisar_DoubleClick(object sender, EventArgs e)
        {
            Seleciona();
        }

        private void Seleciona()
        {
            SqlConnection connection = Conexao.ObterConexao();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = "Select * from tbl_atendente";

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dv_funcionarios.DataSource = table;
            connection.Close();
        }

    }
}
