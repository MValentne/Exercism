using System.Text.RegularExpressions;

static class LogLine
{   
    public static string Message(string logLine)
    {
        //Deletes the level from '[' to ':'
        string replaced = Regex.Replace(logLine, @"\[.*?\:", "");
        //Deletes remaining spaces at the beginning of the string
        replaced = replaced.TrimStart();
        replaced = replaced.TrimEnd();
        return replaced;
    }

    public static string LogLevel(string logLine)
    {
        //Match is a class, match is an object. 
        Match match = Regex.Match(logLine, @"\[(.*?)\]");
        return match.Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine)
    {
        Match match = Regex.Match(logLine, @"\[(.*?)\]");
        string aux = match.Groups[1].Value.ToLower();
        string main = Regex.Replace(logLine, @"\[(.*?)\:", "");
        main = main.TrimStart();
        main = main.TrimEnd();
        return $"{main} ({aux})";
    }
}
