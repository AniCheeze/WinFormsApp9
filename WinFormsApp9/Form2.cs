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
        public Form2(List<Poizon>p)
        {
            InitializeComponent();
            foreach (Poizon poizon in p)
            {
                if (poizon.GetType() == 0)
                {
                    pictureBox1.Image = Image.FromFile(Path.Combine(Application.StartupPath, "P1.jpg"));
                }
                if(poizon.GetType() == 1) 
                {
                    pictureBox2.Image = Image.FromFile(Path.Combine(Application.StartupPath, "P2.jpg"));
                }
                if(poizon.GetType() == 2)
                {
                    pictureBox3.Image = Image.FromFile(Path.Combine(Application.StartupPath, "P3.jpg"));
                }
            }
        }


    }
}
