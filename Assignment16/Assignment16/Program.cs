using Assignment16.text;
using Assignment16.text_formatter;

ITextFormatter textFormatter = new TextFormatter();

IText text = new Text("Hello world!");
IText redUnderlinedText = textFormatter.GetRedUnderlinedText(text);
IText violetItalicsUnderlinedText = textFormatter.GetVioletItalicsUnderlinedText(text);

Console.WriteLine(redUnderlinedText.GetFormattedText());
Console.WriteLine(violetItalicsUnderlinedText.GetFormattedText());

Console.WriteLine(textFormatter.RemoveUnderlineFromText(redUnderlinedText)?.GetFormattedText());
Console.WriteLine(textFormatter.RemoveUnderlineFromText(violetItalicsUnderlinedText)?.GetFormattedText());
