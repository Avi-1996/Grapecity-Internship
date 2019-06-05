using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{

    public partial class WinCalc : Form
    {
        public bool IsOperatorExcuted = false;
        public bool IsOperatorThere = false;
        public bool ExceptionAccour = false;
        Calculator.ScienceMathLib calLib = new Calculator.ScienceMathLib();
        public WinCalc()
        {
            InitializeComponent();
        }


        private void scienctificToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Height = 518;
        }



        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 415;
        }

        private void numberBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            if (this.inputTxtbox.Text == "0")
            {
                this.inputTxtbox.Text = "";
            }
            if (LableContainOprator())
            {
                double FNumber = 0;
                if (label1.Text[0] == '-')
                    FNumber = double.Parse(label1.Text.Substring(1, label1.Text.Length - 1));
                else
                    FNumber = double.Parse(label1.Text.Substring(0, label1.Text.Length - 1));
                double SNumber = double.Parse(btn.Text);
                char Operator = label1.Text[label1.Text.Length - 1];
                performOperation(FNumber, SNumber, Operator);
                IsOperatorExcuted = true;
            }
            else
            {
                if ((btn.Text != ".") || (btn.Text == "." && !this.inputTxtbox.Text.Contains(".")))
                {
                    inputTxtbox.Text += btn.Text.ToString();
                    label1.Text = inputTxtbox.Text;
                }
                    
            }
        }

        private void opratorClicked(object sender, EventArgs e)
        {
            Button op = (Button)(sender);
            if (IsOperatorExcuted)
            {
                this.label1.Text = "";
                this.label1.Text = this.inputTxtbox.Text.ToString();
               // this.inputTxtbox.Text = "0";
                IsOperatorExcuted = false;
            }
            switch (op.Text.ToString())
            {
                case "+":
                    if (!IsOperatorThere)
                    {
                        this.label1.Text +=  " " + op.Text;
                        IsOperatorThere = true;
                    }
                    this.inputTxtbox.Text = "";
                    break;
                case "-":
                    if (!IsOperatorThere)
                    {
                        this.label1.Text +=" " + op.Text;
                        IsOperatorThere = true;
                    }
                    
                    this.inputTxtbox.Text = "";
                    break;
                case "*":
                    if (!IsOperatorThere)
                    {
                        this.label1.Text += " " + op.Text;
                        IsOperatorThere = true;
                    }
                    
                    this.inputTxtbox.Text = "";
                    break;
                case "/":
                    if (!IsOperatorThere)
                    {
                        this.label1.Text +=" " + op.Text;
                        IsOperatorThere = true;
                    }
                    
                    this.inputTxtbox.Text = "";
                    break;
                case "%":
                    if (!IsOperatorThere)
                    {
                        this.label1.Text += " " + op.Text;
                        IsOperatorThere = true;
                    }
                    this.inputTxtbox.Text = "";
                    break;
                case "1/x":

                    calLib.FNum = double.Parse(inputTxtbox.Text);
                    calLib.OneDivByX();
                    this.IsOperatorExcuted = true;
                    this.inputTxtbox.Text = calLib.Result.ToString();
                    break;
                case "±":
                    if (double.Parse(inputTxtbox.Text) < 0)
                        this.inputTxtbox.Text = (-(double.Parse(inputTxtbox.Text))).ToString();
                    else
                        this.inputTxtbox.Text = (-(double.Parse(inputTxtbox.Text))).ToString();
                    label1.Text = inputTxtbox.Text;
                    IsOperatorThere = true;
                    break;
            }
        }

        private void moBtn_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void clearScreen(object sender, EventArgs e)
        {
            Button clear = (Button)(sender);
            if (clear.Text == "C")
                this.inputTxtbox.Text = "0";
            else if (clear.Text == "CE")
            {
                this.inputTxtbox.Text = "0";
                this.label1.Text = "";
            }
            else
            {
                try
                {
                    this.inputTxtbox.Text = this.inputTxtbox.Text.Substring(0, inputTxtbox.Text.Length - 1);
                }
                catch
                {

                }
            }

        }
        public bool LableContainOprator()
        {
            if (label1.Text == "") return false;
            if (!(label1.Text == "") || label1.Text.Last() == '+' ||label1.Text.Last()== '-' || label1.Text.Contains("*") || label1.Text.Contains("/") || label1.Text.Contains("%"))
                return true;
            else
                return false;
        }
        public void performOperation(double FNumber,Double SNumber,char Operator)
        {
            calLib.FNum = FNumber;
            calLib.SNum = SNumber;
            switch (Operator)
            {
                case '+':
                    calLib.Add();
                    break;
                case '-':
                    calLib.Sub();
                    break;
                case '*':
                    calLib.Mul();
                    break;
                case '/':
                    if(SNumber == 0)
                    {
                        this.inputTxtbox.Text = "Can't Divide By Zero ";
                        ExceptionAccour = true;
                    }
                    else
                    {
                        calLib.Div();
                        ExceptionAccour = false;
                    }
                        
                    break;
                case '%':
                    calLib.Mod();
                    break;
                
            }
            if (!ExceptionAccour)
            {
                this.inputTxtbox.Text = calLib.Result.ToString();
            }
            IsOperatorThere = false;

        }
    }
}

