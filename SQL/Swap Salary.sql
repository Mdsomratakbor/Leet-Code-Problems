/* Write your T-SQL query statement below */
UPDATE SALaRY SET sex = case when sex='m' then 'f' else 'm' end
