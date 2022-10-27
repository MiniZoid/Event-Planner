using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;

namespace Event_Planner
{
    public partial class Form1 : Form
    {
        List<Label> boxes = new List<Label>();
        DateTime currentMonth = DateTime.Now;
        Dictionary<String,Month> months = new Dictionary<String, Month>();
        Month previousMonth;
        Month nextMonth;
        public Form1(){
            InitializeComponent();
            for(var i = 0;i <= 42;i++){
                boxes.Add(new Label() {
                    Name =  i.ToString(),
                    Height = 136,
                    Width = 83,
                    MinimumSize = new Size(136,83),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Text = ""});
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Month start = generateMonth(currentMonth);
            this.previousMonth = generateMonth(currentMonth.AddMonths(1));
            this.nextMonth =  generateMonth(currentMonth.AddMonths(-1));
            paintMonth(start,previousMonth,nextMonth);
        }

        private Month generateMonth(DateTime dt){
            Month month = new(dt);
            try{
                months.Add(getCurrentMonth(dt),month);
            }
            catch{
                return months[getCurrentMonth(dt)];
            }
            return month;
        }

        public void paintMonth(Month current, Month previous, Month next){
            Month.Text = current.ToString();
            var x = 12;
            var y = 161;
            foreach(var day in boxes) {
                if(x >= 1000) {
                    x = 12;
                    y = y + 140;
                }
                day.Location = new Point(x,y);
                this.Controls.Add(day);
                x +=  142;
            }

            for(int i = 0;i<42;i++) {
                boxes[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                boxes[i].Text = "";
            }

            int prevOffset = previousMonth.numbOfDays - current.firstOfMonth+1;
            for(int k=0; k<current.firstOfMonth; k++){
                boxes[k].Text = previous.days[prevOffset].getText();
                boxes[k].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                prevOffset++;
            }

            for(int i = 0;i<current.numbOfDays;i++) {
                boxes[i+current.firstOfMonth].Text = current.days[i+1].getText();
            }
            int set = 1;
            for(int l=current.numbOfDays+current.firstOfMonth; l<42; l++){
                boxes[l].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                boxes[l].Text = next.days[set].getText();
                set++;
            }

        }
        private void Month_Click(object sender, EventArgs e) { }

        public void addEvent(String plan, DateTime dt){
            Month month = generateMonth(dt);
            months[getCurrentMonth(dt)].addEvent(plan,dt);            
            paintMonth(months[getCurrentMonth(currentMonth)],previousMonth,nextMonth);
        }

        public void removeEvent(int day){
        }

        private void next_Click(object sender, EventArgs e)
        {
            previousMonth = generateMonth(currentMonth);
            currentMonth = currentMonth.AddMonths(1);
            nextMonth = generateMonth(currentMonth.AddMonths(1));
            paintMonth(generateMonth(currentMonth), nextMonth, previousMonth);
        }

        private void prev_Click(object sender, EventArgs e){
            
            nextMonth = generateMonth(currentMonth);
            currentMonth = currentMonth.AddMonths(-1);
            previousMonth = generateMonth(currentMonth.AddMonths(-1));
            paintMonth(generateMonth(currentMonth), nextMonth, previousMonth);
        }

        private void newEvent_Click(object sender, EventArgs e)
        {
            EventCreator window = new EventCreator(this, currentMonth);
            window.Show();
        }

        private void weekButton_Click(object sender, EventArgs e)
        {
            Weekform weekform = new Weekform(this, currentMonth);
            weekform.Show();
        }

        public String getCurrentMonth(DateTime dt){
            return dt.ToString("MMM")+dt.ToString("yyyy");
        }
    }
}