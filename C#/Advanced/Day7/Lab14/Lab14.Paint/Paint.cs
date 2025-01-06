namespace Lab14.Paint
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    
        Color myColor = DefaultBackColor;
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                myColor = colorDialog1.Color;
        }

        private void Draw(object sender, MouseEventArgs e)
        {
            SolidBrush myBrush = new SolidBrush(myColor);
            Graphics x = CreateGraphics();
            x.FillEllipse(myBrush, e.X - 20, e.Y - 20, 40, 40);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                myColor = DefaultBackColor;
            else if (e.Button == MouseButtons.Left)
                myColor = colorDialog1.Color;
            MouseMove += Draw;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MouseMove -= Draw;
        }
    }
}
