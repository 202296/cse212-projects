public static class ArraysTester
{
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run()
    {
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



    // <plan>

    // Here's a plan to implement the `MultiplesOf` function:

    // 1.Initialize an empty list to store the multiples.
    // 2.Start a loop from 1 to `length`, inclusive.
    // 3.Inside the loop, multiply the `number` by the loop index and add the result to the list.
    // 4.After the loop, return the list containing the multiples.

    // </plan>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.





        // Here's my plan to implement the `MultiplesOf` function:

        // 1. I will Initialize an empty list to store the multiples.
        // 2. I will then start a loop from 1 to `length`, inclusive.
        // 3. Now inside the loop, I will multiply the `number` by the loop index and add the result to the list.
        // 4. After the loop, I will return the list containing the multiples.


        // Initialize an empty list to store the multiples
        List<double> multiples = new List<double>();

        // Start a loop from 1 to length, inclusive
        for (int i = 1; i <= length; i++)
        {
            // Multiply the number by the loop index and add the result to the list
            multiples.Add(number * i);
        }

        // After the loop, return the list containing the multiples
        return multiples.ToArray();
    }


    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>


    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.


        // This is my plan to implement the `RotateListRight` function:

        // 1. I will firstly calculate the effective rotation amount by taking the remainder of the input `amount` divided by the length of the `data` list. This will ensures that we handle cases where the rotation amount exceeds the length of the list.
        // 2. I will secondly create a new list to store the rotated elements.
        // 3. I will thirdly use the `GetRange` method to extract the elements from the original list starting from the index `(data.Count - effectiveRotationAmount)` to the end of the list. This will represents the elements that will be moved to the beginning of the rotated list.
        // 4. I will fourthly use the `RemoveRange` method to remove these elements from the original list.
        // 5. I will fifthly use the `InsertRange` method to insert the extracted elements at the beginning of the original list.
        // 6. Finally, I will return the modified list.


        // Calculate the effective rotation amount
        int effectiveRotationAmount = amount % data.Count;

        // Create a new list to store the rotated elements
        List<int> rotated = new List<int>();

        // Extract the elements from the original list starting from the index (data.Count - effectiveRotationAmount)
        rotated.AddRange(data.GetRange(data.Count - effectiveRotationAmount, effectiveRotationAmount));

        // Remove these elements from the original list
        data.RemoveRange(data.Count - effectiveRotationAmount, effectiveRotationAmount);

        // Insert the extracted elements at the beginning of the original list
        data.InsertRange(0, rotated);
    }



}
