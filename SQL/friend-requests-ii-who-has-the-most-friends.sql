select distinct  top 1 id, count(id) num
from (
 select requester_id as id, accepter_id as freind from RequestAccepted  
    union
select accepter_id as id, requester_id as freind from RequestAccepted 
) x
group by id
order by num desc