namespace DesktopCalculator
{
    partial class WinCalc
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
        #region Windows Form Designer generated code

       
        private void DefineLayout()
        {
            this.SuspendLayout();
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinCalc));
           
            // WinCalc
            this.KeyPreview = true;
            this.KeyDown += OnKeyPressEvent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(LayoutResource.Martz90_Circle_Calculator));
            this.Location = new System.Drawing.Point(250, 250);
            this.MaximizeBox = false;
            this.Name = LayoutResource.Name;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = LayoutResource.WinCalcText;
            this.ResumeLayout(false);
            //
            //Calling the callayout partial class methods 
            //
            this.AllocateMemory();
            this.AddMenu();
            this.AddTextBox();
            this.AddButtons();
            this.AddControls();
        }
        #endregion
    }
}

