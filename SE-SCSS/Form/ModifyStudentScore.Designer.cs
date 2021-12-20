namespace SE_SCSS
{
    partial class ModifyStudentScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Button_ModifyScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前成绩";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 35);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "修改成绩";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 205);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 35);
            this.textBox2.TabIndex = 3;
            // 
            // Button_ModifyScore
            // 
            this.Button_ModifyScore.Location = new System.Drawing.Point(141, 357);
            this.Button_ModifyScore.Name = "Button_ModifyScore";
            this.Button_ModifyScore.Size = new System.Drawing.Size(141, 73);
            this.Button_ModifyScore.TabIndex = 4;
            this.Button_ModifyScore.Text = "确认修改";
            this.Button_ModifyScore.UseVisualStyleBackColor = true;
            this.Button_ModifyScore.Click += new System.EventHandler(this.Button_ModifyScore_Click);
            // 
            // ModifyStudentScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 535);
            this.Controls.Add(this.Button_ModifyScore);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "ModifyStudentScore";
            this.Text = "修改学生成绩";
            this.Load += new System.EventHandler(this.ModifyStudentScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Button_ModifyScore;
    }
}