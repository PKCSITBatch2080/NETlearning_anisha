using System;

class Student {
    public string ProjectWork { get; set; }
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



    public  virtual void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student RollNo: {rollNumber}");
        Console.WriteLine($"Student Address: {Address}");
        Console.WriteLine($"Student DOB: {dob}");
    }
}