public class Sorting
{

    public static void BubbleSort() 
    {
        Console.WriteLine("Bubble Sort:");
        Console.WriteLine("AVG: O(n^2)   Worst: n-1   Best: O(n)");
        int[] array  = randomArray(10);
        printArray(array);
        Console.WriteLine("Start Sortting");

        //bubble sort is like a bubble, the higher valued elements rise up to the top of the array
        bool swapped;
        int temp;
        //loop over all the elements in the array
        for (int i = 0; i < array.Length - 1; i++) 
        {
            swapped = false;
            //take the j element and compare it with the element above
            for (int j = 0; j < array.Length - 1; j++)
            {
                //if the element is greater than the right element then swap it 
                if (array[j] > array[j + 1])
                {
                    //swap the two elements in the array
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
            printArray(array);
        }
        
    }

    public static void SelectionSort()
    {
        Console.WriteLine("Selection Sort");
    }




    //Generate an array with random integers
    public static int[] randomArray(int size) {

        Random rnd = new Random();
        int[] rndArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            rndArray[i] = rnd.Next(0,101); //random number between 0-100
        }

        return rndArray;    
    }

    // Function to print an array
    static void printArray(int[] array)
    {
        int i;
        for (i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine();
    }
}

