using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comment = new Dictionary<Process, string>();
        }

        Process[] proc;
        public Dictionary<Process, string> comment;



        void GetAllProcess()
        {
            listProc.Items.Clear();
            proc = Process.GetProcesses();
            labelCounter.Text = proc.Length.ToString();

            foreach (Process p in proc)
            {
                ListViewItem itemId = new ListViewItem(p.ProcessName);
                itemId.SubItems.Add(Convert.ToString(p.Id));
                itemId.Tag = p;
                listProc.Items.Add(itemId);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listProc.Items.Clear();
            GetAllProcess();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RunNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListProc_SelectedIndexChanged(object sender, EventArgs e)
        {
            Process p = GetProcess();

            if(p != null)
            {
                labelName.Text = p.ProcessName;
                labelStatus.Text = p.Responding.ToString();
                labelMemory.Text = (Math.Ceiling(( p.PrivateMemorySize64 / 1024f) / 1024f)).ToString() + "MB";
                labelThread.Text = p.Threads.ToString();
                try
                {
                    labelDesc.Text = p.MainModule.FileVersionInfo.FileDescription;
                    labelStart.Text = p.StartTime.ToString();
                }
                catch(Exception ex)
                {
                    labelDesc.Text = "Access Denied";
                }
                PerformanceCounter counter = new PerformanceCounter("Process", "% Processor Time", p.ProcessName, true);
                double cpu = Math.Round(counter.NextValue() / Environment.ProcessorCount, 2);
                labelCpu.Text = cpu.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void RunNewTaskToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (frumRunTask frm = new frumRunTask())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GetAllProcess();
                }
            }GetAllProcess();
        }

        private void BtKill_Click(object sender, EventArgs e)
        {
            ListViewItem itemId = listProc.SelectedItems[0]; 
            Process p = (Process)itemId.Tag;
            p.Kill();
            GetAllProcess();
        }

        private Process GetProcess()
        {
            if (listProc.SelectedItems.Count > 0 && listProc.SelectedItems[0] != null)
            {
                foreach (Process p in proc)
                {
                    if (p.ProcessName == listProc.SelectedItems[0].Text)
                    {
                        return p;
                    }
                }
            }
            return null;
            GetAllProcess();
        }

        private void CommentTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
