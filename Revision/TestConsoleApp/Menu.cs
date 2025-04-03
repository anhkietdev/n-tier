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
                Practise practise = new Practise();
                switch (choice)
                {
                    case 1:
                        practise.UserInputArray();
                        break;
                    case 2:
                        practise.FindMax();
                        break;
                    case 3:
                        practise.FindMin();
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
