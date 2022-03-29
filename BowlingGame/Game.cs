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
        frames[currentFrame].SetRolls(pins);
        if (currentRoll == 2 || pins==10)
        {
            currentFrame++;
            currentRoll = 1;
        }
        else
            currentRoll++;
    }
    
    public int totalScore()
    {
        int totalSum = 0;
        int currentFrameIndex;
        for(int i=0; i < 10; i++)
        {
            currentFrameIndex = i;
            int frameScore = frames[currentFrameIndex].GetRolls().Sum();
            
            if (frameScore == 10)
            {
                bool isStrike = frames[currentFrameIndex].GetRolls().Count == 1;
                if (isStrike)
                {
                    int strikeScore = CalculateStrikeScore(currentFrameIndex);
                    frameScore = frameScore + strikeScore;
                }
            }
            totalSum = totalSum + frameScore;

        }
        return totalSum;
    }
    
    
    public int CalculateStrikeScore(int currentFrameIndex)
    {
        int firstRoll=0;
        int secondRoll=0;
        if (frames[currentFrameIndex + 1].GetRolls().Count == 2)
            return frames[currentFrameIndex + 1].GetRolls().Sum();
        
        firstRoll=frames[currentFrameIndex + 1].GetRolls().First();
        secondRoll = frames[currentFrameIndex + 2].GetRolls().First();
        return firstRoll + secondRoll;
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
