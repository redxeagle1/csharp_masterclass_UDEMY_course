# Dictionary<TKey, TValue>

- A `Dictionary<TKey, TValue>` is a generic collection that stores **key-value pairs** in an unsorted structure. Unlike lists or arrays indexed by sequential integers ($0, 1, 2...$), dictionaries allow retrieval of values using unique keys of any specified type (such as `string`, `int`, or custom objects).

- Under the hood, a dictionary uses a **hash table**. It maps keys to array indexes using a hash function, allowing for near-instantaneous lookup, insertion, and deletion regardless of the dictionary size.

- A simple dictionary definition is `Dictionary<string, int> ages = [];` (C# 12+) or `var ages = new Dictionary<string, int>();`

> The `<TKey, TValue>` syntax represents generic placeholders for both the unique lookup key (`TKey`) and the stored data (`TValue`). Keys **must be unique** and cannot be `null` (for reference types), whereas values can be duplicated or `null`.

## Dictionary Properties

- `Count` : Gets the total number of key-value pairs actually contained in the dictionary.

- `Keys` : Gets a collection containing all unique keys in the dictionary.

- `Values` : Gets a collection containing all stored values in the dictionary.

| **Property** | **What it Represents** | **Performance** | **Modification** |
| --- | --- | --- | --- |
| **`Count`** | The actual number of key-value pairs stored. | Always $O(1)$ to read. | **Read-only**. Automatically updates when items are added or removed. |
| --- | --- | --- | --- |
| **`Keys`** | A view collection of every unique key. | $O(1)$ to access the wrapper. | **Read-only**. Reflects changes made to the dictionary automatically. |
| **`Values`** | A view collection of every stored value. | $O(1)$ to access the wrapper. | **Read-only**. Reflects changes made to the dictionary automatically. |

## Core Methods

- `Add(TKey key, TValue value)`: Adds the specified key and value. Throws an `ArgumentException` if the key already exists.

- `ContainsKey(TKey key)`: Determines whether the dictionary contains a specific key. Returns `true` or `false` in $O(1)$ time.

- `TryGetValue(TKey key, out TValue value)`: Gets the value associated with the specified key safely. Returns `true` if found; otherwise, returns `false` without throwing an exception.

- `Remove(TKey key)`: Removes the value with the specified key from the dictionary. Returns `true` if successful.

- `TryAdd(TKey key, TValue value)`: Attempts to add a key-value pair. Returns `false` instead of throwing an exception if the key already exists.

- `Clear()`: Removes all key-value pairs from the dictionary.

- `ContainsValue(TValue value)`: Checks if a value exists in the dictionary. Requires an $O(n)$ linear scan.

## Complexity Comparison

| **Operation** | **Best / Average Case** | **Worst Case** | **Notes** |
| --- | --- | --- | --- |
| **Lookup by Key** (`dict[key]`, `TryGetValue`) | $O(1)$ | $O(n)$ | Worst case occurs only during severe hash collisions. |
| **Insertion** (`Add`, `TryAdd`) | $O(1)$ | $O(n)$ | Worst case occurs when internal bucket array resizes. |
| **Deletion** (`Remove`) | $O(1)$ | $O(n)$ | Unbinds key and frees bucket. |
| **Lookup by Value** (`ContainsValue`) | $O(n)$ | $O(n)$ | Requires checking every entry sequentially. |

## Use Cases

- **Fast Lookups & Caching:** Storing pre-computed results, configurations, or session data mapped to unique IDs or names.

- **Grouping & Aggregation:** Indexing collections of data by specific properties (e.g., grouping employees by Department ID).

- **Uniqueness Enforcement via Keys:** Mapping records where each item must have a distinct identifier (e.g., User ID $\\rightarrow$ User Profile).

## Best Practices

- **Pre-allocating Capacity:**
        -   If you know the approximate number of items, pass the initial capacity to the constructor `new Dictionary<string, int>(1000)` to prevent expensive internal table re-hashing and resizing.

- **Safe Retrieval (`TryGetValue` vs Indexer):**
        -   Avoid `if (dict.ContainsKey(key)) { var val = dict[key]; }` because it performs two hash lookups. Use `dict.TryGetValue(key, out var val)` instead to perform the lookup once.

- **Immutable/Stable Keys:**
        -   Ensure objects used as keys are immutable or do not change their state after insertion. Changing an object's properties while it is a key alters its hash code, making it unretrievable.

## Working with Dictionary

```cs
// Pre-allocating capacity to avoid resizing overhead
var expectedCount = 50;
Dictionary<string, int> ageMap = new Dictionary<string, int>(expectedCount);

```

in c# 15

```cs
// Supported in C# 15+
Dictionary<int, string> employees = [
    1: "Julia",
    2: "Anna",
    3: "Thomas"
];
```

### Dictionary Manipulation

```cs
// Initialization syntax (C# 12+ collection expressions or dictionary initializers)
Dictionary<string, int> studentGrades = new()
{
    ["Alice"] = 95,
    ["Bob"] = 87,
    ["Charlie"] = 91
};

// 1. Safe Lookup (Best Practice)
if (studentGrades.TryGetValue("Alice", out int grade))
{
    Console.WriteLine($"Alice's grade: {grade}");
}

// 2. Indexer assignment (Adds or Overwrites)
studentGrades["David"] = 88; // Adds "David"
studentGrades["Bob"] = 90;   // Overwrites Bob's score safely

// 3. Iterating over Key-Value pairs
foreach (KeyValuePair<string, int> KVP in studentGrades)
{
    Console.WriteLine($"{KVP.Key}: {KVP.Value}");
}

// 4. Deletion
studentGrades.Remove("Charlie");

```
