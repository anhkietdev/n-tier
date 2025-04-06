namespace TestConsoleApp
{
    public class Menu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("======ARRAY PRACTICES======");
            Console.WriteLine("1. Enter the elements of an array and display them");
            Console.WriteLine("2. Find the maximum element in an array");
            Console.WriteLine("3. Find the minimum element in an array");
            Console.WriteLine("4. Summ all element in an array");
            Console.WriteLine("5. Get average element in an array");
            Console.WriteLine("6. Reverse element in an array");
            Console.WriteLine("7. Find unique element in an array");
            Console.WriteLine("8. Exit");
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
                        int[] array = practise.ProcessArray();
                        practise.DisplayArray(array);
                        break;
                    case 2:
                        practise.FindMax();
                        break;
                    case 3:
                        practise.FindMin();
                        break;
                    case 4:
                        practise.SumAll();
                        break;
                    case 5:
                        practise.GetAverage();
                        break;
                    case 6:
                        practise.ReverseArray();
                        break;
                    case 7:
                        practise.FindUnique();
                        break;
                    case 8:
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
