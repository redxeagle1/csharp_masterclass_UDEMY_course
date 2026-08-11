## arrays <!-- markdownlint-disable-line -->

- `array`: A data structure capable of storing multiple variables of the same type (like an array of strings).
- Arrays are fixed-size (static) structures with a length specified when they are instantiated.
- Because an array has a fixed size, you must use `Array.Resize(ref YOUR_ARRAY, new_size);` to resize it. This has low performance since it requires allocating a new array and copying all elements every time you call it.

### Declaring and Instantiating Arrays

- Declaring an array means specifying its type, while instantiating it allocates the memory for its size.
  
    > - `type` is the array type, like `int` or `float`.
    > - `size` defines how many elements the array can hold.
    >
    >```csharp
    > TYPE[] array_name = new TYPE[SIZE]; // Declaration and instantiation
    > ```
    >
    > Note: If you access this array directly after instantiating it, the elements will contain the defined type's default value (e.g., `0` for ints, `null` for strings).

- To initialize the array with specific values right away, you can use a collection expression:
  
    > - The size is automatically defined by how many elements are passed.
    > - All passed elements must match the specified type.
    >
    >```csharp
    > float[] myFloatArray = [12, 21, 21.3f, 21, 21]; // Initialization (note the 'f' for float)
    > ```

### Indexing

- Array indexing starts at `0` and goes up to `(array size) - 1`.
- Accessing an index outside of this defined range will throw an `IndexOutOfRangeException` at **runtime**.
- `yourArray.Length` is a property used to get the total size (number of elements) of the array.
  
    > An example of array indexing:
    >
    >```csharp
    > double[] myDoubleArray = [12, 21, 21.3, 21, 21]; 
    > double firstElement = myDoubleArray[0]; // Accesses the number 12
    > int size = myDoubleArray.Length; // Returns 5
    > ```
