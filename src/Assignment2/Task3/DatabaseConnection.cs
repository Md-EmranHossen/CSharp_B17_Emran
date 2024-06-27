using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3 
{
  public class DatabaseConnection {

    private readonly string _connectionString;
    public DatabaseConnection(string connectionString) 
    {
      _connectionString = connectionString;
    }
  }
}