namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExec = new System.Windows.Forms.Button();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.txtLinha = new System.Windows.Forms.TextBox();
            this.txtPalavra = new System.Windows.Forms.TextBox();
            this.rd0 = new System.Windows.Forms.RadioButton();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd4 = new System.Windows.Forms.RadioButton();
            this.rd5 = new System.Windows.Forms.RadioButton();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.gbox = new System.Windows.Forms.GroupBox();
            this.txtCacheL = new System.Windows.Forms.TextBox();
            this.txtCacheP = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.progB = new System.Windows.Forms.ProgressBar();
            this.pnlResult.SuspendLayout();
            this.gbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExec
            // 
            this.btnExec.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExec.Location = new System.Drawing.Point(290, 297);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(159, 23);
            this.btnExec.TabIndex = 9;
            this.btnExec.Text = "Executar";
            this.btnExec.UseVisualStyleBackColor = false;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // txtTag
            // 
            this.txtTag.Enabled = false;
            this.txtTag.Location = new System.Drawing.Point(47, 300);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(42, 20);
            this.txtTag.TabIndex = 6;
            // 
            // txtLinha
            // 
            this.txtLinha.Enabled = false;
            this.txtLinha.Location = new System.Drawing.Point(95, 300);
            this.txtLinha.Name = "txtLinha";
            this.txtLinha.Size = new System.Drawing.Size(42, 20);
            this.txtLinha.TabIndex = 7;
            // 
            // txtPalavra
            // 
            this.txtPalavra.Enabled = false;
            this.txtPalavra.Location = new System.Drawing.Point(143, 300);
            this.txtPalavra.Name = "txtPalavra";
            this.txtPalavra.Size = new System.Drawing.Size(43, 20);
            this.txtPalavra.TabIndex = 8;
            // 
            // rd0
            // 
            this.rd0.AutoSize = true;
            this.rd0.Location = new System.Drawing.Point(6, 19);
            this.rd0.Name = "rd0";
            this.rd0.Size = new System.Drawing.Size(383, 17);
            this.rd0.TabIndex = 0;
            this.rd0.TabStop = true;
            this.rd0.Tag = "0";
            this.rd0.Text = "Direto - Tag/Linha/Palavra 3x2x3 (cache com 4 linhas, 8 palavras por linha)";
            this.rd0.UseVisualStyleBackColor = true;
            this.rd0.CheckedChanged += new System.EventHandler(this.rd0_CheckedChanged);
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Location = new System.Drawing.Point(6, 42);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(383, 17);
            this.rd1.TabIndex = 1;
            this.rd1.TabStop = true;
            this.rd1.Tag = "1";
            this.rd1.Text = "Direto - Tag/Linha/Palavra 3x3x2 (cache com 8 linhas, 4 palavras por linha)";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Linha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Palavra";
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(6, 65);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(389, 17);
            this.rd2.TabIndex = 2;
            this.rd2.TabStop = true;
            this.rd2.Tag = "2";
            this.rd2.Text = "Direto - Tag/Linha/Palavra 3x4x1 (cache com 16 linhas, 2 palavras por linha)";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(6, 88);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(431, 17);
            this.rd3.TabIndex = 3;
            this.rd3.TabStop = true;
            this.rd3.Tag = "3";
            this.rd3.Text = "Mapeamento associativo - Tag/Palavra 5x3 (cache com 4 linhas, 8 palavras por linh" +
    "a)";
            this.rd3.UseVisualStyleBackColor = true;
            this.rd3.CheckedChanged += new System.EventHandler(this.rd3_CheckedChanged);
            // 
            // rd4
            // 
            this.rd4.AutoSize = true;
            this.rd4.Location = new System.Drawing.Point(6, 111);
            this.rd4.Name = "rd4";
            this.rd4.Size = new System.Drawing.Size(431, 17);
            this.rd4.TabIndex = 4;
            this.rd4.TabStop = true;
            this.rd4.Tag = "4";
            this.rd4.Text = "Mapeamento associativo - Tag/Palavra 6x2 (cache com 8 linhas, 4 palavras por linh" +
    "a)";
            this.rd4.UseVisualStyleBackColor = true;
            this.rd4.CheckedChanged += new System.EventHandler(this.rd4_CheckedChanged);
            // 
            // rd5
            // 
            this.rd5.AutoSize = true;
            this.rd5.Location = new System.Drawing.Point(6, 134);
            this.rd5.Name = "rd5";
            this.rd5.Size = new System.Drawing.Size(437, 17);
            this.rd5.TabIndex = 5;
            this.rd5.TabStop = true;
            this.rd5.Tag = "5";
            this.rd5.Text = "Mapeamento associativo - Tag/Palavra 7x1 (cache com 16 linhas, 2 palavras por lin" +
    "ha)";
            this.rd5.UseVisualStyleBackColor = true;
            this.rd5.CheckedChanged += new System.EventHandler(this.rd5_CheckedChanged);
            // 
            // pnlResult
            // 
            this.pnlResult.AutoScroll = true;
            this.pnlResult.BackColor = System.Drawing.SystemColors.Window;
            this.pnlResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlResult.Controls.Add(this.lbResult);
            this.pnlResult.Location = new System.Drawing.Point(12, 337);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(444, 279);
            this.pnlResult.TabIndex = 10;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(12, 11);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 0;
            // 
            // gbox
            // 
            this.gbox.BackColor = System.Drawing.SystemColors.Control;
            this.gbox.Controls.Add(this.rd0);
            this.gbox.Controls.Add(this.rd1);
            this.gbox.Controls.Add(this.rd5);
            this.gbox.Controls.Add(this.rd2);
            this.gbox.Controls.Add(this.rd4);
            this.gbox.Controls.Add(this.rd3);
            this.gbox.Location = new System.Drawing.Point(12, 106);
            this.gbox.Name = "gbox";
            this.gbox.Size = new System.Drawing.Size(444, 165);
            this.gbox.TabIndex = 11;
            this.gbox.TabStop = false;
            this.gbox.Text = "Configuração";
            // 
            // txtCacheL
            // 
            this.txtCacheL.Enabled = false;
            this.txtCacheL.Location = new System.Drawing.Point(192, 300);
            this.txtCacheL.Name = "txtCacheL";
            this.txtCacheL.Size = new System.Drawing.Size(43, 20);
            this.txtCacheL.TabIndex = 12;
            // 
            // txtCacheP
            // 
            this.txtCacheP.Enabled = false;
            this.txtCacheP.Location = new System.Drawing.Point(241, 300);
            this.txtCacheP.Name = "txtCacheP";
            this.txtCacheP.Size = new System.Drawing.Size(43, 20);
            this.txtCacheP.TabIndex = 13;
            // 
            // txtTipo
            // 
            this.txtTipo.Enabled = false;
            this.txtTipo.Location = new System.Drawing.Point(18, 300);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(23, 20);
            this.txtTipo.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cache L.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cache P.";
            // 
            // img
            // 
            this.img.Image = ((System.Drawing.Image)(resources.GetObject("img.Image")));
            this.img.Location = new System.Drawing.Point(0, -1);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(474, 92);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img.TabIndex = 18;
            this.img.TabStop = false;
            // 
            // progB
            // 
            this.progB.Location = new System.Drawing.Point(11, 617);
            this.progB.Name = "progB";
            this.progB.Size = new System.Drawing.Size(444, 23);
            this.progB.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 652);
            this.Controls.Add(this.progB);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtCacheP);
            this.Controls.Add(this.txtCacheL);
            this.Controls.Add(this.gbox);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPalavra);
            this.Controls.Add(this.txtLinha);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.btnExec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trabalho 3 - Organização e Arquitetura de Computadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.gbox.ResumeLayout(false);
            this.gbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.TextBox txtLinha;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.RadioButton rd0;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.RadioButton rd4;
        private System.Windows.Forms.RadioButton rd5;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.GroupBox gbox;
        private System.Windows.Forms.TextBox txtCacheL;
        private System.Windows.Forms.TextBox txtCacheP;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.ProgressBar progB;
    }
}

