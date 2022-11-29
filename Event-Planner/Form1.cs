using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace Event_Planner{
    public partial class Form1 : Form
    {
        List<Label> boxes = new List<Label>();
        List<Day> displayDays = new List<Day>(42);
        public DateTime currentMonth = DateTime.Now;
        Dictionary<String,Month> months = new Dictionary<String, Month>();
        Dictionary<string,List<string>> JSONData = new Dictionary<string,List<string>>();
        public Month previousMonth;
        public Month nextMonth;
        public Month thisMonth;
        public Form1(){
            InitializeComponent();
            for(var i = 0;i <= 42;i++){
                boxes.Add(new Label(){
                    Name =  i.ToString(),
                    Height = 136,
                    Width = 83,
                    MinimumSize = new Size(136,83),
                    BorderStyle = System.Windows.Forms.BorderStyle.None,
                    Text = ""});
            }
        }

        private void Form1_Load(object sender, EventArgs e){
            Month start = generateMonth(currentMonth);
            this.previousMonth = generateMonth(currentMonth.AddMonths(-1));
            this.nextMonth =  generateMonth(currentMonth.AddMonths(1));
            paintMonth(start,previousMonth,nextMonth);
            thisMonth = start;
            readJSON();
        }
        public Month generateMonth(DateTime dt){
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
            foreach(var day in boxes){
                if(x >= 1000) {
                    x = 12;
                    y = y + 140;
                }
                day.Location = new Point(x,y);
                this.Controls.Add(day);
                x +=  142;
            }
            for(int i = 0;i<42;i++){
                boxes[i].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                boxes[i].Text = "";
                boxes[i].ForeColor = System.Drawing.Color.Black;
            }
            displayDays.Clear();
            int prevOffset = previousMonth.numbOfDays - current.firstOfMonth+1;
            for(int k=0; k<current.firstOfMonth; k++){
                boxes[k].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                boxes[k].Text = previous.days[prevOffset].getText();
                displayDays.Add(previous.days[prevOffset]);
                prevOffset++;
            }
            for(int i = 0;i<current.numbOfDays;i++){
                boxes[i+current.firstOfMonth].Text = current.days[i+1].getText();
                displayDays.Add(previous.days[i+1]);
            }
            int set = 1;
            for(int l=current.numbOfDays+current.firstOfMonth; l<42; l++){
                boxes[l].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                boxes[l].Text = next.days[set].getText();
                displayDays.Add(previous.days[set]);
                set++;
            }
            if(next.isCurrentMonth() == true){
                for(int i=current.numbOfDays+prevOffset; i<42; i++){
                    if(displayDays[i].isToday() == true) boxes[i].ForeColor = System.Drawing.Color.Red;
                }    
            }
            else if(current.isCurrentMonth() == true){
                for(int i=0; i<42; i++){
                    if(displayDays[i].isToday() == true){
                        boxes[i].ForeColor = System.Drawing.Color.Red;
                        break;
                    } 
                }                
            }
            else if(previous.isCurrentMonth() == true){
                for(int i=0; i<current.firstOfMonth; i++){
                    if(displayDays[i].isToday() == true) boxes[i].ForeColor = System.Drawing.Color.Red;
                }  
            }
        }
        private void Month_Click(object sender, EventArgs e){}

        public void addEvent(String plan, DateTime dt){
            Month cache = generateMonth(dt);
            months[getCurrentMonth(dt)].addEvent(plan,dt);             
            paintMonth(generateMonth(currentMonth),previousMonth,nextMonth);
        }

        private void next_Click(object sender, EventArgs e){
            previousMonth = generateMonth(currentMonth);
            currentMonth = currentMonth.AddMonths(1);
            nextMonth = generateMonth(currentMonth.AddMonths(1));
            thisMonth = generateMonth(currentMonth);
            paintMonth(generateMonth(currentMonth),previousMonth, nextMonth);
        }

        private void prev_Click(object sender, EventArgs e){            
            nextMonth = generateMonth(currentMonth);
            currentMonth = currentMonth.AddMonths(-1);
            previousMonth = generateMonth(currentMonth.AddMonths(-1));
            thisMonth = generateMonth(currentMonth);
            paintMonth(generateMonth(currentMonth),previousMonth, nextMonth);
        }

        private void newEvent_Click(object sender, EventArgs e){
            EventCreator window = new EventCreator(this, currentMonth);
            window.Show();
        }
        public String getCurrentMonth(DateTime dt){
            return dt.ToString("MMM")+dt.ToString("yyyy");
        }
        public Dictionary<String, Month>  getMonthDict(){
            return months;
        }

        private void eventViewButton_Click(object sender, EventArgs e)
        {
            EventView eventview = new EventView(this, currentMonth);
            eventview.Show();
        }

        private void readJSON(){
            string fileName = "data.json";
            string jsonString = File.ReadAllText(fileName);
            Dictionary<string, List<string>> values = JsonConvert.DeserializeObject<Dictionary<string,List<string>>>(jsonString);
            foreach(KeyValuePair<string,List<string>> entry in values){
                Month cache = months[entry.Key];
                List<string> events = values[entry.Key];
                for(int i=0; i<events.Count; i++){
                    string[] items = events[i].Split(",");
                    for(int x=0;x<items.Length;x++){
                        string[] split = items[x].Split("|");
                        if(split[0] == ""){
                            continue;
                        }
                        string name = split[0];
                        string time = split[1];
                        string dateInput = time;
                        var parsedDate = DateTime.Parse(dateInput);
                        cache.days[i].createEvent(name,parsedDate);
                    }
                        
                }

            }
            paintMonth(thisMonth, previousMonth, nextMonth);
        }

        public void writeJSON(){
            try{
                JSONData.Add(thisMonth.getKey(),thisMonth.getEvents());
            }
            catch(Exception ex){
                JSONData[thisMonth.getKey()] = thisMonth.getEvents();    
            }
            string fileName = "data.json";
            var options = new JsonSerializerOptions{WriteIndented = true};
            string jsonString = System.Text.Json.JsonSerializer.Serialize(JSONData, options);
            File.WriteAllText(fileName,jsonString);
        }

        private void deleteEvent_Click(object sender,EventArgs e) {
            eventDelete eventDelete = new eventDelete(this, months);
            eventDelete.Show();
        }
    }
}