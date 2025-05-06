(* ::Package:: *)

var1=Association[];
InputForm[var1]


var1["a"]="b";
InputForm[var1]


var1["a1"]="b1";
InputForm[var1]


var1["a2"]=Circle[{3,2},4];
InputForm[var1]


T1=Table[
	Get[f,Method->"String"]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-54\\ODN-54.txt"],"\n"]}]

T1[[2]]["Circle1"]



