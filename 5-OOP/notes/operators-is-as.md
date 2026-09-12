# identity operators

- `is` and `as` are type-checking and type-conversion operators. They help us determine and safely convert the type of an object at runtime.

## `is`

- With C# 7.0 and later, `is` can be used with pattern matching
- The `is` operator **checks if an object is of a specific type** and returns a boolean (`true` or `false`).

    ```c#
    class Animal {}
    class Dog : Animal {} // c# inheritance
    
    Animal myPet = new Dog();
    
    if (myPet is Dog)
    {
        Console.WriteLine("myPet is a Dog");
    }
    else
    {
        Console.WriteLine("myPet is NOT a Dog");
    }

    //Output: myPet is a Dog
    ```

## `as`

- The `as` operator provides safe type conversion by attempting to convert an object to a specified type, returning null if the conversion fails instead of throwing an exception.

    ```C#
    class Animal {}
    class Dog : Animal {}
    class Cat : Animal {}
    
    Animal myPet = new Dog();
    
    Dog myDog = myPet as Dog;
    if (myDog != null)
    {
        Console.WriteLine("Successfully cast to Dog.");
    }
    else
    {
        Console.WriteLine("Conversion failed.");
    }
    Output:

    // Output: Successfully cast to Dog.
    ```

    > However, if myPet was a Cat:
        > `Animal myPet = new Cat();`
        > `Dog myDog = myPet as Dog;`
    > The output will be `Conversion failed.`

## Comparing `is` and `as` with Alternatives

The `is` operator, `as` operator, and explicit casting in C# serve distinct purposes depending on how strictly you need to verify type safety.

|**Feature**|**is Operator**|**as Operator**|**Explicit Casting ((Type)obj)**|
|---|---|---|---|
|**Purpose**|Checks if an object is of a specific type|Safely converts an object to a target type|Forcefully converts an object to a target type|
|**Return Type**|`bool` (`true` / `false`)|Object of target type, or `null`|Object of target type|
|**Failure Result**|Returns `false`|Returns `null`|Throws `InvalidCastException`|
|**Best For**|Pre-checking types before executing logic|Safe conversions when `null` is an acceptable fallback|Conversions where you are 100% certain of the type|

### **When to Use Which**

- **Use `is`** when you only need to check type compatibility without performing an immediate conversion (or when using pattern matching like `if (obj is String s)`).
- **Use `as`** when converting reference or nullable types where failure should be handled gracefully using a `null` check.
- **Use Explicit Casting** when the target type is guaranteed, or when working with value types that cannot evaluate to `null`.
