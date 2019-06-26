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
        //initialization of the basic Variable that will be needed through out the execution of the program
        private bool _isOperatorExcuted = false;
        private bool _isOperatorThere = false;
        private bool _exceptionAccour = false;
        private bool _isMemoryThere = false;
        private bool _plusMinusClicked = true;// at the start the  value of plus minus button is minus and goes in alternative fashion
        private string _result = "";
        private string _firstNumber = "";
        private bool _isSciOpExcuted = false;
        private string _secondNumber = "";
        private bool _evalExcuted = false;
        private double _memoryValue = 0;
        private char _operator;
        private string _copyData = "";
        public static bool IsHelpMenuOpen = false;
        Calculator.AirthmatiCalLib BasicCalculatorLib = null;
        Calculator.ScientificLib AdvanceCalculatorLib = null;
        Help helpMenu = null;
        
        
        #region Handling Input or Initilazation of operands and Operators
        //Invoked when Number clicked
        
        private void NumberBtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            Validate(btn);
            switch (btn.Tag.ToString())
            {
                case ".":
                    if (!inputTextBox.Text.Contains("."))
                        inputTextBox.Text += btn.Tag;
                    break;
                case "±":
                    if (_plusMinusClicked)
                    {
                        _plusMinusClicked = false;
                        inputTextBox.Text = LayoutResource.MinusBtnTag + inputTextBox.Text;
                    }
                    else
                    {
                        _plusMinusClicked = true;
                        inputTextBox.Text = inputTextBox.Text.Replace("-","");
                    }
                    break;
                default:
                    inputTextBox.Text += btn.Tag;
                    break;
            }
            labelEquation.Focus();
        }

        //Below function will perform some validation like 
        //the clearing the text before adding the number to it
        //taking care of minus button it should not be the first one
        //and if the Equal button has been execute then the all data has to be cleared

        public void Validate(Button btn)
        {
            if (inputTextBox.Text == "0" || _isSciOpExcuted)
            {
                inputTextBox.Text = "";
                _isSciOpExcuted = false;
            }
            if (_isOperatorExcuted && btn.Text != LayoutResource.MinusBtnTag)
            {
                _firstNumber = BasicCalculatorLib.Result.ToString();
                _isOperatorExcuted = false;
                inputTextBox.Text = "";
                _secondNumber = "";
            }
            if (_evalExcuted && !_isOperatorThere)
            {
                _evalExcuted = false;
                inputTextBox.Text = "";
                labelEquation.Text = "";
                _isOperatorThere = false;
                _isOperatorExcuted = false;
                _firstNumber = "";
                _secondNumber = "";
                BasicCalculatorLib.Result = 0;
            }
        }

        // Below function invoked for the Operator initialization

        public void OperatorClicked(object sender, EventArgs e)
        {
            Button OperatorSymbol = (Button)sender;
            _initializeOperands(OperatorSymbol);
            switch (OperatorSymbol.Tag)
            {
               
                case "Exception":
                    MessageBox.Show(LogicResource.ErrorMsg);
                    OperatorSymbol.Tag = ((Button)sender).Text;
                    btnClearEverything.PerformClick();
                    break;
                default:
                    labelEquation.Text += OperatorSymbol.Text;
                    _isOperatorThere = true;
                    break;
            }
            labelEquation.Focus();
            
        }
        //Below function do following things
        //initialize the first number
        //check the operator is valid for the operation or not
        //if valid the perfor operation or if the operand are invalid then raise exception
        private void _initializeOperands(Button operatorSymbol)
        {
            if (!_isOperatorThere)
            {
                _firstNumber = inputTextBox.Text;
                labelEquation.Text = inputTextBox.Text;
                inputTextBox.Text = "0";
                _isOperatorThere = true;
                _result = inputTextBox.Text;
            }
            else if (inputTextBox.Text == _result && !_isSciOpExcuted)
            {
                labelEquation.Text = labelEquation.Text.Substring(0, labelEquation.Text.Length - 1);
            }
            else
            {
                try
                {
                    _secondNumber = inputTextBox.Text;
                    _operator = labelEquation.Text[labelEquation.Text.Length - 1];
                    PerformOperation(double.Parse(_firstNumber), double.Parse(_secondNumber), _operator);
                    _firstNumber = _result;
                }
                catch
                {
                    operatorSymbol.Tag = "Exception";
                }
            }
        }

        // this function provide the all constant value 
        private void ConstOpClicked(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            switch (btn.Tag.ToString())
            {
                case "∏":
                    inputTextBox.Text = Calculator.AirthmatiCalLib.PiValue.ToString();
                    break;
                case "e":
                    inputTextBox.Text = Calculator.AirthmatiCalLib.ExpValue.ToString();
                    break;
            }
        }
        #endregion

        #region Clearing the Inputs or screen
        // this function will be invoked to clear the screen or the inputbox
        private void ClearScreen(object sender, EventArgs e)
        {
            Button clear = (Button)(sender);
            switch (clear.Tag)
            {
                case "C":
                    inputTextBox.Text = "0";
                    break;
                case "CE":
                    inputTextBox.Text = "0";
                    labelEquation.Text = "";
                    _isOperatorExcuted = false;
                    _isOperatorThere = false;
                    _evalExcuted = false;
                    _firstNumber = "";
                    _secondNumber = "";
                    _result = "";
                    break;
                default: //if Esc clicked then it will going to excute
                    if (inputTextBox.Text.Length > 1)
                        inputTextBox.Text = inputTextBox.Text.Substring(0, inputTextBox.Text.Length - 1);
                    else
                        inputTextBox.Text = "0";
                    break;
            }
        }
        #endregion

        // this function perform the action required for clicking the MS MR M- M= Buttons
        private void MemoryBtnClicked(object sender, EventArgs e)
        {
            Button btn = (Button)(sender);
            switch (btn.Tag.ToString())
            {
                case "MR":
                    if (_isMemoryThere)
                    {
                        inputTextBox.Text = _memoryValue.ToString();
                    }
                    break;
                case "MS":
                    _memoryValue = double.Parse(inputTextBox.Text);
                    _isMemoryThere = true;
                    btnMemoryClear.Enabled = true;
                    btnMemoryRestore.Enabled = true;
                    break;
                case "MC":
                    if (_isMemoryThere)
                    {
                        _isMemoryThere = false;
                        _memoryValue = 0;
                        btnMemoryClear.Enabled = false;
                        btnMemoryRestore.Enabled = false;
                    }
                    break;
                case "M-":
                    _memoryValue--;
                    break;
                case "M+":
                    _memoryValue++;
                    break;
            }
        }

        // this function perform the basic operation
        public void PerformOperation(double fNumber, Double sNumber, char opera)
        {
            BasicCalculatorLib = new Calculator.AirthmatiCalLib(fNumber, sNumber);
            switch (opera)
            {
                case '+':
                    _result = BasicCalculatorLib.Add().ToString();
                    break;
                case '-':
                    _result = BasicCalculatorLib.Sub().ToString();
                    break;
                case '*':
                    _result = BasicCalculatorLib.Mul().ToString();
                    break;
                case '/':
                    if (sNumber == 0)
                    {
                        inputTextBox.Text = LogicResource.DivByZero;
                        _exceptionAccour = true;
                    }
                    else
                    {
                        _result = BasicCalculatorLib.Div().ToString();
                        _exceptionAccour = false;
                    }
                    break;
                case '%':
                    _result = BasicCalculatorLib.Mod().ToString();
                    break;
                case '^':
                    _result = BasicCalculatorLib.Power().ToString();
                    break;
            }
            if (!_exceptionAccour)
            {
                labelEquation.Text += inputTextBox.Text;
                inputTextBox.Text = _result;
            }
            _isOperatorThere = false;
            _isOperatorExcuted = true;
        }

        public void OnEqualBtnClick(object sender, EventArgs e)
        {
            if (_isOperatorThere)
            {
                _operator = labelEquation.Text[labelEquation.Text.Length - 1];
                _secondNumber = inputTextBox.Text;
                try
                {
                    PerformOperation(double.Parse(_firstNumber), double.Parse(_secondNumber), _operator);
                }
                catch (Exception)
                {
                    MessageBox.Show(LogicResource.ErrorMsg);
                    btnClearEverything.PerformClick();
                }
                _evalExcuted = true;
                _isOperatorExcuted = true;
            }
        }

        //this function is invoked when any of the menu button is Clicked
        private void MenuItemClick(object sender, EventArgs e)
        {
            MenuItem btn = (MenuItem)sender;
            switch (btn.Tag.ToString())
            {
                case "Standerd":
                    Height = 510;
                    this.RemoveScientificControl();
                    break;
                case "Scientific":
                    Height = 650;
                    this.AddScientificControl();
                    break;
                case "Copy":
                    _copyData = inputTextBox.Text;
                    break;
                case "Paste":
                    inputTextBox.Text = _copyData;
                    break;
                case "Help":
                    if (!IsHelpMenuOpen)
                    {
                        Help help = new Help();
                        help.Show();
                        IsHelpMenuOpen = true;
                    }
                    break;
                case "Exit":
                    Close();
                    break;
            }
        }

        // Implementation of the the scientific operations

        public void OnUniaryOperatorClicked(object sender, EventArgs e)
        {
            AdvanceCalculatorLib = new Calculator.ScientificLib(double.Parse(inputTextBox.Text));
            Button Operator = (Button)sender;
            switch (Operator.Tag)
            {
                case "1/x":
                    _result = AdvanceCalculatorLib.OneDivByX().ToString();
                    break;
                case "x!":
                    _result = AdvanceCalculatorLib.Fact().ToString();
                    break;
                case "Sine":
                    _result = AdvanceCalculatorLib.Sine().ToString();
                    break;
                case "Cos":
                    _result = AdvanceCalculatorLib.Cosine().ToString();
                    break;
                case "x^2":
                    _result = AdvanceCalculatorLib.Sqr().ToString();
                    break;
                case "Tan":
                    _result = AdvanceCalculatorLib.Tan().ToString();
                    break;
                case "Log":
                    _result = AdvanceCalculatorLib.Log().ToString();
                    break;
                case "x^3":
                    _result = AdvanceCalculatorLib.Cube().ToString();
                    break;
                case "Root":
                    _result = AdvanceCalculatorLib.Sqrt().ToString();
                    break;
            }
            _isSciOpExcuted = true;
            inputTextBox.Text = AdvanceCalculatorLib.Result.ToString();
        }
        //this function will handle all the input from the keyboard
        public void OnKeyPressEvent(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Add:
                    btnPlusOp.PerformClick();
                    break;
                case Keys.Multiply:
                    btnMulOp.PerformClick();
                    break;
                case Keys.Divide:
                    btnDivOp.PerformClick();
                    break;
                case Keys.Subtract:
                    btnMinusOp.PerformClick();
                    break;
                case Keys.Shift:
                    btnMod.PerformClick();
                    break;
                case Keys.T:
                    btnTan.PerformClick();
                    break;
                case Keys.C:
                    btnClear.PerformClick();
                    break;
                case Keys.Enter:
                    btnEqual.PerformClick();
                    break;
                case Keys.NumPad1:
                    btnOne.PerformClick();
                    break;
                case Keys.NumPad2:
                    btnTwo.PerformClick();
                    break;
                case Keys.NumPad3:
                    btnThree.PerformClick();
                    break;
                case Keys.NumPad4:
                    btnFour.PerformClick();
                    break;
                case Keys.NumPad5:
                    btnFive.PerformClick();
                    break;
                case Keys.NumPad6:
                    btnSix.PerformClick();
                    break;
                case Keys.NumPad7:
                    btnSeven.PerformClick();
                    break;
                case Keys.NumPad8:
                    btnEight.PerformClick();
                    break;
                case Keys.NumPad9:
                    btnNine.PerformClick();
                    break;
                case Keys.NumPad0:
                    btnZero.PerformClick();
                    break;
                case Keys.Decimal:
                    btnDot.PerformClick();
                    break;
                case Keys.R:
                    btnMemoryRestore.PerformClick();
                    break;
                case Keys.S:
                    btnMemoryStore.PerformClick();
                    break;
                case Keys.Oemplus:
                    btnMPlus.PerformClick();
                    break;
                case Keys.OemMinus:
                    btnMMinus.PerformClick();
                    break;
                case Keys.Back:
                    btnEscape.PerformClick();
                    break;
            }
        }
       
    }
}

