--model, modelname, ALC, ��ǰ��, ��ǰ��ȣ, ����
select P.model,M.modelname ,P.ALC, A.��ǰ��, A.��ǰ��ȣ, A.���� 
from processtable P INNER JOIN printsystemtable M ON P.model=M.model	
					INNER JOIN partchtable A ON P.ALC=A.ALC