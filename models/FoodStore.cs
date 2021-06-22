public class FoodStore : Store{

   
    public FoodStore(string name, bool isopen, string healthInspectorName){

    Name = name;
    Speciality = "Food";

    IsOpen = isopen;

    TotalEmployees = 50;
    
    Items.Add("Chesse");
    Items.Add("Meat");
    Items.Add("Milk");

    Revenue = 1000000;

    HealthInspectorName = healthInspectorName;

    }
    public string HealthInspectorName;

    


}