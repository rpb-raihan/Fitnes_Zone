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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Home h = new Home();
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
