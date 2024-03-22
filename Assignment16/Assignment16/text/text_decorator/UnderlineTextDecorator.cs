namespace Assignment16.text.text_decorator
{
    public class UnderlineTextDecorator(IText text) : BaseTextDecorator(text)
    {
        public override string GetFormattedText()
        {
            return $"((underline) {Text?.GetFormattedText() ?? ""})";
        }
    }
}
