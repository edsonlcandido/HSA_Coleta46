using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class UsuarioContext
    {
        private readonly DbContext _context;
        public UsuarioContext()
        {
            SQLiteConnection sQLiteConnection = new SQLiteConnection("Data Source=HSA_Coleta.db;");
            _context= new DbContext(sQLiteConnection,false);
        }
    }
}
