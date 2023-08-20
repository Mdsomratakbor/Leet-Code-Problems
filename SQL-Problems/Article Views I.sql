select distinct a.author_id id
from Views a
where a.author_id=a.viewer_id 
