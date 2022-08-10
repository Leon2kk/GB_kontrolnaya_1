# Итоговая проверочная работа

## Ссылка на GitHUB
[Проверочная работа](https://github.com/Leon2kk/GB_kontrolnaya_1.git)

## Задача
Из имеющего массива строк, получить массив где длина элементов меньше или равно 3 символам.

[hello, 2, world, :-)] -> [2, :-)]

### Алгоритм
    1. Проходим по массиву циклом.
    2. Проверяем каждый элемента на кол-во символов.
    3. Если в элементе количество символов 3 или меньше, то этот элемент записываем в результирующий массив.
    4. Выводим результат.

### Блок-Схема
![Блок-схема](https://github.com/Leon2kk/GB_kontrolnaya_1/blob/master/shema_kr1.jpg)

### Программный код на ЯП C# 6.0
```sh
string[]  mas = new string[] {"hello", "2", "world", ":-)"},
          res = new string[mas.Length];
            
            int i = 0;
            foreach(string item in mas)
            {
                if (item.Length <= 3)
                {
                    res[i++] = item;
                }
            }

            // удаляем Null элементы
            res = res.Where(item => item != null).ToArray();
```

[Ссылка на Program.cs](https://github.com/Leon2kk/GB_kontrolnaya_1/blob/master/Program.cs)
