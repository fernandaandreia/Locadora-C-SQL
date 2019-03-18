using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LocadoraNoite_2019
{
    public partial class Menu : Form
    {
       public string FuncionarioLogado;
       public string Nivel_do_Funcionario;

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Text = FuncionarioLogado;

            if (Nivel_do_Funcionario == "1")
            {
                relatóriosToolStripMenuItem.Visible = false;
                configurarToolStripMenuItem.Visible = false;
                apagarToolStripMenuItem.Visible = false;
                alterarSenhaToolStripMenuItem.Visible = false;
            }
            else if (Nivel_do_Funcionario == "2")
            {
                relatóriosToolStripMenuItem.Visible = false;
                configurarToolStripMenuItem.Visible = false;
            }
        }

        private void porPaísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cons_Cliente_Pais cons_cli_pais = new Cons_Cliente_Pais();
            cons_cli_pais.Show();
        }
    }
}
