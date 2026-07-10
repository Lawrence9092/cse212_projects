
public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
         // Step 1: Create a new array that can store the required number of multiples.
    // The array size will be equal to the value of the length parameter.
    double[] multiples = new double[length];

    // Step 2: Use a loop to visit every position in the array.
    // The loop starts at index 0 and continues until the last index (length - 1).
    for (int i = 0; i < length; i++)
    {
        // Step 3: Calculate the multiple for the current position.
        // Since array indexes start at 0 but multiples start at 1,
        // multiply the number by (i + 1).
        multiples[i] = number * (i + 1);
    }

    // Step 4: Return the completed array containing all the multiples.
    return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Repeat the rotation the required number of times.
    // Step 2: Save the last element in the list.
    // Step 3: Remove the last element from the end.
    // Step 4: Insert the saved element at the beginning of the list.
    // Step 5: Continue until the list has been rotated the required number of times.

    for (int i = 0; i < amount; i++)
    {
        int last = data[data.Count - 1];

        data.RemoveAt(data.Count - 1);

        data.Insert(0, last);
    }
    }
}
