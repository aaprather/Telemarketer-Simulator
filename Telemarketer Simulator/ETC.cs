using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemarketer_Simulator
{
    class ETC
    {
        public void s()  //clears the screen
        {
            int r = 0;
            while (r++ < 12)
            {

                Console.Write("\n\n");
            }
        }

        
        public void sp()  //single space
        {
            Console.WriteLine();
        }

        public void ss()  //require user input before screen clear
        {
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadKey();
            s();

        }
    }
}
