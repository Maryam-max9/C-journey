namespace library_system
{

    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.UserInfo();
            user.TheLibraryMenu();
        }
        private bool _isExiting = false;
    }


    public class User
    {
        public void UserInfo()
        {
            Console.WriteLine("Write Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

        }
        public void TheLibraryMenu()
        {
            while (true) // Infinite loop to keep showing menu
            {

                Console.WriteLine("\nHere is what you can do with books");
                Console.WriteLine("1. Borrow books");
                Console.WriteLine("2. Buy books");
                Console.WriteLine("3. Just reading");
                Console.WriteLine("4. Searching books");
                Console.WriteLine("5. Display all books");
                Console.WriteLine("6. Exit");
                Console.Write("\nEnter your choice (1-6): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        BorrowBooks();
                        break;
                    case "2":
                        BuyBooks();
                        break;
                    case "3":
                        Reading();
                        break;
                    case "4":
                        SearchingBooks();
                        break;
                    case "5":
                        DisplayAllBooks();
                        break;
                    case "6":
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Invalid option Try again");
                        break;




                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();


            }
        }

        static void BorrowBooks()
        {
            Console.WriteLine("---> Borrowing Books <---");
            Console.WriteLine("1. Fiction");
            Console.WriteLine("2. Non-Fiction");
            Console.WriteLine("3. Textbooks");

        }
        static void BuyBooks()
        {
            Console.WriteLine("---> Buying Books <---");
            Console.WriteLine("1. Any new releases -> $20");
            Console.WriteLine("2. Any old -> $15");

        }

        static void Reading()
        {
            Console.WriteLine("---> Reading Area <---");
            Console.WriteLine("You can read whatever you want here");
        }


        static void SearchingBooks()
        {
            Console.WriteLine("Provide a book title: ");
            string BookName = Console.ReadLine();
            /*
            Console.WriteLine(" Author is: ");
            Console.WriteLine(" ISBN is: ");
            Console.WriteLine(" Copies Available are: ");
            */
            List<Book> books = new List<Book>
               {
                    new Book { Title = "1984", Author = "George Orwell", ISBN = "978-0451524935", CopiesAvailable = 3 },
                     new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien", ISBN = "978-0547928227", CopiesAvailable = 5 }
               };

            Book foundBook = books.FirstOrDefault(b =>
                             b.Title.Equals(BookName, StringComparison.OrdinalIgnoreCase));

            if (foundBook != null)
            {
                Console.WriteLine($"{foundBook.Title} Author is: {foundBook.Author}");
                Console.WriteLine($"{foundBook.Title} ISBN is: {foundBook.ISBN}");
                Console.WriteLine($"{foundBook.Title} Copies Available are: {foundBook.CopiesAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }



        }


        static void DisplayAllBooks()
        {

        }

        static void Exit()
        {

            Console.WriteLine("Thank U for using my library system bye!");
            bool IsExiting = true;


        }

    }


    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int CopiesAvailable { get; set; }



    }
}




