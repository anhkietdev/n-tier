namespace TestConsoleApp
{
    public class Menu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("1. Enter the elements of an array and display them");
            Console.WriteLine("2. Find the maximum element in an array");
            Console.WriteLine("3. Find the minimum element in an array");
            Console.WriteLine("4. Exit");
        }
        public void Run()
        {
            int choice;
            do
            {
                DisplayMenu();
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Practise practise = new Practise();
                        practise.UserInputArray();
                        break;
                    case 2:
                        Practise practise1 = new Practise();
                        practise1.FindMax();
                        break;
                    case 3:
                        Practise practise2 = new Practise();
                        practise2.FindMin();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);
        }
    }
}
