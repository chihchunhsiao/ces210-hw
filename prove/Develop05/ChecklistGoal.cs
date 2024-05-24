using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _amountComplete = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
    public int GetAmountComplete()
    {
        return _amountComplete;
    }

    public void SetAmountComplete(int amountComplete)
    {
        _amountComplete = amountComplete;
    }



    public override void RecordEvent()
    {
        _amountComplete ++; 

        if (_amountComplete == _target)
        {
            int newPoints = _bonus + int.Parse(_points);

            _points = Convert.ToString(newPoints);
            
        }     

    }

    public override bool IsComplete()
    {
        if (_amountComplete == _target)
        {
            return true;
        }
         
        else 
        {
            return false;
        }
        
    }

    public override string GetDetailsString()
    {
        
        return $"{_shortName}, {_description}, -- Currently completed: {_amountComplete}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points},{_bonus},{_target},{_amountComplete}";
    }


}
