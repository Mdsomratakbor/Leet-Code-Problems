
;with HIGHTSALARYEMPLOYEE as  
   (  
      SELECT departmentId, max(salary) salary
       from Employee
       group by departmentId
    )  

select d.name as Department, e.name Employee, e.salary Salary
from employee e
inner join HIGHTSALARYEMPLOYEE eb on eb.departmentId = e.departmentId and eb.salary = e.salary
inner join Department d on d.id = eb.departmentId
order by eb.departmentId
