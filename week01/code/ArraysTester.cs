public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of doubles with the specified length
        double[] multiples = new double[length];

        // Step 2: Use a loop to calculate the multiples
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the array of multiples
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3, 
    /// then the list returned should be <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  
    /// The value of amount will be in the range of 1 and data.Count.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Use modulo to ensure the amount is within the range of 1 and data.Count
        amount = amount % data.Count;

        // Step 2: Create a temporary list to store the rotated elements
        List<int> rotatedElements = new List<int>();

        // Step 3: Add the elements that need to be rotated to the temporary list
        rotatedElements.AddRange(data.GetRange(data.Count - amount, amount));

        // Step 4: Remove the rotated elements from the original list
        data.RemoveRange(data.Count - amount, amount);

        // Step 5: Insert the rotated elements at the beginning of the original list
        data.InsertRange(0, rotatedElements);
    }
}
