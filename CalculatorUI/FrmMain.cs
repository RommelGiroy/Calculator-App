using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class FrmMain : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lblZero_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 0;
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 1;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 2;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 3;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 4;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 5;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 6;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 7;
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 8;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblPreview.Text += 9;
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            lblPreview.Text = ".";
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            lblPreview.Text += "/";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            lblPreview.Text += "*";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblPreview.Text += "-";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            lblPreview.Text += "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblPreview.Text.Substring(0, lblPreview.Text.Length -1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblPreview.Text = String.Empty;
            lblResult.Text = "0";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = "Are your sure want to close this application?";

            if (MessageBox.Show(message, "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

    }
}
