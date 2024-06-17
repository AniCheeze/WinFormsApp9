namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        int touch;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            touch += 5;
            label1.Text = touch.ToString();
            switch (touch)
            {
                case 100:
                    {
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass1.jpg"));
                        break;
                    }
                case 200:
                    {
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass2.jpg"));
                        break;
                    }
                case 300:
                    {
                        break;
                    }
                case 400:
                    {
                        break;
                    }
                case 500:
                    {
                        break;
                    }
                case 600:
                    {
                        break;
                    }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
