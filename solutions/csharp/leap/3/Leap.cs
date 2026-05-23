public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        /*
            pqr + p!q!r + p!qr = 1
            = p(qr + !q!r + !qr)
            = p(qr + !q(!r + r))
            = p(qr + !q(1))
            = p(qr + !q) = 1
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