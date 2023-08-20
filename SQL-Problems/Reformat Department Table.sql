/* Write your T-SQL query statement below */
SELECT  id,
SUM(CASE WHEN month = 'Jan'  Then revenue Else null end) Jan_Revenue ,
SUM(CASE WHEN month = 'Feb'  Then revenue Else null end) Feb_Revenue ,
SUM(CASE WHEN month = 'Mar'  Then revenue Else null end) Mar_Revenue ,
SUM(CASE WHEN month = 'Apr'  Then revenue Else null end) Apr_Revenue ,
SUM(CASE WHEN month = 'May'  Then revenue Else null end) May_Revenue ,
SUM(CASE WHEN month = 'Jun'  Then revenue Else null end) Jun_Revenue ,
SUM(CASE WHEN month = 'Jul'  Then revenue Else null end) Jul_Revenue ,
SUM(CASE WHEN month = 'Aug'  Then revenue Else null end) Aug_Revenue ,
SUM(CASE WHEN month = 'Sep'  Then revenue Else null end) Sep_Revenue ,
SUM(CASE WHEN month = 'Oct'  Then revenue Else null end) Oct_Revenue ,
SUM(CASE WHEN month = 'Nov'  Then revenue Else null end) Nov_Revenue ,
SUM(CASE WHEN month = 'Dec'  Then revenue Else null end) Dec_Revenue 
FROM Department
GROUP BY ID

