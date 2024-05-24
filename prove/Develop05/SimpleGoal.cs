public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public override void RecordEvent()
    {    
        _isComplete = true;
        
    }

    public override bool IsComplete()
    {
        if (_isComplete == true)
        return true;

        else 
        return false;
    }

    public override string GetStringRepresentation()
    {
        
        return $"{_shortName},{_description},{_points},{_isComplete}";
    }


}
