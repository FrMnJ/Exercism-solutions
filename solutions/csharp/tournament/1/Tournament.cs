
using System.Text;

public static class Tournament
{   
    public static readonly Dictionary<string, Team> teams = new();

    public static void Tally(Stream inStream, Stream outStream)
    {
        teams.Clear();
        ProcessResults(inStream);
        string table = GenerateTable();
        using (var writer = new StreamWriter(outStream))
        {
            writer.Write(table);
        }
    }

    private static string TableHeader => "Team                           | MP |  W |  D |  L |  P";

    private static string GenerateTable()
    {
        var builder = new StringBuilder();
        builder.Append(TableHeader);

        if(teams.Count == 0)
        {
            return builder.ToString().TrimEnd();
        }
        else builder.Append("\n");

        var sortedTeams = teams.Values
                .OrderByDescending(t => t.Points)
                .ThenBy(t => t.Name);

        foreach (var team in sortedTeams)
        {
            builder.Append(
                $"{team.Name,-31}| {team.MatchesPlayed,2} | {team.Wins,2} | {team.Draws,2} | {team.Losses,2} | {team.Points,2}" + "\n");
        }

        return builder.ToString().TrimEnd();
    }


    private static void ProcessResults(Stream inStream)
    {
        using (var reader = new StreamReader(inStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(";");
                var team1Name = parts[0].Trim();
                var team2Name = parts[1].Trim();
                var result = parts[2].Trim();
                if (!teams.ContainsKey(team1Name))
                {
                    teams[team1Name] = new Team(team1Name);
                }
                if (!teams.ContainsKey(team2Name))
                {
                    teams[team2Name] = new Team(team2Name);
                }
                switch (result)
                {
                    case "win":
                        teams[team1Name].AddWin();
                        teams[team2Name].AddLoss();
                        break;
                    case "loss":
                        teams[team1Name].AddLoss();
                        teams[team2Name].AddWin();
                        break;
                    case "draw":
                        teams[team1Name].AddDraw();
                        teams[team2Name].AddDraw();
                        break;
                }
            }
        }
    }

    public class Team(string name, int wins, int losses, int draws)
    {
        public Team(string name) : this(name, 0, 0, 0) { }
        public string Name => name;
        public int MatchesPlayed => wins + losses + draws;
        public int Wins => wins;
        public int Draws => draws;
        public int Losses => losses;
        public int Points => wins * 3 + draws;
        public void AddWin() => wins++;
        public void AddLoss() => losses++;
        public void AddDraw() => draws++;
    }
}
