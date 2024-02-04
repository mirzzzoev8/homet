namespace Task1;
public class Person
{
    string name;
    string address; 

    public Person(string _name, string _address)
    {
        name = _name;
        address = _address;
    }
    public string getName(){
        return name;
    }
    public string getAddress(){
        return address;
    }
    public void setAddress(string _address){
        address = _address;
    }
    public override string ToString()
    {
        return $"{name} {address}";
    }
}
