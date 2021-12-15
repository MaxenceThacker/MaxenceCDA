using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCantine.Data
{
    public class DatabaseConnection
    {
        public string Server { get; }
        public string Port { get; }
        public string Database { get; }
        public string User { get; }
        public string Password { get; }
        public string SSL { get; }

        public DatabaseConnection(string server, string port, string database, string user, string password, string ssl)
        {
            this.Server = server;
            this.Port = port;
            this.Database = database;
            this.User = user;
            this.Password = password;
            this.SSL = ssl;
        }
    }