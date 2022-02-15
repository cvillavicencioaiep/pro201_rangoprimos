using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace rangoprimos
{
    public partial class Presentacion : Form
    {
        public Presentacion()
        {
            InitializeComponent();
            comboBox1.Items.Add("1-99");
            comboBox1.Items.Add("100-999");
            comboBox1.Items.Add("1000-9999");
            comboBox1.Items.Add("10000-99999");
            comboBox1.Items.Add("100000-999999");
            comboBox1.Items.Add("100000-1999999");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string opcion = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string[] limites = opcion.Split('-');
            int ini = Convert.ToInt32(limites[0]);
            int fin = Convert.ToInt32(limites[1]);

            NegocioPrimo a = new NegocioPrimo();
            int[] resultado = a.cantPrimo(ini, fin);
            desde.Text = limites[0];
            hasta.Text = limites[1];
            menor.Text = Convert.ToString(resultado[0]);
            mayor.Text = Convert.ToString(resultado[1]);
            cant.Text = Convert.ToString(resultado[2]);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            tiempo.Text = elapsedTime;
            obs.Text = "Se han analizado " + (fin - ini) + " números,\n" + ((fin - ini) - resultado[2]) + " de ellos son números compuestos";
            toolStripStatusLabel1.Text = "Análisis completo";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }
    }
}
