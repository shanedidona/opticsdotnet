(* ::Package:: *)

x1=x10+a1*Cos[theta1];
y1=y10+a1*Sin[theta1];

dist1Squared=(x1-xp)^2+(y1-yp)^2;
dDist1Squared=D[dist1Squared,a1];

FullSimplify[Solve[dDist1Squared==0,a1]];
a1Min=a1/.FullSimplify[Solve[dDist1Squared==0,a1]][[1,1]];

d1Min=FullSimplify[Sqrt[FullSimplify[dist1Squared/.a1->a1Min]]]


x2=x20+a2*Cos[theta2]
y2=y20+a2*Sin[theta2]

dist2Squared=(x2-xp)^2+(y2-yp)^2;
dDist2Squared=D[dist2Squared,a2];

FullSimplify[Solve[dDist2Squared==0,a2]];
a2Min=a2/.FullSimplify[Solve[dDist2Squared==0,a2]][[1,1]]
a2Min=a2/.FullSimplify[Solve[dDist2Squared==0,a2]][[1]]

d2Min=FullSimplify[Sqrt[FullSimplify[dist2Squared/.a2->a2Min]]]


Exp1=FullSimplify[d1Min^2+d2Min^2]

dx=D[Exp1,xp]
dy=D[Exp1,yp]

Solve[dx==0,xp]
Solve[dy==0,yp]


d1Min
d1Min/.{xp->x2,yp->y2}
ExpCombo=FullSimplify[d1Min/.{xp->x2,yp->y2}]
D[ExpCombo,a2]
"sep"
DExpCombo=FullSimplify[D[ExpCombo,a2]]
DExpCombo=FullSimplify[D[ExpCombo,a2],theta1!=theta2]
DExpCombo=FullSimplify[D[ExpCombo^2,a2],theta1!=theta2]
DExpCombo=FullSimplify[D[ExpCombo^2,a2]]
"sep"
Solve[DExpCombo==0,a2]
a2MinCombo=a2/.Solve[DExpCombo==0,a2][[1]]
FullSimplify[a2MinCombo]


a1/.FullSimplify[Solve[dDist1Squared==0,a1]][[1]]
a1/.FullSimplify[Solve[dDist1Squared==0,a1]][[1,1]]



Table[
	Get[f,Method->"String"]
,{f,StringSplit[Import["C:\\Users\\shane\\opticsdotnet\\Tasks\\ODN-45\\ODN45_1.txt"]]}]
