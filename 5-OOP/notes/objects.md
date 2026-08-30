# OOP

- OOP is short for object oriented programming a programming paradigm for building Complex project with ease
- OOP considers everything as an object which has attribute, properties and methods and also OOP connects between objects and reality
  - consider a college as an example for an OOP representations
- OOP composes of a set of rules and two main functional components {Classes, Objects} as well as a bunch of secondary components like interfaces
- in short everythingg is an object in the paradigm's view

## classes

- a class is a blue print for object or in other word the base in which we build our objects
- it's considered a reference type which have been discussed in variable section
- it's can be used as user defined type just like `string int char`
- it defines how object will act and what will it store
- it can be inhireted from and to other classes

## objects

- an object is instance of the class
- it has set of methods, properties and attributes.
- an object is created by using the `new` Keyword which allocates memory for our object like this
  
  ```c#
  Random numGen = new Random();
  // you can create the same object using the simplified version
  Random numGen = new();
  ```
  
  > in other simple term ``creat an object from [Random] `Random numGen` that matches the same blueprint aka instruction and attribute of [Random] `new Random()` ``
