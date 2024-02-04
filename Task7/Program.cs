var birdCount = new BirdCount();
birdCount.BusyDays();
public class BirdCount
{
    int[]  birdCounts = new int[7] { 0, 2, 5, 3, 7, 8, 4 };

    public int BusyDays()
    {
        return birdCounts.Count(e => e >= 5);
    }
}