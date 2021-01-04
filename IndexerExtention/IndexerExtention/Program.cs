using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExtention
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //string word = "Hello";
            //word[0] = 'a';
            //Console.WriteLine(word[0]);
            //Library lib = new Library("Libraff");
            //Book book = new Book("Xemse");
            //lib[0] = book;
            //Console.WriteLine(lib[0]);
            //lib.books[110] = book;
            //Console.WriteLine(lib.books[0]);

            #endregion

            #region Operators in custom types
            //Person p1 = new Person("Tural", "Elesgerli", 22);
            //Person p2 = new Person("Mehemmedeli", "Abbaszade", 19);
            //Console.WriteLine(p1>p2);
            //Person[] people = { p1, p2 };
            #endregion

            #region Extension
            string mail = "kamran@code.edu.az";
            Console.WriteLine(mail.IsEmail());

            int a = 23;
            int b = 3;
            a.Sum(b);
            //Console.WriteLine(IsEmail(mail));
            #endregion

        }

        //static bool IsEmail(string mail)
        //{
        //    try
        //    {
        //        MailAddress mailAddress = new MailAddress(mail);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
           
        //}
    }

    

    #region Operators in custom types
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public static int operator +(Person p1, Person p2)
        {
            return p1.Age + p2.Age;
        }

        public static bool operator >(Person p1,Person p2)
        {
            return p1.Age > p2.Age;
        }

        public static bool operator <(Person p1, Person p2)
        {
            return p1.Age < p2.Age;
        }
    }
    #endregion

    #region Indexer
    //homework
    //class Alphabet
    //{
    //    private char[] letters;
    //}

    class Library
    {
        public string Name { get; set; }
        private Book[] books;
        public Library(string name)
        {
            Name = name;
            books = new Book[100];
        }

        public Book this[int index]
        {
            get 
            {
                try
                {
                    return books[index];
                }
                catch (Exception)
                {

                    return books[0];
                }
                
            }
            set 
            {
                try
                {
                    books[index] = value;
                }
                catch (Exception)
                {
                    Console.WriteLine($"{index} indexse set ede bilmersiz.Sonuncu index {books.Length-1}");
                }
            }
        }
    }

    class Book:Object
    {
        public string Name { get; set; }
        public Book(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    #endregion
}
