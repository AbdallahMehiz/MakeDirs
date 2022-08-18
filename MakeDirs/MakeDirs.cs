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

namespace MakeDirs
{
    public partial class MakeDirs : Form
    {
        public MakeDirs()
        {
            InitializeComponent();
        }

        private void makeDirBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(dirNum.Text);
            for (int i = num; i > 0; i--)
            {
                Directory.CreateDirectory($"{folderBrowseDialogue.SelectedPath}/{prefixTextBox.Text}{i.ToString()}{suffixTextBox.Text}");
            }
            makeDirBtn.Text = "Done!";
        }
        private void dirNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowseDialogue.ShowDialog() == DialogResult.OK)
            {
                selectedPath.Text = folderBrowseDialogue.SelectedPath;
            }
        }
    }
}
