using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnlogin.Click += (s, e) => login(s);
        }
        private void login(object s)
        {
            var dd = (Button)s;
            MessageBox.Show(dd.Text);
        }
    }
}
