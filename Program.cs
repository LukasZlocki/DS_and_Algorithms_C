using DataStructuresAndAlgorithms_C;

// array for selection purpose
int[] Array = new int [] {-11, 12, -42, 0, 1, 90, 68, 6, -9};

void ShowArray(int[] array)
{
    string arrayString = "";
    for(int i = 0; i < array.Length; i++)
    {
        arrayString += " " + array[i];
    }
    Console.WriteLine("{0}", arrayString);
}

// *** Selection Sort Part ***
Console.WriteLine("Selection Algorithms - Selection sort:");
Console.WriteLine("Before sort:");
ShowArray(Array);
int[] SortedArray = SelectionSort.StartSelectionSort(Array);
Console.WriteLine("Selection sort result:");
ShowArray(SortedArray);


// *** Selection Sort Part ***
 
