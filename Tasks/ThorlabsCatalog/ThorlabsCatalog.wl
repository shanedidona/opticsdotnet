(* ::Package:: *)

Parse1[lines_]:=Module[
	{line,FileAssoc},
		FileAssoc=Association[];
		
		Do[
			
	
		,{line,lines}]
	]

Table[
	StringSplit[Import[f,"Text"]]


,{f,FileNames["*.txt","C:\\Users\\shane\\opticsdotnet\\Tasks\\ThorlabsCatalog\\Renderings"]}];


a1=Association[]
a1["s"]=1
a1



InputForm["\[CapitalOSlash]"]
Put["\[CapitalOSlash]","C:\\Users\\shane\\opticsdotnet\\Tasks\\ThorlabsCatalog\\test1.txt"]

Read["\[CapitalOSlash]",String]


Pages=Get["C:\\Users\\shane\\opticsdotnet\\Tasks\\ThorlabsCatalog\\Renderings\\Renderings.txt"];
T1=Table[
	Table[
		{row[["Name"]],{Table[Graphics[f],{f,row["AxiOpticalElements"]}]}}
	,{row,page["ThorlabsCatalogSections"]}]
,{page,Pages}];
TableForm[
Flatten[T1,1]
]
