public static class Pangram
{
    public static bool IsPangram(string word)
    {
        int count = 0;
        word = word.ToLower();
        bool[] abc = new bool[26];
        foreach(var c  in word){
            if(char.IsLetter(c)){
                if(!abc[(c - 'a')]){
                    abc[(c - 'a')] = true;
                    count++;
                }
            }
        }
        return count == 26;
    }
}
