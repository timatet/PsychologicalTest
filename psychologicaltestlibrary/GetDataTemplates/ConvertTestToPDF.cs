using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace psychologicaltestlib
{
    public class ConvertTestToPDF : IDataSaveInterface
    {
        #region Fields

        #endregion Fields

        #region Methods
        public void Print(UserClass _User, string _NameTest)
        {
            //Объект документа пдф
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            //Создаем объект записи пдф-документа в файл
            PdfWriter.GetInstance(doc, new FileStream(_NameTest + ".pdf", FileMode.Create));

            //Открываем документ
            doc.Open();

            BaseFont baseFont = BaseFont.CreateFont(@"fonts\Ubuntu-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font font = new Font(baseFont, Font.DEFAULTSIZE, Font.NORMAL);

            doc.NewPage();
            Paragraph prg = new Paragraph("Привdет мир!", font);

            doc.Close();
            //Здесь реализация метода печати в PDF файл
        }

        #endregion Methods

        #region Constructors
        public ConvertTestToPDF()
        {

        }
        #endregion Constructors
    }
}