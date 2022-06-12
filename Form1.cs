using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChildForm form = new ChildForm();
            form.Show();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            DataTable dataTable = new DataTable();
            DataColumn wordColumn = new DataColumn("单词");
            dataTable.Columns.Add(wordColumn);
            DataColumn pronounceColumn = new DataColumn("音标");
            dataTable.Columns.Add(pronounceColumn);
            DataColumn meanColumn = new DataColumn("释义");
            dataTable.Columns.Add(meanColumn);
            DataColumn exampleColumn = new DataColumn("例句");
            dataTable.Columns.Add(exampleColumn);
            DataColumn chineseColumn = new DataColumn("译句");
            dataTable.Columns.Add(chineseColumn);

            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                string fileFullName = openFileDialog.FileName;

                if (!string.IsNullOrEmpty(fileFullName) && File.Exists(fileFullName))
                {
                    FileInfo fileinfo = new FileInfo(fileFullName);
                    this.txtFileName.Text = fileinfo.Name;

                    string[] fileContents = File.ReadAllLines(fileFullName, Encoding.GetEncoding("GB2312"));

                    foreach (string fileContent in fileContents)
                    {
                        DataRow row = dataTable.NewRow();

                        if (Regex.IsMatch(fileContent, @"^([0-9]+\.).*([).*(]).*$"))
                        {
                            
                        }
                    }
                }

                



            }
        }
    }
}
