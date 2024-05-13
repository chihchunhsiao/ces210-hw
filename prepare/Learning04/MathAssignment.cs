public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment()
    {

    }

    public MathAssignment(string student, string topic, string textbookSection, string problems) : base(student, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeWorkList()
    {
        return $"Section {_textbookSection} Problems {_problems}\n";
    }
}