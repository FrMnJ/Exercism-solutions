public static class Proverb
{
    // Time - O(N)
    // Space - O(N)
    // Where N is equal to the number of subjects
    public static string[] Recite(string[] subjects)
    {
        string[] verses = new string[subjects.Length];
        for(int i = 0; i < subjects.Length - 1; i++){
            verses[i] = $"For want of a {subjects[i]} the {subjects[i+1]} was lost.";
        }
        if(subjects.Length >= 1)
            verses[subjects.Length-1] = $"And all for the want of a {subjects[0]}.";
        return verses;
    }
}