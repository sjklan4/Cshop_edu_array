exec up_Factoring_Manage
@cMode = 'select_processtable';

SELECT * FROM processtable;

select model,modelname, pat.ALC,pat.��ǰ��,pat.��ǰ��ȣ,pat.����
from processtable as prt
inner join partchtable as pat
 on prt.ALC = pat.ALC;




 select model,ALC,��ǰ��,��ǰ��ȣ,����
 from processtable;