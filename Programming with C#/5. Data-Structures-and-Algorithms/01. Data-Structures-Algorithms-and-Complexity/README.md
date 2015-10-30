## Data Structures, Algorithms and Complexity
### Homework
### Task1

#####	1. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++)
      {
          int start = 0, end = arr.Length-1;
          while (start < end)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
### Answer
The algorithm complexity is `O(n^2)`.
### Explanation
The number of elementary steps is `~n*(n-1)`, `end = n-1`

###	Task2

#####	2. **What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```
### Answer
The algorithm complexity is `O(n*m)`.
### Explanation
*	Worst Case: Every member is even and the inner loop will iterate m times on every n time for the rows, so that the running time will be `O(n*m)`.
*	Average Case: n/2 member is even and the inner loop will iterate m times on every n/2 time for the rows, so that the running time will be `O(n*m)`, steps is `~m*n/2`.
*	Best Case: Every member is odd and the inner loop will never iterate, so that the running time will be only for the outer -> `O(n)`.

###	Task3

#####	3. `(*)` What is the expected running time of the following C# code?**
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.


	```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```


### Answer
The algorithm complexity is `O(n*m)`.
### Explanation
The number of elementary steps is `~n*(m-1)`.
