using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Brio
{
    public class CookieProcessing
    {
        /// <summary>
        /// Создает аутентификационные данные в Cookie
        /// </summary>
        /// <param name="userName">Имя пользователя, связанное с билетом. </param>
        /// <param name="isPersistent">true , если билет будет храниться с постоянным файлом Cookie (сохраняемым между сеансами браузера);
        /// в противном случае — false. Если билет хранится в URL-адресе, это значение игнорируется.</param>
        public void CreateCookie(string userName, string cookieName, bool isPersistent = false)
        {
            var ticket = new FormsAuthenticationTicket(
                  1,
                  userName,
                  DateTime.Now,
                  DateTime.Now.Add(FormsAuthentication.Timeout),
                  isPersistent,
                  string.Empty,
                  FormsAuthentication.FormsCookiePath);

            // Encrypt the ticket.
            var encTicket = FormsAuthentication.Encrypt(ticket);

            // Create the cookie.
            var AuthCookie = new HttpCookie(cookieName)
            {
                Value = encTicket,
                Expires = DateTime.Now.Add(FormsAuthentication.Timeout)
            };
            HttpContext.Response.Cookies.Set(AuthCookie);
        }
    }
}
