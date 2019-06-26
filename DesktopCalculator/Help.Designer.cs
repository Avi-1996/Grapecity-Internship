using System;
using System.Windows.Forms;
namespace DesktopCalculator
{
    partial class Help
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        // Drawing the mainLLayout
        private void DrawLayout()
        {
            AllocateMemory();
            DrawButtons();
            DrawLabel();
            Drawtablelayout();
            DrwaPicture();
            SuspendLayout();
            // 
            // Help
            // 
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnHelpMenuClosed);
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1152, 561);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutHelp);
            Controls.Add(tableLayoutHelp1);
            Controls.Add(labelHelp);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = LayoutResource.HelpLayoutName;
            Text = LayoutResource.HelpLayoutName;
            tableLayoutHelp1.ResumeLayout(false);
            tableLayoutHelp.ResumeLayout(false);
            tableLayoutHelp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        
        #region drwaing the Component
        public void DrawButtons()
        {
            // btnDiv
            // 
            btnDiv.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnDiv.Location = new System.Drawing.Point(3, 108);
            btnDiv.Name = LayoutResource.DivBtnName;
            btnDiv.Size = new System.Drawing.Size(81, 29);
            btnDiv.Text = LayoutResource.DivBtnText;
            // 
            // btnMod
            // 
            btnMod.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMod.Location = new System.Drawing.Point(3, 143);
            btnMod.Name = LayoutResource.ModBtnName;
            btnMod.Size = new System.Drawing.Size(81, 29);
            btnMod.Text = LayoutResource.ModBtnText;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnPlusMinus.Location = new System.Drawing.Point(3, 178);
            btnPlusMinus.Name = LayoutResource.PlusMinusBtnName;
            btnPlusMinus.Size = new System.Drawing.Size(81, 29);
            btnPlusMinus.Text = LayoutResource.PlusMinusBtnText;
            // 
            // btnMr
            // 
            btnMr.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMr.Location = new System.Drawing.Point(3, 213);
            btnMr.Name = LayoutResource.MrBtnName;
            btnMr.Size = new System.Drawing.Size(81, 29);
            btnMr.TabIndex = 0;
            // 
            // btnMc
            // 
            btnMc.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMc.Location = new System.Drawing.Point(3, 248);
            btnMc.Name = LayoutResource.McBtnName;
            btnMc.Size = new System.Drawing.Size(81, 29);
            btnMc.Text = LayoutResource.McBtnText;
            // 
            // btnMs
            // 
            btnMs.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMs.Location = new System.Drawing.Point(3, 283);
            btnMs.Name = LayoutResource.MsBtnName;
            btnMs.Size = new System.Drawing.Size(81, 29);
            btnMs.Text = LayoutResource.MsBtnText;
           
            // 
            // btnMMinus
            // 
            btnMMinus.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMMinus.Location = new System.Drawing.Point(3, 318);
            btnMMinus.Name = LayoutResource.MminusName;
            btnMMinus.Size = new System.Drawing.Size(80, 29);
            btnMMinus.Text = LayoutResource.MminusTag;
           
            // 
            // btnMPlus
            // 
            btnMPlus.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMPlus.Location = new System.Drawing.Point(3, 353);
            btnMPlus.Name = LayoutResource.MPlusName;
            btnMPlus.Size = new System.Drawing.Size(81, 29);
            btnMPlus.TabIndex = 0;
            btnMPlus.Text = LayoutResource.MPlusTag;
            // 
            // btnSine
            // 
            btnSine.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnSine.Location = new System.Drawing.Point(438, 3);
            btnSine.Name = LayoutResource.SineBtnName;
            btnSine.Size = new System.Drawing.Size(65, 29);
            btnSine.Text = LayoutResource.SineBtnText;
            // 
            // btnCos
            // 
            btnCos.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnCos.Location = new System.Drawing.Point(438, 38);
            btnCos.Name = LayoutResource.CosBtnName;
            btnCos.Size = new System.Drawing.Size(65, 29);
            btnCos.Text = LayoutResource.CosBtnText;
            // 
            // btnTan
            // 
            btnTan.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnTan.Location = new System.Drawing.Point(438, 73);
            btnTan.Name = LayoutResource.TanBtnName;
            btnTan.Size = new System.Drawing.Size(65, 29);
            btnTan.Text = LayoutResource.TanBtnText;
            // 
            // btnXPowY
            // 
            btnXPowY.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnXPowY.Location = new System.Drawing.Point(438, 108);
            btnXPowY.Name = LayoutResource.XPowYBtnName;
            btnXPowY.Size = new System.Drawing.Size(65, 29);
            btnXPowY.Text = LayoutResource.XPowYBtnText;
            // 
            // btnPi
            // 
            btnPi.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnPi.Location = new System.Drawing.Point(438, 143);
            btnPi.Name = LayoutResource.PiBtnName;
            btnPi.Size = new System.Drawing.Size(65, 29);
            btnPi.Text = LayoutResource.PiBtnText;
            // 
            // btnExp
            // 
            btnExp.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnExp.Location = new System.Drawing.Point(438, 178);
            btnExp.Name = LayoutResource.ExpBtnName;
            btnExp.Size = new System.Drawing.Size(65, 29);
            btnExp.Text = LayoutResource.ExpBtnText;
            // 
            // btnXCube
            // 
            btnXCube.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnXCube.Location = new System.Drawing.Point(438, 213);
            btnXCube.Name = LayoutResource.XQubeBtnName;
            btnXCube.Size = new System.Drawing.Size(65, 29);
            btnXCube.Text = LayoutResource.XQubeBtnText;
            // 
            // btnOneDivX
            // 
            btnOneDivX.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnOneDivX.Location = new System.Drawing.Point(438, 248);
            btnOneDivX.Name = LayoutResource.OneDivXName;
            btnOneDivX.Size = new System.Drawing.Size(65, 29);
            btnOneDivX.Text = LayoutResource.OneDivXText;
            // 
            // btnEsc
            // 
            btnEsc.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnEsc.Location = new System.Drawing.Point(438, 283);
            btnEsc.Name = LayoutResource.EScName;
            btnEsc.Size = new System.Drawing.Size(65, 29);
            btnEsc.Text = LayoutResource.EscText; 
            // 
            // btnEqual
            // 
            btnEqual.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnEqual.Location = new System.Drawing.Point(438, 318);
            btnEqual.Name = LayoutResource.EqualBtnName;
            btnEqual.Size = new System.Drawing.Size(65, 29);
            btnEqual.Text = LayoutResource.EqualBtnText;
            // 
            // btnXFact
            // 
            btnXFact.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnXFact.Location = new System.Drawing.Point(438, 353);
            btnXFact.Name = LayoutResource.XFactBtnName;
            btnXFact.Size = new System.Drawing.Size(65, 29);
            btnXFact.Text = LayoutResource.XFactBtnText;
            // 
            // btnRoot
            // 
            btnRoot.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnRoot.Location = new System.Drawing.Point(438, 388);
            btnRoot.Name = LayoutResource.RootBtnName;
            btnRoot.Size = new System.Drawing.Size(65, 29);
            btnRoot.TabIndex = 0;
            btnRoot.Text = LayoutResource.RootBtnText;
            btnRoot.UseVisualStyleBackColor = true;
            // 
            // btnCE
            // 
            btnCE.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnCE.Location = new System.Drawing.Point(438, 423);
            btnCE.Name = LayoutResource.CEName;
            btnCE.Size = new System.Drawing.Size(65, 37);
            btnCE.Text = LayoutResource.CEText;
            // 
            // btnXPowTwo
            // 
            btnXPowTwo.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnXPowTwo.Location = new System.Drawing.Point(3, 388);
            btnXPowTwo.Name = LayoutResource.XPowTwoBtnName;
            btnXPowTwo.Size = new System.Drawing.Size(81, 29);
            btnXPowTwo.Text = LayoutResource.XPowTwoBtnText;
            // 
            // btnClear
            // 
            btnClear.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnClear.Location = new System.Drawing.Point(3, 423);
            btnClear.Name = LayoutResource.ClearBtnName;
            btnClear.Size = new System.Drawing.Size(81, 37);
            btnClear.Text = LayoutResource.ClearbtnText;
            // 
            // btnMul
            // 
            btnMul.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMul.Location = new System.Drawing.Point(3, 73);
            btnMul.Name = LayoutResource.MulBtnName;
            btnMul.Size = new System.Drawing.Size(81, 29);
            btnMul.Text = LayoutResource.MulBtnText;
            // 
            // btnMinus
            // 
            btnMinus.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnMinus.Location = new System.Drawing.Point(3, 38);
            btnMinus.Name = LayoutResource.MinusBtnName;
            btnMinus.Size = new System.Drawing.Size(81, 29);
            btnMinus.Text = LayoutResource.MinusBtnText;
            // 
            // btnPlus
            // 
            btnPlus.Font = new System.Drawing.Font(LayoutResource.Font, 12F, System.Drawing.FontStyle.Bold);
            btnPlus.Location = new System.Drawing.Point(3, 3);
            btnPlus.Name = LayoutResource.PlusBtnName;
            btnPlus.Size = new System.Drawing.Size(81, 29);
            btnPlus.Text = LayoutResource.PlusBtnText;
        }
        public void DrawLabel()
        {
            // 
            // labelHelp
            // 
            labelHelp.AutoSize = true;
            labelHelp.Font = new System.Drawing.Font(LayoutResource.Font, 22.2F, System.Drawing.FontStyle.Bold);
            labelHelp.Location = new System.Drawing.Point(225, 9);
            labelHelp.Size = new System.Drawing.Size(594, 44);
            labelHelp.Text = LayoutResource.LableHelpTitle;
            // 
            // labelClear
            // 
            labelClear.AutoSize = true;
            labelClear.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelClear.Location = new System.Drawing.Point(90, 420);
            labelClear.Size = new System.Drawing.Size(223, 20);
            labelClear.Text = LayoutResource.ClearToolTip;
            // 
            // labelCe
            // 
            labelCe.AutoSize = true;
            labelCe.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelCe.Location = new System.Drawing.Point(509, 420);
            labelCe.Size = new System.Drawing.Size(350, 40);
            labelCe.Text = LayoutResource.CeToolTip;
            // 
            // labelRoot
            // 
            labelRoot.AutoSize = true;
            labelRoot.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelRoot.Location = new System.Drawing.Point(509, 385);
            labelRoot.Size = new System.Drawing.Size(203, 20);
            labelRoot.Text = LayoutResource.rootTooltip;
            // 
            // labelXFact
            // 
            labelXFact.AutoSize = true;
            labelXFact.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelXFact.Location = new System.Drawing.Point(509, 350);
            labelXFact.Size = new System.Drawing.Size(199, 20);
            labelXFact.Text = LayoutResource.XFactBtnTooTip;
            // 
            // labelSine
            // 
            labelSine.AutoSize = true;
            labelSine.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelSine.Location = new System.Drawing.Point(509, 0);
            labelSine.Size = new System.Drawing.Size(152, 20);
            labelSine.Text = LayoutResource.SineBtnToolTip;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            label19.Location = new System.Drawing.Point(509, 35);
            label19.Size = new System.Drawing.Size(158, 20);
            label19.Text = LayoutResource.CosBtnToolTip;
            // 
            // labelEqual
            // 
            labelEqual.AutoSize = true;
            labelEqual.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelEqual.Location = new System.Drawing.Point(509, 315);
            labelEqual.Size = new System.Drawing.Size(282, 20);
            labelEqual.Text = LayoutResource.EqualBtnToolTip;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            label20.Location = new System.Drawing.Point(509, 70);
            label20.Size = new System.Drawing.Size(156, 20);
            label20.Text = LayoutResource.EqualBtnToolTip;
            // 
            // lablelXPowY
            // 
            lablelXPowY.AutoSize = true;
            lablelXPowY.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            lablelXPowY.Location = new System.Drawing.Point(509, 105);
            lablelXPowY.Size = new System.Drawing.Size(242, 20);
            lablelXPowY.Text = LayoutResource.XPowYBtnToolTip;
            // 
            // labelPi
            // 
            labelPi.AutoSize = true;
            labelPi.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelPi.Location = new System.Drawing.Point(509, 140);
            labelPi.Size = new System.Drawing.Size(221, 20);
            labelPi.Text = LayoutResource.PiBtnToolTip;
            // 
            // labelExp
            // 
            labelExp.AutoSize = true;
            labelExp.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelExp.Location = new System.Drawing.Point(509, 175);
            labelExp.Size = new System.Drawing.Size(214, 20);
            labelExp.Text = LayoutResource.ExpBtnToolTip;
            // 
            // labelXCube
            // 
            labelXCube.AutoSize = true;
            labelXCube.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelXCube.Location = new System.Drawing.Point(509, 210);
            labelXCube.Size = new System.Drawing.Size(163, 20);
            labelXCube.Text = LayoutResource.XQubeBtnToolTip;
            // 
            // labelOneDivX
            // 
            labelOneDivX.AutoSize = true;
            labelOneDivX.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelOneDivX.Location = new System.Drawing.Point(509, 245);
            labelOneDivX.Size = new System.Drawing.Size(303, 20);
            labelOneDivX.Text = LayoutResource.OneDivXToolTip;
            // 
            // labelEsc
            // 
            labelEsc.AutoSize = true;
            labelEsc.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelEsc.Location = new System.Drawing.Point(509, 280);
            labelEsc.Size = new System.Drawing.Size(341, 20);
            labelEsc.Text = LayoutResource.EscToolTip;
            // 
            // labelAdd
            // 
            labelAdd.AutoSize = true;
            labelAdd.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelAdd.Location = new System.Drawing.Point(90, 0);
            labelAdd.Size = new System.Drawing.Size(250, 20);
            labelAdd.Text = LayoutResource.PlusBtnToolTip;
            // 
            // labelMinus
            // 
            labelMinus.AutoSize = true;
            labelMinus.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMinus.Location = new System.Drawing.Point(90, 35);
            labelMinus.Size = new System.Drawing.Size(278, 20);
            labelMinus.Text = LayoutResource.MinusBtnToolTip;
            // 
            // labelMul
            // 
            labelMul.AutoSize = true;
            labelMul.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMul.Location = new System.Drawing.Point(90, 70);
            labelMul.Size = new System.Drawing.Size(289, 20);
            labelMul.Text = LayoutResource.MulBtnTooltip;
            // 
            // labelDIv
            // 
            labelDIv.AutoSize = true;
            labelDIv.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelDIv.Location = new System.Drawing.Point(90, 105);
            labelDIv.Size = new System.Drawing.Size(250, 20);
            labelDIv.Text = LayoutResource.DivBtnToolTip;
            // 
            // labelMod
            // 
            labelMod.AutoSize = true;
            labelMod.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMod.Location = new System.Drawing.Point(90, 140);
            labelMod.Size = new System.Drawing.Size(330, 20);
            labelMod.Text = LayoutResource.ModToolTip;
            // 
            // labelPlusMinus
            // 
            labelPlusMinus.AutoSize = true;
            labelPlusMinus.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelPlusMinus.Location = new System.Drawing.Point(90, 175);
            labelPlusMinus.Size = new System.Drawing.Size(236, 20);
            labelPlusMinus.Text = LayoutResource.PlusBtnToolTip;
            // 
            // labelMr
            // 
            labelMr.AutoSize = true;
            labelMr.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMr.Location = new System.Drawing.Point(90, 210);
            labelMr.Size = new System.Drawing.Size(287, 20);
            labelMr.Text = LayoutResource.MrToolTip;
            // 
            // labelMc
            // 
            labelMc.AutoSize = true;
            labelMc.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMc.Location = new System.Drawing.Point(90, 245);
            labelMc.Size = new System.Drawing.Size(272, 20);
            labelMc.Text = LayoutResource.McBtnToolTip;
            // 
            // labelMs
            // 
            labelMs.AutoSize = true;
            labelMs.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMs.Location = new System.Drawing.Point(90, 280);
            labelMs.Size = new System.Drawing.Size(219, 20);
            labelMs.Text = LayoutResource.MsBtnToolTip;
            // 
            // labelMDec
            // 
            labelMDec.AutoSize = true;
            labelMDec.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMDec.Location = new System.Drawing.Point(90, 315);
            labelMDec.Size = new System.Drawing.Size(303, 20);
            labelMDec.Text = LayoutResource.MMinusToolTip;
            // 
            // labelMInc
            // 
            labelMInc.AutoSize = true;
            labelMInc.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelMInc.Location = new System.Drawing.Point(90, 350);
            labelMInc.Size = new System.Drawing.Size(294, 20);
            labelMInc.Text = LayoutResource.MPlusToolTip;
            // 
            // labelXPowTwo
            // 
            labelXPowTwo.AutoSize = true;
            labelXPowTwo.Font = new System.Drawing.Font(LayoutResource.Font, 10.2F, System.Drawing.FontStyle.Bold);
            labelXPowTwo.Location = new System.Drawing.Point(90, 385);
            labelXPowTwo.Size = new System.Drawing.Size(286, 20);
            labelXPowTwo.Text = LayoutResource.XPowTwoBtnToolTip;
        }

        // Drawing the table layout for the description

        public void Drawtablelayout()
        {
            // 
            // tableLayoutHelp1
            // 
            tableLayoutHelp1.ColumnCount = 2;
            tableLayoutHelp1.Location = new System.Drawing.Point(282, 88);
            tableLayoutHelp1.Name = LayoutResource.TableLayoutName;
            tableLayoutHelp1.RowCount = 12;
            tableLayoutHelp1.Size = new System.Drawing.Size(537, 395);
            // 
            // tableLayoutHelp
            // 
            tableLayoutHelp.ColumnCount = 4;
            tableLayoutHelp.Controls.Add(btnMinus, 0, 1);
            tableLayoutHelp.Controls.Add(btnMul, 0, 2);
            tableLayoutHelp.Controls.Add(btnDiv, 0, 3);
            tableLayoutHelp.Controls.Add(btnMod, 0, 4);
            tableLayoutHelp.Controls.Add(btnPlusMinus, 0, 5);
            tableLayoutHelp.Controls.Add(btnMr, 0, 6);
            tableLayoutHelp.Controls.Add(btnMc, 0, 7);
            tableLayoutHelp.Controls.Add(btnMs, 0, 8);
            tableLayoutHelp.Controls.Add(btnPlus, 0, 0);
            tableLayoutHelp.Controls.Add(labelAdd, 1, 0);
            tableLayoutHelp.Controls.Add(labelMinus, 1, 1);
            tableLayoutHelp.Controls.Add(labelMul, 1, 2);
            tableLayoutHelp.Controls.Add(labelDIv, 1, 3);
            tableLayoutHelp.Controls.Add(labelMod, 1, 4);
            tableLayoutHelp.Controls.Add(labelPlusMinus, 1, 5);
            tableLayoutHelp.Controls.Add(labelMr, 1, 6);
            tableLayoutHelp.Controls.Add(labelMc, 1, 7);
            tableLayoutHelp.Controls.Add(labelMs, 1, 8);
            tableLayoutHelp.Controls.Add(labelMDec, 1, 9);
            tableLayoutHelp.Controls.Add(labelMInc, 1, 10);
            tableLayoutHelp.Controls.Add(labelXPowTwo, 1, 11);
            tableLayoutHelp.Controls.Add(btnMMinus, 0, 9);
            tableLayoutHelp.Controls.Add(btnMPlus, 0, 10);
            tableLayoutHelp.Controls.Add(btnSine, 2, 0);
            tableLayoutHelp.Controls.Add(btnCos, 2, 1);
            tableLayoutHelp.Controls.Add(btnTan, 2, 2);
            tableLayoutHelp.Controls.Add(btnXPowY, 2, 3);
            tableLayoutHelp.Controls.Add(btnPi, 2, 4);
            tableLayoutHelp.Controls.Add(btnExp, 2, 5);
            tableLayoutHelp.Controls.Add(btnXCube, 2, 6);
            tableLayoutHelp.Controls.Add(btnOneDivX, 2, 7);
            tableLayoutHelp.Controls.Add(btnEsc, 2, 8);
            tableLayoutHelp.Controls.Add(btnEqual, 2, 9);
            tableLayoutHelp.Controls.Add(btnXFact, 2, 10);
            tableLayoutHelp.Controls.Add(btnRoot, 2, 11);
            tableLayoutHelp.Controls.Add(btnCE, 2, 12);
            tableLayoutHelp.Controls.Add(btnXPowTwo, 0, 11);
            tableLayoutHelp.Controls.Add(btnClear, 0, 12);
            tableLayoutHelp.Controls.Add(labelClear, 1, 12);
            tableLayoutHelp.Controls.Add(labelCe, 3, 12);
            tableLayoutHelp.Controls.Add(labelRoot, 3, 11);
            tableLayoutHelp.Controls.Add(labelXFact, 3, 10);
            tableLayoutHelp.Controls.Add(labelSine, 3, 0);
            tableLayoutHelp.Controls.Add(label19, 3, 1);
            tableLayoutHelp.Controls.Add(label20, 3, 2);
            tableLayoutHelp.Controls.Add(lablelXPowY, 3, 3);
            tableLayoutHelp.Controls.Add(labelPi, 3, 4);
            tableLayoutHelp.Controls.Add(labelExp, 3, 5);
            tableLayoutHelp.Controls.Add(labelXCube, 3, 6);
            tableLayoutHelp.Controls.Add(labelOneDivX, 3, 7);
            tableLayoutHelp.Controls.Add(labelEsc, 3, 8);
            tableLayoutHelp.Controls.Add(labelEqual, 3, 9);
            tableLayoutHelp.Location = new System.Drawing.Point(285, 94);
            tableLayoutHelp.Name = LayoutResource.TableLayoutName;
            tableLayoutHelp.RowCount = 17;
            tableLayoutHelp.Size = new System.Drawing.Size(869, 467);
        }
        public void DrwaPicture()
        {
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DesktopCalculator.Properties.Resources.download;
            pictureBox1.Location = new System.Drawing.Point(15, 94);
            pictureBox1.Size = new System.Drawing.Size(264, 341);
            pictureBox1.TabStop = false;
        }
        #endregion

        #region Initialization and creating instances
        public void AllocateMemory()
        {
            labelHelp = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutHelp1 = new TableLayoutPanel();
            tableLayoutHelp = new TableLayoutPanel();
            btnDiv = new Button();
            btnMod = new Button();
            btnPlusMinus = new Button();
            btnMr = new Button();
            btnMc = new Button();
            btnMs = new Button();
            labelAdd = new Label();
            labelMinus = new Label();
            labelMul = new Label();
            labelDIv = new Label();
            labelMod = new Label();
            labelPlusMinus = new Label();
            labelMr = new Label();
            labelMc = new Label();
            labelMs = new Label();
            labelMDec = new Label();
            labelMInc = new Label();
            labelXPowTwo = new Label();
            btnMMinus = new Button();
            btnMPlus = new Button();
            btnSine = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnXPowY = new Button();
            btnPi = new Button();
            btnExp = new Button();
            btnXCube = new Button();
            btnOneDivX = new Button();
            btnEsc = new Button();
            btnEqual = new Button();
            btnXFact = new Button();
            btnRoot = new Button();
            btnCE = new Button();
            btnXPowTwo = new Button();
            btnClear = new Button();
            labelClear = new Label();
            labelCe = new Label();
            labelRoot = new Label();
            labelXFact = new Label();
            labelSine = new Label();
            label19 = new Label();
            label20 = new Label();
            lablelXPowY = new Label();
            labelPi = new Label();
            labelExp = new Label();
            labelXCube = new Label();
            labelOneDivX = new Label();
            labelEsc = new Label();
            labelEqual = new Label();
            btnMul = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            tableLayoutHelp1.SuspendLayout();
            tableLayoutHelp.SuspendLayout();
        }

        private Label labelHelp;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutHelp1;
        private TableLayoutPanel tableLayoutHelp;
        private Button btnDiv;
        private Button btnMod;
        private Button btnPlusMinus;
        private Button btnMr;
        private Button btnMc;
        private Button btnMs;
        private Button btnMMinus;
        private Button btnMPlus;
        private Button btnEsc;
        private Button btnEqual;
        private Button btnClear;
        private Button btnCos;
        private Button btnTan;
        private Button btnXPowY;
        private Button btnPi;
        private Button btnExp;
        private Button btnXCube;
        private Button btnOneDivX;
        private Button btnXFact;
        private Button btnXPowTwo;
        private Label labelAdd;
        private Button btnCE;
        private Button btnSine;
        private Button btnRoot;
        private Label labelMinus;
        private Label labelMul;
        private Label labelDIv;
        private Label labelMod;
        private Label labelPlusMinus;
        private Label labelMr;
        private Label labelMc;
        private Label labelMs;
        private Label labelMDec;
        private Label labelMInc;
        private Label labelXPowTwo;
        private Label labelClear;
        private Label labelCe;
        private Label labelRoot;
        private Label labelXFact;
        private Label labelSine;
        private Label label19;
        private Label label20;
        private Label lablelXPowY;
        private Label labelPi;
        private Label labelExp;
        private Label labelXCube;
        private Label labelOneDivX;
        private Label labelEsc;
        private Label labelEqual;
        private Button btnMinus;
        private Button btnMul;
        private Button btnPlus;
        #endregion
    }
}
