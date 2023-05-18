using System.Reflection.Metadata;

namespace Ukesoppgave_3;

public class Pet
{
    private string _name;
    private int _age;
    private string _type;

    public Pet(string name, int age, string type)
    {
        _name = name;
        _age = age;
        _type = type;
    }

    public void Feed(string food)
    {
        Console.WriteLine($"Thank you for the food, i do like {food} but prefer something else");
    }
    public void Feed(string food, bool isFavoriteFood)
    {
        Console.WriteLine($"Thank you for the food, {food} is my favorite!");
    }
}