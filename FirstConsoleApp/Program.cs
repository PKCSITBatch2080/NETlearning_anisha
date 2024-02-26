using System;

Console.WriteLine("I am main method");

DataTypes dt = new();
dt.Learn();


Methods m = new();
m.Greet("Hi");



// var highest =m.GetMax([3.4,5.6,78.4,23.4]); //uisng array 
// Console.WriteLine(highest);


 var highest =m.GetMax(3.4,5.6,78.2,23.4); //using without array 
 var highest2 =m.GetMax(3.4,5.6); //using without array 
 var highest3 =m.GetMax(3.4,5.6,78.2,67.4); //using without array 
 var highest4 =m.GetMax(5.6,23.4); //using without array 
Console.WriteLine(highest);



Generics g= new();
g.Display<string>("hiiiii you!!");
g.Display<int>(786);



Student anisha =new Student();
Student anjali =new Student("anjali Tamanag", 22);
var smritiRn= anjali.rollNumber;