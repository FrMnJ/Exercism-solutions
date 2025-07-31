public class GradeSchool
{
    private HashSet<string> students = new();
    private Dictionary<int, List<string>> grades = new();
    public bool Add(string student, int grade)
    {
        if (students.Add(student))
        {
            if (!grades.ContainsKey(grade))
            {
                grades[grade] = new List<string>();
                grades[grade].Add(student);
            }
            else
            {
                grades[grade].Add(student);
            }
            return true;
        }
        return false;
    }

    public IEnumerable<string> Roster()
    {
        return grades.OrderBy(g => g.Key)
                      .SelectMany(g => g.Value.OrderBy(s => s));
    }

    public IEnumerable<string> Grade(int grade)
    {
        if(grades.ContainsKey(grade))
        {
            return grades[grade].OrderBy(s => s);
        }
        return Enumerable.Empty<string>();
    }
}