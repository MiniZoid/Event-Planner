using System;

public class Day
{
    Label label = new Label();
    public Day(int i){
		label.Height = 136;
		label.Width = 83;
		label.MinimumSize = new Size(136,83);
		label.BorderStyle = System.Windows.Forms.BorderStyle.None;
		label.Text = i.ToString();
    }

	public void setVisible(){
		label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    }

	public void setInvisible(){
        label.BorderStyle = System.Windows.Forms.BorderStyle.None;
    }

	public void createEvent(String text){
		label.Text = label.Text + " \n\n" + text;	
	}

	public void setText(String text){
		label.Text = text;
	}

	public String getText(){ 
		return label.Text;	
	}
}
