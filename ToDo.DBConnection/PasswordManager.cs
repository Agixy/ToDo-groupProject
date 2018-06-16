using System.IO;
using System.Xml.Serialization;

namespace ToDo.DBConnection
{
    class PasswordManager
    {
        public string AddPassword(string input)
        {
            return input.Replace("${password}", GetPassword());
        }

        private string GetPassword()
        {
            try
            {
                return File.ReadAllText("password.user");
            }
            catch
            {
                return "";
            }
        }
    }

    class PasswordStore
    {
        public string DbUserAndPass { get; set; }
    }
}
