using System.Media;

namespace Lab14.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void InsertBtnTextAtPosition(string b)
        {
            //txtResult.Focus();
            int pos = GetInsertPosition();
            if (!txtResult.Text.Contains('.') || b == ".")
                txtResult.Text = txtResult.Text.Insert(pos, b);
            else if (txtResult.Text.Contains(".") && b == ".")
                SystemSounds.Exclamation.Play();
            txtResult.SelectionStart = pos + 1;

        }

        private int GetInsertPosition()
        {
            txtResult.Focus();
            int pos = 0;
            pos = txtResult.Focused ? txtResult.SelectionStart : txtResult.Text.Length;

            return pos;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int pos = GetInsertPosition() - 1;
            if (txtResult.Text.Length > 0 && pos >= 0)
            {
                txtResult.Text = txtResult.Text.Remove(pos, 1);
                txtResult.SelectionStart = pos;
            }
            btnDel.Focus();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private static void PreventEntry(KeyPressEventArgs e)
        {
            e.Handled = true;
            SystemSounds.Exclamation.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static string op;
        static float num1 = 0;

        readonly static string[] acceptedInput = [".", "+", "-", "*", "X", "/", "÷", "%", "="];
        readonly static string[] mathOperations = acceptedInput[1..];
        private void btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            var b = e.KeyChar.ToString();
            int pos = GetInsertPosition();
            if ((!char.IsDigit(char.Parse(b)) && b != "\b") && !Array.Exists(acceptedInput, x => x == b))
                PreventEntry(e);
            else if (Array.Exists(mathOperations, x => x == b))
            {
                num1 = float.Parse(txtResult.Text);
                op = b;
                txtResult.Clear();
            }
            else if (b == "\b")
            {
                txtResult.Text = txtResult.Text.Remove(pos - 1, 1);
            }
            else
            {
                InsertBtnTextAtPosition(b);
            }
            var btn = sender as Button;
            if (btn != null)
                btn.Focus();
        }

        void MakeOp(float currentNum)
        {
            switch (op)
            {
                case "+":
                    num1 += currentNum;
                    break;
                case "-":
                    num1 -= currentNum;
                    break;
                case "*":
                case "X":
                    num1 *= currentNum;
                    break;
                case "/":
                    num1 /= currentNum;
                    break;
                case "%":
                case "÷":
                    num1 %= currentNum;
                    break;
                case "=":
                    BtnEqual_Click(btnEqual, EventArgs.Empty);
                    break;
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            btn_KeyPress(sender, new KeyPressEventArgs(char.Parse(b?.Text)));
            b.Focus();
        }
    }
}
