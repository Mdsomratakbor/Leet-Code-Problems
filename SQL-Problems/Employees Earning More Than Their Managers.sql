/* Write your T-SQL query statement below */
select a.name Employee from employee a
inner join employee b on b.id = a.managerid
where a.salary>b.salary
