﻿using System;

public class Day
{
    Label label = new Label();
	public String day;
	public List<Plan> plans;
    public Day(int i){
		day = i.ToString();
		plans = new List<Plan>();
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
		plans.Add(plan);
		label.Text = day + "\n"+  printPlans();
	}

	public String printPlans(){
        String str = "";
        if (plans.Count > 1)
		{
			str = plans.Count.ToString() + " events";
		}
		else
		{
			str = plans[0].ToString();
        }
		//for(int i=0; i<plans.Count;i++){
		//	str = plans[i].ToString() + "\n" + str;		
		//}
		return str;
	}

	public List<Plan> getPlans()
	{
		return plans;
	}

	public void setText(String text){
		label.Text = text;
	}

	public String getText(){ 
		return label.Text;	
	}
}
