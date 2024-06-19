namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        int touch, plus = 1, time = 0;
        List<Poizon> poizons = new List<Poizon>();
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.Green;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int PG = rnd.Next(0, 4);
            if (PG == 0)
            {
                PG = rnd.Next(0, 3);
                poizons.Add(new Poizon(PG));
            }
            if (time == 0)
            {
                touch += 1;
            }
            else
            {
                touch += plus;
                time--;
            }
            label1.Text = touch.ToString();
            if (touch >= 100)
            {
                label2.Text = "Титул: Геншинёнок";
                pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass1.jpg"));
                if(touch >= 200)
                {
                    label2.Text = "Титул: Растер";
                    pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass2.jpg"));
                    if(touch >= 300)
                    {
                        label2.Text = "Элден рингер";
                        pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass3.jpg"));
                        if( touch >= 400)
                        {
                            label2.Text = "Фортнайтер";
                            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass4.jpg"));
                        }
                        if (touch >= 500)
                        {
                            label2.Text = "Батлфилд плеер";
                            pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "grass5.jpg"));
                            if(touch >= 600)
                            {
                                label2.Text = "Титул: Хойщик";
                            }
                        }
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(poizons,time);
            f2.ShowDialog();
            foreach (Poizon p in poizons)
            {
                if (p.GetTime() != 0)
                {
                    plus = p.GetBuy();
                    time = p.GetTime();
                    poizons.Remove(p);
                    break;
                }
            }
        }
    }
    public class Poizon
    {
        int type;
        int bust;
        int time; // Кол. кликов

        public Poizon()
        {
            type = 0;
            bust = 0;
            time = 0;

        }
        public Poizon(int type)
        {
            this.type = type;
            type = 0;
            time= 0;
        }
        public int GetType()
        {
            return type;
        }
        public int GetBuy()
        {
            return bust;
        }
        public int GetTime()
        {
            return time;
        }
        public void SetBust(int b, int t)
        {
            bust = b;
            time = t;
        }
    }
}
