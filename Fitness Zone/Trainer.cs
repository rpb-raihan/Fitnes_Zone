using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Zone
{
    public partial class Trainer : Form
    {
        public Trainer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TrainerMale t = new TrainerMale();
            t.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FemaleTrainer t = new FemaleTrainer();
            t.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
    }
}
