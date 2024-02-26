using System;

class Student {
    // Default constructor
    public Student(){

    }

    // parameterized constructor
        public Student(string n, byte rn){
        name=n;

        if(rn>100)
         return ;
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
    string address;

    DateTime dob;
}