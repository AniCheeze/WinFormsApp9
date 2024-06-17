namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        int touch;
        List<Poizon> poizons = new List<Poizon>();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int PG = rnd.Next(0, 4);
            if (PG == 0)
            {
                PG = rnd.Next(0, 3);
                poizons.Add(new Poizon(PG, (PG + 1) * 3, 5));
            }
            touch += 1;
            label1.Text = touch.ToString();
            switch (touch)
            {
                case 100:
                    {
                        label1.Text = "�����: ���������";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass1.jpg"));
                        break;
                    }
                case 200:
                    {
                        label1.Text = "�����: ������";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass2.jpg"));
                        break;
                    }
                case 300:
                    {
                        label1.Text = "����� ������";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass3.jpg"));
                        break;
                    }
                case 400:
                    {
                        label1.Text = "����������";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass4.jpg"));
                        break;
                    }
                case 500:
                    {
                        label1.Text = "�������� �����";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass5.jpg"));
                        break;
                    }
                case 600:
                    {
                        label1.Text = "�����: ������";
                        break;
                    }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(poizons);
            f2.ShowDialog();

        }

    }
    public class Poizon
    {
        int type;
        int bust;
        int time; // ���. ������

        public Poizon()
        {
            type = 0;
            bust = 0;
            time = 0;

        }
        public Poizon(int type, int bust, int time)
        {
            this.type = type;
            this.time = time;
            this.bust = bust;
        }
        public int GetType()
        {
            return type;
        }
    }
}
