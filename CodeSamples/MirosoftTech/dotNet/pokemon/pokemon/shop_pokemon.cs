using System;


namespace pokemon
{

    public class shop_pokemon
    {
        static int sml;
        public double three(int h, int k)//function to calculate discount when three items are purchased
        {
            double r_r;
            if (k == sml)
            {
                r_r = k * h * 0.8;
            }
            else
            {
                r_r = (k * (h - (h - sml)) * 0.8) + (k * (h - sml));
            }
            return r_r;
        }
        public double two(int h, int k)//function to calculate discount when two items are purchased
        {
            double r_r;
            if (h == sml)
            {
                r_r = k * h * 0.9;
            }
            else if (h == 0)
            {
                r_r = 0;
            }
            else
            {
                r_r = (k * (h - (h - sml)) * 0.9) + (k * (h - sml));
            }
            return r_r;
        }
        public double price(int inpt_pica, int inpt_squi, int inpt_charm)//funtion returns the total price
        {
        int pica = 6;
        int squi = 5;
        int charm = 5;
        double p_r = 0, s_r = 0, c_r = 0,t_r=0, price;
        int[] array = { inpt_pica, inpt_squi, inpt_charm };
            sml = array[0];
            for (int i = 0; i < 2; i++)
            {
                if (array[i] < sml)
                {
                    sml = array[i];
                }
            }
                if (inpt_pica >= sml && inpt_squi >= sml && inpt_charm >= sml)
                {
                    shop_pokemon pk3 = new shop_pokemon();
                    p_r = pk3.three(inpt_pica, pica);
                    s_r = pk3.three(inpt_squi, squi);
                    c_r = pk3.three(inpt_charm, charm);
                }
                else if ((inpt_pica >= sml && inpt_squi >= sml) || (inpt_squi >= sml && inpt_charm >= sml) || (inpt_pica >= sml && inpt_charm >= sml))
                {
                    shop_pokemon pk2 = new shop_pokemon();
                    p_r = pk2.two(inpt_pica, pica);
                    s_r = pk2.two(inpt_squi, squi);
                    c_r = pk2.two(inpt_charm, charm);
                }
                t_r = p_r + s_r + c_r;
            return t_r;
            }
        public static void Main(string[] args)
        {
            Double price;
            try
            {
            Console.WriteLine("enter no of pickacus");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter no of squirtile");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter no of charmander");
            int c = int.Parse(Console.ReadLine());
            if (a == 0 && b == 0 && c == 0)
            {
                    Console.WriteLine("please select any value");
                    Console.Read();
                }
            else
            {
                    shop_pokemon pk = new shop_pokemon();
                    price = pk.price(a, b, c);
                    Console.WriteLine("total price: {0}", price);
                    Console.Read();
                }
        }
            catch (FormatException) {
                Console.WriteLine("enter numerices only");
                Console.Read();
            }

        }
    }
}
