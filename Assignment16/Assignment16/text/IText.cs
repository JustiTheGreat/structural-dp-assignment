namespace Assignment16.text
{
    public interface IText
    {
        IText? Text { get; set; }

        string GetFormattedText();
    }
}
