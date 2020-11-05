using System;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
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

        public async Task<String[]> Abrir()
        {
            Pesquisa.Reset();
            Pesquisa.Multiselect = true;
            Pesquisa.Title = "Selecione o Arquivo";
            //Pesquisa.Filter = "*.CSV|*.CSV";
            Pesquisa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Pesquisa.ShowDialog();

            return Pesquisa.FileNames;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void pastaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CaminhoPasta = txtCaminho.Text;

            dgvArquivos.Rows.Clear();
            try
            {
                this.CarregaGrid(CaminhoPasta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), ex.Message.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void CarregaGrid(String Aux)
        {
            DirectoryInfo Directory = new DirectoryInfo(Aux);
            FileInfo[] filesString = Directory.GetFiles();
            DirectoryInfo[] sub = Directory.GetDirectories();
            DateTime lastModified = DateTime.MinValue;
            int i = 0;

            foreach (FileInfo file in filesString)
            {
                if (!String.IsNullOrEmpty(txtArquivo.Text))
                {
                    if (file.ToString().Contains(txtArquivo.Text))
                    {
                        dgvArquivos.Rows.Add(Aux, file.Name, file.LastAccessTime, file.LastWriteTime, Convert.ToString((float)file.Length / Math.Pow(1024.00, (rbKB.Checked && !rbMB.Checked ? 1 : 2))) + " " + (rbKB.Checked && !rbMB.Checked ? rbKB.Text : rbMB.Text));
                    }
                }
                else
                {
                    dgvArquivos.Rows.Add(Aux, file.Name, file.LastAccessTime, file.LastWriteTime, Convert.ToString((float)file.Length / Math.Pow(1024.00, (rbKB.Checked && !rbMB.Checked ? 1 : 2))) + " " + (rbKB.Checked && !rbMB.Checked ? rbKB.Text : rbMB.Text));
                }

                i++;
                dgvArquivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                StatusLabel.Text = "Arquivos Localizados: ";
                txtContador.Text = dgvArquivos.Rows.Count.ToString();
            }

            foreach (DirectoryInfo dir in sub)
            {
                subpastas(dir.FullName?.ToString(), i);
            }
        }

        public async void subpastas(String aux, int values)
        {
            DirectoryInfo Directory = new DirectoryInfo(aux);
            FileInfo[] filesString = Directory.GetFiles();
            DirectoryInfo[] sub = Directory.GetDirectories();

            foreach (FileInfo file in filesString)
            {
                if (!String.IsNullOrEmpty(txtArquivo.Text))
                {
                    if (file.ToString().Contains(txtArquivo.Text))
                    {
                        dgvArquivos.Rows.Add(aux, file.Name, file.LastAccessTime, file.LastWriteTime, Convert.ToString(Math.Round((float)file.Length/ Math.Pow(1024.00, (rbKB.Checked && !rbMB.Checked ? 1 : 2)), 2)) + " " + (rbKB.Checked && !rbMB.Checked ? rbKB.Text : rbMB.Text));
                    }
                }
                else
                {
                    dgvArquivos.Rows.Add(aux, file.Name, file.LastAccessTime, file.LastWriteTime, Convert.ToString(Math.Round((float)file.Length/ Math.Pow(1024.00, (rbKB.Checked && !rbMB.Checked ? 1 : 2)), 2)) + " " + (rbKB.Checked && !rbMB.Checked ? rbKB.Text : rbMB.Text));
                }

                values++;

                StatusLabel.Text = "Arquivos Localizados: ";
                txtContador.Text = dgvArquivos.Rows.Count.ToString();
                dgvArquivos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }

            foreach (DirectoryInfo dir in sub)
            {
                subpastas(dir.FullName?.ToString(), values);
            }

        }

        private async void btnPesquisa_Click(object sender, EventArgs e)
        {
            CaminhoPasta = txtCaminho.Text;
            dgvArquivos.Rows.Clear();


            if (!string.IsNullOrEmpty(CaminhoPasta))
            {
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
            else
            {
                MessageBox.Show("favor informar um caminho", "Caminho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnExpExcel_Click(object sender, EventArgs e)
        {
            exportar(txtCaminho.Text, true, false, false);
        }

        private async void btnExpCSV_Click(object sender, EventArgs e)
        {
            exportar(txtCaminho.Text, false, true, false);
        }

        private async void btnExpTXT_Click(object sender, EventArgs e)
        {
            exportar(txtCaminho.Text, false, false, true);
        }

        public async void exportar(string aux, bool b_excel, bool b_csv, bool b_txt)
        {
            if (!string.IsNullOrEmpty(aux))
            {
                string NomeArquivo = aux.Split('\\')[aux.Split('\\').Length - 3].Trim() + "_" + aux.Split('\\')[aux.Split('\\').Length - 2].Trim() + "_" + aux.Split('\\')[aux.Split('\\').Length - 1].Trim();
                string cabecalho = string.Empty;

                if (b_excel)
                {
                    string tipoPlan = string.Empty;
                    string sVersion = string.Empty;
                    Excel.Application objExcel = new Excel.Application();
                    switch (objExcel.Version.ToString())
                    {
                        case "14.0":
                            sVersion = "2010";
                            tipoPlan = "plan";
                            break;
                        case "15.0":
                            sVersion = "2013";
                            tipoPlan = "plan";
                            break;
                        case "16.0":
                            sVersion = "2016";
                            tipoPlan = "planilha";
                            break;
                        default:
                            sVersion = "Too Old!";
                            tipoPlan = "plan";
                            break;
                    }
                    objExcel.Workbooks.Add();
                    objExcel.ActiveWorkbook.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + (NomeArquivo.Substring(NomeArquivo.Length-1, 1) == "_" ? NomeArquivo.Substring(0, NomeArquivo.Length - 1) : NomeArquivo) + ".xlsx");
                    objExcel.Worksheets[tipoPlan + "1"].Name = (NomeArquivo.Substring(NomeArquivo.Length-1, 1) == "_" ? NomeArquivo.Substring(0, NomeArquivo.Length - 1).Substring(0, 30) : NomeArquivo.Substring(0,NomeArquivo.Length));
                    objExcel.Visible = true;

                    int LinhasCabecalhos = 0, coluna = 0;
                    objExcel.Worksheets[(NomeArquivo.Substring(NomeArquivo.Length-1, 1) == "_" ? NomeArquivo.Substring(0, NomeArquivo.Length - 1).Substring(0, 30) : NomeArquivo.Substring(0, NomeArquivo.Length))].Activate();
                    objExcel.ActiveSheet.Cells.Font.Name = "Arial";
                    objExcel.ActiveSheet.Cells.Font.Size = 9;
                    LinhasCabecalhos = 1;
                    objExcel.ActiveSheet.Rows(LinhasCabecalhos).Font.Bold = true;
                    objExcel.ActiveSheet.Rows(LinhasCabecalhos).Font.Size = 10;
                    objExcel.ActiveSheet.Columns(1).AutoFit();
                    coluna = 0;
                    for (int i = 0; i < dgvArquivos.Columns.Count; i++)
                    {
                        objExcel.ActiveSheet.Rows(LinhasCabecalhos).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        objExcel.ActiveSheet.Cells(LinhasCabecalhos, ++coluna).Value = dgvArquivos.Columns[i].HeaderText.ToString();
                    }
                    for (int i = 1; i < dgvArquivos.Rows.Count; i++)
                    {
                        for (int j = 1; j <= dgvArquivos.Columns.Count; j++)
                        {
                            objExcel.ActiveSheet.Cells(i+1, j).Value = dgvArquivos.Rows[i-1].Cells[j-1].Value.ToString();
                        }
                    }
                    objExcel.ActiveSheet.Columns.AutoFit();
                    objExcel.ActiveWorkbook.Save();
                    objExcel.Application.Quit();
                }
                else if (b_txt || b_csv)
                {
                    string extensao = string.Empty;
                    if (b_csv)
                    {
                        extensao = ".CSV";
                    }
                    else if (b_txt)
                    {
                        extensao = ".TXT";
                    }

                    StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ " + (NomeArquivo.Substring(NomeArquivo.Length-1, 1) == "_" ? NomeArquivo.Substring(0, NomeArquivo.Length - 1) : NomeArquivo) + extensao);
                    for (int i = 0; i < dgvArquivos.Columns.Count; i++)
                    {
                        cabecalho += dgvArquivos.Columns[i].HeaderText.ToString() + ";";
                    }

                    sw.WriteLineAsync(cabecalho);
                    sw.Flush();

                    for (int i = 0; i < dgvArquivos.Rows.Count; i++)
                    {
                        string linha = string.Empty;
                        for (int j = 0; j < dgvArquivos.Columns.Count; j++)
                        {
                            linha += dgvArquivos.Rows[i].Cells[j].Value?.ToString() + ";";
                        }
                        sw.WriteLineAsync(linha);
                        sw.Flush();
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
            else
            {
                MessageBox.Show("Favor pesquisar alguma pasta antes", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCaminho.Focus();
            }
        }
    }
}
