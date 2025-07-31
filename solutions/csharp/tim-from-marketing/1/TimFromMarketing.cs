static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string result = "";
        if(id != null)
        {
            result += $"[{id}] - ";
        }
        result += $"{name}";
        department = department == null ? "OWNER": department.ToUpper();
        result += $" - {department}";
        return result;
    }
}
