namespace ChristmasTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of the Christmas tree (positive integer):");

            // Try to parse user input to an integer
            if (int.TryParse(Console.ReadLine(), out int height) && height > 0)
            {
                // Create a ChristmasTreeDrawer and render the tree
                var drawer = new ChristmasTreeDrawer();
                string tree = drawer.BuildTree(height);
                Console.WriteLine(tree);
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.ReadKey();
        }
    }
}
