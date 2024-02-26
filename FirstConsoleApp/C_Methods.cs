using System;
using System.Linq;  //namespace import gareko

class Methods
{

    // Used arrow function
    public void Greet()=>  Console.WriteLine("Hey, there!");
  

   public void Greet(string greeting)=> Console.WriteLine($"{greeting}, there!"); //string interpolation

    public  float CalculateBMI(float weightInkg, float heightInFt)
    {
        var heightInM = heightInFt * 0.3048f;
        var bmi = weightInkg/(heightInM * heightInM);
        return bmi;
    }



// Type as arguments


// Variable number of argument 
    public double GetMax(params double[] numbers) =>  numbers.Max(); //params is used to  for sending the any comma variable

    public (int, int) GetMinMax(params int[] numbers)
    {
        var smallest =numbers.Min();
        var highest =numbers.Max();
        return (smallest, highest);
    }
  
}