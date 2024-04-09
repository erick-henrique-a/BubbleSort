using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace trabalho
{
    public partial class Form1 : Form
    {
        Stopwatch timer;
        int[] vetor = new int[10000];
        Random ale = new Random();
        public Form1()
        {
            InitializeComponent();
            chart1.Series.Clear();

            chart1.Series.Add("Não Otimizado");
            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.Series.Add("Otimizado");
            chart1.Series[1].ChartType = SeriesChartType.Line;

            chart1.Series.Add("Complexidade");
            chart1.Series[2].ChartType = SeriesChartType.Line;

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = ale.Next(20000);
            }
        }
        public Stopwatch bubblesortruim(int[] array)
 {
            int temp;
            int[] ord = new int[array.Length];
            array.CopyTo(ord, 0);
            timer = new Stopwatch();
            timer.Start();
            for (int j = 0; j < ord.Length; j++)
        {
            for (int i = 0; i < ord.Length-1; i++)
            {
                if (ord[i] > ord[i + 1])
                {
                    temp = ord[i + 1];
                    ord[i + 1] = ord[i];
                    ord[i] = temp;
                }
            }
            }
            timer.Stop();
        return timer;
}
        public Stopwatch bubblesortbom(int[] array)
        {
            int temp;
            bool boo;
            int[] ord = new int[array.Length];
            array.CopyTo(ord, 0);
            timer = new Stopwatch();
            timer.Start();
            for (int j = 0; j < ord.Length; j++)
            {
                boo = true;
                for (int i = 0; i < ord.Length - i - 1; i++)
                {
                    if (ord[i] > ord[i + 1])
                    {
                        boo = false;
                        temp = ord[i + 1];
                        ord[i + 1] = ord[i];
                        ord[i] = temp;
                    }
                }
                if(boo == true)
                {
                    break;
                }
            }
            timer.Stop();
            return timer;
        }
        private void medio_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double constante=0;
            int count=0;
            for (int i = 0; i <= 10000; i = i + 200, count++)
            {
                int[] fra = new int[i];
                Array.Copy(vetor, 0, fra, 0, i);//copia de um pro outro do indice 0 para o indice 0, o i e o limite
                Stopwatch bom = bubblesortbom(fra);
                Stopwatch ruim = bubblesortruim(fra);
                chart1.Series[0].Points.Add((int)ruim.ElapsedMilliseconds);
                chart1.Series[1].Points.Add((int)bom.ElapsedMilliseconds);
                while ((count * count * constante < (double)ruim.ElapsedMilliseconds) && (count * count * constante < (double)ruim.ElapsedMilliseconds))
                {
                    constante += 0.000001;
                }
            }
            for (int i = 0; i < chart1.Series[0].Points.Count; i++)
            {
                chart1.Series[2].Points.Add(i * i * constante);
            }
        }

        private void pior_Click(object sender, EventArgs e)
        {
            int[] pior = new int[vetor.Length];
            for(int i = 0; i < 10000; i++)
            {
                pior[i] = 10000-i;
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double constante = 0;
            int count = 0;
            for (int i = 0; i <= 10000; i = i + 200, count++)
            {
                int[] fra = new int[i];
                Array.Copy(pior, 0, fra, 0, i);//copia de um pro outro do indice 0 para o indice 0, o i e o limite
                Stopwatch bom = bubblesortbom(fra);
                Stopwatch ruim = bubblesortruim(fra);
                chart1.Series[0].Points.Add((int)ruim.ElapsedMilliseconds);
                chart1.Series[1].Points.Add((int)bom.ElapsedMilliseconds);
                while ((count * count * constante < (double)ruim.ElapsedMilliseconds) && (count * count * constante < (double)ruim.ElapsedMilliseconds))
                {
                    constante += 0.000001;
                }
            }
            for (int i = 0; i < chart1.Series[0].Points.Count; i++)
            {
                chart1.Series[2].Points.Add(i * i * constante);
            }
        }

        private void melhor_click(object sender, EventArgs e)
        {
            int[] melhor = new int[vetor.Length];
            for(int i = 0; i < 10000; i++)
            {
                melhor[i] = i;
            }
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            double constante = 0;
            int count = 0;
            for (int i = 0; i <= 10000; i = i + 200, count++)
            {
                int[] fra = new int[i];
                Array.Copy(melhor, 0, fra, 0, i);//copia de um pro outro do indice 0 para o indice 0, o i e o limite
                Stopwatch bom = bubblesortbom(fra);
                Stopwatch ruim = bubblesortruim(fra);
                chart1.Series[0].Points.Add((int)ruim.ElapsedMilliseconds);
                chart1.Series[1].Points.Add((int)bom.ElapsedMilliseconds);
                while ((count * count * constante < (double)ruim.ElapsedMilliseconds) && (count * count * constante < (double)ruim.ElapsedMilliseconds))
                {
                    constante += 0.000001;
                }
            }
            for (int i = 0; i < chart1.Series[0].Points.Count; i++)
            {
                chart1.Series[2].Points.Add(i * i * constante);
            }
        }
    }
}
