(* ::Package:: *)

TableForm[
Table[
	Table[
		Get[f1,Method->"String"]
	,{f1,StringSplit[Import[f]]}]
,{f,FileNames["*.txt","C:\\Users\\shane\\opticsdotnet\\Tasks\\ThorlabsCatalog"]}]
]
