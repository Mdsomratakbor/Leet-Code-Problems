/* Write your T-SQL query statement below */
SELECT a.id from Weather a, Weather b 
where     
 a.temperature>b.temperature and  datediff(day, b.RecordDate, a.RecordDate) =  1
