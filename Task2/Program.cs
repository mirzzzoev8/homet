BirdCount birdCount = new BirdCount();
int[] lastWeekCounts = birdCount.LastWeek();
Console.WriteLine(string.Join(", ", lastWeekCounts));


public class BirdCount
{
    int[]  birdCounts = new int[7] { 0, 2, 5, 3, 7, 8, 4 };

    public int[] LastWeek()
    {
        return birdCounts;
    }
}


