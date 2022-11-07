
namespace WindowsFormsApp1
{
    partial class imgSlider
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.imgBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(25, 395);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(413, 398);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(75, 23);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = "next";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(197, 398);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 4;
            this.txtNum.Text = "1";
            // 
            // imgBoard
            // 
            this.imgBoard.Image = global::WindowsFormsApp1.Properties.Resources.img__5_;
            this.imgBoard.Location = new System.Drawing.Point(12, 12);
            this.imgBoard.Name = "imgBoard";
            this.imgBoard.Size = new System.Drawing.Size(476, 352);
            this.imgBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBoard.TabIndex = 0;
            this.imgBoard.TabStop = false;
            this.imgBoard.Click += new System.EventHandler(this.imgBoard_Click);
            // 
            // imgSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.imgBoard);
            this.Name = "imgSlider";
            this.Text = "imgSlider";
            this.Load += new System.EventHandler(this.imgSlider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBoard;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TextBox txtNum;
    }
}