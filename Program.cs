using System;

public class Program
{
    public static void Main(string[] args)
    {
        int numberOfValues;
        numberOfValues = ReadInteger($"Enter the size of array: ");
        double[] values = new double[numberOfValues];
        double sum = 0;
        for (int i = 0; i< numberOfValues;i++)
        {

            values[i] = ReadDouble($"Enter the {i + 1}st value: ");
        } 

        for (int j = 0; j< numberOfValues; j++)
        {
            sum += values[j];
            Console.WriteLine(values[j]);
        }
        Console.WriteLine("The sum of array values is " + sum);
    }

    public static int ReadInteger(string prompt)
    {

        Console.Write(prompt);

        while(true)
        {

            try
            {
                return Int32.Parse(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Please enter a valid integer");
            }
        }
    }
    public static double ReadDouble(string prompt)
    {

        Console.Write(prompt);

        while(true)
        {

            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch
            {

                Console.WriteLine("Please enter a valid value in double");
            }
        }
    }
}
