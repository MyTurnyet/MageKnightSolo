namespace Solo.Interfaces
{
    public interface IDeck
    {
        int CardCount();
        IDeck Shuffle();
        string[] Draw();
    }
}