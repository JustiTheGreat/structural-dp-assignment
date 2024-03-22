namespace Assignment16.text.text_decorator
{
    public abstract class BaseTextDecorator(IText text) : IText
    {
        public IText? Text { get; set; } = text;

        public abstract string GetFormattedText();
    }
}
