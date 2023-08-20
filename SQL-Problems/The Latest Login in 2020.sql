WITH last_login AS (
  SELECT
    user_id, time_stamp last_stamp,
    ROW_NUMBER() OVER(PARTITION BY user_id ORDER BY time_stamp DESC) AS row_number
  FROM Logins
    WHERE YEAR(time_stamp) = 2020
)
SELECT
  user_id, last_stamp
FROM last_login
WHERE row_number = 1;
