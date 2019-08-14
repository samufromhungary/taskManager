namespace taskMan
{
    partial class frumRunTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frumRunTask));
            this.labelRun = new System.Windows.Forms.Label();
            this.runTextBox = new System.Windows.Forms.TextBox();
            this.btRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRun
            // 
            this.labelRun.AutoSize = true;
            this.labelRun.Location = new System.Drawing.Point(12, 25);
            this.labelRun.Name = "labelRun";
            this.labelRun.Size = new System.Drawing.Size(30, 13);
            this.labelRun.TabIndex = 0;
            this.labelRun.Text = "Run:";
            this.labelRun.Click += new System.EventHandler(this.Label1_Click);
            // 
            // runTextBox
            // 
            this.runTextBox.Location = new System.Drawing.Point(48, 22);
            this.runTextBox.Name = "runTextBox";
            this.runTextBox.Size = new System.Drawing.Size(353, 20);
            this.runTextBox.TabIndex = 1;
            // 
            // btRun
            // 
            this.btRun.Location = new System.Drawing.Point(326, 48);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(75, 23);
            this.btRun.TabIndex = 2;
            this.btRun.Text = "Run";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frumRunTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 75);
            this.Controls.Add(this.btRun);
            this.Controls.Add(this.runTextBox);
            this.Controls.Add(this.labelRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frumRunTask";
            this.Text = "Run";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRun;
        private System.Windows.Forms.TextBox runTextBox;
        private System.Windows.Forms.Button btRun;
    }
}