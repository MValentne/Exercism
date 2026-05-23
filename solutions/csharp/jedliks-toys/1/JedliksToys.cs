class RemoteControlCar
{
    public int battery = 100;
    public int meters; // 0

    //Construye el nuevo objeto
    public static RemoteControlCar Buy()
        => new RemoteControlCar();

    public string DistanceDisplay()
        => $"Driven {meters} meters"; 

    public string BatteryDisplay()
    {
        if (battery == 0){
            return "Battery empty";
        } else {
            return $"Battery at {battery}%";
        }
    }

    public void Drive()
    {
        if(battery == 0){
            return;
        } else {
            battery = battery - 1;
            meters = meters + 20;
        }
    }
}
