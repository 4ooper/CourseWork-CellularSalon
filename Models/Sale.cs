using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.PhoneClasses;


namespace Models
{
    public class Sale
    {
        public PhoneClasses.Phone phone;
        public User client;
        public User employee;
        public DateTime dateTime;
        public string linkToHtml;

        public Sale() { }
        public Sale(PhoneClasses.Phone phone, User client, User employee)
        {
            this.phone = phone;
            this.client = client;
            this.employee = employee;
            this.dateTime = DateTime.Now;
            this.linkToHtml = createHtml();
        }

        public string createHtml()
        {

            string path = $"..\\..\\..\\SaleReports\\{this.phone.name} {this.dateTime.ToShortDateString()}-{this.dateTime.Millisecond}.html";

            string html = "<!DOCTYPE html>" +
                "<html lang='ru'>" +
                "<head>" +
                "<meta charset='UTF - 8'>" +
                "<meta http-equiv='X - UA - Compatible' content='IE = edge'>" +
                "<meta name='viewport' content='width = device - width, initial - scale = 1.0'>" +
                $"<title>{this.phone.name}</title>" +
                "</head>" +
                "<body>" +
                $"<h1>Телефон: {this.phone.name}</h1>" +
                $"<p>Покупатель: {this.client.name}</p>" +
                $"<p>Продавец: {this.employee.name}</p>" +
                $"<p>Дата продажи: {this.dateTime.ToShortDateString()}</p>" +
                $"<p>Цена: {this.phone.totalPrice()}р</p>" +
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
