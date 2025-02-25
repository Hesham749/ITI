namespace TestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            HttpClient client = new();
            var res = await client.GetAsync("https://localhost:7165/api/Courses");
            if (res.IsSuccessStatusCode)
            {
                List<Course> courses = await res.Content.ReadAsAsync<List<Course>>();
                dataGridView1.DataSource = courses;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Course crs = new()
            {
                id = int.Parse(txtID.Text),
                crs_name = txtName.Text,
                crs_desc = txtDesc.Text,
                duration = int.Parse(txtDuration.Text)
            };



            HttpClient client = new();
            var res = await client.PostAsJsonAsync("https://localhost:7165/api/Courses", crs);
            if (res.IsSuccessStatusCode)
            {
                Form1_Load(sender, null);
                return;
            }
            MessageBox.Show("Error");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
