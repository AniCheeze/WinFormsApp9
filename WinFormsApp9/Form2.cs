using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp9
{
    public partial class Form2 : Form
    {
        List<Poizon> p;
        bool Uhave = false;
        int time;
        public Form2(List<Poizon> p, int time)
        {
            InitializeComponent();
            this.time = time;
            this.p = p;
            foreach (Poizon poizon in p)
            {
                if (poizon.GetType() == 0)
                {
                    pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "P1.jpg"));
                }
                if (poizon.GetType() == 1)
                {
                    pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "P2.jpg"));
                }
                if (poizon.GetType() == 2)
                {
                    pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "P3.jpg"));
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Uhave != true && time == 0)
            {
                foreach (Poizon p1 in p)
                {
                    if (p1.GetType() == 0)
                    {
                        p1.SetBust(5, 5);
                        Uhave = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Можно использовать только одно зелье","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Uhave != true && time == 0)
            {
                MessageBox.Show(time.ToString());
                foreach (Poizon p1 in p)
                {
                    if (p1.GetType() == 1)
                    {
                        p1.SetBust(10, 5);
                        Uhave = true;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Можно использовать только одно зелье","Eror",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Uhave != true && time == 0)
            {
                foreach (Poizon p1 in p)
            {
                if (p1.GetType() == 2)
                {
                    p1.SetBust(15, 5);
                    Uhave = true;
                    break;
                }
            }
            }
            else
            {
                MessageBox.Show("Можно использовать только одно зелье", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
