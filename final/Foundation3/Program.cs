using System;

class Program
{
    static void Main(string[] args)
    {
        Address addressLectures = new Address("Yihsin", "Chudong", "Chinchu", "TW");
        Lectures lectures = new Lectures("Parent-Child Piture Book", "Enhance parent-child relationship by explaining picture book skills.",
            "July 13th, 2024", "7:00 pm", addressLectures, "Zheng Liu", 100);
        
        Console.WriteLine(lectures.GetFullDetails());
        Console.WriteLine(lectures.GetStanderDetails());        
        Console.WriteLine($"Short Description:\nEvent type: {lectures}, {lectures.GetShortDescription()}");
        Console.WriteLine("---------------------------------------------------------------------------");
                
        Address addressReceptions = new Address("Muhlhauser", "Fairfield", "OH", "USA");
        Receptions receptions = new Receptions("Wedding Reception", "Sasa Jirah & Allan Susilo's wedding reception.", "Sep. 10th, 2024","7:00 pm", addressReceptions, "123bily@gmail.com");

        Console.WriteLine(receptions.GetFullDetails());
        Console.WriteLine(receptions.GetStanderDetails());       
        Console.WriteLine($"Short Description:\nEvent type: {receptions}, {receptions.GetShortDescription()}");
        Console.WriteLine("---------------------------------------------------------------------------");

        Address addressOutdoor = new Address("Rue Diderot", "Montreuil", "Paris", "France");
        Outdoor outdoor = new Outdoor("Yacht Party", "Bachelor party with a professional DJ.", "June 15th, 2024","5:00 pm", addressOutdoor,"Cloudy");

        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine(outdoor.GetStanderDetails());       
        Console.WriteLine($"Short Description:\nEvent type: {outdoor}, {outdoor.GetShortDescription()}");
        

    }
}