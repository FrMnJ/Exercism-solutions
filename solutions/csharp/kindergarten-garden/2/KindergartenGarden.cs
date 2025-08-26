using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

public class KindergartenGarden
{
    private readonly List<string> students = new List<string>(){
        "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", 
        "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"
    };

    private readonly Dictionary<string, int> studentIndices;
    private readonly string firstRow;
    private readonly string secondRow;

    public KindergartenGarden(string diagram)
    {
        var rows = diagram.Split('\n');
        if (rows.Length != 2)
            throw new ArgumentException("Diagram must contain exactly two rows");

        firstRow = rows[0];
        secondRow = rows[1];

        studentIndices = students
            .Select((name, i) => new { name, i })
            .ToDictionary(x => x.name, x => x.i);
    }

    public IEnumerable<Plant> Plants(string student)
    {
        if (!studentIndices.TryGetValue(student, out int indexStudent))
            throw new ArgumentException($"Invalid student name: {student}");

        indexStudent *= 2;

        foreach (var row in new[] { firstRow, secondRow })
        {
            yield return MapLetterToPlant(row[indexStudent]);
            yield return MapLetterToPlant(row[indexStudent + 1]);
        }
    }

    private Plant MapLetterToPlant(char c) => c switch
    {
        'V' => Plant.Violets,
        'R' => Plant.Radishes,
        'C' => Plant.Clover,
        'G' => Plant.Grass,
        _   => throw new ArgumentException($"Invalid plant character: {c}")
    };
}
