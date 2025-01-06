using System.Media;

namespace Lab14.RegisterationForm
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"ID : {txtId.Text}\nName : {txtName.Text}\nAge : {txtAge.Text}\nMobile : {txtMobile.Text}", "Register Successfully");
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != '\b'))
                PreventEntry(e);
        }

        private void AgeValidation(object sender, KeyPressEventArgs e)
        {
            if (int.TryParse(txtAge.Text + e.KeyChar.ToString(), out int r))
            {
                if (r < 1 || r > 50)
                    PreventEntry(e);
            }
        }

        private static void PreventEntry(KeyPressEventArgs e)
        {
            e.Handled = true;
            SystemSounds.Exclamation.Play();
        }

    }

}

