var name = "Kamil";
var gender = 'M';
var myAge = 3;
if  (gender != 'M' && myAge<30)
{
    Console.WriteLine("Kobieta ponizej 30");
}
else if (name == "Ewa" && myAge == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == 'M' && myAge < 18)
{
    Console.WriteLine("niepelnoletni mezczyzna");
}
else
{
    Console.WriteLine("");
}