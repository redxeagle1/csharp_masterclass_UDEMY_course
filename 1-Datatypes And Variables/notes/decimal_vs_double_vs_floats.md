# decimal vs double vs float

In C#, the primary difference between float, double, and decimal lies in their internal base representation, precision, and performance.
Use double for general science and graphics, decimal for money and finance, and float for memory-constrained systems like mobile 3D graphics.

------------------------------

## Quick Comparison Matrix

| Feature | float | double | decimal |
| --- | --- | --- | --- |
| Size | 32 bits (4 bytes) | 64 bits (8 bytes) | 128 bits (16 bytes) |
| Precision | ~6-7 digits | ~15-16 digits | 28-29 digits |
| Internal Base | Binary (Base 2) | Binary (Base 2) | Decimal (Base 10) |
| Performance | Extremely Fast (Hardware) | Fast (Hardware/Default) | Slower (Software) |
| Literal Suffix | `f` or `F` | None or `d` / `D` | `m` or `M` |
| Best Used For | Mobile games, graphics | Physics, ML, engineering | Money, taxes, bookkeeping |

------------------------------

## Detailed Breakdown## 1. Float (System.Single)

* How it works: It uses standard IEEE 754 binary floating-point representation.
* The Catch: Because it represents numbers in base-2 (binary), it cannot perfectly represent simple base-10 fractions like 0.1. This leads to tiny accumulating rounding errors.
* Syntax:

```c#
float price = 19.99f;
```

## 2. Double (System.Double)

* How it works: This is the default type for any fractional number in C# if you don't add a suffix. Like float, it uses binary math but has twice the memory allocation and vastly better precision.
* The Catch: It still suffers from base-2 rounding anomalies (e.g., 0.1 + 0.2 might equal 0.30000000000000004).
* Syntax:

```c#
double distance = 123.45; (or 123.45d) 
```

## 3. Decimal (System.Decimal)

* How it works: It processes numbers using base-10 math. It eliminates the rounding quirks of binary floating points completely.
* The Catch: Operations are calculated in software rather than directly on your CPU hardware's FPU. This makes it significantly slower than double or float for intense math.
* Syntax:

```c#
decimal balance = 1000.50m;
```

------------------------------

## The Code Example That Proves the Difference

If you run the following code in C#, you can instantly see why using the wrong type breaks financial applications:

```C#
// Binary floating point issuesdouble a = 0.1;double b = 0.2;
Console.WriteLine(a + b); // Outputs: 0.30000000000000004 (Inexact!)
// Exact base-10 calculationdecimal x = 0.1m;decimal y = 0.2m;
Console.WriteLine(x + y); // Outputs: 0.3 (Perfectly exact)
```

## Summary of Rules

* Choose decimal if the project involves adding up dollars, cents, or any values where rounding errors will cause math compliance audits to fail.
* Choose double if you are building calculators, maps, physics tools, machine learning pipelines, or handling giant scientific values.
* Choose float only if you are trying to save memory space while processing millions of small decimal values simultaneously (like point-clouds or 3D vertices).
