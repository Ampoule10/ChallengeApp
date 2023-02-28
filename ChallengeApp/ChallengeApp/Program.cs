string name = "Ewa";
Console.WriteLine(name);
string gender = "female";
Console.WriteLine(gender);
int age = 33;
Console.WriteLine(age);

if (gender == "female" && age < 33)
{
    Console.WriteLine("Kobieta ponizej 30 lat");

}
else
    Console.WriteLine("To nie jest kobieta ponizej 30 lat");

if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else
    Console.WriteLine("To nie jest Ewa, lat 33");

if (age < 18 && gender == "male")
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}
else
    Console.WriteLine("To nie jest niepelnoletni mezczyzna");