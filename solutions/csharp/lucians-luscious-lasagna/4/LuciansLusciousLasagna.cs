class Lasagna
{
    private int expectedTime = 40;
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => expectedTime;
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int time) => expectedTime - time;
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) => layers * 2; 
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int time) => (layers * 2) + time;
}
