//
// Домашнее задание к занятию 12. Модификатор static.
//
// Задача 1. Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
// метод, определяющий длину окружности по заданному радиусу;
// метод, определяющий площадь круга по заданному радиусу;
// метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
//
using DZ12;
// Задаем раиус r
double r;
Console.Write("Введите радиус r=");
while (!double.TryParse(Console.ReadLine(), out r))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
Console.WriteLine();
// Вычисляем длину окружности
double length = Circle.GetLength(r);
Console.WriteLine("Длина окружности \t {0}", length-length%0.01);
// Вычисляем площадь круга
double square = Circle.GetSquare(r);
Console.WriteLine("Площадь круга \t\t {0}", square-square%0.01);
Console.WriteLine();
// Задаем координату точки Х
double x;
Console.Write("Введите координату точки Х=");
while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
// Задаем координату точки Y
double y;
Console.Write("Введите координату точки Y=");
while (!double.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
// Задаем координату центра круга Х0
double x0;
Console.Write("Введите координату точки Х=");
while (!double.TryParse(Console.ReadLine(), out x0))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
// Задаем координату центра круга У0
double y0;
Console.Write("Введите координату точки Y=");
while (!double.TryParse(Console.ReadLine(), out y0))
{
    Console.WriteLine("Ошибка ввода! Введите целое число");
}
Console.WriteLine();
// Проверяем, лежит ли точка в круге
Console.WriteLine(Circle.GetRadius(r, x, x0,y,y0));
Console.ReadKey();


