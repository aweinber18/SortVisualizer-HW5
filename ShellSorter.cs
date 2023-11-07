using Sorting_Visualization;
using System;

public class ShellSorter<T> where T : IComparable<T>
{
    private SortVisualizer sortVisualizer;

    public ShellSorter(SortVisualizer sv) {
        sortVisualizer = sv;
    }

    public T[] Sort(T[] array, int gap)
    {
        if (gap == 0)
            return array;
        for (int i = 0; i < array.Length - gap - 1; i++)
        {
            if (array[i].CompareTo(array[i + gap]) > 0)
            {
                Swap(array, i, i + gap);
            }
        }
        return Sort(array, gap / 2);
    }
    private void Swap(T[] array, int i, int j)
    {
        T temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        sortVisualizer.ResetRTB();
    
        Thread.Sleep(500);
    }

}
