namespace Assignment16.text.text_decorator
{
    public class RemoveUnderlineDecorator(IText text) : BaseTextDecorator(text)
    {
        public override string GetFormattedText()
        {
            return RemoveUnderlineFromText(Text)?.GetFormattedText() ?? "";
        }

        public IText? RemoveUnderlineFromText(IText? text)
        {
            if (text == null)
                return null;

            if (text.Text is null)
                return text;

            IText? newText = RemoveUnderlineFromText(text.Text);

            if (newText is not null && newText is UnderlineTextDecorator)
                text.Text = newText.Text;

            return text;
        }
    }
}
