using System.Media;

namespace Lab14.Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        static string op;
        static double num1 = 0;

        readonly static string[] acceptedInput = [".", "+", "-", "*", "X", "/", "÷", "%", "="];
        readonly static string[] mathOperations = acceptedInput[1..];

        private void InsertBtnTextAtPosition(string b)
        {
            if (txtResult.SelectionLength >= 1)
            {
                btnDel_Click(btnDel, EventArgs.Empty);
            }
            int pos = GetInsertPosition();
            if ((!txtResult.Text.Contains('.') || b != "."))
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
            num1 = 0;
            op = null;
            lblOp.Text = op;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int pos = GetInsertPosition();
            int deleteLength = (txtResult.SelectionLength > 1) ? txtResult.SelectionLength : 1;
            pos = (deleteLength > 1 || pos != txtResult.TextLength) ? pos : pos - 1;
            if (txtResult.Text.Length > 0 && pos >= 0)
            {
                txtResult.Text = txtResult.Text.Remove(pos, deleteLength);
                txtResult.SelectionStart = pos;
            }
            btnDel.Focus();
        }

        private static void PreventEntry(KeyPressEventArgs e)
        {
            e.Handled = true;
            SystemSounds.Exclamation.Play();
        }

        private void btn_KeyPress(object sender, KeyPressEventArgs e)
        {
            var b = e.KeyChar.ToString();
            int pos = GetInsertPosition();
            if ((!char.IsDigit(char.Parse(b)) && b != "\b") && !Array.Exists(acceptedInput, x => x == b))
                PreventEntry(e);
            else if (Array.Exists(mathOperations, x => x == b))
            {
                SetOperation(b);
                lblOp.Text = op;
                if(op!="=")
                    lblOp.BackColor = SystemColors.GradientActiveCaption;
                double.TryParse(txtResult.Text, out num1);
            }
            else if (b == "\b")
            {
                btnDel_Click(sender, e);
            }
            else
            {
                if (txtResult.Text == "0")
                    txtResult.Clear();

                if (op == null)
                    InsertBtnTextAtPosition(b);
                else
                {
                    op = null;
                    txtResult.Clear();
                    InsertBtnTextAtPosition(b);
                }

            }
            var btn = sender as Button;
            if (btn != null)
                btn.Focus();
        }

        private void SetOperation(string b)
        {
            switch (b)
            {
                case "=":
                    BtnEqual_Click(btnEqual, EventArgs.Empty);
                    break;
                case "/":
                    op = "÷";
                    break;
                case "*":
                    op = "X";
                    break;
                default:
                    op = b;
                    break;
            }
        }

        double GetResult(double currentNum)
        {
            switch (op)
            {
                case "+":
                    return num1 += currentNum;
                case "-":
                    return num1 -= currentNum;
                case "*":
                case "X":
                    return num1 *= currentNum;
                case "/":
                case "÷":
                    return num1 /= currentNum;
                case "%":
                    return num1 %= currentNum;
            }
            return currentNum;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            op = lblOp.Text;
            double.TryParse(txtResult.Text, out double x);
            if (x == 0 && (op == "/" || op == "÷"))
            {
                txtResult.Text = "Divide by Zero";
            }
            else
            {
                txtResult.Text = GetResult(x).ToString();
                op = null;
                txtResult.SelectionStart = txtResult.TextLength;
            }
            lblOp.Text = null;
            op = null;
            lblOp.BackColor = Color.AliceBlue;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            btn_KeyPress(sender, new KeyPressEventArgs(char.Parse(b?.Text)));
            b.Focus();

        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;
            btn_KeyPress(btnClear, e);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btnClear.Focus();
        }
    }
}
