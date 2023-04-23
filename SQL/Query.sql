/* 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.
*/

SELECT p.name AS 'Продукт', c.Name AS 'Категория' FROM Products p
 LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
 LEFT JOIN Categories c ON pc.CategoryId = c.Id