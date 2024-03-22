namespace Assignment16.text.text_decorator
{
    public class BoldTextDecorator(IText text) : BaseTextDecorator(text)
    {
        public override string GetFormattedText()
        {
            return $"((bold) {Text?.GetFormattedText() ?? ""})";
        }
    }
}
