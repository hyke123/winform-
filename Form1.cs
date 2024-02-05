using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"The height of userControl is {this.userControl11.Height}");
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Font = System.Drawing.SystemFonts.IconTitleFont;
            MessageBox.Show($"The height of userControl is {this.userControl11.Height}");
        }
    }
}
