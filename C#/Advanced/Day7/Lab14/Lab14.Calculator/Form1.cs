using System.Media;

namespace Lab14.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string op;
        static float num1 = 0;

        readonly static string[] acceptedInput = [".", "+", "-", "*", "X", "/", "÷", "%", "="];
        readonly static string[] mathOperations = acceptedInput[1..];

        private void InsertBtnTextAtPosition(string b)
        {
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
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int pos = GetInsertPosition() - 1;
            int deleteLength = (txtResult.SelectionLength > 0) ? txtResult.SelectionLength : 1;
            pos = deleteLength > 1 ? pos + 1 : pos;
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
                op = b;
                float.TryParse(txtResult.Text, out num1);
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
                    txtResult.Clear();
                    InsertBtnTextAtPosition(b);
                }

            }
            var btn = sender as Button;
            if (btn != null)
                btn.Focus();
        }

        float GetResult(float currentNum)
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
            float.TryParse(txtResult.Text, out float x);
            if (x == 0)
            {
                txtResult.Text = "Divide by Zero";
            }
            else
            {
                txtResult.Text = GetResult(x).ToString();
                op = null;
                txtResult.SelectionStart = txtResult.TextLength;
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var b = sender as Button;
            btn_KeyPress(sender, new KeyPressEventArgs(char.Parse(b?.Text)));
            b.Focus();

        }

        private void txtResult_KeyPress(object sender, KeyPressEventArgs e)
        {
            //var b = e.KeyChar.ToString();
            //if ((!char.IsDigit(char.Parse(b)) && b != "\b") && !Array.Exists(acceptedInput, x => x == b))
            //    PreventEntry(e);
            //InsertBtnTextAtPosition(b);
        }
    }
}
