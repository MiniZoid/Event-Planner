using System;
using System.Reflection.Metadata.Ecma335;

public class Month{

    private DateTime time;
    public int firstOfMonth;
    public int numbOfDays;
    public int monthNum;
    public List<Day> days = new List<Day>();

	public Month(DateTime dt){
        monthNum = dt.Month;
        this.time = dt;
        var offset = new DateTime(time.Year,time.Month,1);
        firstOfMonth = (int)offset.DayOfWeek;
        numbOfDays = DateTime.DaysInMonth(time.Year,time.Month);

        for(var i = 0;i <= 42;i++) {
            Day day = new Day(i);
            days.Add(day);
        }
    }

    public void addEvent(String day, DateTime dt){
       days[dt.Day].createEvent(day,dt);   
    }

    public bool isCurrentMonth(){
        if(monthNum == DateTime.Now.Month){
            return true;
        }
        return false;
    }

    override
    public String ToString(){
        return time.ToString("MMMMMMMMM")+" "+time.ToString("yyyy");
    }

    public string getKey(){
        return time.ToString("MMM")+time.ToString("yyyy");    
    }

    public List<string> getEvents(){
        List<string> events = new List<string>();
        for(int i=0; i<days.Count;  i++){
            events.Add(days[i].getPlans());
        }
        return events;
    }
}
