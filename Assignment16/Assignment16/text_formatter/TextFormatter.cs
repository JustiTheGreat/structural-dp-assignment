using Assignment16.text;
using Assignment16.text.text_decorator;

namespace Assignment16.text_formatter
{
    public class TextFormatter : ITextFormatter
    {
        public IText GetRedUnderlinedText(IText text)
        {
            return new ColorTextDecorator(new UnderlineTextDecorator(text), Color.RED);
        }

        public IText GetVioletItalicsUnderlinedText(IText text)
        {
            return new ColorTextDecorator(new ItalicsTextDecorator(new UnderlineTextDecorator(text)), Color.VIOLET);
        }

        public IText RemoveUnderlineFromText(IText text)
        {
            return new RemoveUnderlineDecorator(text);
        }
    }
}
