using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Event_Planner
{
    public partial class EventView : Form
    {
        Form1 form;
        DateTime dt;
        List<Plan> plans;
        Dictionary<String, Month> months;
        List<Day> days;

        public EventView(Form1 form, DateTime currmonth)
        {
            InitializeComponent();
            this.form = form;
            this.dt = currmonth;
        }

        private void EventView_Load(object sender, EventArgs e)
        {
            string title = "Events For " + dt.ToString("MMM") + " " + dt.ToString("yyyy");
            eventview_label.Text = title;


            months = getMonths();
            days = getDays();

            String i = "";
            string newLine = Environment.NewLine;

            foreach (var day in days)
            {
                foreach(var plan in day.plans)
                {
                    i = i + "-" + plan.Key.ToString() + " at " + plan.Value.getTime() +  newLine;
                }     
            }
            i = i.ToString();
            if (string.IsNullOrEmpty(i))
            {
                eventview_tb.Text = "No Events For This Month";
            }
            else
            {
                eventview_tb.Text = i;
            }
            

        }
        public Dictionary<String, Month> getMonths()
        {
            Dictionary<String, Month> months = form.getMonthDict();
            return months;
        }

        public List<Day> getDays()
        {
            List <Day> days = months[form.getCurrentMonth(dt)].days;
            return days;
        }

        private void eventview_label_Click(object sender, EventArgs e)
        {

        }

        private void eventview_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
