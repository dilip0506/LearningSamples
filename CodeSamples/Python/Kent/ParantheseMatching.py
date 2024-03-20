def par(sp):
  sl = []
  pus, pos = "<({[", ">)}]"
  for i in sp :
    if i in pus :
      sl.append(i)
    elif i in pos :
      if not len(sl) :
        return False
      else :
        s_t = sl.pop()
        bb = pus[pos.index(i)]
        if s_t != bb :
          return False
  return not len(sl)
print(par('[()]{}{[()()]()}'))
print(par('[(])'))
