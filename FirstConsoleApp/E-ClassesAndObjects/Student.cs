using System;
using System.Data.Common;

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


   public Student(string n, byte rn, DateTime dob)
    {
        name = n;
        RollNumber = rn;
        Dob = dob;
    }
    public string name;
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

    public DateTime Dob{ get; }



    public  virtual void DisplayInfo()
    {
        Console.WriteLine($"Student Name: {name}");
        Console.WriteLine($"Student RollNo: {rollNumber}");
        Console.WriteLine($"Student Address: {Address}");
        Console.WriteLine($"Student DOB: {Dob}");
    }
}