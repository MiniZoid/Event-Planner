using System;

public class Day
{
    Label label = new Label();
	string day;
	int dayNum;
	DateTime dt;
	public Dictionary<String, Plan> plans = new Dictionary<String, Plan>();
    public Day(int i){
		dayNum = i;
		day = i.ToString();
		label.Height = 136;
		label.Width = 83;
		label.MinimumSize = new Size(136,83);
		label.BorderStyle = System.Windows.Forms.BorderStyle.None;
		label.Text = day.ToString();
    }

	public bool isToday(){
		if((int)DateTime.Now.Day == dayNum){
			return true;	
		}
		return false;
	}

	public void createEvent(String name, DateTime time){
		Plan plan = new Plan(name,time);
		try{
            plans.Add(name,plan);
        }
		catch{}
		label.Text = getText();
	}

	public void deleteEvent(string key){
		plans.Remove(key);
		
	}

	public string getPlans(){
		string result = "";
        foreach(KeyValuePair<string,Plan> entry in plans){
			result = result + " "+entry.Value.ToString()+",";
		}
		if(result.Length>0){
			result = result.Remove(0,1);
		}
		return result;
	}

	public String getText(){ 
		if(plans.Count == 0){
			return day;	
		}
		return day + "\nEvents today: \n" + plans.Count.ToString();	
	}
}
