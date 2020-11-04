using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LocalizaArquivos
{
    public partial class PesquisaFolder : Form
    {
        public PesquisaFolder()
        {
            InitializeComponent();
        }

        OpenFileDialog Pesquisa = new OpenFileDialog();
        FolderBrowserDialog folder = new FolderBrowserDialog();
        String CaminhoPasta = String.Empty;
        Thread th;

        String[] Abrir()
        {
            Pesquisa.Reset();
            Pesquisa.Multiselect = true;
            Pesquisa.Title = "Selecione o Arquivo";
            //Pesquisa.Filter = "*.CSV|*.CSV";
            Pesquisa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Pesquisa.ShowDialog();

            return Pesquisa.FileNames;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CaminhoPasta = txtCaminho.Text;

            dgvArquivos.Rows.Clear();
            //th = new Thread(new ThreadStart());
            try
            {
                this.CarregaGrid(CaminhoPasta);
            }
            catch(Exception ex)
            {
                //StatusLabel.Text = ex.Message.ToString();
                MessageBox.Show(ex.StackTrace.ToString(), ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        public async void CarregaGrid(String Aux)
        {
            DirectoryInfo Directory = new DirectoryInfo(Aux);
            
            FileInfo[] filesString = Directory.GetFiles();
            DateTime lastModified = DateTime.MinValue;
            String ArqAutbank = String.Empty;
            int i = 0;

            foreach (FileInfo file in filesString)
            {
                if (!String.IsNullOrEmpty(txtArquivo.Text))
                {
                    if (file.ToString().Contains(txtArquivo.Text))
                    {
                        if (file.LastWriteTime > lastModified)
                        {
                           // float j = 
                            dgvArquivos.Rows.Add(Aux, file.Name, file.LastAccessTime, file.LastWriteTime, Convert.ToString((float)file.Length/1024.00) + " KB");
                        }
                    }
                }
                else
                {
                    if (file.LastWriteTime > lastModified)
                    {
                        dgvArquivos.Rows.Add(Aux, file.Name, file.LastAccessTime, file.LastWriteTime, file.Length);
                    }
                }

                i++;
                dgvArquivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            StatusLabel.Text = "Arquivos Localizados: " + i;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            CaminhoPasta = txtCaminho.Text;

            dgvArquivos.Rows.Clear();
            //th = new Thread(new ThreadStart());
            try
            {
                this.CarregaGrid(CaminhoPasta);
            }
            catch (Exception ex)
            {
                //StatusLabel.Text = ex.Message.ToString();
                MessageBox.Show(ex.StackTrace.ToString(), ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
