public static class LineUp
{
    public static string Format(string name, int number)
    {
        string converted = number.ToString();
        string ending;
        if ((converted.EndsWith("1") && !(converted.EndsWith("11")))){
            ending = "st";
        } else if ((converted.EndsWith("2") && !(converted.EndsWith("12")))){
            ending = "nd";
        } else if ((converted.EndsWith("3") && !(converted.EndsWith("13")))){
            ending = "rd";
        } else {
            ending = "th";
        }
        return $"{name}, you are the {number}{ending} customer we serve today. Thank you!";
    }
}
