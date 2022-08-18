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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void makeDirBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(dirNum.Text);
            for(int i = num; i > 0; i--)
            {
                Directory.CreateDirectory(i.ToString());
            }
        }

        private void dirNum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
