using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pctools
{
    public partial class Form1 : Form
    {
        const string run = "注意";
        const string tips1 = "杀毒软件会影响此程序的使用，请退出杀毒软件再次使用。";
        const string PE制作 = "PE制作";
        const string Windows11 = "Windows 11激活";
        const string Windows10 = "Windows 10激活";
        const string Windows7 = "Windows 7激活";
        const string tips = "请在退出杀毒软件后使用此功能。";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("图拉丁硬件检测.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips1,run,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("Geek Uninstaller.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("GPUZ.exe");
            Process.Start("start.bat");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("start.bat");
            Process.Start("starts.bat");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("HWiNFO64.bat");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Process.Start("OEM_change.exe");
        }

        private void 系统信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("图拉丁硬件检测.exe");
        }

        private void 磁盘管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("DiskGenius.exe");
        }

        private void 镜像写入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("rufus.exe");
        }

        private void windows10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips, Windows10, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("HWIDGen 61.01 汉化版.exe");
            }
        }

        private void windows7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips, Windows7, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("WIN7 激活程序.exe");
            }
            
        }

        private void 软件卸载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Geek Uninstaller.exe");
        }

        private void gPUZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("GPUZ.exe");
        }

        private void 文件搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Everything.exe");
        }

        private void dismToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Dism++x64.exe");
        }

        private void gPU超频工具ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("MSIAfterburnerSetup464.exe");
        }

        private void 显卡驱动卸载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Display Driver Uninstaller.exe");
        }

        private void 显示器检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("DisplayX.exe");
        }

        private void 键盘检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Keyboard Test Utility.exe");
        }

        private void 鼠标检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("MOUSERATE.EXE");
        }

        private void 显卡检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("GPUZ.exe");
            Process.Start("start.bat");
        }

        private void cPU压力测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("starts.exe");
        }

        private void sSD硬盘测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("ATTO 磁盘基准测试.exe");
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void windows11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips, Windows11,MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("Activation.cmd");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips, Windows10, MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("HWIDGen 61.01 汉化版.exe");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Process.Start("Wub_x64.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips, PE制作, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Process.Start("FirPE_1.8.1.exe");
            }
        }

        private void pE制作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(tips, PE制作, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Process.Start("FirPE_1.8.1.exe");
            }
        }
    }
}
