namespace taskMan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listProc = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btUpdate = new System.Windows.Forms.Button();
            this.btKill = new System.Windows.Forms.Button();
            this.labelCurr = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMemory = new System.Windows.Forms.Label();
            this.labelThread = new System.Windows.Forms.Label();
            this.labelDesc = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelCommSch = new System.Windows.Forms.Label();
            this.labelDescSch = new System.Windows.Forms.Label();
            this.labelThreadSch = new System.Windows.Forms.Label();
            this.labelMemorySch = new System.Windows.Forms.Label();
            this.labelStatusSch = new System.Windows.Forms.Label();
            this.labelNameSch = new System.Windows.Forms.Label();
            this.labelStartSch = new System.Windows.Forms.Label();
            this.labelCpuSch = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelCpu = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listProc
            // 
            this.listProc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listProc.Location = new System.Drawing.Point(12, 25);
            this.listProc.Name = "listProc";
            this.listProc.Size = new System.Drawing.Size(195, 581);
            this.listProc.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listProc.TabIndex = 0;
            this.listProc.UseCompatibleStateImageBehavior = false;
            this.listProc.View = System.Windows.Forms.View.Details;
            this.listProc.SelectedIndexChanged += new System.EventHandler(this.ListProc_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 131;
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(12, 612);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 1;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btKill
            // 
            this.btKill.Location = new System.Drawing.Point(104, 612);
            this.btKill.Name = "btKill";
            this.btKill.Size = new System.Drawing.Size(75, 23);
            this.btKill.TabIndex = 2;
            this.btKill.Text = "End";
            this.btKill.UseVisualStyleBackColor = true;
            this.btKill.Click += new System.EventHandler(this.BtKill_Click);
            // 
            // labelCurr
            // 
            this.labelCurr.AutoSize = true;
            this.labelCurr.Location = new System.Drawing.Point(296, 9);
            this.labelCurr.Name = "labelCurr";
            this.labelCurr.Size = new System.Drawing.Size(102, 13);
            this.labelCurr.TabIndex = 3;
            this.labelCurr.Text = "Current Proccesses:";
            this.labelCurr.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Location = new System.Drawing.Point(424, 9);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(13, 13);
            this.labelCounter.TabIndex = 4;
            this.labelCounter.Text = "0";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(449, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.RunNewTaskToolStripMenuItem_Click_1);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(294, 50);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 13);
            this.labelName.TabIndex = 30;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(294, 115);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 29;
            // 
            // labelMemory
            // 
            this.labelMemory.AutoSize = true;
            this.labelMemory.Location = new System.Drawing.Point(294, 187);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(0, 13);
            this.labelMemory.TabIndex = 28;
            // 
            // labelThread
            // 
            this.labelThread.AutoSize = true;
            this.labelThread.Location = new System.Drawing.Point(294, 262);
            this.labelThread.Name = "labelThread";
            this.labelThread.Size = new System.Drawing.Size(0, 13);
            this.labelThread.TabIndex = 27;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(294, 325);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(0, 13);
            this.labelDesc.TabIndex = 26;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(306, 591);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(125, 20);
            this.commentTextBox.TabIndex = 25;
            this.commentTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CommentTextBox_MaskInputRejected);
            // 
            // labelCommSch
            // 
            this.labelCommSch.AutoSize = true;
            this.labelCommSch.Location = new System.Drawing.Point(222, 593);
            this.labelCommSch.Name = "labelCommSch";
            this.labelCommSch.Size = new System.Drawing.Size(54, 13);
            this.labelCommSch.TabIndex = 24;
            this.labelCommSch.Text = "Comment:";
            // 
            // labelDescSch
            // 
            this.labelDescSch.AutoSize = true;
            this.labelDescSch.Location = new System.Drawing.Point(213, 325);
            this.labelDescSch.Name = "labelDescSch";
            this.labelDescSch.Size = new System.Drawing.Size(63, 13);
            this.labelDescSch.TabIndex = 23;
            this.labelDescSch.Text = "Description:";
            // 
            // labelThreadSch
            // 
            this.labelThreadSch.AutoSize = true;
            this.labelThreadSch.Location = new System.Drawing.Point(213, 262);
            this.labelThreadSch.Name = "labelThreadSch";
            this.labelThreadSch.Size = new System.Drawing.Size(44, 13);
            this.labelThreadSch.TabIndex = 22;
            this.labelThreadSch.Text = "Thread:";
            // 
            // labelMemorySch
            // 
            this.labelMemorySch.AutoSize = true;
            this.labelMemorySch.Location = new System.Drawing.Point(213, 187);
            this.labelMemorySch.Name = "labelMemorySch";
            this.labelMemorySch.Size = new System.Drawing.Size(79, 13);
            this.labelMemorySch.TabIndex = 21;
            this.labelMemorySch.Text = "Memory usage:";
            // 
            // labelStatusSch
            // 
            this.labelStatusSch.AutoSize = true;
            this.labelStatusSch.Location = new System.Drawing.Point(211, 115);
            this.labelStatusSch.Name = "labelStatusSch";
            this.labelStatusSch.Size = new System.Drawing.Size(40, 13);
            this.labelStatusSch.TabIndex = 20;
            this.labelStatusSch.Text = "Status:";
            // 
            // labelNameSch
            // 
            this.labelNameSch.AutoSize = true;
            this.labelNameSch.Location = new System.Drawing.Point(213, 50);
            this.labelNameSch.Name = "labelNameSch";
            this.labelNameSch.Size = new System.Drawing.Size(38, 13);
            this.labelNameSch.TabIndex = 19;
            this.labelNameSch.Text = "Name:";
            // 
            // labelStartSch
            // 
            this.labelStartSch.AutoSize = true;
            this.labelStartSch.Location = new System.Drawing.Point(213, 391);
            this.labelStartSch.Name = "labelStartSch";
            this.labelStartSch.Size = new System.Drawing.Size(54, 13);
            this.labelStartSch.TabIndex = 31;
            this.labelStartSch.Text = "Start time:";
            // 
            // labelCpuSch
            // 
            this.labelCpuSch.AutoSize = true;
            this.labelCpuSch.Location = new System.Drawing.Point(213, 461);
            this.labelCpuSch.Name = "labelCpuSch";
            this.labelCpuSch.Size = new System.Drawing.Size(64, 13);
            this.labelCpuSch.TabIndex = 32;
            this.labelCpuSch.Text = "CPU usage:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(276, 391);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(0, 13);
            this.labelStart.TabIndex = 33;
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(283, 461);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(0, 13);
            this.labelCpu.TabIndex = 34;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(356, 617);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 35;
            this.btSave.Text = "Save Comment";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 643);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelCpuSch);
            this.Controls.Add(this.labelStartSch);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelMemory);
            this.Controls.Add(this.labelThread);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.labelCommSch);
            this.Controls.Add(this.labelDescSch);
            this.Controls.Add(this.labelThreadSch);
            this.Controls.Add(this.labelMemorySch);
            this.Controls.Add(this.labelStatusSch);
            this.Controls.Add(this.labelNameSch);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.labelCurr);
            this.Controls.Add(this.btKill);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.listProc);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listProc;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btKill;
        private System.Windows.Forms.Label labelCurr;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.Label labelThread;
        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.MaskedTextBox commentTextBox;
        private System.Windows.Forms.Label labelCommSch;
        private System.Windows.Forms.Label labelDescSch;
        private System.Windows.Forms.Label labelThreadSch;
        private System.Windows.Forms.Label labelMemorySch;
        private System.Windows.Forms.Label labelStatusSch;
        private System.Windows.Forms.Label labelNameSch;
        private System.Windows.Forms.Label labelStartSch;
        private System.Windows.Forms.Label labelCpuSch;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.Button btSave;
    }
}

