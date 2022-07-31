/* Write your T-SQL query statement below */

SELECT stock_name, SUM(CASE WHEN operation='Buy' THEN -price ELSE price end ) capital_gain_loss
FROM Stocks
GROUP BY stock_name
