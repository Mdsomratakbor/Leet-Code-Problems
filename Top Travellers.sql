SELECT name,  ISNULL(travelled_distance, 0 ) travelled_distance  
FROM Users a
LEFT JOIN ( 
    SELECT user_id, SUM(distance) travelled_distance
    FROM Rides 
    GROUP BY user_id
) b on b.user_id  = a.id
ORDER BY travelled_distance DESC, a.name ASC
