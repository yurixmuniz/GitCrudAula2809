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
    public partial class FrmTeste : Form
    {
        public FrmTeste()
        {
            InitializeComponent();
        }

        private void FrmTeste_Load(object sender, EventArgs e)
        {
            txt_nome.Enabled = false;
            btn_salvar.Enabled = false;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            btn_novo.Enabled = false;
            txt_nome.Enabled = true;
            btn_salvar.Enabled = true;
            txt_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Conexao.ObterConexao();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            btn_novo.Enabled = false;
            if (txt_nome.Text == "")
            {
                MessageBox.Show("há campos vazios.");
            }
            else
            {
                try
                {
                    string strSql = $"Insert into tbl_teste (registro_nome) values ('{txt_nome.Text}')";
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
            txt_nome.Clear();
        }
    }
}
