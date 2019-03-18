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
    public partial class Cons_Cliente_Pais : Form
    {
        SqlConnection conexao;
        SqlDataAdapter adapter;
        DataTable tblclientes;
        string strsql, strconexao;

        public Cons_Cliente_Pais()
        {
            InitializeComponent();
        }

        private void Cons_Cliente_Pais_Load(object sender, EventArgs e)
        {

        }

        private void bt_Pesq_Click(object sender, EventArgs e)
        {
            strconexao = "data source = (local); initial catalog = locadora; integrated security = sspi";

            conexao = new SqlConnection(strconexao);
            conexao.Open();

            tblclientes = new DataTable();

            strsql = "select * from clientes where cidade ='" + txt_Pais.Text + "'";
            adapter = new SqlDataAdapter(strsql, conexao);
            adapter.Fill(tblclientes);

            Grade.DataSource = tblclientes;
        }
    }
}
