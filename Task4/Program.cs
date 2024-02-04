var birdCount = new BirdCount();
birdCount.IncrementTodaysCount();
birdCount.Today();
public class BirdCount
{
    int[]  birdCounts = new int[7] { 0, 2, 5, 3, 7, 8, 4 };

    public int Today()
    {
        return birdCounts[6];
    }
    public void IncrementTodaysCount()
    {
        birdCounts[6]++;
    }
}
