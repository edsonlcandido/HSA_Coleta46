using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class EmailRepository
    {
        private static readonly string CONNECTION_STRING = @"Data Source=HSA_Coleta.db;";
        public static IEnumerable<EmailModel> listar()
        {
            List<EmailModel> emails = new List<EmailModel>();
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $@"SELECT email
                                        FROM emails;
                                    ";
            connection.Open();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    EmailModel emailModel = new EmailModel();
                    emailModel.email = reader.GetString(0);
                    emails.Add(emailModel);
                }
            }
            connection.Close();
            return emails;
        }
    }
}
