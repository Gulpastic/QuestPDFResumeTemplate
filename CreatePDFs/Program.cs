using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

QuestPDF.Settings.License = LicenseType.Community;

Document.Create(container =>
{
    container.Page(page =>
    {
        page.Header()
        .Padding(5)
        .BorderBottom(1).ExtendHorizontal()
        .Column(col =>
        {
            col.Item().AlignCenter().Text(Placeholders.Name()).FontSize(25).Bold();
            col.Item().Row(row =>
            {
                row.Spacing(60);
                row.AutoItem().AlignLeft().Text(Placeholders.Email());
                row.AutoItem().AlignCenter().Text(Placeholders.PhoneNumber());
                row.AutoItem().AlignRight().Text("DOB: " + Placeholders.LongDate());
            });
        });

        page.Content()
        .BorderBottom(1).ExtendHorizontal()
        .PaddingTop(10)
        .PaddingLeft(40)
        .PaddingRight(40)
        .PaddingBottom(40)
        .Column(col =>
        {
            col.Item().AlignLeft().Text("SUMMARY").Bold().FontSize(15);
            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);
            col.Item().AlignLeft().Text(Placeholders.LoremIpsum());
            col.Item().PaddingVertical(5);
            col.Item().AlignLeft().Text("EXPERIENCE").Bold().FontSize(15);
            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);
            col.Item().AlignLeft().Text(Placeholders.Name()).Bold().FontSize(10);
            col.Item().AlignLeft().Text(Placeholders.LongDate() + " - " + Placeholders.LongDate()).FontSize(10);
            col.Item().AlignLeft().Text(Placeholders.LoremIpsum());
            col.Item().PaddingVertical(5);
            col.Item().AlignLeft().Text(Placeholders.Name()).Bold().FontSize(10);
            col.Item().AlignLeft().Text(Placeholders.LongDate() + " - " + Placeholders.LongDate()).FontSize(10);
            col.Item().AlignLeft().Text(Placeholders.LoremIpsum());
            col.Item().PaddingVertical(5);
            col.Item().AlignLeft().Text("PROJECTS").Bold().FontSize(15);
            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);
            col.Item().AlignLeft().Text(Placeholders.LoremIpsum());
            col.Item().PaddingVertical(5);
            col.Item().AlignLeft().Text("EDUCATION").Bold().FontSize(15);
            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);
            col.Item().Text(Placeholders.Name() + "     " + Placeholders.ShortDate() + " to " + Placeholders.ShortDate());
            col.Item().PaddingVertical(5);
            col.Item().AlignLeft().Text("SKILLS").Bold().FontSize(15);
            col.Item().PaddingVertical(5).LineHorizontal(1).LineColor(Colors.Black);
            col.Item().AlignLeft().Text(Placeholders.Paragraph());
        });
    });

}).ShowInPreviewer();
