select b.unique_id, a.name from Employees a
left join EmployeeUNI b on b.id = a.id