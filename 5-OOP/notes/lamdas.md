# Lambda

- A lambda expression in C# is a concise, anonymous function (a method without a name) that you can treat as a data value. You can pass them as arguments to other methods, store them in variables, or use them to write quick, inline logic
- They use the lambda declaration operator (=>), which is read as "goes to" or "becomes" or "حيث"

## Lambda Syntax

```text
(input-parameters) => expression-or-statement-block
```

## Lambda Types

1. Expression Type

   - An expression lambda consists of a single line of code on the right side of the operator. The result of that expression is automatically returned.

    ```cs
    // Multiplies x by itself. The 'return' keyword is implied.
    Func<int, int> square = x => x * x; 
    Console.WriteLine(square(5)); // Output: 25

    ```

2. Statement Type

    - A statement lambda has a block of code enclosed in curly braces {} on the right side. You must use the return keyword explicitly if the method returns a value.

    ```cs
    Func<int, int, int> addAndMultiply = (a, b) => 
    {
        int sum = a + b;
        return sum * 2;
    };

    Console.WriteLine(addAndMultiply(3, 4)); // Output: 14

    ```

## Lambda drawbacks

1. The biggest hidden drawback is unnecessary object allocation. Every time you create a lambda, the compiler may need to allocate memory on the heap.

   - Delegate Allocation: If this happens inside a frequently called loop, **it causes frequent Garbage Collection (GC) spikes**.
   - Closures (Variable Capture): If your lambda uses a variable defined _outside_ its own scope, it creates a closure. The compiler secretly generates a hidden class behind the scenes to hold that variable, allocating both the class instance and the delegate on the heap.

2. Debugging and Readability Challenges

   - Difficult Call Stacks: Because lambdas are anonymous, crash stack traces won't show a clean method name.
   - BreakPoints

3. Capturing this and Memory Leaks

   - If a lambda inside a class uses an instance variable or calls an instance method, it implicitly captures `this` (the entire parent object). If that lambda delegate is stored in a long-lived event or static variable,_**the entire parent object cannot be garbage collected, causing a memory leak.**_

## Lambda optimizations

1. using `static` modifier to Stop closures and Prevent allocations
    - Use static lambdas to guarantee zero heap allocations from closures in performance-critical code.
    - use cases are
      - High-Frequency Loops
      - Collection Filtering
      - Concurrent / Multi-threaded Code

2. Cache `Delegates` for Frequent Operations: If a lambda is executed millions of times (e.g., in a game loop or high-throughput API), do not declare it inline. Store it in a reusable private field or local variable.

    ```cs
    // Unoptimized: Captures the 'min' variable, forcing the compiler to allocate a new closure and a new delegate on every single method call.
    public void FilterData(List<int> data, int min) => data.Where(x => x > min);

    // Optimized: Delegate and class state are captured/allocated once during class construction, saving memory if called frequently.
    private int _cachedMin = 0;
    public void FilterDataOptimized(List<int> data) => data.Where(x => x > _cachedMin); 
    // (Note: If 'x => x > 0' didn't capture anything, the compiler would automatically cache it for you!)

    ```

3. Pass State to Avoid Closures
    - Many modern .NET methods (like `List<T>.Find, ConcurrentDictionary`, or logging frameworks) allow you to pass a state object directly into the method. This lets your lambda use external data without creating a closure heap allocation.

    ```cs
    int targetId = 42;

    // Unoptimized: Captures 'targetId', causing an allocation
    var user = users.Find(u => u.Id == targetId);

    // Optimized: Pass targetId as a state parameter (No closure allocation!)
    var userOpt = users.Find(static (u, stateId) => u.Id == stateId, targetId);
    ```

4. Fall Back to Standard Methods or Local Functions
    - If your lambda
      - getting long
      - requires heavy debugging
      - needs complex logic
    - replace it with a Local Function. Local functions look cleaner, can be named, handle parameter capturing more efficiently under the hood, and don't force delegate allocations unless explicitly cast to one.

    ```cs
    // Better for readability and debugging than a massive statement lambda
    public void ProcessData(List<int> numbers)
    {
        var results = numbers.Where(IsValidNumber);

        // Named local function
        bool IsValidNumber(int n) => n > 0 && n % 2 == 0; 
    }
    ```
