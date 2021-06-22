public class ElectronicStore : Store{


    public ElectronicStore(string name, bool isopen){

    Name = name;
    Speciality = "Electronic";

    IsOpen = isopen;

    TotalEmployees = 25;
    
    Items.Add("TV");
    Items.Add("Playstaion");
    Items.Add("Mobile");

    Revenue = 500000;

    }


}