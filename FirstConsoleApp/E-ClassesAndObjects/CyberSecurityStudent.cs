using System;

// Multilevel Inheritance 
class CyberSecurityStudent :CSStudent
{

    public CyberSecurityStudent(string name, byte rn, string pTitle, string Certification):base(name, rn, pTitle) 
    {
        SecurityCertification = Certification;
    }
    public string EthicalHackingTitle { get; set; }
    public string SecurityCertification { get; set; }
    public DateTime CertifiedDate { get; set; }



    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Certification: {SecurityCertification}");
        Console.WriteLine($"Certified Date: {CertifiedDate}");
    }

       public static void Do()
    {        
    }
}