**Решение:**

В данном решении первоначальный массив вводится пользователем с клавиатуры. Сначала просим пользователя ввести количество строк в массиве. Вызываем метод *InputNumber()*, который проверяет корректность ввода. Введённое значение записываем в переменную *size* - размер массива. После этого пользователь вводит строки, которые записываются в массив *strings* при помощи метода *GetArray(size)*. 

Выводим созданный массив с помощью метода *PrintArray()*. 

Формируем новый пустой массив для хранения коротких строк:

 *string[] shortStrings = new string[0];*

В цикле *for* пробегаем по всем элементам массива, вводим переменную *elem* для хранения значения текущего элемента массива. Если длина этого элемента (строки) меньше либо равна 3, то изменяем размер нового массива:

  *Array.Resize(ref shortStrings, newSize)*.

Добавляем элемент в новый массив и увеличиваем размер этого массива:

*shortStrings[newSize - 1] = elem;*

*newSize++;*

По завершении цикла *for* заменяем ссылку со старого на новый массив и выводим получившийся результат, используя метод *PrintArray().*