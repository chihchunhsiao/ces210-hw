public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment()
    {

    }

    public WritingAssignment(string student, string topic, string title) : base(student, topic)
    {
        _title = title;
    }

    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}\n";
    }
}