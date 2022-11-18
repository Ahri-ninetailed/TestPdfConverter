using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml.html;
using System.Diagnostics;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
/*Byte[] pfd_res = null;
string html = @"<html>
    <body>
        <div style=""padding-left:400px;
            <p style=""align:center;"">
            <br>
            +7 (495) 461-00-11
            <br>
            +7 (800) 555-34-14
            <br>
            avia@bpo.travel
            </p>

        </div>
        <hr />
        <div style=""display: flex;"">
            <div style=""width: 50%; display: inherit;
            align-items: center;"">
                <p>Электронный билет</p>
            </div>
            <div>
                <table>
                    <tr>
                        <td>Дата покупки:</td>
                        <td>123</td>
                    </tr>
                </table>
            </div>
        </div>
        <hr>
        <div>
            <div style=""display: flex;"">
                <div style=""width: 50%; display: inherit;
                align-items: center;"">
                    <p>Стоимость</p>
                </div>
                <div>
                    <table>
                        <tr>
                            <td>Базовая цена:</td>
                            <td>123</td>
                        </tr>
                    </table>
                </div>
            </div>
            <br>
        </div>
        <hr>
        <div style=""display: flex;"">
            <div style=""width: 50%; display: inherit;
            align-items: center;"">
                <p>Контакты</p>
            </div>
            <div>
                <p>Телефон: 123</p>
                <p>Email: 123</p>
                <p>Другой адрес: 123</p>
            </div>
        </div>
        <hr>
        <div>
            <p>Пассажиры</p>
            <br>
            <div>
                <div>
                    <table>
                        <tr>
                            <th>
                                День Рождения
                            </th>
                            <th>
                                Пол
                            </th>
                            <th>
                                Код пассажира
                            </th>
                            <th>
                                Фамилия
                            </th>
                            <th>
                                Имя
                            </th>
                            <th>
                                Отчество
                            </th>
                        </tr>
                        <tr>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                        </tr>
                    </table>
                </div>
                <div>
                    <p>Документ</p>
                    <table>
                        <tr>
                            <th>
                                Дата выпуска
                            </th>
                            <th>
                                Дата окончания
                            </th>
                            <th>
                                Тип документа
                            </th>
                            <th>
                                Номер
                            </th>
                            <th>
                                Код страны
                            </th>
                        </tr>
                        <tr>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                            <td>
                                содержимое
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <hr>
        <div>
            <p>Билет</p>
            <br>
            <div>
                <table>
                    <tr>
                        <th>
                            Номер билета
                        </th>
                        <th>
                            Дата
                        </th>
                        <th>
                            Цена
                        </th>
                    </tr>
                    <tr>
                        <td>
                            содержимое
                        </td>
                        <td>
                            содержимое
                        </td>
                        <td>
                            содержимое
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <hr>
        <div style=""display: flex;"">
            <div style=""width: 50%; display: inherit;
            align-items: center;"">
                <p>Перевозчик</p>
            </div>
            <div>
                <p>GUID: 123</p>
                <p>Имя перевозчика: 123</p>
                <p>Код перевозчика: 123</p>
                <p>Цифровой код перевозчика: 123</p>
            </div>
        </div>
    </body>
</html>";
using (MemoryStream ms = new MemoryStream())
{
    var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
    pdf.AddPage(new PdfSharp.Pdf.PdfPage(pdf));
    pdf.Save(ms);
    pfd_res = ms.ToArray();
}
using var writer = new BinaryWriter(File.OpenWrite("temp.pdf"));
writer.Write(pfd_res);*/



/*StringBuilder sb = new StringBuilder();
sb.Append("<html>");
sb.Append("<body>");
sb.Append("<p style='text-align: end;'>b2b.bpo.travel</p>");

sb.Append("<div>");
sb.Append("<p style='color: green;'>b2b.bpo.travel</p>");
sb.Append("</div>");
sb.Append("</body>");
sb.Append("</html>");
StringReader sr = new StringReader(sb.ToString());
Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
iTextSharp.text.html.simpleparser.HtmlWorker htmlparser = new HtmlWorker(pdfDoc);


byte[] res = null;
using (MemoryStream ms = new MemoryStream())
{
    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, ms);
    pdfDoc.Open();
    htmlparser.Parse(sr);
    pdfDoc.Close();
    res = ms.ToArray();
    ms.Close();
}
using var temptemp = new BinaryWriter(File.OpenWrite("itextsharp.pdf"));
temptemp.Write(res);*/





