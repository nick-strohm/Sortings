# Sortings

This repository is part of the tasks of our computer science teaching. It expands the required task of the BubbleSort and SelectionSort algorithms by additional sorting algorithms.

## Comparison
Tested with `n` random generated numbers with a max value of 10000. The times are average values from 20 tests. The results are displayed in milliseconds.

Items  | BubbleSort | CountingSort | CSharpSort | GravitySort | HeapSort | InsertionSort | MergeSort | QuickSort | RadixSort | SelectionSort
-------|-----------:|-------:|--------:|-----------:|--------:|-----------:|--------:|--------:|-------:|----------:
10     |     0,4412 | 0,0890 |  0,5442 |     1,3199 |  0,0473 |     0,0238 |  0,0500 |  0,0314 | 0,0232 |     0,0450
100    |     0,5452 | 0,0967 |  0,3813 |    24,6079 |  0,0779 |     0,0446 |  0,0639 |  0,0482 | 0,0228 |     0,0991
1000   |    12,3429 | 0,1311 |  1,5494 |   189,6053 |  0,4035 |     1,1937 |  0,3664 |  0,2678 | 0,0276 |     2,0110
10000  |   952,9073 | 0,2968 |  2,4022 |  2232,4620 |  5,0702 |   123,7584 |  2,0847 |  3,0451 | 0,0830 |   184,6863
100000 | 92759,4344 | 1,8311 | 30,0934 | 63317,4748 | 65,0805 | 13440,6042 | 47,0254 | 41,6130 | 0,9383 | 19776,6919
