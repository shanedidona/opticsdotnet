(* ::Package:: *)

Table1=Table[
	Table[
		Get[f1,Method->"String"]
	,{f1,StringSplit[Import[f]]}]
,{f,FileNames["*.txt","C:\\Users\\shane\\opticsdotnet\\Tasks\\ThorlabsCatalogBestForm"]}];

TableForm[Sort[Table1,#1[[1]]<#2[[1]]&]]
