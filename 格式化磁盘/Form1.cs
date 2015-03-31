using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 格式化磁盘
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        [DllImport("shell32.dll")]
        private static extern int SHFormatDrive(IntPtr hWnd, int drive, long fmtID, int Options);

        public const long SHFMT_ID_DEFAULT = 0xFFFF;

        private void btn_磁盘_Click(object sender, EventArgs e)
        {
            try
            {
                //格式G盘
                SHFormatDrive(this.Handle, this.cmb_磁盘.SelectedIndex, SHFMT_ID_DEFAULT, 0);
                MessageBox.Show("格式化完成", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch {
                MessageBox.Show("格式化失败", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
