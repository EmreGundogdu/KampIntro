select * from Customers
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

select * from Customers where City = 'Berlin'

select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>10

select * from Products order by ProductName /*ProductName göre sıraldık*/
select * from Products order by CategoryID,SupplierID /*CategoryID göre sıraldık*/

select * from Products where CategoryID=1 order by UnitPrice desc  --ascending  --descending

select count(*) from Products where CategoryID=2

select categoryId,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select * from Products inner join Categories on Products.CategoryID = Categories.CategoryID
--DTO Data Transformation Object

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID
select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null --solda olup sağda olmayanları da getir
select * from Orders o right join Customers c on c.CustomerID = o.CustomerID where o.CustomerID is null --sağda olup solda olmayanları da getir