SELECT B.product_name, A.year, A.price FROM 
Sales A 
INNER JOIN Product B on B.product_id = A.product_id
