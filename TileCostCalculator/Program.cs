namespace TileCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int AVERAGE_FLOORING_PER_HOUR = 20;
            const double FLOORING_COST_PER_HOUR = 86.00;
            const string RECTANGLE_UPPERCASE = "Rectangle";
            const string RECTANGLE_LOWERCASE = "rectangle";
            const string TRIANGLE_UPPERCASE = "Triangle";
            const string TRIANGLE_LOWERCASE = "triangle";
            const string CIRCLE_UPPERCASE = "Circle";
            const string CIRCLE_LOWERCASE = "circle";


            double area = 0, totalFloorCost, laborCost;

            //Introduction Text and ask for width (using \n character to separate)
            Console.WriteLine("Welcome to Tile Cost Calculator.\nThis will help you calculate how much it would cost to cover a specified area with flooring.\n\nWhat shape is your floor? Rectangle, Triangle or Circle? (Choose 1): ");

            string floorShape = Console.ReadLine();

            if (floorShape != RECTANGLE_UPPERCASE && floorShape != TRIANGLE_UPPERCASE && floorShape != RECTANGLE_LOWERCASE && floorShape != TRIANGLE_LOWERCASE && floorShape != CIRCLE_UPPERCASE && floorShape != CIRCLE_LOWERCASE)
            {
                Console.WriteLine("The given shape is not supported, please choose either Rectangle, Triangle or Circle.");
                return;
            }

            if (floorShape == RECTANGLE_UPPERCASE || floorShape == RECTANGLE_LOWERCASE)
            {
                //Ask for floor width
                Console.WriteLine("\nPlease enter the floor width: ");
                double floorWidth = Convert.ToDouble(Console.ReadLine());

                //Ask for floor length
                Console.WriteLine("\nPlease enter the floor length: ");
                double floorHeight = Convert.ToDouble(Console.ReadLine());

                // Calculate area
                area = floorWidth * floorHeight;
            }
            if (floorShape == TRIANGLE_UPPERCASE || floorShape == TRIANGLE_LOWERCASE)
            {
                //Ask for floor base
                Console.WriteLine("\nPlease enter the floor base: ");
                double floorBase = Convert.ToDouble(Console.ReadLine());

                //Ask for floor height
                Console.WriteLine("\nPlease enter the floor height: ");
                double floorHeight = Convert.ToDouble(Console.ReadLine());

                // Calculate area
                area = (floorBase * floorHeight) / 2.0;

            }
            else // Floor is a circle
            {
                //Ask for floor radius
                Console.WriteLine("\nPlease enter the floor radius: ");
                double floorRadius = Convert.ToDouble(Console.ReadLine());

                area = Math.PI * floorRadius * floorRadius;
            }

            //Ask for floor cost per 1 unit
            Console.WriteLine("\nPlease enter the cost per 1 unit flooring: ");
            double floorCost = Convert.ToDouble(Console.ReadLine());

            // Calculate the cost of the floor and labor
            totalFloorCost = area * floorCost;
            laborCost = (area / AVERAGE_FLOORING_PER_HOUR) * FLOORING_COST_PER_HOUR;

            //Output result
            Console.WriteLine($"\nThe flooring will cost you ${Math.Round(totalFloorCost, 2)}.\nThe labor will cost you ${Math.Round(laborCost, 2)}.");
        }
    }
}
