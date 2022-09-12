using  System;
namespace ArmstongNumber

{
    public class Class1
    {
        public static void Main()
        {
            int a = 0;
            double sonuc = 0;
            for (int j = 0; j < 10000; j++)
            {
                
                for (int i = 0; i < j.ToString().Length; i++)
                {
                    int b = Convert.ToInt32(j % Math.Pow(10, i + 1));
                    b = b / Convert.ToInt32(Math.Pow(10, i));
                    sonuc += Math.Pow(b, 3);
                    b = 0;
                }

                if (sonuc == j)
                {
                    Console.WriteLine(j + "" +  "" + " Bu sayı Armstong sayısıdır");
                }

                sonuc = 0;
            }
            
        } 
    }
}