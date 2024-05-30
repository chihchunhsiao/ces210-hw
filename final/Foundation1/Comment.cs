public class Comment
{
    private string _personName;
    private string _commentText;

    public Comment(string personName, string commentText)
    {
        _personName = personName;
        _commentText = commentText;
    }

    public string GetComment()
    {
        return $"Person Name: {_personName}; Comment Text: {_commentText}";
    }
}