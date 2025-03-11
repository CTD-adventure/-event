using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEventTest20250310
{
    public partial class Form2 : Form
    {
        //public event EventHandler<string> F2toF1;
        public delegate void Form2toForm1Handler(string msg);
        public Form2toForm1Handler handler;
        Form1 _form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
            //_form1.F1toF2 += _form1_F1toF2;
            _form1.f1ToF2 = new Form1.F1toF2((s)=>this.textBox1.Text =s);
        }

        private void Getmsg(string msg)
        {
            this.textBox1.Text = msg;
        }

        private void _form1_F1toF2(object? sender, string e)
        {
            textBox1.Text = e;
        }

        private void button_send2F1_Click(object sender, EventArgs e)
        {
            //if (F2toF1!=null)
            //{
            //    F2toF1?.Invoke(this, textBox1.Text);
            //}
            if (handler != null)
            {
                handler?.Invoke(textBox1.Text);
            }
        }
    }
}
