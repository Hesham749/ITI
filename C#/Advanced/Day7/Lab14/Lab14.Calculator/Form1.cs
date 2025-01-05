using System.Media;

namespace Lab14.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Num_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b != null)
                InsertBtnTextAtPosition(b);
        }

        private void InsertBtnTextAtPosition(Button b)
        {
            int pos = !txtResult.Focused ? txtResult.Text.Length : txtResult.SelectionStart;
            if (!txtResult.Text.Contains('.') || b != btnDot)
                txtResult.Text = txtResult.Text.Insert(pos, b.Text);
            else if (txtResult.Text.Contains(".") && b == btnDot)
                SystemSounds.Exclamation.Play();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }
    }
}
