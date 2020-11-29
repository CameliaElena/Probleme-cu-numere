using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme_cu_numere
{
    class Program
    {
       
        
        static void Main(string[] args)
        {

            //ecuatieGrad1();
            //ecuatieGrad2();
            // DividemNumar();
            //AnBisect();
            //reverseDigits();
            //checkValidity();
            //InversareAB();
            //InversareAB2();
            //Divizori();
            // Primalitate();
            //DivizoriN();
            //AnBisectY1Y2();
            //Palindrom();
            //Crescator();
            //divizorMultiplu();
            //FactoriPrimi();
            //Fractie();
            //ultimaCifra();
        }

        private static void ultimaCifra()
        {
            int x, y;
            int uc;
            string line;
            line = Console.ReadLine();
            char[] sept = { ' ', ',', '.', '?' };
            string[] numere = line.Split(sept,StringSplitOptions.RemoveEmptyEntries);
            x = int.Parse(numere[0]);
            y = int.Parse(numere[1]);
            uc = (x + y) % 10;
            
            Console.WriteLine($"{uc}");
            Console.ReadKey();


        }

        private static void Fractie()
        {
            int m = 13;
            int n = 30;
            double d;
            d = (double)m / n;
            Console.WriteLine(d);
            double fract = d - Math.Truncate(d);
            while(fract!=0)
            {
                Console.WriteLine($"{Math.Truncate(fract*10)}");
                fract = fract * 10 - Math.Truncate(fract * 10);
                Console.WriteLine();
            }

         








        }

        //Afisati descompunerea in factori primi ai unui numar n.
        private static void FactoriPrimi()
        {
            Console.WriteLine("Introduceti numarul natural");
            int n = int.Parse(Console.ReadLine());
            int m, p;
            m = n;
            //pentru fiecare numar verificam daca este divizor
            for (int divizor = 2; divizor <= n / 2; divizor++)
            {
                //este divizor, calculam multiplicitatea
                if (m % divizor == 0)
                {
                    p = 0;
                    while (m % divizor == 0)
                    {
                        p++;
                        m /= divizor;
                    }
                    Console.Write("{0}^{1}*", divizor, p);
                }
                if (m == 1)
                    break;
            }
            Console.WriteLine("1");
            Console.ReadLine();
        }
    

        

        //Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
        private static void divizorMultiplu()
        {
            int a, b, r, aux;
            Console.WriteLine("Introduceti m= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n= ");
            b = int.Parse(Console.ReadLine());
            aux = int.Parse(Console.ReadLine());
            if (a < b)
                aux = a;
            a = b;
            b = aux;
            r = a % b;
            while (r != 0)
                a = b;
            b = r;
            r = a % b;
           
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            
                Console.WriteLine();
            }
            



        }

        //Se dau 3 numere.Sa se afiseze in ordine crescatoare.
        private static void Crescator()
        {
            int a, b, c,aux;
            Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti c= ");
            c = int.Parse(Console.ReadLine());
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();


        }

        //Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.
        private static void Palindrom()
        {
            int n, m, o = 0, p;
            Console.Write("Introduceti numarul n = ");
            n = int.Parse(Console.ReadLine());
            m = n;
            while (n != 0)
            {
                p = n % 10;
                o = o * 10 + p;
                n = n / 10;
            }
            //verificam daca numarul stocat este egal cu oglinditul
            if (o == m)
                Console.Write("numarul este palindrom");
            else
                Console.Write("numarul nu este palindrom");
            Console.ReadKey();
        }

        //Determianti cati ani bisecti sunt intre anii y1 si y2.
        private static void AnBisectY1Y2()
        {
            int y1, y2;
            Console.WriteLine("Introduceti primul an= ");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea an= ");
            y2 = int.Parse(Console.ReadLine());
            int acc = 0;
            while(true)
            {
                if ((y1 % 4 == 0 && y1 % 100 != 0) || y1 % 400 == 0)
                    acc++;
                if (y1 + 1 == y2) break;
                y1++;
                Console.WriteLine("Sunt"+acc);
            }

        }

        //Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
        private static void DivizoriN()
        {
            int a, b, n;
            Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            if (a % n == 0)
                Console.WriteLine((b / n) - (a / n) + 1);
            else
                Console.WriteLine((b / n) - (a / n));
            Console.ReadKey();
                        
        }

        //Test de primalitate: determinati daca un numar n este prim.
        private static void Primalitate()

        {
            int n;
            
            bool prime = true;
            int i = 2;
            Console.WriteLine("Introduceti n= ");
            n = int.Parse(Console.ReadLine());
            while (i <= n / 2)
            {
                if (n % i == 0)
                    prime = false;
                i += 1;
            }

            if (prime)
                Console.WriteLine("Numarul {0} este prim", n);
            else
                Console.WriteLine("Numarul {0} nu este prim", n);

            Console.Read();
        }
       

        //Afisati toti divizorii numarului n. 
        private static void Divizori()
        {
            int n,i;
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.WriteLine(i);
            Console.ReadKey();
        }

        //(Swap restrictionat) Se dau doua variabile numerice a si b 
         // ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   
        private static void InversareAB2()
        {
            int x = 10;
            int y = 5;
            x = x * y;
            y = x / y;
            x = x / y;
            Console.WriteLine("Dupa inversare= " + " x = " + x + ", y = " + y);

        }

        //(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
        private static void InversareAB()
        {
            int a, b, aux;
            Console.Write("Introduceti primul numar a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}", a, b);
            aux = a; a = b; b = aux;
            Console.Write("Dupa interschimbare a={0}, b={1}", a, b);
            Console.ReadKey();
        }

        //Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
        private static void checkValidity()
        {

            int a, b, c;
            
            Console.WriteLine("Introduceti a= ");
            a = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Introduceti b= ");
            b = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introduceti c= ");
            c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b &&
                                b + c > a )
               
                    Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
             Console.ReadKey();
        }

        //Afisati in ordine inversa cifrele unui numar n. 
        private static void reverseDigits()


        {
            int n,reverse = 0, rem;
            Console.Write("Introduceti un numar= ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            Console.WriteLine("Numarul inversat este: " + reverse);

        }




        //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
        private static void ecuatieGrad2()
        {

            float a, b, c, dt;
            double x1, x2;
            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    if (c == 0) Console.WriteLine("Ec. nedeterminat.");
                    else Console.WriteLine("Ec. imposibila");
                else
                {
                    x1 = -c / b;
                    Console.WriteLine("Ec. de gr. 1 cu x1 = {0}", x1);
                }
            else
            {
                dt = b * b - 4 * a * c;
                if (dt < 0)
                    Console.WriteLine("Ec. are solutii complxe");
                else
                {
                    if (dt == 0)
                    {
                        x1 = x2 = -b / (2 * a);
                        Console.WriteLine("x1 = x2 = {0}", x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(dt)) / (2 * a);
                        x2 = (-b - Math.Sqrt(dt)) / (2 * a);
                        Console.WriteLine("Solutiile sunt x1 = {0}, x2 = {1}", x1, x2);
                    }
                }
            }


        }


        //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.

        private static void ecuatieGrad1()
        {

            float a, b, x;
            Console.Write("Introduceti a = ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti b = ");
            b = float.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Ecuatie nedet. ");
                else
                    Console.WriteLine("Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia este x = {0}", x);

                Console.WriteLine();
            }

        }

        //Detreminati daca un an y este an bisect. 
        private static void AnBisect()
        {
            int n;
            n = int.Parse(Console.ReadLine());
            {

                if ((n % 4 == 0) || (n % 100 == 0 && n % 400 != 0))
                {
                    Console.WriteLine("TRUE");
                }
                else
                {
                    Console.WriteLine("FALSE");
                    Console.ReadKey();
                }
            }
        }
    }
}
            


        
    

            
        
           
       