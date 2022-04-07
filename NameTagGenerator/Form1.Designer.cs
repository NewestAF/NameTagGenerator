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
            this.save = new System.Windows.Forms.Button();
            this.chooseBackground = new System.Windows.Forms.Button();
            this.chooseCSV = new System.Windows.Forms.Button();
            this.fontSelect = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.save.Location = new System.Drawing.Point(525, 700);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 31);
            this.save.TabIndex = 0;
            this.save.Text = "저장";
            this.save.UseVisualStyleBackColor = true;
            this.save.UseWaitCursor = true;
            // 
            // chooseBackground
            // 
            this.chooseBackground.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseBackground.Location = new System.Drawing.Point(80, 80);
            this.chooseBackground.Name = "chooseBackground";
            this.chooseBackground.Size = new System.Drawing.Size(500, 50);
            this.chooseBackground.TabIndex = 1;
            this.chooseBackground.Text = "배경 선택";
            this.chooseBackground.UseVisualStyleBackColor = true;
            this.chooseBackground.UseWaitCursor = true;
            this.chooseBackground.Click += new System.EventHandler(this.chooseBackground_Click);
            // 
            // chooseCSV
            // 
            this.chooseCSV.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chooseCSV.Location = new System.Drawing.Point(80, 160);
            this.chooseCSV.Name = "chooseCSV";
            this.chooseCSV.Size = new System.Drawing.Size(500, 50);
            this.chooseCSV.TabIndex = 2;
            this.chooseCSV.Text = "CSV 선택";
            this.chooseCSV.UseVisualStyleBackColor = true;
            this.chooseCSV.UseWaitCursor = true;
            this.chooseCSV.Click += new System.EventHandler(this.chooseCSV_Click);
            // 
            // fontSelect
            // 
            this.fontSelect.FormattingEnabled = true;
            this.fontSelect.Location = new System.Drawing.Point(80, 251);
            this.fontSelect.Name = "fontSelect";
            this.fontSelect.Size = new System.Drawing.Size(225, 28);
            this.fontSelect.TabIndex = 3;
            this.fontSelect.Text = "폰트 선택";
            this.fontSelect.UseWaitCursor = true;
            this.fontSelect.SelectedIndexChanged += new System.EventHandler(this.fontSelect_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(657, 753);
            this.Controls.Add(this.fontSelect);
            this.Controls.Add(this.chooseCSV);
            this.Controls.Add(this.chooseBackground);
            this.Controls.Add(this.save);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(675, 800);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button save;
        private Button chooseBackground;
        private Button chooseCSV;
        private ComboBox fontSelect;
    }
}