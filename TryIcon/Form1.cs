using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TryIcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmsMenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // 화면 감추기
        {
            e.Cancel = true; //프로그램을 닫아도 죽지 않게 함
            VisibleChange(false);
        }

        private void CmsMenu_DoubleClick(object sender, EventArgs e)
        {

        }

        private void NtiTray_DoubleClick(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread(); // 어플리케이션 쓰레드 완전 종료
        }
    }
}
