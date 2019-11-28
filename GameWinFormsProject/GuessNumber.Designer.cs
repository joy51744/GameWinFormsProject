namespace GameWinFormsProject
{
    partial class GuessNumber
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(469, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(31, 22);
            this.toolStripLabel1.Text = "離開";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buttonAgain
            // 
            this.buttonAgain.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonAgain.Location = new System.Drawing.Point(282, 268);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(77, 32);
            this.buttonAgain.TabIndex = 55;
            this.buttonAgain.Text = "重玩";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buttonOk.Location = new System.Drawing.Point(80, 268);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(77, 32);
            this.buttonOk.TabIndex = 54;
            this.buttonOk.Text = "確定";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelMessage.Location = new System.Drawing.Point(88, 199);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(69, 19);
            this.labelMessage.TabIndex = 53;
            this.labelMessage.Text = "label2";
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(235, 119);
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(124, 22);
            this.textBoxGuess.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(88, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = "要猜的數字";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTitle.Location = new System.Drawing.Point(185, 52);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(85, 29);
            this.labelTitle.TabIndex = 50;
            this.labelTitle.Text = "label1";
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 331);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GuessNumber";
            this.Text = "C#遊戲專案 | 猜數字";
            this.Load += new System.EventHandler(this.GuessNumber_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button buttonAgain;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
    }
}