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
            splitContainer1 = new SplitContainer();
            tasks_list = new ListBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
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
            // TasksView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 780);
            Controls.Add(splitContainer1);
            Name = "TasksView";
            Text = "TasksView";
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox tasks_list;
    }
}