using System.Reflection.Emit;

namespace MyEventTest20250310
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        //public event EventHandler<string> F1toF2;
        public delegate void F1toF2(string msg);
        public F1toF2 f1ToF2;

        private void button_showF2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            //form2.F2toF1 += Form2_F2toF1;
            form2.handler = new Form2.Form2toForm1Handler((s) => textBox1.Text = s);
            form2.Show();
        }

        private void Form2_F2toF1(object? sender, string e)
        {
            this.textBox1.Text = e;
        }

        private void button_send2F2_Click(object sender, EventArgs e)
        {
            //if (F1toF2!=null)
            //{
            //    F1toF2?.Invoke(this, textBox1.Text);
            //}
            if (f1ToF2!=null)
            {
                f1ToF2?.Invoke(textBox1.Text);
            }
        }
    }
}
