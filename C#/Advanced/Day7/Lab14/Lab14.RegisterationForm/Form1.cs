using System.Media;

namespace Lab14.RegisterationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ID : {txtId.Text}\nName : {txtName.Text}\nAge : {txtAge.Text}\nMobile : {txtMobile.Text}", "Register Successfully");
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            TextBox t = sender as TextBox;
            if (char.IsDigit(e.KeyChar))
            {
                if (t.Text.Length < t.MaxLength)
                    AppendCharacterToTxtBox(t, e);
                else
                    SystemSounds.Exclamation.Play();
            }
            else
                BackSpaceWileHandeled(t, e);
        }

        private void AgeValidation(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            bool parsed = int.TryParse((txtAge.Text + e.KeyChar.ToString()), out int result);
            if (parsed && result <= 50)
                AppendCharacterToTxtBox(txtAge, e);
            else
                BackSpaceWileHandeled(txtAge, e);
        }

        void AppendCharacterToTxtBox(TextBox t, KeyPressEventArgs e)
        {
            if (t != null)
            {
                int pos = t.SelectionStart;
                if (t.SelectionLength > 0)
                {
                    int len = t.SelectionLength;
                    t.Text = t.Text?.Remove(t.SelectionStart, t.SelectedText.Length);
                    t.SelectionStart = pos;
                }

                t.Text = t.Text.Insert(pos, e.KeyChar.ToString());
                t.SelectionStart = pos + 1;
            }

        }

        private void BackSpaceWileHandeled(TextBox t, KeyPressEventArgs e)
        {
            if (t != null)
            {
                if (e.KeyChar == '\b' & t.Text.Length > 0)
                {
                    int pos = t.SelectionStart;
                    if (t.SelectionLength > 0)
                    {
                        int len = t.SelectionLength;
                        t.Text = t.Text?.Remove(t.SelectionStart, t.SelectedText.Length);
                        t.SelectionStart = pos;
                    }
                    else if (pos > 0)
                    {
                        t.Text = t.Text?.Remove(t.SelectionStart - 1, 1);
                        t.SelectionStart = pos - 1;
                    }
                }
            }
        }
    }

}

