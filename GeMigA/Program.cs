class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("Do you want to create a triangle or square? (or quit)?");
            string answer = Console.ReadLine().Substring(0, 1).ToLower();

            switch (answer)
            {
                case "s":
                    Console.WriteLine("Choose size of square");
                    Console.Write("Width: ");
                    int width = ChooseAmount();
                    int height = width;
                    Console.WriteLine(GetTextRectangleFromDimensions(width, height));
                    break;
                case "r":
                    Console.WriteLine("Choose width and height of rectangle");
                    Console.Write("Width: ");
                    int width = ChooseAmount();
                    Console.Write("Height: ");
                    int height = ChooseAmount();
                    Console.WriteLine(GetTextRectangleFromDimensions(width, height));
                    break;
                case "t":
                    Console.WriteLine("Choose base and height of triangle");
                    Console.Write("base: ");
                    int width = ChooseAmount();
                    Console.Write("Height: ");
                    int height = ChooseAmount();
                    Console.WriteLine(GetTextTriangleFromDimensions(width, height));
                    break;
                case "c":
                    break;
                case "q":
                    running = false;
                    break;
                default:
                    break;
            }

        }
    }
    static string GetTextRectangleFromDimensions(int width, int height)
    {
        string square = string.Empty;

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                square += "x";
            }
            square += "\n";
        }
        return square;
    }
    static string GetTextTriangleFromDimensions(int width, int height)
    {
        string triangle = string.Empty;

        for (var y = 1; y <= height; y++)
        {
            float amount = (float)width * (1 / (height / (float)y)) - 0.0001f; // 
            amount = 2 * MathF.Floor(amount / 2) + 1;

            for (var x = 1; x <= (width - amount) / 2; x++)
            {
                triangle += " ";
            }

            for (var x = 1; x <= amount; x++)
            {
                triangle += "y";
            }
            triangle += "\n";
        }
        return triangle;
    }
    static string GetTextCircleFromDimensions(int width, int height)
    {
        string circle = string.Empty;
        return circle;
    }
    private static int ChooseAmount()
    {
        string response = Console.ReadLine();
        int responseInt;

        if (response != null && int.TryParse(response, out responseInt))
        {
            if (responseInt >= 1) return responseInt;
            else
            {
                Console.WriteLine($"Please enter a number larger than 1");
                responseInt = ChooseAmount();
            }
        }
        else
        {
            Console.WriteLine("Please enter a number");
            responseInt = ChooseAmount();
        }
        return responseInt;
    }
}