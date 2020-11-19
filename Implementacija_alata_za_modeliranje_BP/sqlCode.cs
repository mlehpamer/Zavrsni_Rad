using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Implementacija_alata_za_modeliranje_BP
{
    public partial class sqlCode : Form
    {
        private string projectName;
        List<string> content = new List<string>();
        public sqlCode(string projectName)
        {
            this.projectName = projectName;
            InitializeComponent();
        }

        private void sqlCode_Load(object sender, EventArgs e)
        {
            LoadProjects loadProjects = new LoadProjects();
            foreach (var item in loadProjects.TableContentToSQL(projectName))
            {
                txtCode.AppendText(item.ToString());
                txtCode.AppendText("\n");
                content.Add(item);
            }          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ads = new FolderBrowserDialog();
            ads.ShowDialog();
            string filePath = ads.SelectedPath;
            try
            {
                using (TextWriter tw = new StreamWriter(filePath+"\\"+projectName+".txt"))
                {
                    foreach (String s in content)
                        tw.WriteLine(s);
                }
            }
            catch
            {

            }
            this.Close();
        }
    }
}
