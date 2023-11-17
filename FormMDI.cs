using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manipulacao
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void FormMDI_Load(object sender, EventArgs e)
        {
            

            //this.IsMdiConteiner = true;
            Form1 f =  new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exemplo de instruções associadas à opção Novo do menu
            Form1 f = new Form1();
            f.MdiParent = this;
            f.Show();
        }

        private void tsGuardar_Click(object sender, EventArgs e)
        {
            //exemplo de instruções associadas à ferramenta Guardar
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja guardar o ficheiro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                timer1.Enabled = true;
                barraProgresso.Value = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (barraProgresso.Value <= barraProgresso.Maximum - 1)
            {
                barraProgresso.Value += 1;
            }
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
