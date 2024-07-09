# Shapes Library for Mindbox

1. [**Задание.**](#01)
2. [**Структура проекта.**](#02)
3. [**Результаты работы Unit тестов.**](#03)
4. [**SQL Запрос.**](#04).

## 1. Задание.<a name="01"></a>
```
Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам.
Дополнительно к работоспособности оценим:

Юнит-тесты

Легкость добавления других фигур

Вычисление площади фигуры без знания типа фигуры в compile-time

Проверку на то, является ли треугольник прямоугольным
```
## 2. Структура проекта.<a name="02"></a>
<a href="https://github.com/AlexanderPravin/ShapesLibrary/tree/079d4507ddaeb50ce160d02ed83d23a244625aec/.src/Shapes">.src/Shapes</a> - библиотека, содержащая в себе интерфейсы, фабрики и фигуры;

<a href="https://github.com/AlexanderPravin/ShapesLibrary/tree/079d4507ddaeb50ce160d02ed83d23a244625aec/.test/ShapesLibraryTest">.test/ShapesLibraryTest</a> - проект, содержащий в себе Unit тесты библиотеки;

<a href="https://github.com/AlexanderPravin/ShapesLibrary/tree/079d4507ddaeb50ce160d02ed83d23a244625aec/.src/Shapes/Interfaces">.src/Shapes/Interface</a> - директория, в которой находятся интерфейсы, определяющие контракты для фабрики и фигуры;

<a href="https://github.com/AlexanderPravin/ShapesLibrary/tree/079d4507ddaeb50ce160d02ed83d23a244625aec/.src/Shapes/Figures">.src/Shapes/Figures</a> - директория, которая содержит конкретные реализации IShapes;

<a href="https://github.com/AlexanderPravin/ShapesLibrary/tree/079d4507ddaeb50ce160d02ed83d23a244625aec/.src/Shapes/Factories">.src/Shapes/Factories</a> - директория, которая содержит реализацию абстрактной фабрики;

## 3. Результаты работы Unit тестов. <a name="03"></a>
![image](https://github.com/AlexanderPravin/ShapesLibrary/assets/121981456/8e3d49f3-0da1-4e6b-8fb3-8dc05db33c33)

## 4. SQL Запрос. <a name="04"></a>
```
SELECT 
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID
ORDER BY 
    p.ProductName, 
    c.CategoryName;
```

Где:
1. Таблица с продуктами - Products;
2. Таблица для связи многие ко многим - ProductsCategories;
3. Таблица с категориями - Categories;
