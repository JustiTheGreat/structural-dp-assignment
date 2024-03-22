namespace Assignment16.text.text_decorator
{
    public class ItalicsTextDecorator(IText text) : BaseTextDecorator(text)
    {
        public override string GetFormattedText()
        {
            return $"((italics) {Text?.GetFormattedText() ?? ""})";
        }
    }
}
