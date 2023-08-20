select a.name,  bonus
 from Employee a
left  join Bonus b on b.empId = a.empId
where b.bonus<1000  or b.bonus is null