
SELECT name NAME,SUM(amount)  BALANCE
from  Users A
INNER JOIN Transactions B ON B.account  = A.account 
GROUP BY name
HAVING SUM(amount)>=10000
