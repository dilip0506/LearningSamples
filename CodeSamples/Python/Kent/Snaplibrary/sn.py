import snap
from snap import *
G1 = TNGraph.New()
G1.AddNode(1)
G1.AddNode(5)
G1.AddNode(32)
G1.AddEdge(1,5)
G1.AddEdge(5,1)
G1.AddEdge(5,32)
G2 = GenRndGnm(PNGraph, 100, 1000)
#traverse the nodes
for NI in G2.Nodes():
	print("node id %d with out-degree %d and in-degree %d" % (NI.GetId(), NI.GetOutDeg(), NI.GetInDeg()))
# traverse the edges
for EI in G2.Edges():
	print("edge (%d, %d)" % (EI.GetSrcNId(), EI.GetDstNId()))
# traverse the edges by nodes
for NI in G2.Nodes():
	for Id in NI.GetOutEdges():
		print("edge (%d %d)" % (NI.GetId(), Id))
snap.DrawGViz(G2, snap.gvlDot, "G1.png", "G1",G2)
