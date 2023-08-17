/* Write your T-SQL query statement below */
SELECT firstName, lastName, city, state   from   Person  a
LEFT JOIN Address b on a.personId = b.personId
