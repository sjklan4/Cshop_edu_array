--model, modelname, ALC, 부품명, 부품번호, 색상
select P.model,M.modelname ,P.ALC, A.부품명, A.부품번호, A.색상 
from processtable P INNER JOIN printsystemtable M ON P.model=M.model	
					INNER JOIN partchtable A ON P.ALC=A.ALC