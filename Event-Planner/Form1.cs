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
            paintMonth(start);
        }

        private Month generateMonth(DateTime dt){
            Month month = new(dt);
            Month.Text = month.ToString();
            try{
                months.Add(getCurrentMonth(),month);
            }
            catch{
                return months[getCurrentMonth()];
            }
            return month;
        }

        public void paintMonth(Month month){
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

            for(int i = 0;i<=42;i++) {
                boxes[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                boxes[i].Text = "";
            }
            for(int i = 0;i<month.numbOfDays;i++) {
                boxes[i+month.firstOfMonth].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                boxes[i+month.firstOfMonth].Text = month.days[i+1].getText();
            }
        }
        private void Month_Click(object sender, EventArgs e) { }

        public void addEvent(String plan, int day){
            String cache = getCurrentMonth();
            months[cache].addEvent(plan,day);
            paintMonth(months[cache]);
        }

        public void removeEvent(int day){
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            paintMonth(generateMonth(currentMonth));
        }

        private void prev_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            paintMonth(generateMonth(currentMonth));
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

        public String getCurrentMonth(){
            return currentMonth.ToString("MMM")+currentMonth.ToString("yyyy");
        }
    }
}