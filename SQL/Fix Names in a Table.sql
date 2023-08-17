/* Write your T-SQL query statement below */
SELECT user_id, CONCAT(UPPER(SUBSTRING(NAME, 1,1)), LOWER(SUBSTRING(NAME, 2, LEN(NAME)-1))) name
FROM Users
order by user_id
