using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3
{
    internal class Hero
    {
        string username;
        int level;

        public string Username { get => username; set => username = value; }
        public int Level { get => level; set => level = value; }


        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }
        public Hero()
        {

        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name} - Username: {this.Username} - Level: {this.Level}";
        }
    }
}
