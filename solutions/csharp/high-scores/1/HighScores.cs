public class HighScores
{
    private readonly List<int> list;

    public HighScores(List<int> list)
        => this.list = list;
    

    public List<int> Scores()
        => list;

    public int Latest()
        => list[^1];

    public int PersonalBest()
        => list.Max();

    public List<int> PersonalTopThree()
        => list.OrderBy(x => x)
        .TakeLast(3)
        .OrderByDescending(x => x)
        .ToList();
}