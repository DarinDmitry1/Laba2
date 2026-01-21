using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cleoName = new Name("Клеопатра");
            var pushkinName = new Name("Пушкин", "Александр", "Сергеевич");
            var mayakName = new Name("Маяковский", "Владимир");

            Console.WriteLine(cleoName);
            Console.WriteLine(pushkinName);
            Console.WriteLine(mayakName);

            var cleoPerson = new Person(cleoName, 152);
            Console.WriteLine(cleoPerson);
            var pushkinPerson = new Person(pushkinName, 167);
            Console.WriteLine(pushkinPerson);
            var mayakPerson = new Person(mayakName, 189);
            Console.WriteLine(mayakPerson);

            var ivanName = new Name("Чудов", "Иван", "");
            var petrName = new Name("", "Петр", "");
            var borisName = new Name("", "Борис", "");

            var fivan = new fPerson(ivanName);
            var fpetr = new fPerson(petrName, father: fivan);
            var fboris = new fPerson(borisName, father: fpetr);

            Console.WriteLine(fivan);
            Console.WriteLine(fpetr);
            Console.WriteLine(fboris);

            var A = new City("A");
            var B = new City("B");
            var C = new City("C");
            var D = new City("D");
            var E = new City("E");
            var F = new City("F");

            A.AddRoute(B, 5);
            A.AddRoute(D, 6);
            A.AddRoute(F, 1);
            B.AddRoute(A, 5);
            B.AddRoute(C, 3);
            C.AddRoute(B, 3);
            C.AddRoute(D, 4);
            D.AddRoute(E, 2);
            D.AddRoute(A, 6);
            D.AddRoute(C, 4);
            E.AddRoute(F, 2);
            F.AddRoute(B, 1);
            F.AddRoute(E, 2);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);               
            Console.WriteLine(D);
            Console.WriteLine(E);
            Console.WriteLine(F);

            var klepatra = new Nameif("Дарьин","","Андреевич");
            Console.WriteLine(klepatra);

            var barsik = new Cat("Барсик");

            Console.WriteLine(barsik);
            barsik.Mew();
            barsik.MewN(3);
        }
    }
}