XingBot
=======


## Memo

Xing cpp.h 변환시
```txt
cpp header 붙여넣을 때
^\s+char\s(\w+)\[\d+\];\s+(\/\/\s+\[)(\w+)

public $3 $1; $2$3


^(\s+)?char\s+(\w+)(\s+)?\[(\s+)?\d+\];\s+char\s+\w+(\s+)?;(\s+)?(\/\/(\s+)?\[)(\w+)

public $9 $2; $7$9

뒷쪽 테스트 수정
^(\s+outData.)(\w+)(\s+=\s)([\w.]+\()?(_RealDict\[szTrCode\]\.GetFieldData\(["\w]+,\s\")(\w+)(\"\)\)?;)

$1$2$3$4$5$2$7

```
