public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        // !(p.q.!r) + !(p) = 1
       /*
        if(year % 4 == 0) {
            if(year % 100 == 0) {
                if (year % 400 == 0) {
                    return true;
                } else {
                    return false;
                }
            } else {
                return true;
            }
        } else {
            return false;
        }
        */
        int p = year % 4;
        int q = year % 100;
        int r = year % 400;
        if ((p == 0) && (((q == 0) && (r == 0)) || !(q == 0))){
            return true;
        } else {
            return false;
        }
    }
}