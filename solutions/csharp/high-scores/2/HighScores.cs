using System.Collections.ObjectModel;

public class HighScores
{
    private readonly List<int> list;

    public HighScores(List<int> list)
        => this.list = list;
    

    public IList<int> Scores()
        => new ReadOnlyCollection<int>(list);

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