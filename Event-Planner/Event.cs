
public class Plan{

	String name;
	String description;
    DateTime time;

	public Plan(String name, DateTime dt) {
		this.name = name;
		this.time = dt;
	}

	public String getDiscription(){
		return description;
    }

	public String getTime(){
		return time.ToString("MM/dd/yyyy hh:mm tt");

    }

	public String getName(){
		return name;
	}
	override
	public String ToString(){
		return name + "|" + time.ToString("hh:mm tt");	

    }
}
