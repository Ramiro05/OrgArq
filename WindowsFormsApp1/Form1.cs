using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int[] memoria = new int[255];
        int dTag, dLinha, mTag, mLinha, mPalavra;

        public Form1()
        {
            InitializeComponent();
        }

        private void rd0_CheckedChanged(object sender, EventArgs e)
        {
            if (rd0.Checked)
            {
                txtTipo.Text = "D";

                txtTag.Text = "3";
                dTag = 5;
                mTag = 224;

                txtLinha.Text = "2";
                dLinha = 3;
                mLinha = 24;

                txtPalavra.Text = "3";
                mPalavra = 7;

                txtCacheL.Text = "4";
                txtCacheP.Text = "8";
            }
        }

        private void rd1_CheckedChanged(object sender, EventArgs e)
        {
            if (rd1.Checked)
            {
                txtTipo.Text = "D";
                txtTag.Text = "3";
                dTag = 5;
                mTag = 224;

                txtLinha.Text = "3";
                dLinha = 2;
                mLinha = 28;

                txtPalavra.Text = "2";
                mPalavra = 3;

                txtCacheL.Text = "8";
                txtCacheP.Text = "4";
            }
        }

        private void rd2_CheckedChanged(object sender, EventArgs e)
        {
            if (rd2.Checked)
            {
                txtTipo.Text = "D";

                txtTag.Text = "3";
                dTag = 5;
                mTag = 224;

                txtLinha.Text = "4";
                dLinha = 1;
                mLinha = 30;

                txtPalavra.Text = "1";
                mPalavra = 1;

                txtCacheL.Text = "16";
                txtCacheP.Text = "2";
            }
        }

        private void rd3_CheckedChanged(object sender, EventArgs e)
        {
            if (rd3.Checked)
            {
                txtTipo.Text = "A";

                txtTag.Text = "5";
                dTag = 3;
                mTag = 248;

                txtLinha.Text = "-";

                txtPalavra.Text = "3";
                mPalavra = 7;

                txtCacheL.Text = "4";
                txtCacheP.Text = "8";
            }
        }

        private void rd4_CheckedChanged(object sender, EventArgs e)
        {
            if (rd4.Checked)
            {
                txtTipo.Text = "A";

                txtTag.Text = "6";
                dTag = 2;
                mTag = 252;

                txtLinha.Text = "-";

                txtPalavra.Text = "2";
                mPalavra = 3;

                txtCacheL.Text = "8";
                txtCacheP.Text = "4";
            }
        }

        private void rd5_CheckedChanged(object sender, EventArgs e)
        {
            if (rd5.Checked)
            {
                txtTipo.Text = "A";

                txtTag.Text = "7";
                dTag = 1;
                mTag = 254;

                txtLinha.Text = "-";

                txtPalavra.Text = "1";
                mPalavra = 1;

                txtCacheL.Text = "16";
                txtCacheP.Text = "2";
            }
        }

        private void btnExec_Click(object sender, EventArgs e)
        {
            int[,] cache = new int[Convert.ToInt32(txtCacheL.Text), Convert.ToInt32(txtCacheP.Text) + 2];
            int maskTag, maskLinha, maskPalavra;
            
            //Convert.ToInt32(txtCacheL.Text)
            //progB.Maximum = 100;
            //progB.Step = 1;
            //progB.Value = 0;
            // backgroundWorker.RunWorkerAsync();
            ////

            try
            {
                StreamReader rd = new StreamReader(System.Environment.CurrentDirectory.ToString() + "\\Enderecos.txt");
                string linhaArq = null;

                while ((linhaArq = rd.ReadLine()) != null)
                {
                    int endInt = Int32.Parse(linhaArq.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
                    
                    maskTag = (endInt & mTag) >> dTag;
                    maskLinha = (endInt & mLinha) >> dLinha;
                    maskPalavra = (endInt & mPalavra);

                    





                }
                rd.Close();
            }
            catch
            {
                Console.WriteLine("Erro ao executar Leitura do Arquivo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 255; i++)
                memoria[i] = i;
        }

        private int[] getBloco(int end)
        {
            int[] outBloco = new int[8];
            int cont = 0;
            bool hit = false;

            for (int i = 0; i < memoria.Length; i++)
            {
                if (cont < 8)
                {
                    outBloco[cont] = memoria[i];
                
                    if (outBloco[cont] == end )
                        hit = true;

                    cont++;
                }
                else 
                    cont = 0;

                if (cont == 8 && hit)
                    break;                
            }
            return outBloco;
        }
    }
}
//falta fazer
//cache
//contador de hit & miss
//relatorio


//for para percorrer as linhas
//verificar se o verificador é 0 ou 1 [linhas, 0]
//verificar se a linha batem, se sim

//    verificar a tag, se sim é hit(break)

//    se nao busca na memoria


