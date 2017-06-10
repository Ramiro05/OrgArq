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
        int[] memoria = new int[256];
        int dTag, dLinha, mTag, mLinha, mPalavra;
        int miss = 0, hit = 0;

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 256; i++)
                memoria[i] = i;
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
            miss = 0; hit = 0;
            int[,] cache = new int[Convert.ToInt32(txtCacheL.Text), Convert.ToInt32(txtCacheP.Text) + 2];

            for (int i = 0; i < cache.GetLength(0); i++)
                cache[i, 1] = -1;

            int maskTag, maskLinha; // maskPalavra; sem uso


            //Convert.ToInt32(txtCacheL.Text)
            //progB.Maximum = 100;
            //progB.Step = 1;
            //progB.Value = 0;
            // backgroundWorker.RunWorkerAsync();            

            try
            {
                StreamReader rd = new StreamReader(System.Environment.CurrentDirectory.ToString() + "\\Enderecos.txt");
                string linhaArq = null;


                while ((linhaArq = rd.ReadLine()) != null)
                {
                    int endInt = Int32.Parse(linhaArq.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);

                    maskTag = (endInt & mTag) >> dTag;
                    maskLinha = (endInt & mLinha) >> dLinha;
                    //maskPalavra = (endInt & mPalavra); sem uso

                    if (txtTipo.Text == "D")
                        mapDireto(maskLinha, cache, endInt);
                    else if (txtTipo.Text == "A")
                        mapAssociativo(maskTag, cache, endInt);
                }
                rd.Close();

                lbResult.Text = "Miss: " + miss + " - Hit: " + hit;
            }
            catch
            {
                Console.WriteLine("Erro ao executar Leitura do Arquivo");
            }

        }        

        private int[] getBloco(int end)
        {
            int[] outBloco = new int[Convert.ToInt32(txtCacheP.Text)];
            int cont = 0;
            bool hit = false;

            for (int i = 0; i < memoria.Length; i++)
            {
                if (cont < outBloco.Length)
                {
                    outBloco[cont] = memoria[i];

                    if (outBloco[cont] == end)
                        hit = true;

                    cont++;
                }
                else
                {
                    cont = 0;
                    outBloco[cont] = memoria[i];
                    cont++;
                }

                if (cont == outBloco.Length && hit)
                    break;
            }
            return outBloco;
        }

        private void mapDireto(int maskLinha, int[,] cache, int endInt)
        {
            int[] outBloco = new int[Convert.ToInt32(txtCacheP.Text)];            
            bool deuHit = false;

            if (cache[maskLinha, 0] == 0)
            {
                cache[maskLinha, 0] = 1;
                miss++;
                outBloco = getBloco(endInt);

                for (int i = 2; i < cache.GetLength(1); i++)
                    cache[maskLinha, i] = outBloco[i - 2];
            }
            else
            {
                for (int i = 2; i < cache.GetLength(1); i++)
                {
                    if (cache[maskLinha, i] == endInt)
                    {
                        deuHit = true;
                        hit++;
                    }
                }

                if (!deuHit)
                {
                    miss++;
                    outBloco = getBloco(endInt);

                    for (int x = 2; x < cache.GetLength(1); x++)
                        cache[maskLinha, x] = outBloco[x - 2];
                }
            }            
        }

        private void mapAssociativo(int maskTag, int[,] cache, int endInt)
        {
            int[] outBloco = new int[Convert.ToInt32(txtCacheP.Text)];

            for (int i = 0; i < cache.GetLength(0); i++)
            {
                if (cache[i, 1] < 0)
                {
                    cache[i, 1] = maskTag;
                    miss++;
                    outBloco = getBloco(endInt);

                    cache[i, 0]++;

                    for (int x = 2; x < cache.GetLength(1); x++)
                        cache[i, x] = outBloco[x - 2];

                    break;
                }
                else
                {
                    if (cache[i, 1] == maskTag)
                    {
                        cache[i, 0]++;
                        hit++;
                        break;
                    }
                }
            }

            //politica de substituição

            int val = 0, menor = cache[0, 0];

            for (int z = 1; z < cache.GetLength(0); z++)
            {
                if (cache[z, 0] < menor)
                {
                    menor = cache[z, 0];
                    val = z;
                }
            }

            miss++;
            outBloco = getBloco(endInt);

            for (int x = 2; x < cache.GetLength(1); x++)
                cache[val, x] = outBloco[x-2];            
        }
    }
}
//

