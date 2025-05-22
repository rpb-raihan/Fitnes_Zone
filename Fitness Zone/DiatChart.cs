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
    public partial class DiatChart : Form
    {
        public DiatChart()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loss h = new Loss();
            h.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shredded h = new Shredded();
            h.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gain h = new Gain();
            h.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Trainer t = new Trainer();
            t.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TimeClass t = new TimeClass();
            t.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DiatChart h = new DiatChart();
            h.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
            this.Hide();
        }
    }
}
