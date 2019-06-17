using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadBigData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random(DateTime.Now.Millisecond);
        private void Button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Task.Run(() =>
            {
                for (int i = 0; i < 100000000; i++)
                {

                }
            });
        }
    }
}
