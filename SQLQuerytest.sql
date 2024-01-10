exec up_Factoring_Manage
@cMode = 'select_processtable';

SELECT * FROM processtable;

select model,modelname, pat.ALC,pat.부품명,pat.부품번호,pat.색상
from processtable as prt
inner join partchtable as pat
 on prt.ALC = pat.ALC;




 select model,ALC,부품명,부품번호,색상
 from processtable;