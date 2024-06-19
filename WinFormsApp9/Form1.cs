namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        int touch = 298;
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
                poizons.Add(new Poizon(PG, (PG + 1) * 3, 5));
            }
            touch += 1;
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
            Form2 f2 = new Form2(poizons);
            f2.ShowDialog();

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
