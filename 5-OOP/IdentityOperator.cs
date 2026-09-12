#:property PublishAOT=false
Animal myPet = new Cat();

Dog? myDog = myPet as Dog;
if (myDog != null)
{
    Console.WriteLine("Successfully cast to Dog.");
}
else
{
    Console.WriteLine("Conversion failed.");
}


class Animal {}
class Dog : Animal {}
class Cat : Animal {}



