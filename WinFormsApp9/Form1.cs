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
            touch += 1;
            label1.Text = touch.ToString();
            switch (touch)
            {
                case 100:
                    {
                        label1.Text = "Титул: Геншинёнок";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass1.jpg"));
                        break;
                    }
                case 200:
                    {
                        label1.Text = "Титул: Растер";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass2.jpg"));
                        break;
                    }
                case 300:
                    {
                        label1.Text = "Элден рингер";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass3.jpg"));
                        break;
                    }
                case 400:
                    {
                        label1.Text = "Фортнайтер";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass4.jpg"));
                        break;
                    }
                case 500:
                    {
                        label1.Text = "Батлфилд плеер";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass5.jpg"));
                        break;
                    }
                case 600:
                    {
                        label1.Text = "Титул: Хойщик";
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
