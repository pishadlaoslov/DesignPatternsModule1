using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatDM2Homework
{
    public class User
    {
        public required string Name { get; set; }
        public required string Email { get; set; }

        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

    }

}
