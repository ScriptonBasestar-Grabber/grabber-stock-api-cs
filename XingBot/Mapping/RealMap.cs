using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XingBot.real.Mapping
{
    //TODO 이거못씀. 설정값 가져오는 방식으로 변경
    class RealMap
    {
        Dictionary<string, MappingRowModel> futures = new Dictionary<string, MappingRowModel>();

        RealMap()
        {
            futures.Add("FC0", MappingRowModelBuilder.Create().InBlock(
                    Tuple.Create("futcode", typeof(string))
                ).OutBlock(
                    Tuple.Create("chetime", typeof(string)),
                    Tuple.Create("sign", typeof(string)),
                    Tuple.Create("sign", typeof(float)),
                    Tuple.Create("change", typeof(float)),
                    Tuple.Create("drate", typeof(float)),
                    Tuple.Create("price", typeof(float)),
                    Tuple.Create("open", typeof(float)),
                    Tuple.Create("high", typeof(float)),
                    Tuple.Create("low", typeof(float)),
                    Tuple.Create("cgubun", typeof(long)),
                    Tuple.Create("cvolume", typeof(long)),
                    Tuple.Create("volume", typeof(long)),
                    Tuple.Create("value", typeof(long)),
                    Tuple.Create("mdvolume", typeof(long))
                )
                .Build()
            );
        }
    }
}