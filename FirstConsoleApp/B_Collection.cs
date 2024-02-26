using System.Collections.Generic;

class Coll
{
    void Learn()
    {

        // One  dimensional 
        byte[] ages=[78, 23,45,67,12,34,56,7,8];
        string[] names=["anisha", "resma", "namrata"];
      
        // Multi
        int [,] studentsInClassRoom =new int[7,6];
        studentsInClassRoom[0,0] =0;
        studentsInClassRoom[0,1]=1;
        studentsInClassRoom[0,2]=2;
        studentsInClassRoom[0,3]=30;


        // Jagged Array
        int[][] studentsInClassRoom2 =[[1,2,3],[3,4],[2,4,5,6]];

        // Collections
        List<int>  agesList=[3,4,5,6,7,8,9];
        List<string> nameList = ["anisha", "anjali","rekha"];  //Big O oh n times lagcah aasri nikalda   O(n), n =30000000,


        // Dictionary
        Dictionary<string, long> countryPopulation = new();

        countryPopulation.Add("Nepal", 2457898556);
        countryPopulation.Add("India",3457898556);
        countryPopulation.Add("China",5457898556);
        countryPopulation.Add("USA",6457898556);


        // var p = countryPopulation("India");
    }
}
