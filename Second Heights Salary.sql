SELECT(SELECT distinct salary 
FROM Employee 
ORDER BY salary DESC
OFFSET 1 ROWS 
FETCH NEXT 1 ROWS ONLY)SecondHighestSalary;
