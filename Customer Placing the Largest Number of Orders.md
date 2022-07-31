 SELECT TOP 1 customer_number FROM(
 SELECT customer_number,  COUNT(customer_number) AS number 
          FROM Orders customer_number
       GROUP BY customer_number 
       ) y
      ORDER BY number DESC
      
      
 // Without Subquery 
 
  
    SELECT top 1 customer_number 
    FROM Orders
    GROUP BY customer_number
    ORDER BY COUNT(customer_number) DESC
      
      
