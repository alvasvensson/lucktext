

string name;
string favouriteAnimal;
string favouriteSnack;
string hateAnimal;
string favouriteDay;


Console.WriteLine("what's your name?");
name = Console.ReadLine();



Console.WriteLine($"Welcome {name}! Whats your favourite animal?");

favouriteAnimal = Console.ReadLine();

Console.WriteLine("What is your favourite snack?");

favouriteSnack = Console.ReadLine();

Console.WriteLine("What animal do you hate or are scared of?");

hateAnimal = Console.ReadLine();

Console.WriteLine("What is your favourite day of the week?");

favouriteDay = Console.ReadLine();

if (name == "alva")
{

    Console.WriteLine($"I hope you someday soon get a nice {favouriteDay} where you get to hang out with a {favouriteAnimal} ");
    Console.WriteLine($"and eat lots of {favouriteSnack}  without meeting any {hateAnimal}");
}
if (name == "alva" == false)
{

    Console.WriteLine($"I hope you someday soon don't get a nice {favouriteDay} where you don't get to hang out with a {favouriteAnimal} ");
    Console.WriteLine($"and don't get to eat lots of {favouriteSnack}  but do meet {hateAnimal}");
}

System.Console.WriteLine("hejdå");
Console.WriteLine("Press enter to quit");

Console.ReadLine();
