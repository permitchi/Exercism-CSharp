class Lasagna
{
    public int ExpectedMinutesInOven ()
    {
        return 40;
    }
  
    public int RemainingMinutesInOven (int actualTimePassed)
    {
        return ExpectedMinutesInOven() - actualTimePassed;
    }
    public int PreparationTimeInMinutes (int lasagnaLayers)
    {
        return lasagnaLayers * 2;
    } 
    
    public int ElapsedTimeInMinutes (int lasagnaLayers, int actualTimePassed)
    {
        return PreparationTimeInMinutes(lasagnaLayers) + actualTimePassed;
    }
}