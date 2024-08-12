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
            btn_tasks_delete = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn_tasks_reset = new Button();
            btn_tasks_addupdate = new Button();
            panel2 = new Panel();
            check_tasks_compl_input = new CheckBox();
            combo_tasks_priority_input = new ComboBox();
            label3 = new Label();
            txt_tasks_desc_input = new TextBox();
            label2 = new Label();
            txt_tasks_name_input = new TextBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tasks_email_label = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tasks_lname_label = new Label();
            tasks_fname_label = new Label();
            tasks_list = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            splitContainer1.Panel1.Controls.Add(btn_tasks_delete);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel3);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tasks_list);
            splitContainer1.Size = new Size(1354, 780);
            splitContainer1.SplitterDistance = 450;
            splitContainer1.TabIndex = 0;
            // 
            // btn_tasks_delete
            // 
            btn_tasks_delete.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_tasks_delete.BackColor = Color.Crimson;
            btn_tasks_delete.ForeColor = Color.White;
            btn_tasks_delete.Location = new Point(12, 691);
            btn_tasks_delete.Name = "btn_tasks_delete";
            btn_tasks_delete.Size = new Size(427, 77);
            btn_tasks_delete.TabIndex = 3;
            btn_tasks_delete.Text = "Delete";
            btn_tasks_delete.UseVisualStyleBackColor = false;
            btn_tasks_delete.Click += btn_tasks_delete_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btn_tasks_reset, 1, 0);
            tableLayoutPanel3.Controls.Add(btn_tasks_addupdate, 0, 0);
            tableLayoutPanel3.Location = new Point(12, 598);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(427, 87);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btn_tasks_reset
            // 
            btn_tasks_reset.BackColor = Color.Cornsilk;
            btn_tasks_reset.Dock = DockStyle.Fill;
            btn_tasks_reset.Location = new Point(216, 3);
            btn_tasks_reset.Name = "btn_tasks_reset";
            btn_tasks_reset.Size = new Size(208, 81);
            btn_tasks_reset.TabIndex = 1;
            btn_tasks_reset.Text = "Reset";
            btn_tasks_reset.UseVisualStyleBackColor = false;
            btn_tasks_reset.Click += btn_tasks_reset_Click;
            // 
            // btn_tasks_addupdate
            // 
            btn_tasks_addupdate.Dock = DockStyle.Fill;
            btn_tasks_addupdate.Location = new Point(3, 3);
            btn_tasks_addupdate.Name = "btn_tasks_addupdate";
            btn_tasks_addupdate.Size = new Size(207, 81);
            btn_tasks_addupdate.TabIndex = 0;
            btn_tasks_addupdate.Text = "Add";
            btn_tasks_addupdate.UseVisualStyleBackColor = true;
            btn_tasks_addupdate.Click += btn_tasks_addupdate_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(check_tasks_compl_input);
            panel2.Controls.Add(combo_tasks_priority_input);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_tasks_desc_input);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txt_tasks_name_input);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(15, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(424, 387);
            panel2.TabIndex = 1;
            // 
            // check_tasks_compl_input
            // 
            check_tasks_compl_input.AutoSize = true;
            check_tasks_compl_input.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            check_tasks_compl_input.Location = new Point(3, 348);
            check_tasks_compl_input.Name = "check_tasks_compl_input";
            check_tasks_compl_input.Size = new Size(151, 36);
            check_tasks_compl_input.TabIndex = 25;
            check_tasks_compl_input.Text = "Completed";
            check_tasks_compl_input.UseVisualStyleBackColor = true;
            // 
            // combo_tasks_priority_input
            // 
            combo_tasks_priority_input.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            combo_tasks_priority_input.FormattingEnabled = true;
            combo_tasks_priority_input.Location = new Point(3, 281);
            combo_tasks_priority_input.Name = "combo_tasks_priority_input";
            combo_tasks_priority_input.Size = new Size(418, 40);
            combo_tasks_priority_input.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 248);
            label3.Name = "label3";
            label3.Size = new Size(83, 30);
            label3.TabIndex = 21;
            label3.Text = "Priority";
            // 
            // txt_tasks_desc_input
            // 
            txt_tasks_desc_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_tasks_desc_input.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_tasks_desc_input.Location = new Point(3, 119);
            txt_tasks_desc_input.Multiline = true;
            txt_tasks_desc_input.Name = "txt_tasks_desc_input";
            txt_tasks_desc_input.Size = new Size(418, 108);
            txt_tasks_desc_input.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(122, 30);
            label2.TabIndex = 19;
            label2.Text = "Description";
            // 
            // txt_tasks_name_input
            // 
            txt_tasks_name_input.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_tasks_name_input.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_tasks_name_input.Location = new Point(3, 33);
            txt_tasks_name_input.Name = "txt_tasks_name_input";
            txt_tasks_name_input.Size = new Size(418, 39);
            txt_tasks_name_input.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // tasks_list
            // 
            tasks_list.Dock = DockStyle.Fill;
            tasks_list.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tasks_list.FormattingEnabled = true;
            tasks_list.ItemHeight = 30;
            tasks_list.Location = new Point(0, 0);
            tasks_list.Name = "tasks_list";
            tasks_list.Size = new Size(900, 780);
            tasks_list.TabIndex = 0;
            // 
            // TasksView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 780);
            Controls.Add(splitContainer1);
            Name = "TasksView";
            Text = "Tasks";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private Button btn_tasks_delete;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_tasks_reset;
        private Button btn_tasks_addupdate;
        private TextBox txt_tasks_name_input;
        private Label label1;
        private Label label3;
        private TextBox txt_tasks_desc_input;
        private Label label2;
        private CheckBox check_tasks_compl_input;
        private ComboBox combo_tasks_priority_input;
    }
}