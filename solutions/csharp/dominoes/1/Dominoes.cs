public static class Dominoes
{
    public static bool CanChain(IEnumerable<(int, int)> dominoes)
    {
        if(!dominoes.Any()) return true;
        // Get all unique vertices (numbers appearing in dominoes)
        var unique = dominoes
            .SelectMany(d => new[] { d.Item1, d.Item2 })
            .Distinct();

        UnionFind union = new(unique);

        Dictionary<int, int> degree = new();

        foreach (var domino in dominoes)
        {
            var fromNode = domino.Item1;
            var toNode = domino.Item2;

            // Union the two ends
            union.Union(fromNode, toNode);

            // Count degrees
            if (!degree.ContainsKey(fromNode))
                degree[fromNode] = 0;
            degree[fromNode]++;

            if (!degree.ContainsKey(toNode))
                degree[toNode] = 0;
            degree[toNode]++;
        }

        // Connectivity: all vertices with non-zero degree must share the same parent
        int commonParent = union.Find(degree.First().Key);
        foreach (var kvp in degree)
        {
            if (kvp.Value % 2 != 0) // degree must be even
                return false;

            if (union.Find(kvp.Key) != commonParent) // must be connected
                return false;
        }

        return true;
    }
}

public class UnionFind
{
    private Dictionary<int, int> parents = new();

    public UnionFind(IEnumerable<int> elements)
    {
        foreach (var element in elements)
        {
            parents[element] = element;
        }
    }

    public void Union(int a, int b)
    {
        parents[Find(b)] = Find(a);
    }

    public int Find(int x)
    {
        if (parents[x] != x)
        {
            parents[x] = Find(parents[x]); // path compression
        }
        return parents[x];
    }
}
