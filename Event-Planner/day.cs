using System;

public class Day
{
    Label label = new Label();
	String day;
	public Dictionary<String, Plan> plans = new Dictionary<String, Plan>();
    public Day(int i){
		day = i.ToString();
		label.Height = 136;
		label.Width = 83;
		label.MinimumSize = new Size(136,83);
		label.BorderStyle = System.Windows.Forms.BorderStyle.None;
		label.Text = day.ToString();
    }

	public void setVisible(){
		label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    }

	public void setInvisible(){
        label.BorderStyle = System.Windows.Forms.BorderStyle.None;
    }

	public void createEvent(String name, DateTime time){
		Plan plan = new Plan(name,time);
		try{
            plans.Add(name,plan);
        }
		catch{
			
			}
		label.Text = getText();
	}

	public void deleteEvent(){
		
	}

	public String printPlans(){
		String str ="";
		foreach(KeyValuePair<String,Plan> kvp in plans){
			str = string.Format("{0}",kvp.Value) + "\n" + str;		
		}
		return str;
	}
	public String getText(){ 
		return day + "\n" + printPlans();	
	}
}
