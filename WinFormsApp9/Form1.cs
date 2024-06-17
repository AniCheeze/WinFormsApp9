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
                        break;
                    }
                case 200:
                    {
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
    }
}
