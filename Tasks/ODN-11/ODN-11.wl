(* ::Package:: *)

Table[
	Get[f,Method->"String"]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-11\\ODN11_1.txt"]]}]
