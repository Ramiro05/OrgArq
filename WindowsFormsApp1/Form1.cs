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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //declarações de escopo global
        int[] memoria = new int[256];
        int dTag, dLinha, mTag, mLinha;
        int miss = 0, hit = 0;
        private Timer time = new Timer();
        private Timer time2 = new Timer();

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 256; i++) //cria a estrutura de memoria
                memoria[i] = i;
        }

        //carrega os parametros de entrada acordo com a opção selecionada
        #region - Parametros de entrada

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
                //mPalavra = 7;

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
                //mPalavra = 3;

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
                //mPalavra = 1;

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
                //mPalavra = 7;

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
                //mPalavra = 3;

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
                //mPalavra = 1;

                txtCacheL.Text = "16";
                txtCacheP.Text = "2";
            }
        }
        #endregion

        //Executa
        private void btnExec_Click(object sender, EventArgs e)
        {
            miss = 0; hit = 0; //zera os contadores a cada execução
            int[,] cache = new int[Convert.ToInt32(txtCacheL.Text), Convert.ToInt32(txtCacheP.Text) + 2]; //cria a cache de acordo com os parametros selecionados

            for (int i = 0; i < cache.GetLength(0); i++) //gambi... atribui -1 a cada linha da cache na posição q irá guardar a tag para que 
                cache[i, 1] = -1;                        //no modo associativo a gente saiba quando o campo tag não foi usado e possa dar o miss direto na primeira vez q for consultado
                                                         //tivemos mts problemas para usar int?(nullable) e por isso contornamos dessa maneira.
            int maskTag, maskLinha;

            try
            {
                StreamReader rd = new StreamReader(System.Environment.CurrentDirectory.ToString() + "\\Enderecos.txt");
                string linhaArq = null;


                while ((linhaArq = rd.ReadLine()) != null) //percorre o arquivo com os endereços 
                {
                    int endInt = Int32.Parse(linhaArq.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);

                    //bitwise para criar as máscaras
                    maskTag = (endInt & mTag) >> dTag;
                    maskLinha = (endInt & mLinha) >> dLinha;

                    //chama o respectivo metodos de acordo com o parametro de entrada
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

        //Pelo parametro de entrada o método pega da memória o bloco solicitado(de acordo com o numero de palavras parametrizado pela opção selecionada)
        private int[] getBloco(int end)
        {
            int[] outBloco = new int[Convert.ToInt32(txtCacheP.Text)]; // cria o vetor para guardar os blocos de acordo com o parametro de entrada
            int cont = 0;
            bool hit = false;

            for (int i = 0; i < memoria.Length; i++) //percorre toda memoria
            {
                if (cont < outBloco.Length) //preenche todo o vetor de blocos
                {
                    outBloco[cont] = memoria[i];
                    cont++;
                }
                else
                {
                    for (int x = 0; x < outBloco.Length; x++)//apos preenchido verifica se o endereço solicitado por parametro esta no bloco
                    {
                        if (outBloco[x] == end) //se sim da hit
                            hit = true;
                    }

                    if (hit)
                        break; // qnd der hit, para o loop e retorna todo o bloco em q consta o valor
                    else
                    {
                        outBloco[0] = memoria[i]; //se não deu hit, preenche a primeira posição do bloco e continua preenchenco o restante 
                        cont = 1;                 //do bloco na proxima volta do loop... e assim ate dar hit e retornar o bloco solicitado
                    }
                }

            }
            return outBloco;
        }

        //pesquisa e alimenta a cache usando modo direto
        private void mapDireto(int maskLinha, int[,] cache, int endInt)
        {
            InitializeTimer();
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

        //pesquisa e alimenta a cache usando modo associativo
        private void mapAssociativo(int maskTag, int[,] cache, int endInt)
        {
            InitializeTimer();
            int[] outBloco = new int[Convert.ToInt32(txtCacheP.Text)];
            bool achou = false;

            for (int i = 0; i < cache.GetLength(0); i++)//percorre todas as linhas da cache
            {
                if (cache[i, 1] < 0)//continuação daquela gambi... verifica se a tag nunca foi acessada
                {
                    cache[i, 1] = maskTag;//se não atribui o bloco nessa linha
                    miss++;
                    outBloco = getBloco(endInt);

                    if (cache[i, 0] < 150) //incrementa o contador de acessos da LRU ou zera qnd chegar em 150 acessos
                        cache[i, 0]++;
                    else
                        cache[i, 0] = 0;

                    for (int x = 2; x < cache.GetLength(1); x++)
                        cache[i, x] = outBloco[x - 2];

                    achou = true;
                    break;
                }
                else
                {
                    if (cache[i, 1] == maskTag)//se ja consta alguma tag para essa linha, verifica se é a tag q esta sendo solicitada
                    {
                        hit++;   //se for, deu hit
                        achou = true;

                        if (cache[i, 0] < 150)//incrementa o contador de acessos da LRU ou zera qnd chegar em 150 acessos
                            cache[i, 0]++;
                        else
                            cache[i, 0] = 0;


                        break;
                    }
                }
            }

            //politica de substituição - LRU

            if (!achou)//Se todas as linhas ja foram preenchidas com tags e não deu hit utiliza a politica de substituição
            {
                int val = 0, menor = cache[0, 0];

                for (int z = 1; z < cache.GetLength(0); z++)//percorre as linhas da cache e guarda a linha q tem menor contador de acessos
                {
                    if (cache[z, 0] < menor)
                    {
                        menor = cache[z, 0];
                        val = z;
                    }
                }

                miss++;
                outBloco = getBloco(endInt);//traz o bloco solicitado

                cache[val, 0] = 1;
                cache[val, 1] = maskTag;
                for (int x = 2; x < cache.GetLength(1); x++)//inseri o bloco na linha de menos acesso;
                    cache[val, x] = outBloco[x - 2];
            }
        }

        //ProgressBar
        #region - ProgressBar

        private void InitializeTimer()
        {
            time.Interval = 250;
            time.Tick += new EventHandler(IncreaseProgressBar);
            time.Start();
        }

        private void IncreaseProgressBar(object sender, EventArgs e)
        {
            progB.Increment(1);

            if (progB.Value == progB.Maximum)
            {
                time2.Interval = 550;
                time2.Tick += new EventHandler(ClearProgressBar);
                time2.Start();
                time.Stop();
            }
        }

        private void ClearProgressBar(object sender, EventArgs e)
        {            
            progB.Value = 0;
            time2.Stop();
        }

        #endregion
    }
}

