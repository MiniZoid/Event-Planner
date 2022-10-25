using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Planner
{
    public partial class Weekform : Form
    {
        Form1 form;
        DateTime dt;
        public Weekform(Form1 form, DateTime currmonth)
        {
            InitializeComponent();
            this.form = form;
            this.dt = currmonth;
        }

        private void newEventWeek_Click(object sender, EventArgs e)
        {
            EventCreator window = new EventCreator(form, dt);
            window.Show();
        }
    }
}
