static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0){
            return 3.213f;
        } else if ((balance < 1000) && (balance >= 0)){
            return 0.5f;
        } else if ((balance >= 1000) && (balance < 5000)){
            return 1.621f;
        } else {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal) (balance * (decimal)(InterestRate(balance)/100));
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return (decimal)(balance + Interest(balance));
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int count = 0;
        if (balance == targetBalance){
            return 0;
        } else if(targetBalance > balance){
            while(balance < targetBalance){
                balance = AnnualBalanceUpdate(balance);
                count ++;
            }
        }
        return count;
    }
}
