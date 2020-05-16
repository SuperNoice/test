using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.a().b();

        }
        public Form1 a()
        {
            textBox1.Text += "1"; ;
            return this;
        }
		
		//jopa
		
		//asfty
		//asdtuj

        public Form1 b()
        {
            textBox1.Text += "2";
            return this;
        }
    }
   

}
