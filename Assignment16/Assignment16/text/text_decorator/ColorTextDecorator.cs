namespace Assignment16.text.text_decorator
{
    public class ColorTextDecorator(IText text, Color color) : BaseTextDecorator(text)
    {
        private readonly Color _color = color;

        public override string GetFormattedText()
        {
            return $"(({_color}) {Text?.GetFormattedText() ?? ""})";
        }
    }
}
