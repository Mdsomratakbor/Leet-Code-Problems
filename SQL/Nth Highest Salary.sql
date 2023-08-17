CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        SELECT salary from  (
        
            SELECT distinct salary 
            FROM Employee 
            ORDER BY salary desc
            OFFSET @N-1 ROWS
            FETCH NEXT 1 ROWS ONLY
        ) as p
        
    );
END
