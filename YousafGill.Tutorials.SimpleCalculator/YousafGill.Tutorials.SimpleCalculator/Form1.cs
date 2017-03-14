using System;
using System.Windows.Forms;

namespace YousafGill.Tutorials.SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form Load Code Here
        }
        private void NumberClick(object sender,EventArgs e)
        {
            //Button btn = (Button)sender;
            // OR 
            Button b = sender as Button;
        }
    }
}
