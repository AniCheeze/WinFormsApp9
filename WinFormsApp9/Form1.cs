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
        }
    }
}
