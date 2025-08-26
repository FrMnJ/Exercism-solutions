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
        "Alice", "Bob", "Charlie", "David", "Eve", "Fred", "Ginny", "Harriet", "Ileana", "Joseph", "Kincaid", "Larry"};

    private string _diagram;
    
    public KindergartenGarden(string diagram)
    {
        _diagram = diagram;
    }

    public IEnumerable<Plant> Plants(string student)
    {
        int indexStudent = students.IndexOf(student);
        if(indexStudent == -1) throw new ArgumentException("Invalid student name");
        string[] rows = _diagram.Split('\n');
        string firstRow = rows[0];
        string secondRow = rows[1];
        indexStudent *= 2;
        for(int i = 0; i < 2; i++){
            yield return MapLetterToPlant(firstRow[indexStudent + i]);
        }
        for(int i = 0; i < 2; i++){
            yield return MapLetterToPlant(secondRow[indexStudent + i]);
        }
    }

    

    private Plant MapLetterToPlant(char c)
        => c switch{
            'V'=>Plant.Violets,
            'R'=>Plant.Radishes,
            'C'=>Plant.Clover,
            'G'=>Plant.Grass,
            _ => throw new ArgumentException()
        };
}