/* Write your T-SQL query statement below */
select b.score, a.rank
from Scores b
INNER JOIN (SELECT 
              score,
             RANK() OVER(ORDER BY score DESC) rank
            FROM Scores
            GROUP BY  score) a ON 
  a.score = b.score 
order by score desc
