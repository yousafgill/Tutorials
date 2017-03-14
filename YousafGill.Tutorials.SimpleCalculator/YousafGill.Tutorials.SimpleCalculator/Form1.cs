using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YousafGill.Tutorials.SimpleCalculator
{
    public partial class Form1 : Form
    {
        Decimal FirstValue;
        char op = ' ';
        StringBuilder sbHistory = new StringBuilder();
        public Form1()
        {
            InitializeComponent();
            BindEvents();
        }
        #region Events Binding
        /// <summary>
        /// This method is used to bind event procedures for controls
        /// specially Num Buttons and / Operator Buttons
        /// </summary>
        private void BindEvents()
        {
            //Numbers Click Events Binding
            btnNum0.Click += NumbersClick;
            btnNum1.Click += NumbersClick;
            btnNum2.Click += NumbersClick;
            btnNum3.Click += NumbersClick;
            btnNum4.Click += NumbersClick;
            btnNum5.Click += NumbersClick;
            btnNum6.Click += NumbersClick;
            btnNum7.Click += NumbersClick;
            btnNum8.Click += NumbersClick;
            btnNum9.Click += NumbersClick;

            //Operator Buttons Events Binding
            btnOpAdd.Click += OperatorButtonClick;
            btnOpSub.Click += OperatorButtonClick;
            btnOpMul.Click += OperatorButtonClick;
            btnOpDiv.Click += OperatorButtonClick;

            //Other Buttons 
            btnClear.Click += ClearButtonClick;
            btnResult.Click += ResultClick;
        }


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form Load Code Here
        }

        #region Numbers Button Click Event
        private void NumbersClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            decimal v = (decimal.Parse(txtResult.Text) * 10) + decimal.Parse(b.Text);
            txtResult.Text = v.ToString();
        }
        #endregion

        #region Operator Buttons Click
        private void OperatorButtonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            op = char.Parse(b.Text);
            FirstValue = decimal.Parse(txtResult.Text);
            sbHistory.Append($"{FirstValue}{op}");
            lblHistory.Text = sbHistory.ToString();
            txtResult.Text = "0";

        }
        #endregion

        #region Clear Button Click
        private void ClearButtonClick(object sender, EventArgs e)
        {
            sbHistory.Clear();
            lblHistory.ResetText();
            txtResult.Text = "0";
            FirstValue = 0;
            op = ' ';
        }
        #endregion
        #region Result Button Click
        private void ResultClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            decimal Result = decimal.Parse(txtResult.Text);
            sbHistory.Append($"{Result}");
            sbHistory.Append("=");
            switch (op)
            {
                case '+':
                    Result += FirstValue;
                    break;
                case '-':
                    Result -= FirstValue;
                    break;
                case '*':
                    Result *= FirstValue;
                    break;
                case '/':
                    Result /= FirstValue;
                    break;
                default:
                    break;
            }
            sbHistory.Append($"{Result}");
            lblHistory.Text = sbHistory.ToString();
            txtResult.Text = Result.ToString();

        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
