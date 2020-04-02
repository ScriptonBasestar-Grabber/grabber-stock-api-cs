using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.res.tr
{
    // 서버저장조건리스트조회 ( ENCRYPT,BLOCK,HEADTYPE=A )
    struct _t1866InBlock
    {
        public string user_id; // [user_id,    8] 로그인ID                        StartPos 0, Length 8
        public string gb; // [gb,    1] 조회구분                        StartPos 8, Length 1
        public string group_name; // [group_name,   40] 그룹명                          StartPos 9, Length 40
        public string cont; // [cont,    1] 연속여부                        StartPos 49, Length 1
        public string cont_key; // [cont_key,   40] 연속키                          StartPos 50, Length 40
    }

    struct _t1866OutBlock
    {
        public long result_count; // [result_count  ,    5] 저장조건수                      StartPos 0, Length 5
        public string cont; // [cont,    1] 연속여부                        StartPos 5, Length 1
        public string cont_key; // [cont_key,   40] 연속키                          StartPos 6, Length 40
    }

    struct _t1866OutBlock1
    {
        public string query_index; // [query_index,   12] 서버저장인덱스                  StartPos 0, Length 12
        public string group_name; // [group_name,   40] 그룹명                          StartPos 12, Length 40
        public string query_name; // [query_name,   40] 조건저장명                      StartPos 52, Length 40
    }
}