namespace BowlingGame;

public class Game
{
    private readonly Frame[] _frames;
    private int _currentFrame = 0;
    private int _currentFrameRollIndex=1;

    public Game()
    {
        _frames = new Frame[10];
        for(int id=0; id<10 ; id++)
            _frames[id] = new Frame();
    }

    public void Roll(int pin)
    {
        if(_currentFrame<10)
            _frames[_currentFrame].SetRolls(pin);
        if (_currentFrameRollIndex == 2 || pin == 10)
        {
            _currentFrame++;
            _currentFrameRollIndex = 1;
        }
        else
            _currentFrameRollIndex++;
    }
    
    public int TotalScore()
    {
        var totalSum = 0;
        for(int currentFrameIndex=0; currentFrameIndex < 10; currentFrameIndex++)
        {
            int frameScore = _frames[currentFrameIndex].GetRolls().Sum();
            
            if (frameScore == 10)
            {
                bool isStrike = _frames[currentFrameIndex].GetRolls().Count == 1;
                frameScore += isStrike ?  CalculateStrikeScore(currentFrameIndex) : CalculateSpareScore(currentFrameIndex);
            }
            
            totalSum +=  frameScore;

        }
        return totalSum;
    }

    private int CalculateSpareScore(int currentFrameIndex)
    {
        return _frames[currentFrameIndex + 1].GetRolls().First();
    }


    public int CalculateStrikeScore(int currentFrameIndex)
    {
        int firstRoll=0;
        int secondRoll=0;
        if (_frames[currentFrameIndex + 1].GetRolls().Count == 2)
            return _frames[currentFrameIndex + 1].GetRolls().Sum();
        
        firstRoll=_frames[currentFrameIndex + 1].GetRolls().First();
        secondRoll = _frames[currentFrameIndex + 2].GetRolls().First();
        return firstRoll + secondRoll;
    }
}