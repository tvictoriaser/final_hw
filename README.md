# ***Итоговая проверочная работа***

1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

## ***Задача***

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

*Примеры:*

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]
 
["Russia", "Denmark", "Kazan"] -> []

## ***Решение***

**Метод CreateStringArray**

Изначально задаём вручную первоначальный массив. Также будем его выводить на экран с помощью метода **PrintArray** для наглядности.

**Метод FindCountElementsNewArray**
   * *Инициализируем вспомогательную переменную count = 0, в которую запишем количество элементов, длина которых строго меньше 4 символов. Далее эту переменную будем использовать для задания длины нового массива.*

   * *Вычисляем количество строк, длина которых строго меньше 4 символов.*
  
**Метод NewArray**
   * *Инициализируем массив результатов размером count.*

*  *Формируем массив с результатами.*

**Метод PrintArray**

 * *Выводим массив результатов в консоль*