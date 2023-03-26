# Итоговая проверочная работа по 1 блоку.

>## Контрольная работа по итогу прохождения первого блока обучения.

### *__Задача:__ Из имеющегося массива строк сформировать массив из строк, длина которых <= 3 символа.*


### 1. Блок схема алгоритма.
![image]()

### 2. Описание решения 

*Получение данных массива*
- Ввод длины массива
- Ввод строк массива с клавиатуры

*Получение нового массива по условию*
- Переборка строк, получение длины нового массива
- Переборка строк, составление массива (выбор строк меньше или равно 3 символа)

*Вывод данных*
- Вывод нового массива и массива с ответом

### 3. Решение задачи `код на C#` => [Программа](https://github.com/RomanKhaykichev/First-block/blob/main/Program.cs)

*__Функции:__ Получение данных массива*

```
int Print(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

string PrintString(string message)
{
    Console.Write(message);
    return Convert.ToString(Console.ReadLine());
}

string[] FillArray(int lenght)
{
    string[] array = new string[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = PrintString($"Введите строку массива {i + 1}: ");
    }
    return array;
}

```
*__Функции:__ Получение нового массива по условию*
```
```
*Вывод данных*
```
```
