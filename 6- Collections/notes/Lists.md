# List

- A List\<T\> is generic collection that store element of any specific type like a list of strings or int or chars in linear sequence just like arrays and its size is dynamic
- The difference between an array and a list is that a list is a dynamic array the grows over the time by the double [from 2 to 4 to 8 to 16..etc] and this dynamism allow us define a list without worrying about the size
- A simple list definition is `List<int> numbers = [];`

> the \<T\> is a generic placeholder for the type wether it's `int`, `string` or even a class of yours

## List properties

- `Count` : get the number of the elements contained in the list
- `Capacity` : get and set the maximum number of the element the list can hold before resizing

| Property | What it Represents | Performance | Modification |
| --- | --- | --- | --- |
| **`Count`** | The actual number of items you have added. | Always O(1) to read. | **Read-only**. You cannot change it directly; it updates when you call `Add()`, `Remove()`, etc. |
| **`Capacity`** | The size of the internal backing array. | O(1) to read. O(n) to change. | **Read and Write**. You can set it manually to pre-allocate memory. |

## Core Method

- `Add(T item)`: add an Item to the end of the list
- `Remove(T item)`: remove the first occurrence of a specific object from the list
- `Insert(int index, T item)`: insert Item at the specified index
- `Find(Predicate<T> match)`: Searches for an element that matches the condition specified by the predicate
- `Sort()`: sort the elements in the entire list
- `Clear()`: Removes all elements from the list
- `ToArray()`: ***Copies*** all the element of the list to a new array
- `IndexOf(T item)`: Return the index of the first occurrence of a specific object in the list

## use cases

- Database Record: fetching unknown number of db record before
- Data Manipulation: for frequent data manipulation
- It's the default return type for collection

## best practices

- Capacity Managing
  - if you know the approximate number of elements that the list will hold setting the initial size will improve the performance a lot as it ***avoid frequent resizing***
- Using foreach
  - it offer a clear syntax for handling Lists
