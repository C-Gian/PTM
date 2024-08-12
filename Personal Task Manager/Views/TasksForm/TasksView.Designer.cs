namespace Personal_Task_Manager.Views.TasksForm
{
    partial class TasksView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksView));
            splitContainer1 = new SplitContainer();
            tasks_list = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tasks_lname_label = new Label();
            tasks_fname_label = new Label();
            tasks_email_label = new Label();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tasks_list);
            splitContainer1.Size = new Size(1354, 780);
            splitContainer1.SplitterDistance = 451;
            splitContainer1.TabIndex = 0;
            // 
            // tasks_list
            // 
            tasks_list.Dock = DockStyle.Fill;
            tasks_list.FormattingEnabled = true;
            tasks_list.ItemHeight = 15;
            tasks_list.Location = new Point(0, 0);
            tasks_list.Name = "tasks_list";
            tasks_list.Size = new Size(899, 780);
            tasks_list.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.55814F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.441864F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(430, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 94);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(tasks_email_label);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(100, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 94);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(tasks_lname_label, 1, 0);
            tableLayoutPanel2.Controls.Add(tasks_fname_label, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(327, 42);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tasks_lname_label
            // 
            tasks_lname_label.AutoSize = true;
            tasks_lname_label.Font = new Font("Segoe UI", 15.75F);
            tasks_lname_label.Location = new Point(120, 0);
            tasks_lname_label.Name = "tasks_lname_label";
            tasks_lname_label.Size = new Size(108, 30);
            tasks_lname_label.TabIndex = 1;
            tasks_lname_label.Text = "lastaname";
            // 
            // tasks_fname_label
            // 
            tasks_fname_label.AutoSize = true;
            tasks_fname_label.Font = new Font("Segoe UI", 15.75F);
            tasks_fname_label.Location = new Point(3, 0);
            tasks_fname_label.Name = "tasks_fname_label";
            tasks_fname_label.Size = new Size(111, 30);
            tasks_fname_label.TabIndex = 0;
            tasks_fname_label.Text = "firstaname";
            // 
            // tasks_email_label
            // 
            tasks_email_label.AutoSize = true;
            tasks_email_label.Font = new Font("Segoe UI", 15.75F);
            tasks_email_label.Location = new Point(3, 48);
            tasks_email_label.Name = "tasks_email_label";
            tasks_email_label.Size = new Size(68, 30);
            tasks_email_label.TabIndex = 3;
            tasks_email_label.Text = "label3";
            // 
            // panel2
            // 
            panel2.Location = new Point(15, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 339);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(button2, 1, 0);
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Location = new Point(12, 598);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(427, 87);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(207, 81);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Cornsilk;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(216, 3);
            button2.Name = "button2";
            button2.Size = new Size(208, 81);
            button2.TabIndex = 1;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 691);
            button3.Name = "button3";
            button3.Size = new Size(427, 77);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            // 
            // TasksView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 780);
            Controls.Add(splitContainer1);
            Name = "TasksView";
            Text = "TasksView";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox tasks_list;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Label tasks_email_label;
        private TableLayoutPanel tableLayoutPanel2;
        private Label tasks_lname_label;
        private Label tasks_fname_label;
        private Button button3;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button2;
        private Button button1;
    }
}