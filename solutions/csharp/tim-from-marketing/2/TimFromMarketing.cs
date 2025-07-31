static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string result = "";
        result += (id.HasValue ? $"[{id}] - " : "");
        result += $"{name}";
        result += $" - {department?.ToUpper() ?? "OWNER"}";
        return result;
    }
}
