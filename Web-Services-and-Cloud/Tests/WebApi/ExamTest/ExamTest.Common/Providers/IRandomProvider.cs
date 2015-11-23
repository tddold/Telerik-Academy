namespace ExamTest.Common.Providers
{
    public interface IRandomProvider
    {
        int GetRandomNumber(int min, int max);
    }
}