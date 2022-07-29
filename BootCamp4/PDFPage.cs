using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace BootCamp4
{
    class PDFPage
    {
        protected Document document { get; set; }
        private PdfWriter writer { get; set; }
        public PdfContentByte ContentByte { get; set; }
        private int x { get; set; }
        private int y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public PDFPage(string fileName)
        {
            document = new Document();
            writer = PdfWriter.GetInstance(document, new FileStream(fileName + ".pdf", FileMode.Create));
            DocumentControl();
            ContentByte = writer.DirectContent;
            Width = document.PageSize.Width;
            Height = document.PageSize.Height;
        }
        public PDFPage(string fileName, Document document)
        {
            this.document = document;
            writer = PdfWriter.GetInstance(document, new FileStream(fileName + ".pdf", FileMode.Create));
            ContentByte = writer.DirectContent;
            Width = document.PageSize.Width;
            Height = document.PageSize.Height;
        }
        private void DocumentControl()
        {
            if (!document.IsOpen())
                document.Open();
        }
        public void SetInfos(string authorName, string creator)
        {
            DocumentControl();
            document.AddAuthor(authorName);
            document.AddCreator(creator);
            document.AddCreationDate();
        }
        public void AddImage(Image image, float a, float b, float c, float x, float y, float z)
        {
            DocumentControl();
            ContentByte.AddImage(image, a, b, c, x, y, z);
        }
        public void WriteLines(BaseColor color)
        {
            DocumentControl();

            //PictureBox
            ContentByte.SetColorStroke(color);
            ContentByte.MoveTo(10, Height - 10);
            ContentByte.LineTo(215, Height - 10);
            ContentByte.LineTo(215, Height - 215);
            ContentByte.LineTo(10, Height - 215);
            ContentByte.LineTo(10, Height - 10);

            //MidLine
            ContentByte.MoveTo(225, Height);
            ContentByte.LineTo(225, 0);

            //UserInfos
            ContentByte.MoveTo(0, Height - 225);
            ContentByte.LineTo(225, Height - 225);

            //EducationInfos
            ContentByte.MoveTo(275, Height - 60);
            ContentByte.LineTo(Width - 50 , Height - 60);

            //JobExperience
            ContentByte.MoveTo(275, Height - 471);
            ContentByte.LineTo(Width - 50, Height - 471);

            //Finishing
            ContentByte.Stroke();
        }
        public void AddPhrase(string text, Font font, float x, float y)
        {
            DocumentControl();
            Font textFont = new Font(font);
            Phrase phrase = new Phrase(text, textFont);
            ColumnText.ShowTextAligned(ContentByte, Element.ALIGN_LEFT, phrase, x, y, 0);
        }
        public void AddParagraph(string text, Font font,float a, float b, float x, float y)
        {
            DocumentControl();
            Font textFont = new Font(font);
            Paragraph paragraph = new Paragraph(text, textFont);
            ColumnText ct = new ColumnText(writer.DirectContent);
            Rectangle kare = new Rectangle(a, b, x, y);
            ct.SetSimpleColumn(kare);
            ct.AddElement(paragraph);
            ct.Go();
        }
        public void Close()
        {
            document.Close();
        }
    }
}
