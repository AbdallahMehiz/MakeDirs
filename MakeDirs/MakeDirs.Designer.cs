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
            this.selectedPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowseDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeDirBtn
            // 
            this.makeDirBtn.Location = new System.Drawing.Point(228, 88);
            this.makeDirBtn.Name = "makeDirBtn";
            this.makeDirBtn.Size = new System.Drawing.Size(81, 23);
            this.makeDirBtn.TabIndex = 0;
            this.makeDirBtn.Text = "Make Folders";
            this.makeDirBtn.UseVisualStyleBackColor = true;
            this.makeDirBtn.Click += new System.EventHandler(this.makeDirBtn_Click);
            // 
            // dirNum
            // 
            this.dirNum.Location = new System.Drawing.Point(122, 62);
            this.dirNum.Name = "dirNum";
            this.dirNum.Size = new System.Drawing.Size(60, 20);
            this.dirNum.TabIndex = 1;
            this.dirNum.TextChanged += new System.EventHandler(this.dirNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path of Folders";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // selectedPath
            // 
            this.selectedPath.Location = new System.Drawing.Point(16, 23);
            this.selectedPath.Name = "selectedPath";
            this.selectedPath.Size = new System.Drawing.Size(198, 20);
            this.selectedPath.TabIndex = 3;
            this.selectedPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "# of Folders";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prefixTextBox
            // 
            this.prefixTextBox.Location = new System.Drawing.Point(16, 62);
            this.prefixTextBox.Name = "prefixTextBox";
            this.prefixTextBox.Size = new System.Drawing.Size(100, 20);
            this.prefixTextBox.TabIndex = 7;
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(189, 62);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(106, 20);
            this.suffixTextBox.TabIndex = 8;
            // 
            // prefixLabel
            // 
            this.prefixLabel.AutoSize = true;
            this.prefixLabel.Location = new System.Drawing.Point(13, 46);
            this.prefixLabel.Name = "prefixLabel";
            this.prefixLabel.Size = new System.Drawing.Size(33, 13);
            this.prefixLabel.TabIndex = 9;
            this.prefixLabel.Text = "Prefix";
            // 
            // suffixLabel
            // 
            this.suffixLabel.AutoSize = true;
            this.suffixLabel.Location = new System.Drawing.Point(188, 46);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 10;
            this.suffixLabel.Text = "Suffix";
            // 
            // MakeDirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 122);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectedPath);
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
        private System.Windows.Forms.TextBox selectedPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDialogue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label suffixLabel;
    }
}

