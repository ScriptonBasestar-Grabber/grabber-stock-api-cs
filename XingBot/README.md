XingBot
=======


## Memo

Xing cpp.h º¯È¯½Ã
```txt
^\s+char\s(\w+)\[\d+\];\s+(\/\/\s+\[)(\w+)

public $3 $1; $2$3

^(\s+)?char\s+(\w+)(\s+)?\[(\s+)?\d+\];\s+char\s+\w+(\s+)?;(\s+)?(\/\/(\s+)?\[)(\w+)

public $9 $2; $7$9
```