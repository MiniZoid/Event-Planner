using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Event_Planner {
    public partial class eventDelete:Form {
        Dictionary<String,Month> months;
        Form1 form;
        public eventDelete(Form1 form, Dictionary<String,Month> months){
            this.form = form;
            this.months = months;
            InitializeComponent();
            DateTime time = dateTimePicker1.Value;
            Month month = months[getMonth(time)];
            Day day = month.days[time.Day];
            Dictionary<string,Plan>.KeyCollection keys = day.plans.Keys;
            foreach(string key in keys) {
                checkedListBox1.Items.Add(key,CheckState.Unchecked);
            }
        }

        public string getMonth(DateTime dt){
            return dt.ToString("MMM")+dt.ToString("yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender,EventArgs e) {
            checkedListBox1.Items.Clear();
            DateTime time = dateTimePicker1.Value;
            Month month = months[getMonth(time)];
            Day day = month.days[time.Day];
            Dictionary<string,Plan>.KeyCollection keys = day.plans.Keys;
            foreach(string key in keys){
                checkedListBox1.Items.Add(key, CheckState.Unchecked);    
            }
        }

        private void Close_Click(object sender,EventArgs e) {
            this.Close();
        }

        private void deleteButton_Click(object sender,EventArgs e){
            List<string> keys = new List<string>();
            foreach(string itemChecked in checkedListBox1.CheckedItems){
                keys.Add(itemChecked);
            }
            DateTime time = dateTimePicker1.Value;
            Month month = months[getMonth(time)];
            Day day = month.days[time.Day];
            for(int i=0; i<keys.Count; i++){
                day.deleteEvent(keys[i]);
            }
            form.writeJSON();
            this.Close();
            form.paintMonth(form.generateMonth(form.currentMonth),form.previousMonth,form.nextMonth);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender,EventArgs e) {

        }
    }
}