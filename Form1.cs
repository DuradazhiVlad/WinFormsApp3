using Microsoft.VisualBasic.Devices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;
using System.Reflection.Emit;
using Application = System.Windows.Forms.Application;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        public void Form1_Load_1(object sender, EventArgs e)
        {

            MessageBox.Show("Резюме   Мене звати Влад");
            string FormSize = this.Size.ToString();
            
        }
        //Коорлинати мишки
        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            if (true)
            {
            this.Text = MousePosition.ToString();

            }


            

        }



        
        //При натискані мишки
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {

            MessageBox.Show("Мишка знаходиться зовні");
            }
            if (e.Button == MouseButtons.Right)
            {

                MessageBox.Show(SizeFromClientSize(Size).ToString());
            }

            if (e.Button == MouseButtons.Left&& Control.ModifierKeys == Keys.Shift)
            {
            Form1 form=new Form1();
            form.Close();
                
            }

            
        }
        private void panel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
            {
                Form1 form = new Form1();
                form.Close();
            }
        }




        private void button4_Click(object sender, EventArgs e)
        {
            decimal s = numericUpDown1.Value;
            var rand = new Random();
            for (int i = 0; i < 1999; i++)
            {
                int ra = rand.Next(1, 2000);

                if (ra == numericUpDown1.Value)
                {
                    MessageBox.Show("Користувач загадав число " + ra.ToString());
                    MessageBox.Show("Програмі знадобилося спроб " + i);

                }
            }
            MessageBox.Show("Розмір програми " + SizeFromClientSize(ClientSize));
            MessageBox.Show("Координати мишки ");

        }

        

        

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                MessageBox.Show("Мишка знаходиться в середині");
                
            }
            if (e.Button == MouseButtons.Left && Keys.KeyCode == Keys.Control)
            {
                this.Close();
            }


        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            //if (e. == MouseButtons.Left)
            //{

            //    MessageBox.Show("fdg");
            //}
        }

        
    }
    
}