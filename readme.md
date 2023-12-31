## Все эндпоинты могут возвращать DTO в виде JSON.

```csharp
return Ok(new
{
    data = result
});
// или в любой другой форме DTO.
```


## Реализовать приложение C#, которое предоставит функционал сложения каждого второго нечетного числа из массива чисел тела запроса и вернёт их сумму по модулю.

Проект [LogicMicroservice](/src/LogicMicroservice/)

Задание выполнено используя LINQ метода Where. Сначала были получены все нечетные числа:
```csharp
int[] oddNums = numbers.Where(n => n % 2 != 0).ToArray();
```
А затем произведено их сложение и возвращен ответ по модулю (Math.Abs):
```csharp
for (int i = 1; i < oddNums.Length; i += 2)
{
    sum += oddNums[i];
}
```
Реализация задания представлена в файле [SummaryService.cs](/src/LogicMicroservice/Services/SummaryService.cs)

Проект [ViewMicroservice](src/ViewMicroservice/) отображает ответ в виде JSON.


## Реализовать приложение C#, которое предоставит функционал определения входящий строки на предмет, является ли она палиндромом.

Проект [LogicMicroservice](/src/LogicMicroservice/)



Реализация представлена в файле [PalindromService.cs](/src/LogicMicroservice/Services/PalindromeService.cs)

Проект [ViewMicroservice](src/ViewMicroservice/) отображает ответ в виде JSON.

### Реализовать приложение C#, которое отсортирует и выведет список целых чисел. Алгоритм сортировки, а также структуру данных, в которой будет производиться сортировка – необходимо написать самостоятельно. Если используется более одной структуры – необходимо написать самостоятельно только одну на выбор. Алгоритм сортировки можно взять любой, (быстрая, пузырьковая, вставками и т.д.), структуру данных так же можно взять любую (лист любого вида, словарь, дерево любого вида и т.д.).

Реализация представлена в файле [SortService.cs](/src/LogicMicroservice/Services/SortService.cs)

Проект [ViewMicroservice](src/ViewMicroservice/) отображает ответ в виде JSON.