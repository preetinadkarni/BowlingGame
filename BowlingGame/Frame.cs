namespace BowlingGame;

public class Frame
{
    private List<int> _rolls;
    // private int _score;

    public int Score
    {
        get;
        set;
    }

    public void SetRolls(int pins)
    {
        _rolls.Add(pins);
    }

    public List<int> GetRolls()
    {
        return _rolls;
    }

    public Frame()
    {
        _rolls = new List<int>{};
    }
}