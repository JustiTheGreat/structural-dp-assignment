using Assignment16.text;

namespace Assignment16.text_formatter
{
    public interface ITextFormatter
    {
        IText GetRedUnderlinedText(IText text);

        IText GetVioletItalicsUnderlinedText(IText text);

        IText? RemoveUnderlineFromText(IText text);
    }
}
