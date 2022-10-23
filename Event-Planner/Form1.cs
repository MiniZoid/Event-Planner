namespace Event_Planner
{
    public partial class Form1 : Form
    {
        List<Label> labels;
        DateTime currentMonth = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}

        private void panel1_Paint(object sender, PaintEventArgs e){}

        private void Form1_Load(object sender, EventArgs e){
            generateGrid();
        }

        private void generateGrid(){
            DateTime dt = DateTime.Now;
            Month.Text = dt.ToString("MMMMMMMMM")+" "+dt.ToString("yyyy"); 
            var firstOfMonth = new DateTime(dt.Year, dt.Month, 1);
            int day = (int) firstOfMonth.DayOfWeek;
            int numbDays = DateTime.DaysInMonth(dt.Year, dt.Month);
            labels = new List<Label>();
            for(var i = 0; i <= 42; i++)
                labels.Add(new Label(){Name = "lbl" + i,
                                       Height = 136, 
                                       Width = 83, 
                                       MinimumSize = new Size(136, 83), 
                                       BorderStyle = System.Windows.Forms.BorderStyle.None,
                                       Text = ""});
            var x = 12;
            var y = 161;
            foreach(var lable in labels){
                if(x >= 1000){
                    x = 12;
                    y = y + 140;
                }
                lable.Location = new Point(x, y);
                this.Controls.Add(lable);
                x +=  142;
            }

            labels[day].Text = "1";
            for(int i = 0; i<numbDays; i++)
            {
                labels[i+day].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                int d = i+1;
                labels[i+day].Text = d.ToString();
            }            
        }
        private void Month_Click(object sender, EventArgs e){}

        public void updateText(DateTime dt){
            Month.Text = dt.ToString("MMMMMMMMM")+" "+dt.ToString("yyyy");
            var firstOfMonth = new DateTime(dt.Year, dt.Month, 1);
            int day = (int)firstOfMonth.DayOfWeek;
            int numbDays = DateTime.DaysInMonth(dt.Year, dt.Month);

            for(int i = 0; i<42; i++){
                labels[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                labels[i].Text = "";
            }

                labels[day].Text = "1";
            for(int i = 0; i<numbDays; i++)
            {
                labels[i+day].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                int d = i+1;
                labels[i+day].Text = d.ToString();
            }
        }

        public void addEvent(String plan, int day){
            var firstOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int offset = (int)firstOfMonth.DayOfWeek-1;
            labels[day+offset].Text = labels[day+offset].Text + "\n\n" + "-"+ plan;
        }

        public void removeEvent(int day){
            var firstOfMonth = new DateTime(currentMonth.Year, currentMonth.Month, 1);
            int offset = (int)firstOfMonth.DayOfWeek-1;
            int e = day +offset;
            String t = e.ToString();
            labels[day+offset].Text = t;
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(1);
            updateText(currentMonth);
        }

        private void prev_Click(object sender, EventArgs e)
        {
            currentMonth = currentMonth.AddMonths(-1);
            updateText(currentMonth);
        }

        private void newEvent_Click(object sender, EventArgs e)
        {
            EventCreator window = new EventCreator(this);
            window.Show();
        }
    }
}