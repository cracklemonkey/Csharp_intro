using System;
using System.Collections.Generic;

public class ShoeStore : Store{

    public ShoeStore(string name, bool isopen){

    Name = name;
    Speciality = "Shoes";

    IsOpen = isopen;

    TotalEmployees = 10;
    
    Items.Add("Nike");
    Items.Add("Adidas");
    Items.Add("Puma");

    }

    public List<string> Items = new List<string>();
}