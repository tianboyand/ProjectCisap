using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Siapotik
{
    class classKoneksi
    {
        SqlConnection conn;
        public void koneksi()
        {
            conn = new SqlConnection("Server=localhost; Data Source=TRIE; Database=siapotik; Integrated Security=SSPI");
            conn.Open();
        }
    }
}
