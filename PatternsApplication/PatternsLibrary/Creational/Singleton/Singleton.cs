using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Library.Creational.Singleton
{
    public class Singleton
    {
        private readonly string _dateCreated;

        private Singleton()
        {
            _dateCreated = DateTime.Now.ToString();
        }

        private static Singleton Instance { get; set; }
        public static Singleton GetInstance()
        {
            Instance = Instance ?? new Singleton();
            return Instance;
        }
        public override string ToString()
        {
            return $"Object singleton was created in {_dateCreated}";
        }
    }
}
