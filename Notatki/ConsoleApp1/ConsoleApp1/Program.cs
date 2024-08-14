


int[] Grades = new int[5];
//string[] DayOfWeek = new string[7];

// List<string> DayOfWeek = new List<string>();
//   DayOfWeek.Add("poniedzialek");
//   DayOfWeek.Add("Wtorek");
//   DayOfWeek.Add("Sroda");
//   DayOfWeek.Add("Czwartek");
//   DayOfWeek.Add("piatek");
//   DayOfWeek.Add("sobota");
//   DayOfWeek.Add("niedziela");
//Console.WriteLine (DayOfWeek[2]);

//String[] dayofweek2 = { "poniedzialek", "wtorek", "sroda", "czwartek", "piatek", "sobota", "niedziela" };
//Console.WriteLine(dayofweek2[2]);

//for(int i = 0; i<7; i=i+1)
//for (var i = 0; i < DayOfWeek.Count; i++)
//   { Console.WriteLine(DayOfWeek[i]); }

int number = 4566;



String numberInString = number.ToString();

char[] letters = numberInString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char letter in letters)
{
    if (letter == '0')
    { counter0 = counter0 + 1; }
    else if (letter == '1')
    { counter1++; }
    else if (letter == '2')
    { counter2++; }
    else if (letter == '3')
    { counter3++; }
    else if (letter == '4')
    { counter4++; }
    else if (letter == '5')
    { counter5++; }
    else if (letter == '6')
    { counter6++; }
    else if (letter == '7')
    { counter7++; }
    else if (letter == '8')
    { counter8++; }
    else if (letter == '9')
    { counter9++; }

}
Console.WriteLine(number);

Console.WriteLine("How many 0:" + counter0);
Console.WriteLine("How many 1:" + counter1);
Console.WriteLine("How many 2:" + counter2);
Console.WriteLine("How many 3:" + counter3);
Console.WriteLine("How many 4:" + counter4);
Console.WriteLine("How many 5:" + counter5);
Console.WriteLine("How many 6:" + counter6);
Console.WriteLine("How many 7:" + counter7);
Console.WriteLine("How many 8:" + counter8);
Console.WriteLine("How many 9:" + counter9);




