using System;
using System.Linq;
using System.Text;


namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Test();

            //Registiration registiration = new Registiration();
            //registiration.SetUsername();
            //registiration.GetUsername();
            

        }
        #region Draft
        //public static int Test()
        //{

        //string Username = "";
        //string Password = "";

        //Console.Write("Adini Daxil Et:  ");
        //Username = Console.ReadLine();

        //Console.Write("Sifreni Daxil Et: (Minimum 8 eded)");
        //Password = Console.ReadLine();

        //if (Password.Length < 8)
        //{
        //    Console.WriteLine("Duzgun Parolu Daxil Et");
        //    return -1;
        //}
        //else if (Username.Length != 3)
        //{
        //    Console.WriteLine("Duzgun Adi Daxil Et");
        //}

        //Console.WriteLine("Username: " + Username);
        //Console.WriteLine("Password: " + Password);
        //return 1;

        //}
        #endregion
        #region Draft2                 
        static void Length()
        {

            char[] Karaktarler;

            One();
            Two();
            Three();
            Four();
            Five();

            void One()
            {
                Console.WriteLine("Sifre Daxil Edin");
                string Password = Console.ReadLine();
                Karaktarler = Password.ToArray();

            }
            void Two()
            {
                foreach (char karakter in Karaktarler)
                {
                    if (char.IsNumber(karakter))
                    {
                        Three();
                        return;
                    }
                }
                Console.WriteLine("Minimum 1 Eded Olmalidir: ");
            }
            void Three()
            {
                if (Karaktarler.Length >= 6)
                {
                    Four();
                }
                else
                {
                    Console.WriteLine("En az 8 Eded Olmalidir");
                }
            }
            void Four()
            {

                foreach (char karakter in Karaktarler)
                {
                    if (char.IsUpper(karakter))
                    {
                        Five();
                        return;
                    }
                }
                Console.WriteLine("En Az Bir Boyuk Herf Olmalidir ");
            }
            void Five()
            {
                Console.WriteLine("Parol Uygundur");
            }
        }
    }

        #endregion

    
}

    
