SELECT DISTINCT A.product_id, product_name
FROM Product A
INNER JOIN Sales B ON B.product_id = A.product_id 
WHERE  A.product_id NOT IN (
 SELECT product_id FROM Sales WHERE sale_date>'2019-03-31' OR sale_date<'2019-01-01' 
 )
