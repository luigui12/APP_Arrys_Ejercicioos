using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_Arrys_Ejercicioos
{
    public partial class Form1 : Form
    {
        private int conta = 0;
        private const int Max = 100;
        private double[] vector = new double[Max];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conta < Max)
                {
                    vector[conta] = int.Parse(this.numero.Text);
                }
                conta++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            for (int i=0;i<conta;i++)
            {
                this.lista.Items.Add(vector[i]);
            }
            this.suma.Text = sumatoria().ToString();
            this.promedio1.Text = promedio().ToString();
        }

        private double sumatoria() {
            double suma = 0;
            for (int i=0;i<conta;i++)
            {
                suma = suma + vector[i];
            }
            return suma;
        }
        private double promedio()
        {
            return (sumatoria()/conta);
        }
    }
}
