/* Write your T-SQL query statement below */
select b.product_name, a.year, a.price from Sales a, Product b
where  b.product_id  = a.product_id 