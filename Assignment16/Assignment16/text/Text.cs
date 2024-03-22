namespace Assignment16.text
{
    public class Text(string text) : IText
    {
        IText? IText.Text { get; set; }
        private readonly string _text = text;

        public string GetFormattedText()
        {
            return _text;
        }
    }
}
