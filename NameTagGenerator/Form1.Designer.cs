namespace NameTagGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.save = new System.Windows.Forms.Button();
            this.chooseBackground = new System.Windows.Forms.Button();
            this.chooseCSV = new System.Windows.Forms.Button();
            this.selectFont = new System.Windows.Forms.Button();
            this.exampleBox = new System.Windows.Forms.PictureBox();
            this.test = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.exampleBox)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(408, 525);
            this.save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(78, 23);
            this.save.TabIndex = 0;
            this.save.Text = "저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.UseWaitCursor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // chooseBackground
            // 
            this.chooseBackground.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseBackground.Location = new System.Drawing.Point(62, 60);
            this.chooseBackground.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseBackground.Name = "chooseBackground";
            this.chooseBackground.Size = new System.Drawing.Size(389, 38);
            this.chooseBackground.TabIndex = 1;
            this.chooseBackground.Text = "배경 선택";
            this.chooseBackground.UseVisualStyleBackColor = true;
            this.chooseBackground.UseWaitCursor = true;
            this.chooseBackground.Click += new System.EventHandler(this.chooseBackground_Click);
            // 
            // chooseCSV
            // 
            this.chooseCSV.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCSV.Location = new System.Drawing.Point(62, 120);
            this.chooseCSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseCSV.Name = "chooseCSV";
            this.chooseCSV.Size = new System.Drawing.Size(389, 38);
            this.chooseCSV.TabIndex = 2;
            this.chooseCSV.Text = "CSV 선택";
            this.chooseCSV.UseVisualStyleBackColor = true;
            this.chooseCSV.UseWaitCursor = true;
            this.chooseCSV.Click += new System.EventHandler(this.chooseCSV_Click);
            // 
            // selectFont
            // 
            this.selectFont.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFont.Location = new System.Drawing.Point(62, 180);
            this.selectFont.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectFont.Name = "selectFont";
            this.selectFont.Size = new System.Drawing.Size(389, 38);
            this.selectFont.TabIndex = 3;
            this.selectFont.Text = "폰트 선택";
            this.selectFont.UseVisualStyleBackColor = true;
            this.selectFont.UseWaitCursor = true;
            this.selectFont.Click += new System.EventHandler(this.selectFont_Click);
            // 
            // exampleBox
            // 
            this.exampleBox.Location = new System.Drawing.Point(62, 225);
            this.exampleBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exampleBox.Name = "exampleBox";
            this.exampleBox.Size = new System.Drawing.Size(389, 281);
            this.exampleBox.TabIndex = 4;
            this.exampleBox.TabStop = false;
            this.exampleBox.UseWaitCursor = true;
            // 
            // test
            // 
            this.test.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.test.Location = new System.Drawing.Point(311, 525);
            this.test.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(78, 23);
            this.test.TabIndex = 5;
            this.test.Text = "시행";
            this.test.UseVisualStyleBackColor = true;
            this.test.UseWaitCursor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(513, 571);
            this.Controls.Add(this.test);
            this.Controls.Add(this.exampleBox);
            this.Controls.Add(this.selectFont);
            this.Controls.Add(this.chooseCSV);
            this.Controls.Add(this.chooseBackground);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 610);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exampleBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button save;
        private Button chooseBackground;
        private Button chooseCSV;
        private Button selectFont;
        private PictureBox exampleBox;
        private Button test;
    }
}