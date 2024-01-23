This C# console application, named "RemovevaluefromArray," demonstrates two different approaches to remove a specific value from an array.

Using a Loop to Shift Elements:

The RemoveFromArray1 method initializes an array (numbers) with values.
It uses a for loop to find the index of the element to be removed (numToRemove).
If the element is found, it shifts the subsequent elements to fill the gap.
The array size is reduced by one using Array.Resize to eliminate the last element.
The modified array is then displayed.

Using LINQ to Filter Array:

The RemoveFromArray2 method uses the LINQ query Where to filter out the element to be removed (numToRemove).
The array is effectively replaced with a new array containing only the elements that do not match the specified value.
The resulting array is then displayed.
Both methods showcase different techniques for removing a specific value from an array in C#. The first method involves manual manipulation of the array, while the second method utilizes LINQ for a more concise and expressive approach.
