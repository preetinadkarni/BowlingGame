namespace BowlingGame;

public class Game
{
    private Frame[] frames;
    private int currentFrame = 0;
    private int currentRoll=1;

    public Game()
    {
        frames = new Frame[10];
        for(int id=0; id<10 ; id++)
            frames[id] = new Frame();
    }

    public void Roll(int pins)
    {
        if(_currentFrame<10)
            _frames[_currentFrame].SetRolls(pin);
        SetIndexForNextRoll(pin);

    }

    private void SetIndexForNextRoll(int pin)
    {
        if (_currentFrameRollIndex == 2 || pin == 10)
        frames[currentFrame].SetRolls(pins);
        if (currentRoll == 2)
        {
            currentFrame++;
            currentRoll = 1;
        }
        else
            currentRoll++;
    }

    public int totalScore()
    {
        return frames[0].GetRolls().Sum();
    }
}

public class Frame
{
    private List<int> _rolls;
    private int _score;

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
