using System;

class Student {
    // Default constructor
    public Student(){

    }

    // parameterized constructor
        public Student(string n, byte rn){
        name=n;
        rollNumber=rn;
        }

    string name;
    byte rollNumber;

    public byte RollNumber{
        get{
            return rollNumber;
        }
        set{
               if(value<=100)
     {
          rollNumber= value;
     }  
        }
    }
    public string Address{get; set;} //Auto implemented property

    DateTime dob;



    public void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student RollNo: {name}");
        Console.WriteLine($"Student Address: {name}");
        Console.WriteLine($"Student DOB: {name}");
    }
}