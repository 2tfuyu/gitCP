using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gitCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string content = textBox1.Text;
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked)
                {
                    content = "cproxy.okinawa-ct.ac.jp:8080";
                }
                Clipboard.SetText("git config --global http.proxy " + content);
            }
            else
            {
                Clipboard.SetText("git config --global --unset http.proxy");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
