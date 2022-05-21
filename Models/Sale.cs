using System;
using System.IO;
using System.Text;


namespace Models
{
    /// <summary>
    /// Класс описания продажи
    /// </summary>
    public class Sale
    {
        public string phoneName;
        public string clientEmail;
        public string employeeEmail;
        public DateTime dateTime;
        public string linkToHtml;
        public int price;

        public Sale() { }
        public Sale(string phoneName, string clientEmail, string employeeEmail, int price)
        {
            this.phoneName = phoneName;
            this.clientEmail = clientEmail;
            this.employeeEmail = employeeEmail;
            this.dateTime = DateTime.Now;
            this.price = price;
            this.linkToHtml = createHtml();
        }

        private string createHtml()
        {

            string path = $"..\\..\\..\\SaleReports\\{this.phoneName} {this.dateTime.ToShortDateString()}-{this.dateTime.Millisecond}.html";

            string html = "<!DOCTYPE html>" +
                "<html lang='ru'>" +
                "<head>" +
                "<meta charset='UTF - 8'>" +
                "<meta http-equiv='X - UA - Compatible' content='IE = edge'>" +
                "<meta name='viewport' content='width = device - width, initial - scale = 1.0'>" +
                $"<title>{this.phoneName}</title>" +
                "</head>" +
                "<body>" +
                $"<h1>Телефон: {this.phoneName}</h1>" +
                $"<p>Покупатель: {this.clientEmail}</p>" +
                $"<p>Продавец: {this.employeeEmail}</p>" +
                $"<p>Дата продажи: {this.dateTime.ToShortDateString()}</p>" +
                $"<p>Цена: {this.price}р</p>" +
                "</body>" +
                "</html>";

            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(html);
                fstream.Write(buffer, 0, buffer.Length);
            }

            return path;
        }
    }
}
