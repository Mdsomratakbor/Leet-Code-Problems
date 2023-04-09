SELECT A.project_id, ROUND( AVG(B.experience_years),2) average_years 
FROM Project A
left JOIN Employee B ON B.employee_id = A.employee_id 
GROUP BY A.project_id  
