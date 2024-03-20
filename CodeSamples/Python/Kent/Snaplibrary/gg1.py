import snap
from snap import *
#GG=snap.GenGrid(snap.PUNGraph,4,3)
GG=snap.GenTree(snap.PUNGraph,4,2)
snap.DrawGViz(GG, snap.gvlDot, "G1.png", "GG",GG)
