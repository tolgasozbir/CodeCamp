Select Products.ProductName AS 'Ürün Adı', Sum([Order Details].UnitPrice * [Order Details].Quantity) AS 'Toplam Kazanç'
from Products inner join [Order Details] on Products.ProductID = [Order Details].ProductID
inner join Orders on Orders.OrderID = [Order Details].OrderID
group by Products.ProductName
order by 'Toplam Kazanç' asc