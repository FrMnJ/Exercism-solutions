using System;
using System.Globalization;
public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB) => $"{studentA,61 / 2 - 1} \u2661 {studentB,-(61 / 2 - 1)}";
    public static string DisplayBanner(string studentA, string studentB)
    {
        return @$"     ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA} +  {studentB}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";
    }
    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours) => String.Format(new CultureInfo("de-DE"), "{0} and {1} have been dating since {2:d} - that's {3:#,###.##} hours", studentA, studentB, start, hours); // $"{studentA} and {studentB} have been dating since {start:d} - that's {hours} hours";
}