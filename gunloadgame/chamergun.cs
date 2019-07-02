using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gunloadgame
{
    class chamergun
    {
        public int spinner;
        public int win = 0;
        public int SW;
        public int shotleft = 6;
        public int gunload = 0;
        
        public int Winner()
        {

            if (spinner == 1  && shotleft > 0 && SW == 2)
            {

                win = 1;//this return the value of win to 1


            }
            if (spinner == 1  && shotleft > 0 && SW == 1)
            {

               win = 2;//this return the value of win to 2

            }

            else if (shotleft > 0 && spinner != 1)
            {
                win = 0;//this return the value of win to 0
                shotleft =shotleft - 1;
                SW = SW - 1;

                if (spinner  == 6)//change the value of spins
                {
                    spinner  = 1;
                }
                else
                {
                    spinner++;
                }



            }
            return win;//this return the value of win 
        }
    }
}
