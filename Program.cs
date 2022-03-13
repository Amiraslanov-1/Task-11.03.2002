using System;

namespace TaskFebruary_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Length;
            string LengthStr;
            Console.WriteLine("Enter the number of book :");
            LengthStr = Console.ReadLine();

            while (CheckInput(LengthStr) != true)
            {
                Console.WriteLine("Enter Correctly :");
                LengthStr = Console.ReadLine();

            }

            Length = Convert.ToInt32(LengthStr);






            Book[] books = new Book[Length];
            for (int i = 0; i < Length; i++)
            {



                int id       = GetInputID    ($"{i + 1} - Book No: ", 0, 20);
                int count    = GetInputCount ($"{i + 1} - Number of books :", 0, 20);
                string name  = GetInputName  ($"{i + 1} - Book Name:", 5, 45);
                string genre = GetInputGenre ($"{i + 1} - Genre of the book :", 0, 35);
                double price = GetInputPrice ($"{i + 1} - Price of the book:", 4, 110);




                books[i] = new Book(genre, id, name, price, count)
                {
                    Count = count

                };
            }




            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1-  Filter your books by price ");
                Console.WriteLine("2 - Search in books");
                Console.WriteLine("3 - Show all books  ");
                Console.WriteLine("0 - Exit  ");
                Console.WriteLine("--------------------------------------------------------------------------------");

                string Search = Console.ReadLine();
                int count = Convert.ToInt32(Search);

                if (count == 1)
                {

                    Console.WriteLine("Enter Min and Max Price:");
                    Console.WriteLine("--------------------------------------------------------------------------------");
                    Console.WriteLine(" Min Price:");
                    double MinPrice = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" Max Price:");
                    
                    double MaxPrice = Convert.ToDouble(Console.ReadLine());
                    
                    var NewArr = FilterByPrice(books, MinPrice, MaxPrice);

                    Console.WriteLine("----------------------------Filtered Books-------------------------------------");
                    foreach (var item in NewArr)
                    {

                        Console.WriteLine(item.GetInfo());
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                    continue;

                }
                else if (count==2)
                {
                    Console.WriteLine("Enter the name of the Book : ");
                    string name = Console.ReadLine();
                    FiteredBooksName(books, name);
                    var FilteredArr = FiteredBooksName(books, name);

                    Console.WriteLine  ("----------------------------------------------------------------------------------");
                    foreach (var item in FilteredArr)
                    {
                        Console.WriteLine(item.GetInfo());
                        Console.WriteLine("----------------------------------------------------------------------------------");
                    }

                    continue;
                }
                else if (count==3)
                {
                        Console.WriteLine("-----------------------------------All books------------------------------------");
                    for (int i = 0; i < books.Length; i++)
                    {
                        Console.WriteLine(books[i].GetInfo());
                        Console.WriteLine("--------------------------------------------------------------------------------");
                    }
                }

                else if  (count==0)
                {
                    Console.WriteLine("|----------------------------------------------Program Ended-----------------------------------------------------------|");

                    break;
                }
               else
                {
                    continue;
                }






            } while (true);

            

            static Book[] FilterByPrice(Book[] books, double MinPrice, double MaxPrice)
            {
                Book[] NewArr = new Book[books.Length];
                int count = 0;


                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].ProductPrice >= MinPrice && books[i].ProductPrice <= MaxPrice)
                    {
                        NewArr[count] = books[i];
                        count++;
                    }
                }

                Book[] NewFilteredArr = new Book[count];

                for (int i = 0; i < count; i++)
                {
                    NewFilteredArr[i] = books[i];
                }

                return NewFilteredArr;
            }

            static Book[] FiteredBooksName(Book[] books, string name)
            {
                Book[] FilteredArr = new Book[books.Length];
                int count = 0;

                for (int i = 0; i < books.Length; i++)
                {
                    if (books[i].ProductName == name)
                    {
                        FilteredArr[count] = books[i];
                        count++;
                    }
                }
                Book[] NewFilteredBook = new Book[count];
                for (int i = 0; i < count; i++)
                {
                    NewFilteredBook[i] = FilteredArr[i];
                }
                return NewFilteredBook;
            }
            static bool CheckInput(string input)
            {
                char[] Array = { '1', '2', '3', '4', '5', '6', '7', '8', '9','0' };
                int count = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < Array.Length; j++)
                    {
                        
                        if (input[i] == Array[j])
                        {
                            count++;
                        }

                    }
                }
                if (count == input.Length)
                {
                    return true;
                }

                else
                    return false;
            }



            static int GetInputID(string name, int min, int max)
            {
                int Input;
                string inputStr;

                do
                {

                    Console.WriteLine(name);
                    inputStr = Console.ReadLine();
                    Input = Convert.ToInt32(inputStr);



                }while (Input < min || max < Input);
                return Input;
            }
            static string GetInputName(string name, int min, int max)
            {

                string Input;
                do
                {
                    Console.WriteLine(name);
                    Input = Console.ReadLine();

                }while (Input.Length < min || max < Input.Length);

                return Input;
            }
            static double GetInputPrice(string name, int min, int max)
            {
                double Input;
                string inputStr;
                do
                {
                    Console.WriteLine(name);
                    inputStr = Console.ReadLine();
                    Input = Convert.ToDouble(inputStr);

                }while (Input < min || max < Input);

                return Input;
            }

            static int GetInputCount(string name, int min, int max)
            {
                int Input;
                string inputStr;

                do
                {
                    Console.WriteLine(name);
                    inputStr = Console.ReadLine();
                    Input    = Convert.ToInt32(inputStr);


                } while (Input < min || max < Input);

                return Input;
            }
            static string GetInputGenre(string name, int min, int max)
            {

                string Input;
                do
                {

                    Console.WriteLine(name);
                    Input = Console.ReadLine();



                } while (Input.Length < min || max < Input.Length);
                return Input;
            }


        }
    }
}

