using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention
{
    public static class Extension
    {
        public static bool IsEmail(this string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int Sum(this int n1,int n2)
        {
            return n1 + n2;
        }
    }
}
