namespace Manager
{
    partial class Action
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
            this.label2 = new System.Windows.Forms.Label();
            this.star = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.low = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mark As:";
            // 
            // star
            // 
            this.star.AutoSize = true;
            this.star.Location = new System.Drawing.Point(34, 92);
            this.star.Margin = new System.Windows.Forms.Padding(2);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(68, 17);
            this.star.TabIndex = 3;
            this.star.TabStop = true;
            this.star.Text = "Star TAS";
            this.star.UseVisualStyleBackColor = true;
            this.star.CheckedChanged += new System.EventHandler(this.Star_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(126, 92);
            this.medium.Margin = new System.Windows.Forms.Padding(2);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(62, 17);
            this.medium.TabIndex = 4;
            this.medium.TabStop = true;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.Medium_CheckedChanged);
            // 
            // low
            // 
            this.low.AutoSize = true;
            this.low.Location = new System.Drawing.Point(207, 92);
            this.low.Margin = new System.Windows.Forms.Padding(2);
            this.low.Name = "low";
            this.low.Size = new System.Drawing.Size(97, 17);
            this.low.TabIndex = 5;
            this.low.TabStop = true;
            this.low.Text = "Low-performing";
            this.low.UseVisualStyleBackColor = true;
            this.low.CheckedChanged += new System.EventHandler(this.Low_CheckedChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(252, 130);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 22);
            this.save.TabIndex = 6;
            this.save.Text = "&Save and Close";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(86, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(198, 17);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 159);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.low);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.star);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Action";
            this.Text = "Action";
            this.Load += new System.EventHandler(this.Action_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton star;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton low;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ListBox listBox1;
    }
}