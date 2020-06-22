using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace media_player
{
    public partial class Form1 : Form
    {
        private string filepath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog filedialog = new OpenFileDialog())
            {
                if (filedialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = filedialog.FileName;
                    axWindowsMediaPlayer1.URL = filepath;
                }
            }
        }
    }
}
