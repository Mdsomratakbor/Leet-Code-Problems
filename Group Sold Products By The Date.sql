WITH TMP AS (
SELECT DISTINCT sell_date, product
FROM Activities)

SELECT sell_date, 
       count(product) num_sold, 
       Stuff((SELECT  ',' + product      
              FROM   TMP  t2 
              WHERE  t2.sell_date = t1.sell_date 
              order by product 
              FOR XML PATH('')), 1, 1, '') [products] 
FROM   TMP  t1 
GROUP  BY sell_date