Byte[] bytes;
using (var ms = new MemoryStream())
{
    using (Document doc = new Document())
    {
        using (var writer = PdfWriter.GetInstance(doc, ms))
        {
            doc.Open();
            var example_html =
                     @"<div class=""contact"">
            <p>
            b2b.bpo.travel
            <br/>
            +7 (495) 461-00-11
            <br/>
            +7 (800) 555-34-14
            <br/>
            avia@bpo.travel</p>
            </div>
            <hr/>
            <br/>
          <table>
              <caption>Электронный билет</caption>
              <thead>
                <tr id=""table-header"">
                  <th scope=""col"">Дата покупки</th>
                  <th scope=""col"">Стоимость</th>
                  <th scope=""col"">Телефон</th>
                  <th scope=""col"">Email</th>
                  <th scope=""col"">Другой адрес</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <th scope=""row"">12.12.12</th>
                  <td>1232213</td>
                  <td>+7999 999 99 99 </td>
                  <td>msmdams@mail.ru</td>
                  <td>32112323@mail.ru</td>
                </tr>
              </tbody>
         </table>
          <br/>
        <table>
          <caption>Пассажиры</caption>
          <thead>
            <tr id=""table-header"">
              <th scope=""col"">День рождения</th>
              <th scope=""col"">Пол</th>
              <th scope=""col"">Код пассажира</th>
              <th scope=""col"">Фамилия</th>
              <th scope=""col"">Имя</th>
              <th scope=""col"">Отчество</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope=""row"">12.04.1992</th>
              <td>мужской</td>
              <td>1212321</td>
              <td>Зуев</td>
              <td>максим</td>
              <td>Сергеевич</td>
            </tr>
          </tbody>
        </table>
        <br/>
        <table>
          <caption>Данные</caption>
          <thead>
            <tr id=""table-header"">
              <th scope=""col"">Дата выпуска</th>
              <th scope=""col"">Дата окончания</th>
              <th scope=""col"">Тип документа</th>
              <th scope=""col"">Номер</th>
              <th scope=""col"">Код страны</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope=""row"">12.04.1992</th>
              <td>12.21.1221</td>
              <td>паспорт</td>
              <td>1111111</td>
              <td>ру</td>
            </tr>
          </tbody>
        </table>
        <br/>
          <table>
          <caption>Билет</caption>
          <thead>
            <tr id=""table-header"">
              <th scope=""col"">Номер билета</th>
              <th scope=""col"">Дата</th>
              <th scope=""col"">Цена</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope=""row"">112121212</th>
              <td>12.21.1221</td>
              <td>11111 руб</td>
            </tr>
          </tbody>
        </table>
        <br/>
        <table>
          <caption>Перевозчик</caption>
          <thead>
            <tr id=""table-header"">
              <th scope=""col"">GUID</th>
              <th scope=""col"">Имя перевозчика</th>
              <th scope=""col"">Код перевозчика</th>
              <th scope=""col"">Цифровой код перевозчика</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope=""row"">112121212</th>
              <td>миксвел</td>
              <td>11111</td>
              <td>22222</td>
            </tr>
          </tbody>
        </table>
        ";
            var example_css = @"
.contact{padding-left:500px;text-align:center;}*{font-family:Arial;}
table {
  table-layout: fixed;
  width: 100%;
}
caption {
margin-bottom: 3px;
}

thead th:nth-child(1) {
  width: 30%;
}

thead th:nth-child(2) {
  width: 20%;
}

thead th:nth-child(3) {
  width: 15%;
}

thead th:nth-child(4) {
  width: 35%;
}

td {
  padding: 10px;
}
th {
  padding: 5px;
}
#table-header {
  background:#7290C2;
  color:white;
}
"
            ;

            using (var msCss = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(example_css)))
            {
                using (var msHtml = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(example_html)))
                {
                    iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, msHtml, msCss);
                }
            }
            doc.Close();
        }
    }
    bytes = ms.ToArray();
    using var temptemp = new BinaryWriter(File.OpenWrite("killmepls.pdf"));
    temptemp.Write(bytes);
}



