public static class EliudsEggs
{
    public static int EggCount(int encodedCount)
    {
        int bitCount = 0;
        while (encodedCount > 0)
        {
            if (encodedCount % 2 == 1)
            {
                bitCount += 1;
            }
            encodedCount /= 2;
        }
    return bitCount;
    }
}