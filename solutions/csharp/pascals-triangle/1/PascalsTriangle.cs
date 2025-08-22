public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        if (rows < 0) 
            throw new ArgumentException("rows must be non-negative.");
        if (rows == 0) 
            return Enumerable.Empty<IEnumerable<int>>();

        var res = new List<List<int>>();
        var previous = new List<int> { 1 };
        res.Add(new List<int>(previous));

        for (int r = 1; r < rows; r++)
        {
            previous.Insert(0, 0);
            previous.Add(0);

            var next = new List<int>();
            for (int i = 0; i < previous.Count - 1; i++)
            {
                next.Add(previous[i] + previous[i + 1]);
            }

            res.Add(new List<int>(next));
            previous = next;
        }

        return res;
    }
}
