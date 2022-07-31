/* Write your T-SQL query statement below */
select name Customers from customers a 
left join orders b on a.id = b.customerid
where b.customerId  is null
