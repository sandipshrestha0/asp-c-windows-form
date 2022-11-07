
namespace WindowsFormsApp1
{
    partial class dashboard
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumOfTwoNumberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.negativPositiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSliderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sumOfTwoNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.programsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // programsToolStripMenuItem
            // 
            this.programsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumOfTwoNumberToolStripMenuItem1,
            this.negativPositiveToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.imageSliderToolStripMenuItem,
            this.billingFormToolStripMenuItem,
            this.studentInfoToolStripMenuItem});
            this.programsToolStripMenuItem.Name = "programsToolStripMenuItem";
            this.programsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.programsToolStripMenuItem.Text = "programs";
            this.programsToolStripMenuItem.Click += new System.EventHandler(this.programsToolStripMenuItem_Click);
            // 
            // sumOfTwoNumberToolStripMenuItem1
            // 
            this.sumOfTwoNumberToolStripMenuItem1.Name = "sumOfTwoNumberToolStripMenuItem1";
            this.sumOfTwoNumberToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.sumOfTwoNumberToolStripMenuItem1.Text = "sum of two number";
            this.sumOfTwoNumberToolStripMenuItem1.Click += new System.EventHandler(this.sumOfTwoNumberToolStripMenuItem1_Click);
            // 
            // negativPositiveToolStripMenuItem
            // 
            this.negativPositiveToolStripMenuItem.Name = "negativPositiveToolStripMenuItem";
            this.negativPositiveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.negativPositiveToolStripMenuItem.Text = "Negativ positive";
            this.negativPositiveToolStripMenuItem.Click += new System.EventHandler(this.negativPositiveToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calculatorToolStripMenuItem.Text = "calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // imageSliderToolStripMenuItem
            // 
            this.imageSliderToolStripMenuItem.Name = "imageSliderToolStripMenuItem";
            this.imageSliderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageSliderToolStripMenuItem.Text = "image slider";
            this.imageSliderToolStripMenuItem.Click += new System.EventHandler(this.imageSliderToolStripMenuItem_Click);
            // 
            // billingFormToolStripMenuItem
            // 
            this.billingFormToolStripMenuItem.Name = "billingFormToolStripMenuItem";
            this.billingFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.billingFormToolStripMenuItem.Text = "billing form";
            this.billingFormToolStripMenuItem.Click += new System.EventHandler(this.billingFormToolStripMenuItem_Click);
            // 
            // studentInfoToolStripMenuItem
            // 
            this.studentInfoToolStripMenuItem.Name = "studentInfoToolStripMenuItem";
            this.studentInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.studentInfoToolStripMenuItem.Text = "studentInfo";
            this.studentInfoToolStripMenuItem.Click += new System.EventHandler(this.studentInfoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "exit";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumOfTwoNumberToolStripMenuItem,
            this.negatToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(180, 48);
            // 
            // sumOfTwoNumberToolStripMenuItem
            // 
            this.sumOfTwoNumberToolStripMenuItem.Name = "sumOfTwoNumberToolStripMenuItem";
            this.sumOfTwoNumberToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.sumOfTwoNumberToolStripMenuItem.Text = "sum of two number";
            // 
            // negatToolStripMenuItem
            // 
            this.negatToolStripMenuItem.Name = "negatToolStripMenuItem";
            this.negatToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.negatToolStripMenuItem.Text = "negat";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumOfTwoNumberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem negativPositiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sumOfTwoNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSliderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStripMenuItem;
    }
}