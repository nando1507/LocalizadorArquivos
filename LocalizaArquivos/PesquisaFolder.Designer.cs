namespace LocalizaArquivos
{
    partial class PesquisaFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaFolder));
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.DgvCaminho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvLastWrite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pastaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lblCaminho = new System.Windows.Forms.Label();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.lblArquivo = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progresso = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArquivos
            // 
            this.dgvArquivos.AllowUserToAddRows = false;
            this.dgvArquivos.AllowUserToDeleteRows = false;
            this.dgvArquivos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCaminho,
            this.DgvArquivo,
            this.DgvLastWrite,
            this.DgvData,
            this.DgvSize});
            this.dgvArquivos.Location = new System.Drawing.Point(8, 109);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.ReadOnly = true;
            this.dgvArquivos.Size = new System.Drawing.Size(776, 353);
            this.dgvArquivos.TabIndex = 0;
            // 
            // DgvCaminho
            // 
            this.DgvCaminho.HeaderText = "Caminho";
            this.DgvCaminho.Name = "DgvCaminho";
            this.DgvCaminho.ReadOnly = true;
            // 
            // DgvArquivo
            // 
            this.DgvArquivo.HeaderText = "Arquivo";
            this.DgvArquivo.Name = "DgvArquivo";
            this.DgvArquivo.ReadOnly = true;
            // 
            // DgvLastWrite
            // 
            this.DgvLastWrite.HeaderText = "Data Criação";
            this.DgvLastWrite.Name = "DgvLastWrite";
            this.DgvLastWrite.ReadOnly = true;
            // 
            // DgvData
            // 
            this.DgvData.HeaderText = "Data Ultimo Acesso";
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            // 
            // DgvSize
            // 
            this.DgvSize.HeaderText = "Tamanho";
            this.DgvSize.Name = "DgvSize";
            this.DgvSize.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pastaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pastaToolStripMenuItem
            // 
            this.pastaToolStripMenuItem.Name = "pastaToolStripMenuItem";
            this.pastaToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.pastaToolStripMenuItem.Text = "Abrir";
            this.pastaToolStripMenuItem.Click += new System.EventHandler(this.pastaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Location = new System.Drawing.Point(13, 36);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisa.TabIndex = 2;
            this.btnPesquisa.Text = "Pesquisa";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // lblCaminho
            // 
            this.lblCaminho.AutoSize = true;
            this.lblCaminho.Location = new System.Drawing.Point(96, 41);
            this.lblCaminho.Name = "lblCaminho";
            this.lblCaminho.Size = new System.Drawing.Size(51, 13);
            this.lblCaminho.TabIndex = 3;
            this.lblCaminho.Text = "Caminho:";
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(153, 37);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(362, 20);
            this.txtCaminho.TabIndex = 4;
            // 
            // txtArquivo
            // 
            this.txtArquivo.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtArquivo.Location = new System.Drawing.Point(574, 36);
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(214, 20);
            this.txtArquivo.TabIndex = 6;
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(521, 41);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(43, 13);
            this.lblArquivo.TabIndex = 5;
            this.lblArquivo.Text = "Arquivo";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.progresso});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(124, 17);
            this.StatusLabel.Text = "Arquivos Localizados: ";
            // 
            // progresso
            // 
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(100, 16);
            // 
            // PesquisaFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.lblArquivo);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.lblCaminho);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.dgvArquivos);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaFolder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localiza Informações de Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArquivos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pastaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lblCaminho;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.Label lblArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCaminho;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvLastWrite;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripProgressBar progresso;
    }
}

