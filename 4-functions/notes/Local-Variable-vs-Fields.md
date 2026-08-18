## fields <!-- markdownlint-disable-line -->

fields have the following descritionp

- fields are variables created outside of methods but inside a class
- they have a a class-level scoping which means any method can use it and access it
- they are called also **instance variable**
- to make them in top-level programs you MUST use partial members just like methods as the following of course
  
    > ```c#
    > public partial class Program
    > {
    >     static int number = 67;
    > }
    > ```
    >
    > `static` must be use to avoid instancing the variable and compiler error as will

- they are not considerd as **global variables** since these are accessible through the project itself

## field vs local variable

- both are considered variable and all the rules of variables are applied to both
- local variable are defined at the method-level and the default in top-level programs
- fields are class-level accessible and called **instance variable**
