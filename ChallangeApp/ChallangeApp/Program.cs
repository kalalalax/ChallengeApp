using System.ComponentModel.Design;

string gender = "female";
var name = "Lola";
var age = 66;

if (gender == "female" && age < 30)
{
    Console.WriteLine("Kobieta ponizej 30 lat");
}
else if (name == "Ewa" && age == 30)
    {
    Console.WriteLine("Ewa, lat 30");
    } 
else if (gender == "male" && age < 18)
{
    Console.WriteLine("Niepelnoletni mezczyzna");
}     