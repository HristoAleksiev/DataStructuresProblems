# DataStructuresProblems
Solutions to data structures problems from Telerik's Academy course "Data Structures and Algorithms"

Problems:

  ►Write a program that reads from the console a sequence of positive integer numbers. The sequence ends when empty 
  line is entered. Calculate and print the sum and average of the elements of the sequence. Keep the sequence in List<int>.

Solution: [SumAndAverage](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/SumAndAverage/SumAndAverage)

  ►Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.

Solution: [ReverseWithStack](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/ReverseWithStack/ReverseWithStack)

  ►Write a program that reads a sequence of integers (List<int>) ending with an empty line and sorts them in an 
  increasing order.
  
Solution: [IncreasingOrderSort](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/IncreasingOrderSort/IncreasingOrderSort)
    
  ►Write a method that finds the longest subsequence of equal numbers in given List<int> and returns the result as new 
  List<int>. Write a program to test whether the method works correctly.
  
Solution: [LongestSubsequence](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/LongestSubsequence/LongestSubsequence)
    
  ►Write a program that removes from given sequence all negative numbers.
 
Solution: [RemoveNegativeNumbers](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/RemoveNegativeNumbers/RemoveNegativeNumbers)
    
  ►Write a program that removes from given sequence all numbers that occur odd number of times. Example:
    {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
  
Solution: [RemoveOddAppearances](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/RemoveOddAppearances/RemoveOddAppearances)
    
  ►Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of 
  them occurs.
    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
      2  2 times
      3  4 times
      4  3 times
  
Solution: [OccurenceCounter](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/OccurenceCounter/OccurenceCounter)
    
  ►The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. Write a program to find the
  majorant of given array (if exists). Example:
    {2, 2, 3, 3, 2, 3, 4, 3, 3}  3
    
Solution: [Majorant](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/Majorant/Majorant)
    
  ►We are given the following sequence:
    S1 = N;
    S2 = S1 + 1;
    S3 = 2*S1 + 1;
    S4 = S1 + 2;
    S5 = S2 + 1;
    S6 = 2*S2 + 1;
    S7 = S2 + 2;
      ...
  Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...

Solution: [PrintSequence](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/PrintSequence/PrintSequence)
    
  ►Implement the data structure linked list. Define a class ListItem<T> that has two fields: value (of type T) and NextItem
  (of type ListItem<T>). Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).
 
Solution: [LinkedList](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/LinkedList/LinkedList)
    
  ►Implement the ADT stack as auto-resizable array. Resize the capacity on demand (when no space is available to add / insert
  a new element).
  
Solution: [Stack](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/Stack/Stack)
    
  ►Implement the ADT queue as dynamic linked list. Use generics (LinkedQueue<T>) to allow storing different data types in 
  the queue.

Solution: [LinkedQueue](https://github.com/HristoAleksiev/DataStructuresProblems/tree/master/LinkedQueue/LinkedQueue)
