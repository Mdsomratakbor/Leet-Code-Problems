SELECT a.user_id buyer_id, join_date , ISNULL( orders_in_2019,0)orders_in_2019  
FROM Users A
LEFT JOIN (
    SELECT user_id, COUNT(order_id)  orders_in_2019
    FROM Users u
    FULL JOIN Orders o ON o.buyer_id = u.user_id
    WHERE YEAR(order_date) = 2019
    GROUP BY user_id
    )  B ON B.user_id = A.user_id        
