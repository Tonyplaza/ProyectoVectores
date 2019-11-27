using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVectores
{
    public partial class Form1 : Form
    {
        private int contador=0;
        private int[] nume;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nume[contador] = int.Parse(this.txtNum.Text);
            contador = contador + 1;
            this.lstNum.Items.Add(nume[contador]);
            this.lstNum.Sorted = true;

        }
        private void lstNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            double a = promedio( contador, nume);
            int suma = sumatoria(contador, nume);
            this.txtProm.Text = a.ToString();
            this.txtSum.Text = suma.ToString();
        }
        private static double promedio( int contador, int[] nume)
        {
            int prom,suma=0;
             for (int i = 0; i < contador  ; i++)
            {
                suma = suma + nume[i];
            }
            prom = suma / contador;
            return prom;
        }
        private static int sumatoria(int contador, int[] nume)
        {
            int  suma = 0;
            for (int i = 0; i < contador; i++)
            {
                suma = suma + nume[i];
            }
            return suma;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
