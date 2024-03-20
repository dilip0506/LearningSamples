import snap
from snap import *
T = LoadEdgeList(PNGraph, "facebook_combined.txt", 0, 1)
u=snap.TIntV()
for i in T.Nodes():
    u.Add(i.GetId())
u1 = snap.TIntV()
for j in T.Edges():
    u1.Add(j.GetSrcNId())
di = snap.GetBfsFullDiam(T,5)
ef = snap.GetClustCf(T)
print 'Total no of nodes',u.Len()
print 'Total no of edges',u1.Len()
print 'diameter',di
print 'cluster coefficient',ef
##for p in T.Nodes():
##	print "node id %d out degree %d in degree %d" % (p.GetId(), p.GetOutDeg(), p.GetInDeg())
##for q in T.Edges():
##	print "edge (%d, %d)" % (q.GetSrcNId(), q.GetDstNId())
##for r in T.Nodes():
##	for Id in r.GetOutEdges():
##		print "edge (%d %d)" % (r.GetId(), Id)
##snap.DrawGViz(T, snap.gvlDot, "facebook.png", "Facebook",T)
