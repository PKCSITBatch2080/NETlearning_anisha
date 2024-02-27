// Single Inheritance 

// CSStudent --parent
//Student --Child
class CSStudent: Student, IGradeable{ //Multiple 
    // ctor tab prop tab
     //base is use  for calling the parent class ko constructor  lai
    public CSStudent(string name, byte rn, string pTitle):base(name, rn) 
    {
        ProjectTitle = pTitle;
    }
    public string ProjectTitle { get; set; }
    public string InternWork { get; set; }

    public double GetGrade()=> 3.6;
}