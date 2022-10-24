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
    public partial class EventCreator : Form
    {
        Form1 form;
        DateTime dt;
        public EventCreator(Form1 form, DateTime currmonth)
        {
            InitializeComponent();
            this.form=form;
            this.dt = currmonth;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(eventDay.Value);
            form.addEvent(eventName.Text, val);
            this.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formField1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
