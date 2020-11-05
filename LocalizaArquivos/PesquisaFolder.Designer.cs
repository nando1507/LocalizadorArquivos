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
            this.components = new System.ComponentModel.Container();
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
            this.gbTamanho = new System.Windows.Forms.GroupBox();
            this.rbKB = new System.Windows.Forms.RadioButton();
            this.rbMB = new System.Windows.Forms.RadioButton();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnExpExcel = new System.Windows.Forms.Button();
            this.btnExpCSV = new System.Windows.Forms.Button();
            this.btnExpTXT = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtContador = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbTamanho.SuspendLayout();
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
            this.dgvArquivos.Size = new System.Drawing.Size(914, 371);
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
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
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
            this.txtContador});
            this.statusStrip1.Location = new System.Drawing.Point(0, 483);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(124, 17);
            this.StatusLabel.Text = "Arquivos Localizados: ";
            // 
            // gbTamanho
            // 
            this.gbTamanho.Controls.Add(this.rbKB);
            this.gbTamanho.Controls.Add(this.rbMB);
            this.gbTamanho.Location = new System.Drawing.Point(817, 27);
            this.gbTamanho.Name = "gbTamanho";
            this.gbTamanho.Size = new System.Drawing.Size(105, 44);
            this.gbTamanho.TabIndex = 8;
            this.gbTamanho.TabStop = false;
            this.gbTamanho.Text = "Unidade";
            // 
            // rbKB
            // 
            this.rbKB.AutoSize = true;
            this.rbKB.Location = new System.Drawing.Point(6, 19);
            this.rbKB.Name = "rbKB";
            this.rbKB.Size = new System.Drawing.Size(39, 17);
            this.rbKB.TabIndex = 1;
            this.rbKB.Text = "KB";
            this.rbKB.UseVisualStyleBackColor = true;
            // 
            // rbMB
            // 
            this.rbMB.AutoSize = true;
            this.rbMB.Checked = true;
            this.rbMB.Location = new System.Drawing.Point(51, 19);
            this.rbMB.Name = "rbMB";
            this.rbMB.Size = new System.Drawing.Size(41, 17);
            this.rbMB.TabIndex = 0;
            this.rbMB.TabStop = true;
            this.rbMB.Text = "MB";
            this.rbMB.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnExpExcel
            // 
            this.btnExpExcel.Image = global::LocalizaArquivos.Properties.Resources.icons8_microsoft_excel_161;
            this.btnExpExcel.Location = new System.Drawing.Point(8, 80);
            this.btnExpExcel.Name = "btnExpExcel";
            this.btnExpExcel.Size = new System.Drawing.Size(29, 23);
            this.btnExpExcel.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnExpExcel, "Exportar Excel");
            this.btnExpExcel.UseVisualStyleBackColor = true;
            this.btnExpExcel.Click += new System.EventHandler(this.btnExpExcel_Click);
            // 
            // btnExpCSV
            // 
            this.btnExpCSV.Image = global::LocalizaArquivos.Properties.Resources.icons8_csv_16;
            this.btnExpCSV.Location = new System.Drawing.Point(45, 80);
            this.btnExpCSV.Name = "btnExpCSV";
            this.btnExpCSV.Size = new System.Drawing.Size(26, 23);
            this.btnExpCSV.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnExpCSV, "Exportar CSV");
            this.btnExpCSV.UseVisualStyleBackColor = true;
            this.btnExpCSV.Click += new System.EventHandler(this.btnExpCSV_Click);
            // 
            // btnExpTXT
            // 
            this.btnExpTXT.Image = global::LocalizaArquivos.Properties.Resources.icons8_txt_16;
            this.btnExpTXT.Location = new System.Drawing.Point(79, 80);
            this.btnExpTXT.Name = "btnExpTXT";
            this.btnExpTXT.Size = new System.Drawing.Size(22, 23);
            this.btnExpTXT.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnExpTXT, "Exportar TXT");
            this.btnExpTXT.UseVisualStyleBackColor = true;
            this.btnExpTXT.Click += new System.EventHandler(this.btnExpTXT_Click);
            // 
            // txtContador
            // 
            this.txtContador.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(13, 17);
            this.txtContador.Text = "0";
            // 
            // PesquisaFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 505);
            this.Controls.Add(this.btnExpTXT);
            this.Controls.Add(this.btnExpCSV);
            this.Controls.Add(this.btnExpExcel);
            this.Controls.Add(this.gbTamanho);
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
            this.gbTamanho.ResumeLayout(false);
            this.gbTamanho.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbTamanho;
        private System.Windows.Forms.RadioButton rbKB;
        private System.Windows.Forms.RadioButton rbMB;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnExpExcel;
        private System.Windows.Forms.Button btnExpCSV;
        private System.Windows.Forms.Button btnExpTXT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel txtContador;
    }
}

