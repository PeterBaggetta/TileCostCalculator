namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AVERAGE_FLOORING_PER_HOUR = 20;
            const double FLOORING_COST_PER_HOUR = 86.00;

            double totalFloorCost, laborCost;

            //Introduction Text and ask for width (using \n character to separate)
            Console.WriteLine("Welcome to Tile Cost Calculator.\nThis will help you calculate how much it would cost to cover a specified area with flooring.\n\nWhat shape is your floor, Rectangle or Triangle? (Choose 1): ");

            string floorShape = Console.ReadLine();

            if (floorShape != "Rectangle" && floorShape != "Triangle" && floorShape != "rectangle" && floorShape != "triangle")
            {
                Console.WriteLine("The given shape is not supported, please choose either Rectangle or Triangle.");
                Environment.Exit(0);
            }


            //Ask for floor width
            Console.WriteLine("\nPlease enter the floor width: ");
            double floorWidth = Convert.ToDouble(Console.ReadLine());

            //Ask for floor length
            Console.WriteLine("\nPlease enter the floor length: ");
            double floorHeight = Convert.ToDouble(Console.ReadLine());

            //Ask for floor cost per 1 unit
            Console.WriteLine("\nPlease enter the cost per 1 unit flooring: ");
            double floorCost = Convert.ToDouble(Console.ReadLine());

            if (floorShape == "Rectangle" || floorShape == "rectangle")
            {
                //Calculate total cost of the square floor and the labor
                totalFloorCost = floorWidth * floorHeight * floorCost;
                laborCost = ((floorWidth * floorHeight) / AVERAGE_FLOORING_PER_HOUR) * FLOORING_COST_PER_HOUR;
            }
            else
            {
                //Calculate total cost of the triangle floor and the labor
                totalFloorCost = ((floorWidth * floorHeight) / 2) * floorCost;
                laborCost = (((floorWidth * floorHeight) / 2) / AVERAGE_FLOORING_PER_HOUR) * FLOORING_COST_PER_HOUR;
            }

            //Output result
            Console.WriteLine($"\nThe flooring will cost you ${Math.Round(totalFloorCost, 2)}.\nThe labor will cost you ${Math.Round(laborCost, 2)}.");
        }
    }
}
