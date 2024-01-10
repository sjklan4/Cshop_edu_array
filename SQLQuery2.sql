	SELECT Pr.model,M.modelname,Pr.ALC,Pt.PartName,Pt.PartNum,Pt.PartColor
			FROM processtable as Pr
			INNER JOIN printsystemtable as M ON Pr.model = M.model
			INNER JOIN partchtable as Pt ON Pr.ALC = Pt.ALC
			;