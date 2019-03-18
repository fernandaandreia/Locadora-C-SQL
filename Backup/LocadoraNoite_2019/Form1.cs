using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocadoraNoite_2019
{
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable tblfuncionarios;

        string strsql, strconexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Entrar_Click(object sender, EventArgs e)
        {

            strconexao = "data source = (local); initial catalog = locadora; integrated security = sspi";
            conexao = new SqlConnection(strconexao);
            conexao.Open();

            tblfuncionarios = new DataTable();

            strsql = "select * from funcionarios where usuario = '"+txt_Usuario.Text+"' and senha = '"+txt_Senha.Text+"'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblfuncionarios);

            //verifica se algum registro foi selecionado
            if (tblfuncionarios.Rows.Count == 1)
            {

                string nome = tblfuncionarios.Rows[0]["nomefunc"].ToString();

                Menu menu = new Menu();
                menu.FuncionarioLogado = "Sr(a). " + nome;
                menu.Show();

            }
            else
            {

                MessageBox.Show("Usuário ou Senha incorretos!!!",
                                "Alerta",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);

            }

        }
    }
}
