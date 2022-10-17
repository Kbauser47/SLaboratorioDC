using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLaboratorioDC
{
    public partial class Form1 : Form
    {
        DeCola d = new DeCola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsDe_Click(object sender, EventArgs e)
        {

            string x = txtnum.Text;
            if (d.Llena())
                MessageBox.Show("Error: La decola esta llena");
            else
            {
                d.InsertarDelante(x);
                listMus.Items.Add(x);
            }

        }

        private void btnElimDe_Click(object sender, EventArgs e)
        {

            string x;
            if (d.Vacia())
                MessageBox.Show("Error: La decola esta VACIA");
            else
            {
                x = d.EliminarDelante();
                listMus.Items.Remove(x);
            }

        }

        private void btnInsTra_Click(object sender, EventArgs e)
        {

            string x = txtnum.Text;
            if (d.Llena())
                MessageBox.Show("Error: La decola esta llena");
            else
            {
                d.InsertarDetras(x);
                listMus.Items.Add(x);
            }

        }

        private void btnElimtra_Click(object sender, EventArgs e)
        {

            string x;
            if (d.Vacia())
                MessageBox.Show("Error: La decola esta VACIA");
            else
            {
                x = d.EliminarDetras();
                listMus.Items.Remove(x);
            }

        }
    }
}
