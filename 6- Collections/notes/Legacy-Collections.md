# Legacy

- these are group of collections that are outdated but still maintained and often the modern IDE will warn you upon using it
- It can be found in Legacy codebases

## ArrayList

- it's the older way of using a `List` which was using and Array of object of course that came with a cost of using `object` types
- this collection can hold any value mostly like python's list

### What Is The Difference Between A List And ArrayList In C\#

- The primary difference is that `List<T>` is a generic collection, whereas `ArrayList` is a non-generic collection. In modern C#, `ArrayList` is considered legacy and you should always use `List<T>` for new development.

#### Direct Comparison

| Feature | `List<T>` | `ArrayList` |
| --- | --- | --- |
| **Type System** | **Generic** (strongly typed to `T`) | **Non-generic** (stores everything as an `object`) |
| **Type Safety** | **Compile-time safety**. Rejects mismatched types before code runs. | **No type safety**. Mixes data types freely, leading to potential runtime crashes. |
| **Performance** | **Fast**. No boxing or unboxing required for value types. | **Slower**. Value types must be boxed and unboxed, which creates memory overhead. |
| **Namespace** | `System.Collections.Generic` | `System.Collections` |
| **LINQ Support** | Fully compatible out-of-the-box. | Requires manual casting or `OfType<T>()` filters to use LINQ. |
| **Recommendation** | Standard practice for all C# code. | Legacy. Only use when maintaining pre-.NET 2.0 applications. |

## HashTables

- it's the older way of using a `Dictionary` which was storing `object` types which resulted in boxing and unboxing for the value typed and kill the performance
- it's behavior is similar to python's dictionaries and not type safety by design

> in general hashing is translating data into a string of char based on the hashing algorithms like SHA-family
>
> Hashables works by acting like a real-world dictionary which one word has one meaning or one to one relationship

### what is the difference between a dictionary and legacy HashTables in C\#

The primary difference is that **`Dictionary<TKey, TValue>` is a generic, strongly typed collection**, while **`HashTable` is a non-generic legacy collection** that stores keys and values as `object`. Just like the relationship between `List<T>` and `ArrayList`, `HashTable` is an outdated .NET 1.0 relic that should **not be used in modern C# development**.
While both use a hashing algorithm to provide fast, near-instant lookups (`O(1)` time complexity), they differ significantly in safety, memory handling, and performance.

Direct Comparison

| Feature | `Dictionary<TKey, TValue>` | `HashTable` |
| --- | --- | --- |
| **Type System** | **Generic** (strongly typed keys and values) | **Non-generic** (keys and values are `object`) |
| **Type Safety** | **Compile-time safety**. Rejects invalid types immediately. | **No type safety**. Accepts any object type, risking runtime crashes. |
| **Performance** | **Fast**. No boxing/unboxing overhead for value types (like `int`, `DateTime`). | **Slower for value types**. Requires boxing/unboxing on every read and write. |
| **Missing Keys** | Throws a `KeyNotFoundException` if you look up a key that doesn't exist. | Returns `null` if a key doesn't exist. |
| **Namespace** | `System.Collections.Generic` | `System.Collections` |
| **Thread Safety** | Requires external synchronization (`lock` or `ConcurrentDictionary`). | Supports a thread-safe wrapper via `HashTable.Synchronized()`. |
