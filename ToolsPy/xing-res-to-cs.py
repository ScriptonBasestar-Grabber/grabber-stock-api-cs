
fin = open(r"D:\tmp\Res-VC(2016.03.18)\Res\B7_.res")
fout = open(r"", "w")

inblock_scope = false
outblock_scope = false

for line in fin.readlines():
    print(line)
    if line.startswith("begin"):
        continue
    elif line.startswith("InBlock"):
        inblock_scope = true
    elif line.startswith("OutBlock"):
        outblock_scope = true
    elif line.startswith("end"):
        inblock_scope = false
        outblock_scope = false
    if inblock_scope:
        line.split("[,\w]")
        
    fout.write(code)

fin.close()
fout.close()
