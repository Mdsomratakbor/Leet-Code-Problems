SELECT case when b.salary is null then
a.employee_id else b.employee_id end
employee_id
FROM Employees a
FULL JOIN Salaries b on b. employee_id = a.employee_id
WHERE b.salary is null or a.employee_id is null
order by 1
