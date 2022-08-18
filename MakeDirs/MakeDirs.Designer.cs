namespace MakeDirs
{
    partial class MakeDirs
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
            this.makeDirBtn = new System.Windows.Forms.Button();
            this.dirNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeDirBtn
            // 
            this.makeDirBtn.Location = new System.Drawing.Point(134, 24);
            this.makeDirBtn.Name = "makeDirBtn";
            this.makeDirBtn.Size = new System.Drawing.Size(81, 23);
            this.makeDirBtn.TabIndex = 0;
            this.makeDirBtn.Text = "Make Folders";
            this.makeDirBtn.UseVisualStyleBackColor = true;
            this.makeDirBtn.Click += new System.EventHandler(this.makeDirBtn_Click);
            // 
            // dirNum
            // 
            this.dirNum.Location = new System.Drawing.Point(12, 26);
            this.dirNum.Name = "dirNum";
            this.dirNum.Size = new System.Drawing.Size(116, 20);
            this.dirNum.TabIndex = 1;
            this.dirNum.TextChanged += new System.EventHandler(this.dirNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input # of Folders You Want to Make:";
            // 
            // MakeDirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 60);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dirNum);
            this.Controls.Add(this.makeDirBtn);
            this.Name = "MakeDirs";
            this.Text = "MakeDirs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeDirBtn;
        private System.Windows.Forms.TextBox dirNum;
        private System.Windows.Forms.Label label1;
    }
}

