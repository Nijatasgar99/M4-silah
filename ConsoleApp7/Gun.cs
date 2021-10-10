using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Gun
    {
        public string M4;
        public string  mod;/* avtomaticski, tek-tek*/
        public  int sursatcount; /*daraqdaki gulle sayi*/
        public  int Fullsursat; /*personal gulle saylari*/
        public  int limitsursat; /*daragin limiti*/

        public Gun()
        {

        }
        public Gun(string silahnovu)
        {
            if (silahnovu == "M4")
            {                  
                sursatcount = 30;
                limitsursat = 30;
                Fullsursat = 300;
            }            
        }
        public void Yuklenme()
        {
            if (sursatcount < limitsursat) 
            {
                sursatcount += 1;
                Fullsursat -= 1;
            }
            else
            {
                Console.WriteLine("dolu");
            }
        }
        public void Reload()
        {
            if (sursatcount == 0)
            {
                sursatcount = limitsursat;
                Fullsursat = limitsursat;
                Console.WriteLine("yenilendi");
            }
            else
            {
                Console.WriteLine("xais edirik yenileyin daragi ");
            }
           
        }
        public void ates()
        {
            if (mod=="avtomaticski")
            {
                for (int i = sursatcount; i < limitsursat; i--)
                {
                    sursatcount--;
                    Console.WriteLine(sursatcount);
                }
                
            }

        }
        public void tek()
        {
            if (mod == "tek-tek")
            {
                if (sursatcount > 0)
                {
                    sursatcount -= 1;
                }
                else
                {
                    Console.WriteLine("darag deyis");
                }
            }
        }

    }
  
}
