/* Write your T-SQL query statement below */

select a.customer_id, count(a.visit_id)   count_no_trans  from 
Visits a
where a.visit_id not in (select visit_id from transactions)
group by a.customer_id