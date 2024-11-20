namespace ConsoleApp6;

internal class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string BirthdayYear { get; set; }
    public string Gender { get; set; }
    public string StudyGroup { get; set; }
    public void DisplayInfo()
    {
        var result = $"First Name: {FirstName}, Last Name: {LastName}, Age: {Age}, Birthday Year: {BirthdayYear}, Gender: {Gender}, Study Gruop: {StudyGroup}";
        Console.WriteLine(result);
    }
}
