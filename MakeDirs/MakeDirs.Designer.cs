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
            this.label1 = new System.Windows.Forms.Label();
            this.selectedPath = new System.Windows.Forms.TextBox();
            this.folderBrowseDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.prefixTextBox = new System.Windows.Forms.TextBox();
            this.suffixTextBox = new System.Windows.Forms.TextBox();
            this.prefixLabel = new System.Windows.Forms.Label();
            this.suffixLabel = new System.Windows.Forms.Label();
            this.dirNumStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dirNumFinish = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // makeDirBtn
            // 
            this.makeDirBtn.Location = new System.Drawing.Point(158, 113);
            this.makeDirBtn.Name = "makeDirBtn";
            this.makeDirBtn.Size = new System.Drawing.Size(81, 23);
            this.makeDirBtn.TabIndex = 0;
            this.makeDirBtn.Text = "Make Folders";
            this.makeDirBtn.UseVisualStyleBackColor = true;
            this.makeDirBtn.Click += new System.EventHandler(this.makeDirBtn_Click);
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
            this.selectedPath.Size = new System.Drawing.Size(142, 20);
            this.selectedPath.TabIndex = 3;
            this.selectedPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 23);
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
            this.prefixTextBox.Size = new System.Drawing.Size(109, 20);
            this.prefixTextBox.TabIndex = 7;
            // 
            // suffixTextBox
            // 
            this.suffixTextBox.Location = new System.Drawing.Point(131, 62);
            this.suffixTextBox.Name = "suffixTextBox";
            this.suffixTextBox.Size = new System.Drawing.Size(104, 20);
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
            this.suffixLabel.Location = new System.Drawing.Point(128, 46);
            this.suffixLabel.Name = "suffixLabel";
            this.suffixLabel.Size = new System.Drawing.Size(33, 13);
            this.suffixLabel.TabIndex = 10;
            this.suffixLabel.Text = "Suffix";
            // 
            // dirNumStart
            // 
            this.dirNumStart.Location = new System.Drawing.Point(16, 115);
            this.dirNumStart.Name = "dirNumStart";
            this.dirNumStart.Size = new System.Drawing.Size(65, 20);
            this.dirNumStart.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numbering:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "From:";
            // 
            // dirNumFinish
            // 
            this.dirNumFinish.Location = new System.Drawing.Point(90, 115);
            this.dirNumFinish.Name = "dirNumFinish";
            this.dirNumFinish.Size = new System.Drawing.Size(61, 20);
            this.dirNumFinish.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "To";
            // 
            // MakeDirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 143);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dirNumFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dirNumStart);
            this.Controls.Add(this.suffixLabel);
            this.Controls.Add(this.prefixLabel);
            this.Controls.Add(this.suffixTextBox);
            this.Controls.Add(this.prefixTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectedPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.makeDirBtn);
            this.Name = "MakeDirs";
            this.Text = "MakeDirs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeDirBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectedPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDialogue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prefixTextBox;
        private System.Windows.Forms.TextBox suffixTextBox;
        private System.Windows.Forms.Label prefixLabel;
        private System.Windows.Forms.Label suffixLabel;
        private System.Windows.Forms.TextBox dirNumStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dirNumFinish;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
    }
}

