(* ::Package:: *)

Solve[
		{
			0==2*A3*xp+A5+A6*yp,
			0==2*A2*yp+A4+A6*xp
		}
	,{xp,yp}]



Table[
	Graphics[Get[f,Method->"String"]]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-48\\ODN48_1.txt"]]}]
