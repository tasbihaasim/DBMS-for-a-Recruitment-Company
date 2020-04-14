namespace Manager
{
    partial class Performance
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
            this.from = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.DateTimePicker();
            this.too = new System.Windows.Forms.Label();
            this.connections = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dsignup = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.action = new System.Windows.Forms.Button();
            this.replies = new System.Windows.Forms.ListBox();
            this.signupsNumber = new System.Windows.Forms.ListBox();
            this.connectionNumber = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.compare = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.TAS = new System.Windows.Forms.ComboBox();
            this.OK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of TAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(117, 66);
            this.from.Margin = new System.Windows.Forms.Padding(2);
            this.from.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.from.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(165, 20);
            this.from.TabIndex = 3;
            this.from.Value = new System.DateTime(2019, 11, 13, 0, 0, 0, 0);
            this.from.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(117, 97);
            this.to.Margin = new System.Windows.Forms.Padding(2);
            this.to.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.to.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(165, 20);
            this.to.TabIndex = 4;
            this.to.Value = new System.DateTime(2019, 11, 13, 0, 0, 0, 0);
            // 
            // too
            // 
            this.too.AutoSize = true;
            this.too.Location = new System.Drawing.Point(26, 101);
            this.too.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.too.Name = "too";
            this.too.Size = new System.Drawing.Size(23, 13);
            this.too.TabIndex = 5;
            this.too.Text = "To:";
            // 
            // connections
            // 
            this.connections.AutoSize = true;
            this.connections.Location = new System.Drawing.Point(4, 21);
            this.connections.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connections.Name = "connections";
            this.connections.Size = new System.Drawing.Size(123, 13);
            this.connections.TabIndex = 6;
            this.connections.Text = "No. of Connections Sent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "No. of Signups";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "No. of Replies Received";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dsignup);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.action);
            this.groupBox1.Controls.Add(this.replies);
            this.groupBox1.Controls.Add(this.signupsNumber);
            this.groupBox1.Controls.Add(this.connectionNumber);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.connections);
            this.groupBox1.Location = new System.Drawing.Point(302, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(179, 168);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Performance";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // dsignup
            // 
            this.dsignup.FormattingEnabled = true;
            this.dsignup.Location = new System.Drawing.Point(137, 102);
            this.dsignup.Margin = new System.Windows.Forms.Padding(2);
            this.dsignup.Name = "dsignup";
            this.dsignup.Size = new System.Drawing.Size(29, 17);
            this.dsignup.TabIndex = 16;
            this.dsignup.SelectedIndexChanged += new System.EventHandler(this.Dsignup_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "No. of Diverse Signups";
            // 
            // action
            // 
            this.action.Location = new System.Drawing.Point(85, 131);
            this.action.Margin = new System.Windows.Forms.Padding(2);
            this.action.Name = "action";
            this.action.Size = new System.Drawing.Size(82, 19);
            this.action.TabIndex = 14;
            this.action.Text = "&Rate";
            this.action.UseVisualStyleBackColor = true;
            this.action.Click += new System.EventHandler(this.Action_Click);
            // 
            // replies
            // 
            this.replies.FormattingEnabled = true;
            this.replies.Location = new System.Drawing.Point(137, 75);
            this.replies.Margin = new System.Windows.Forms.Padding(2);
            this.replies.Name = "replies";
            this.replies.Size = new System.Drawing.Size(29, 17);
            this.replies.TabIndex = 11;
            this.replies.SelectedIndexChanged += new System.EventHandler(this.Replies_SelectedIndexChanged);
            // 
            // signupsNumber
            // 
            this.signupsNumber.FormattingEnabled = true;
            this.signupsNumber.Location = new System.Drawing.Point(137, 46);
            this.signupsNumber.Margin = new System.Windows.Forms.Padding(2);
            this.signupsNumber.Name = "signupsNumber";
            this.signupsNumber.Size = new System.Drawing.Size(29, 17);
            this.signupsNumber.TabIndex = 10;
            this.signupsNumber.SelectedIndexChanged += new System.EventHandler(this.SignupsNumber_SelectedIndexChanged);
            // 
            // connectionNumber
            // 
            this.connectionNumber.FormattingEnabled = true;
            this.connectionNumber.Location = new System.Drawing.Point(137, 21);
            this.connectionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.connectionNumber.Name = "connectionNumber";
            this.connectionNumber.Size = new System.Drawing.Size(31, 17);
            this.connectionNumber.TabIndex = 9;
            this.connectionNumber.SelectedIndexChanged += new System.EventHandler(this.ConnectionNumber_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(10, 205);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(457, 220);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Candidate Data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 23);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(425, 179);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // compare
            // 
            this.compare.Location = new System.Drawing.Point(249, 439);
            this.compare.Margin = new System.Windows.Forms.Padding(2);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(98, 22);
            this.compare.TabIndex = 12;
            this.compare.Text = "&Generate Report";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(367, 441);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(91, 20);
            this.close.TabIndex = 13;
            this.close.Text = "&Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TAS
            // 
            this.TAS.FormattingEnabled = true;
            this.TAS.Items.AddRange(new object[] {
            "Maria",
            "Mobeen",
            "Donna",
            "Martinez",
            "Rishi"});
            this.TAS.Location = new System.Drawing.Point(118, 36);
            this.TAS.Margin = new System.Windows.Forms.Padding(2);
            this.TAS.Name = "TAS";
            this.TAS.Size = new System.Drawing.Size(164, 21);
            this.TAS.TabIndex = 14;
            this.TAS.SelectedIndexChanged += new System.EventHandler(this.TAS_SelectedIndexChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(193, 131);
            this.OK.Margin = new System.Windows.Forms.Padding(2);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(87, 21);
            this.OK.TabIndex = 15;
            this.OK.Text = "&OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Performance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.TAS);
            this.Controls.Add(this.close);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.too);
            this.Controls.Add(this.to);
            this.Controls.Add(this.from);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Performance";
            this.Text = "Performance Track";
            this.Load += new System.EventHandler(this.Performance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.DateTimePicker to;
        private System.Windows.Forms.Label too;
        private System.Windows.Forms.Label connections;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox replies;
        private System.Windows.Forms.ListBox signupsNumber;
        private System.Windows.Forms.ListBox connectionNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button action;
        private System.Windows.Forms.ComboBox TAS;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.ListBox dsignup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

