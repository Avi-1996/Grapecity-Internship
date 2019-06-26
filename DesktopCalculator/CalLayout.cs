using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopCalculator
{
    partial class WinCalc : Form
    {
        List<Control> BasicControls = new List<Control>();
        List<Control> ScientificControls = new List<Control>();
        #region intialization of instansecs
        private MainMenu mainMenuMyMenu;
        private TextBox inputTextBox;
        private Button btnMemoryClear;
        private Button btnMemoryRestore;
        private Button btnMPlus;
        private Button btnMMinus;
        private Button btnEscape;
        private Button btnClearEverything;
        private Button btnClear;
        private Button btnRoot;
        private Button btnOne;
        private Button btnTwo;
        private Button btnMod;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnEqual;
        private Button btnZero;
        private Button btnDot;
        private Button btnPi;
        private Button btnLog;
        private Button btnSine;
        private Button btnXFact;
        private Button btnCos;
        private Button btnTan;
        private Button btnXPowTwo;
        private Button btnXPowY;
        private Label labelEquation;
        private Button btnMemoryStore;
        private Button btnPlusMinus;
        private Button btnDivOp;
        private Button btnMulOp;
        private Button btnPlusOp;
        private Button btnExpConst;
        private Button btnXCube;
        private Button btnThree;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMinusOp;
        private Button btnOneDivXOp;
        private ToolTip toolTipInformation;
        #endregion
        #region Allocating Memoroy To each Component

        public WinCalc()
        {
            DefineLayout();
            Height = 500;
        }

        private void AllocateMemory()
        {
            inputTextBox = new TextBox();
            btnMemoryClear = new Button();
            btnMemoryRestore = new Button();
            btnMPlus = new Button();
            btnMMinus = new Button();
            btnEscape = new Button();
            btnClearEverything = new Button();
            btnClear = new Button();
            btnRoot = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnMod = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnEqual = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnPi = new Button();
            btnLog = new Button();
            btnSine = new Button();
            btnXFact = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnXPowTwo = new Button();
            btnXPowY = new Button();
            labelEquation = new Label();
            btnMemoryStore = new Button();
            btnPlusMinus = new Button();
            btnDivOp = new Button();
            btnMulOp = new Button();
            btnPlusOp = new Button();
            btnExpConst = new Button();
            btnXCube = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMinusOp = new Button();
            btnOneDivXOp = new Button();
            toolTipInformation = new ToolTip();
        }
        #endregion

        #region Coding Of GUI
        private void AddMenu()
        {
            mainMenuMyMenu = new MainMenu();
            MenuItem menuOptionFile = mainMenuMyMenu.MenuItems.Add(LayoutResource.File);
            menuOptionFile.MenuItems.Add(LayoutResource.Standard, new EventHandler(MenuItemClick)).Tag ="Standerd"; ;
            menuOptionFile.MenuItems.Add(LayoutResource.Scientific, new EventHandler(MenuItemClick)).Tag ="Scientific";
            MenuItem menuOptionEdit = mainMenuMyMenu.MenuItems.Add(LayoutResource.Edit);
            menuOptionEdit.MenuItems.Add(LayoutResource.Copy, new EventHandler(MenuItemClick)).Tag = "Copy";
            menuOptionEdit.MenuItems.Add(LayoutResource.Paste, new EventHandler(MenuItemClick)).Tag = "Paste";
            MenuItem menuOptionHelp = mainMenuMyMenu.MenuItems.Add(LayoutResource.Help, new EventHandler(MenuItemClick));
            menuOptionHelp.Tag = "Help";
            MenuItem menuOptionExit = mainMenuMyMenu.MenuItems.Add(LayoutResource.Exit, new EventHandler(MenuItemClick));
            menuOptionExit.Tag = "Exit";
            Menu = mainMenuMyMenu;
        }
        private void AddTextBox()
        {
            inputTextBox.Text = "0";
            inputTextBox.Enabled = false;
            inputTextBox.Font = new Font(LayoutResource.Font, 13.8F, FontStyle.Bold);
            inputTextBox.Location = new Point(12, 31);
            inputTextBox.Multiline = true;
            inputTextBox.Name = LayoutResource.InputTextBox;
            inputTextBox.Size = new Size(349, 83);
            inputTextBox.TextAlign = HorizontalAlignment.Right;
        }

        private void AddButtons()
        {
            // 
            //  btnMemoryClear
            // 
            btnMemoryClear.Enabled = false;
            btnMemoryClear.Tag = LayoutResource.McBtnTag;
            btnMemoryClear.Location = new Point(12, 117);
            btnMemoryClear.Name = LayoutResource.McBtnName;
            btnMemoryClear.Text = LayoutResource.McBtnText;
            btnMemoryClear.Click += new EventHandler(MemoryBtnClicked);
            toolTipInformation.SetToolTip(btnMemoryClear, LayoutResource.McBtnToolTip);
            // 
            //  btnMemoryRestore
            // 
            btnMemoryRestore.Enabled = false;
            btnMemoryRestore.Tag = LayoutResource.MrBtnTag;
            btnMemoryRestore.Location = new Point(83, 117);
            btnMemoryRestore.Name = LayoutResource.MrBtnName;
            btnMemoryRestore.Text = LayoutResource.MrBtnTag;
            toolTipInformation.SetToolTip(btnMemoryRestore, LayoutResource.MrToolTip);
            btnMemoryRestore.Click += new EventHandler(MemoryBtnClicked);
            toolTipInformation.SetToolTip(btnMemoryRestore, LayoutResource.MrToolTip);
            // 
            // Memory increment button
            // 
            btnMPlus.Tag = LayoutResource.MPlusTag;
            btnMPlus.Location = new Point(225, 117);
            btnMPlus.Name = LayoutResource.MPlusName;
            btnMPlus.Text = LayoutResource.MPlusTag;
            btnMPlus.Click += new EventHandler(MemoryBtnClicked);
            toolTipInformation.SetToolTip(btnMPlus, LayoutResource.MPlusToolTip);
            // 
            // btnMMinus
            // 
            btnMMinus.Tag = LayoutResource.MminusTag;
            btnMMinus.Location = new Point(296, 117);
            btnMMinus.Name = LayoutResource.MminusName;
            btnMMinus.Text = LayoutResource.MminusTag;
            btnMMinus.Click += new EventHandler(MemoryBtnClicked);
            toolTipInformation.SetToolTip(btnMMinus, LayoutResource.MMinusToolTip);
            // 
            // btnEscape
            // 
            btnEscape.Tag = LayoutResource.EscToolTip;
            btnEscape.Location = new Point(12, 173);
            btnEscape.Name = LayoutResource.EScName;
            btnEscape.Text = LayoutResource.EscText;
            btnEscape.Click += new EventHandler(ClearScreen);
            toolTipInformation.SetToolTip(btnEscape, LayoutResource.EscToolTip);
            // 
            // btnClearEverything
            // 
            btnClearEverything.Tag = LayoutResource.CEBtnTag;
            btnClearEverything.Location = new Point(83, 173);
            btnClearEverything.Name = LayoutResource.CEName;
            btnClearEverything.Text = LayoutResource.CEText;
            btnClearEverything.Click += new EventHandler(ClearScreen);
            toolTipInformation.SetToolTip(btnClearEverything, LayoutResource.CeToolTip);
            // 
            // btnClear
            // 
            btnClear.Tag = LayoutResource.ClearBtnTag;
            btnClear.Location = new Point(154, 173);
            btnClear.Name = LayoutResource.ClearBtnName;
            btnClear.Text = LayoutResource.ClearbtnText;
            btnClear.Click += new EventHandler(ClearScreen);
            toolTipInformation.SetToolTip(btnClear, LayoutResource.ClearToolTip);
            // 
            // btnRoot
            // 
            btnRoot.Tag = LayoutResource.RootBtnTag;
            btnRoot.Location = new Point(296, 173);
            btnRoot.Name = LayoutResource.RootBtnName;
            btnRoot.Text = LayoutResource.RootBtnText;
            btnRoot.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnRoot, LayoutResource.rootTooltip);
            // 
            // btnOne
            // 
            btnOne.Tag = LayoutResource.OneBtnTag;
            btnOne.Location = new Point(12, 229);
            btnOne.Name = LayoutResource.OneBtnName;
            btnOne.Text = LayoutResource.OneBtnText;
            btnOne.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnOne, LayoutResource.OneToolTip);
            // 
            // btnTwo
            //
            btnTwo.Tag = LayoutResource.TwoBtnTag;
            btnTwo.Location = new Point(83, 229);
            btnTwo.Name = LayoutResource.TwoBtnName;
            btnTwo.Text = LayoutResource.TwoBtnText;
            btnTwo.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnTwo, LayoutResource.TwoToolTip);
            // 
            // btnThree
            // 
            btnThree.Tag = LayoutResource.ThreeBtnTag;
            btnThree.Location = new Point(154, 229);
            btnThree.Name = LayoutResource.ThreeBtnName;
            btnThree.Text = LayoutResource.ThreeBtnText;
            btnThree.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnThree, LayoutResource.ThreeToolTip);
            // 
            // btnMod
            // 
            btnMod.Tag = LayoutResource.ModBtnTag;
            btnMod.Location = new Point(296, 229);
            btnMod.Name = LayoutResource.ModBtnName;
            btnMod.Text = LayoutResource.ModBtnText;
            btnMod.Click += new EventHandler(OperatorClicked);
            toolTipInformation.SetToolTip(btnMod, LayoutResource.ModToolTip);
            // 
            // btnFour
            // 
            btnFour.Tag = LayoutResource.FourBtnTag;
            btnFour.Location = new Point(12, 285);
            btnFour.Name = LayoutResource.FourBtnName;
            btnFour.Text = LayoutResource.FourBtnText;
            btnFour.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnMemoryRestore, LayoutResource.FourToolTip);
            // 
            // btnFive
            // 
            btnFive.Tag = LayoutResource.FiveBtnTag;
            btnFive.Location = new Point(83, 285);
            btnFive.Name = LayoutResource.FiveBtnName;
            btnFive.Text = LayoutResource.FiveBtnText;
            btnFive.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnFive, LayoutResource.FiveToolTip);
            // 
            // btnSix
            // 
            btnSix.Tag = LayoutResource.SixBtnTag;
            btnSix.Location = new Point(154, 285);
            btnSix.Name = LayoutResource.SixBtnName;
            btnSix.Text = LayoutResource.SixBtnText;
            btnSix.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnSix, LayoutResource.SixToolTip);
            // 
            // btnEqual
            // 
            btnEqual.Tag = LayoutResource.EqualBtnTag;
            btnEqual.Location = new Point(296, 340);
            btnEqual.Size = new Size(65, 106);
            btnEqual.Name = LayoutResource.EqualBtnName;
            btnEqual.Text = LayoutResource.EqualBtnText;
            btnEqual.Click += new EventHandler(OnEqualBtnClick);
            toolTipInformation.SetToolTip(btnEqual, LayoutResource.EqualBtnToolTip);
            // 
            // btnZero
            // 
            btnZero.Tag = LayoutResource.ZeroBtnTag;
            btnZero.Font = new Font(LayoutResource.Font, 10.8F, FontStyle.Bold);
            btnZero.Location = new Point(12, 396);
            btnZero.Name = LayoutResource.ZeroBtnName;
            btnZero.Size = new Size(136, 50);
            btnZero.Text = LayoutResource.ZeroBtnText;
            btnZero.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnZero, LayoutResource.ZeroBtnToolTip);
            // 
            // btnDot
            // 
            btnDot.Tag = LayoutResource.DotBtnTag;
            btnDot.Location = new Point(154, 396);
            btnDot.Name = LayoutResource.DotBtnName;
            btnDot.Text = LayoutResource.DotBtnText;
            btnDot.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnDot, LayoutResource.DotBtnToolTip);
            // 
            // btnPi
            // 
            btnPi.Size = new Size(65, 50);
            btnPi.Tag = LayoutResource.PiBtnTag;
            btnPi.Location = new Point(12, 472);
            btnPi.Name = LayoutResource.PiBtnName;
            btnPi.Size = new Size(65, 50);
            btnPi.Text = LayoutResource.PiBtnText;
            btnPi.Click += new EventHandler(ConstOpClicked);
            toolTipInformation.SetToolTip(btnPi, LayoutResource.PiBtnToolTip);
            // 
            // btnLog
            // 
            btnLog.Tag = LayoutResource.LogBtnTag;
            btnLog.Location = new Point(83, 472);
            btnLog.Name = LayoutResource.LogBtnName;
            btnLog.Text = LayoutResource.LogBtnText;
            btnLog.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnLog, LayoutResource.LogBtnToolTip);
            // 
            // btnSine
            // 
            btnSine.Tag = LayoutResource.SineBtnTag;
            btnSine.Location = new Point(296, 472);
            btnSine.Name = LayoutResource.SineBtnName;
            btnSine.Text = LayoutResource.SineBtnText;
            btnSine.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnSine, LayoutResource.SineBtnToolTip);
            // 
            // Xfact Button
            // 
            btnXFact.Tag = LayoutResource.XFactBtnTag;
            btnXFact.Location = new Point(154, 472);
            btnXFact.Name = LayoutResource.XFactBtnName;
            btnXFact.Text = LayoutResource.XFactBtnText;
            btnXFact.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnXFact, LayoutResource.XFactBtnTooTip);
            // 
            // btnCos
            // 
            btnCos.Tag = LayoutResource.CosBtnTag;
            btnCos.Location = new Point(12, 528);
            btnCos.Name = LayoutResource.CosBtnName;
            btnCos.Text = LayoutResource.CosBtnText;
            btnCos.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnXFact, LayoutResource.CosBtnToolTip);
            // 
            // btnTan
            // 
            btnTan.Tag = LayoutResource.TanBtnTag;
            btnTan.Location = new Point(83, 528);
            btnTan.Name = LayoutResource.TanBtnName;
            btnTan.Text = LayoutResource.TanBtnText;
            btnTan.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnTan, LayoutResource.TanBtnToolTip);
            // 
            // btnXPowTwo
            // 
            btnXPowTwo.Tag = LayoutResource.XPowTwoBtnTag;
            btnXPowTwo.Location = new Point(225, 472);
            btnXPowTwo.Name = LayoutResource.XPowTwoBtnName;
            btnXPowTwo.Text = LayoutResource.XPowTwoBtnText;
            btnXPowTwo.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnXPowTwo, LayoutResource.XPowTwoBtnToolTip);
            // 
            // btnXPowY
            // 
            btnXPowY.Tag = LayoutResource.XPowYBtnTag;
            btnXPowY.Location = new Point(296, 528);
            btnXPowY.Name = LayoutResource.XPowYBtnName;
            btnXPowY.Text = LayoutResource.XPowYBtnText;
            btnXPowY.Click += new EventHandler(OperatorClicked);
            toolTipInformation.SetToolTip(btnXPowY, LayoutResource.XPowYBtnToolTip);
            // 
            // labelEquation
            // 
            labelEquation.Enabled = true;
            labelEquation.AutoSize = true;
            labelEquation.Location = new Point(16, 95);
            labelEquation.Name = LayoutResource.EquationLabeName;
            labelEquation.Font = new Font(LayoutResource.Font, 7.8F, FontStyle.Regular);
            labelEquation.Focus();
            // 
            // btnMemoryStore
            // 
            btnMemoryStore.Tag = LayoutResource.MsBtnTag;
            btnMemoryStore.Location = new Point(154, 117);
            btnMemoryStore.Name = LayoutResource.McBtnName;
            btnMemoryStore.Text = LayoutResource.MsBtnText; ;
            btnMemoryStore.Click += new EventHandler(MemoryBtnClicked);
            toolTipInformation.SetToolTip(btnMemoryStore, LayoutResource.MsBtnToolTip);
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Tag = LayoutResource.PlusMinusBtnTag;
            btnPlusMinus.Location = new Point(225, 173);
            btnPlusMinus.Name = LayoutResource.PlusMinusBtnName;
            btnPlusMinus.Text = LayoutResource.PlusMinusBtnText;
            btnPlusMinus.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnPlusMinus, LayoutResource.PlusMinusBtnToolTip);
            // 
            // btnDivOp
            // 
            btnDivOp.Tag = LayoutResource.DivBtnTag;
            btnDivOp.Location = new Point(225, 229);
            btnDivOp.Name = LayoutResource.DivBtnName;
            btnDivOp.Text = LayoutResource.DivBtnText;
            btnDivOp.Click += new EventHandler(OperatorClicked);
            toolTipInformation.SetToolTip(btnDivOp, LayoutResource.DivBtnToolTip);
            // 
            // btnMulOp
            // 
            btnMulOp.Tag = LayoutResource.MulBtnTag;
            btnMulOp.Location = new Point(225, 285);
            btnMulOp.Text = LayoutResource.MulBtnText;
            btnMulOp.Click += new EventHandler(OperatorClicked);
            toolTipInformation.SetToolTip(btnMulOp, LayoutResource.MulBtnTooltip);
            // 
            // btnPlusOp
            // 
            btnPlusOp.Tag = LayoutResource.PlusBtnTag;
            btnPlusOp.Location = new Point(225, 396);
            btnPlusOp.Name = LayoutResource.PlusBtnName;
            btnPlusOp.Text = LayoutResource.PlusBtnText;
            btnPlusOp.Click += new EventHandler(OperatorClicked);
            toolTipInformation.SetToolTip(btnPlusOp, LayoutResource.PlusBtnToolTip);
            // 
            // btnExpConst
            // 
            btnExpConst.Tag = LayoutResource.ExpBtnTag;
            Font = new Font(LayoutResource.GeorgiaFont, 10.8F,(FontStyle)(FontStyle.Bold | FontStyle.Italic));
            btnExpConst.Location = new Point(154, 528);
            btnExpConst.Name = LayoutResource.ExpBtnName;
            btnExpConst.Size = new Size(65, 50);
            btnExpConst.Text = LayoutResource.ExpBtnText;
            btnExpConst.Click += new EventHandler(ConstOpClicked);
            toolTipInformation.SetToolTip(btnExpConst, LayoutResource.ExpBtnToolTip);
            // 
            // btnXCube
            // 
            btnXCube.Tag = LayoutResource.XQubeBtnTag;
            btnXCube.Location = new Point(225, 528);
            btnXCube.Name = LayoutResource.XQubeBtnName;
            btnXCube.Text = LayoutResource.XQubeBtnText;
            btnXCube.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnXCube, LayoutResource.XQubeBtnToolTip);
            // 
            // btnSeven
            // 
            btnSeven.Tag = LayoutResource.SevenBtnTag;
            btnSeven.Location = new Point(12, 340);
            btnSeven.Name = LayoutResource.SevenBtnName;
            btnSeven.Text = LayoutResource.SevenBtnText;
            btnSeven.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnSeven, LayoutResource.SevenBtnToolTip);
            // 
            // btnEight
            // 
            btnEight.Tag = LayoutResource.EightBtnTag;
            btnEight.Location = new Point(83, 341);
            btnEight.Name = LayoutResource.EightBtnName;
            btnEight.Text = LayoutResource.EightBtnText;
            btnEight.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnEight, LayoutResource.EightBtnToolTip);
            // 
            // btnNine
            // 
            btnNine.Tag = LayoutResource.NineBtnTag;
            btnNine.Location = new Point(154, 340);
            btnNine.Name = LayoutResource.NineBtnName;
            btnNine.Text = LayoutResource.NineBtnText;
            btnNine.Click += new EventHandler(NumberBtnClick);
            toolTipInformation.SetToolTip(btnNine, LayoutResource.NineBtnToolTip);
            // 
            // btnMinusOp
            // 
            btnMinusOp.Tag = LayoutResource.MinusBtnTag;
            btnMinusOp.Location = new Point(225, 341);
            btnMinusOp.Name = LayoutResource.MinusBtnName;
            btnMinusOp.Text = LayoutResource.MinusBtnText;
            btnMinusOp.Click += new EventHandler(OperatorClicked);
            toolTipInformation.SetToolTip(btnMinusOp, LayoutResource.MinusBtnToolTip);
            // 
            // btnOneDivXOp
            //
            btnOneDivXOp.Tag = LayoutResource.OneDivXTag;
            btnOneDivXOp.Location = new Point(296, 285);
            btnOneDivXOp.Name = LayoutResource.OneDivXName;
            btnOneDivXOp.Text = LayoutResource.OneDivXText;
            btnOneDivXOp.Click += new EventHandler(OnUniaryOperatorClicked);
            toolTipInformation.SetToolTip(btnOneDivXOp, LayoutResource.OneDivXToolTip);
        }
        #endregion

        #region Adding GUI Component to the Form
        private void AddControls()
        {
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 594);
            BasicControls.Add(inputTextBox);
            Controls.Add(labelEquation);
            BasicControls.Add(btnEqual);
            BasicControls.Add(btnMod);
            BasicControls.Add(btnRoot);
            BasicControls.Add(btnMMinus);
            BasicControls.Add(btnPlusOp);
            BasicControls.Add(btnDot);
            BasicControls.Add(btnMulOp);
            BasicControls.Add(btnOneDivXOp);
            BasicControls.Add(btnMinusOp);
            BasicControls.Add(btnNine);
            BasicControls.Add(btnSix);
            BasicControls.Add(btnEight);
            BasicControls.Add(btnFive);
            BasicControls.Add(btnDivOp);
            BasicControls.Add(btnThree);
            BasicControls.Add(btnTwo);
            BasicControls.Add(btnEscape);
            BasicControls.Add(btnMemoryClear);
            BasicControls.Add(btnMemoryRestore);
            BasicControls.Add(btnZero);
            BasicControls.Add(btnPlusMinus);
            BasicControls.Add(btnClear);
            BasicControls.Add(btnSeven);
            BasicControls.Add(btnFour);
            BasicControls.Add(btnClearEverything);
            BasicControls.Add(btnOne);
            BasicControls.Add(btnMemoryStore);
            BasicControls.Add(btnMPlus);
            //Adding Scientific Controls
            ScientificControls.Add(btnLog);
            ScientificControls.Add(btnPi);
            ScientificControls.Add(btnSine);
            ScientificControls.Add(btnXPowY);
            ScientificControls.Add(btnXPowTwo);
            ScientificControls.Add(btnTan);
            ScientificControls.Add(btnExpConst);
            ScientificControls.Add(btnXFact);
            ScientificControls.Add(btnXCube);
            ScientificControls.Add(btnCos);

            foreach (Control control in BasicControls)
            {
                Controls.Add(control);
                control.TabStop = false;
                if(control.Name != LayoutResource.InputTextBoxName 
                    && control.Name != LayoutResource.ZeroBtnName 
                    && control.Name != LayoutResource.EqualBtnName 
                   && control.Name != LayoutResource.EquationLabeName)
                {
                    control.Size = new Size(65, 50);
                    control.Font = new Font(LayoutResource.Font, 10.8F, FontStyle.Bold);
                }
            }
            
        }
        //This function will add the Scientific Controls On runtime 
        public void AddScientificControl()
        {
            foreach (Control control in ScientificControls)
            {

                if (control.Name != LayoutResource.ExpBtnName)
                {
                    control.Size = new Size(65, 50);
                    control.Font = new Font(LayoutResource.Font, 10.8F, FontStyle.Bold);
                }
                Controls.Add(control);
            }
        }
        //This function will add the Scientific Controls On runtime
        public void RemoveScientificControl()
        {
            foreach (Control control in ScientificControls)
            {
                Controls.Remove(control);
            }
        }
        #endregion
    }
}
