// Selection sort

namespace DataStructuresAndAlgorithms_C
{
    public class SelectionSort
    {
        public int[] StartSelectionSort (int[] array)
        {

            for (int i = 0; i < array.Length; i++ )
            {
                int minValue = array[i];
                for(int j = i; j < array.Length; j++)
                {
                    if(array[j] < minValue)
                    {
                        minValue = array[j]; // new min value
                        array[j] = array[i]; // swap value in array
                        array[i] = minValue; // swap array in array
                    }
                }
            }
        return array;
        }


    }
}