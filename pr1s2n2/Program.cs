/*группа студентов сдает экзамен. определить средний балл и количество оценок 5, 4, 3, 2 в абсолюьном и процкнтном соотношении*/
Random r = new Random();
Console.WriteLine("Введите количество человек");
bool fl = false;
int n = 0;
string strn;
List<int> list = new List<int>();
while (!fl)
{
    strn = Console.ReadLine();
    fl = int.TryParse(strn, out n);
}
for (int i = 0; i < n; i++)
{
    int value = r.Next(6);
    list.Add(value);
}
double sum = 0;
int a2 = 0, a3 = 0, a4 = 0, a5 = 0;
for (int i = 0; i < list.Count; i++)
{
    sum += list[i];
    switch (list[i])
    {
        case 2: a2 += 1; break;
        case 3: a3 += 1; break;
        case 4: a4 += 1; break;
        case 5: a5 += 1; break;
        default: continue;
    }
}
double cz = sum / n;
Console.WriteLine("среднее значение " + cz);
Console.WriteLine("курсанты, которые получили 2 " + a2 + "/" + n);
Console.WriteLine("курсанты, которые получили 3 " + a3 + "/" + n);
Console.WriteLine("курсанты, которые получили 4 " + a4 + "/" + n);
Console.WriteLine("курсанты, которые получили 5 " + a5 + "/" + n);

Console.WriteLine("курсанты, которые получили 2 " + a2 * 100.0 / n+ "%");
Console.WriteLine("курсанты, которые получили 3 " + a3 * 100.0 / n+ "%");
Console.WriteLine("курсанты, которые получили 4 " + a4 * 100.0 / n + "%");
Console.WriteLine("курсанты, которые получили 5 " + a5 * 100.0 / n + "%");