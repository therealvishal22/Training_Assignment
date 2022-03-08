using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopspract
{
    public class clsobj
    {
        public int a;
    }
    class objclspract
    {
        static void Main(string[] args)
        {
            clsobj p = new clsobj();
            p.a =20;
            Console.WriteLine("Value of a is "+p.a);
        }
    }
}
