# Описание решения задачи по итоговой контрольной работе основного блока

Данная задача решается в несколько этапов, описание которых приведено ниже:

## 1. Задание пользователем размерности первоначального массива
В консоль выводится сообщение о необходимости ввести размерность массива. После чего пользователь вводит значение, которые проверяется на правильность введения при помощи отдельного метода, котроый при помощи метода TryParse проверяет введено ли число. Если пользователь ввел не числовое значение, а буквенное, то программа предложит ему повторить ввод.

## 2. Создание первначального массива и заполнение его пользователем
Для каждого элемента массива в консоль выводится сообщение о необходимости введения значение i-го элемента массива. По завершению ввода значений всех элементов массива программа автоматически перейдет к исполнению следующего этапа. При этом для удобства проверки правильности работы программы на данном этапе выполняется вывод полученного массива в консоль (вывод осуществляется в соответствии с п. 5 данного документа).

## 3. Определение количества элементов в массиве значение которые меньше или равно 3 символам
Определение количества элементов массива значение которых меньше или равно 3 символам выполняется отдельным методом, который перебирает элементы массива и при нахождении искомого увеличивает значение счетчика. Результат выполнения метода записывается в переменную, которая будет использоваться в следующем этапе.

## 4. Создание нового массива и копирование в него элементов первоначального массива значение которых меньше или равно 3 символам
Данный этап выполняется при помощи отдельного метода, в который передается размерность (опредленная в предыдущем этапе), а также первоначальный массив. Метод перебират все элементы первоначального массива и проверяет на условие что значение выбранного элемента первоначального массива меньше или равно 3 символам, при успешной проверке значение копируется в новый массив и после чего увеличиваются счетчики первоначального и нового массива, а если проверка проверка прошла не успешно, то в это случае увеличивается только счетчик первоначлаьного массива.

## 5. Вывод массивов в консоль.
Вывод массивов в консоль осуществляется отдельным методом. В метод в качетсве аргумента передается массив, который необходимо вывести в консоль. Вывод осуществляется путем перебора всех эелементов массива и вывод каждого по отдельности в соответствующем формате.