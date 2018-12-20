using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace RakutenLib
{
    static public class RakutenCSV
    {
        const string topText = "1,3\n";
        const int limitCode = 39;
        //{0}:count {1}:ループint {2}:１(全角数字)
        const string writeLineTitle = "{0},{1},1,登録銘柄{2}\n";
        //{0}:code {1}:会社名
        const string writeLineCodeText = "STK,{0},{1},1,,,,,0,1,0,0.0000,0,,,,,,\n";

        static public void OutPutRakutenCSV(ICollection<int> codeList, string filePath)
        {
            using (var sw = new StreamWriter(filePath, false, Encoding.GetEncoding("shift_jis")))
            {
                sw.Write(topText);
                var remainingCount = codeList.Count();
                int codeListIndex = 0;
                var codeListEntity = codeList.ToList();
                for (int i = 0; i < 10; i++)
                {
                    //銘柄登録数の計算
                    var count = (remainingCount / limitCode >= 1) ? limitCode : remainingCount;
                    remainingCount = remainingCount - limitCode;
                    if(count <= 0)
                    {
                        count = 0;
                    }
                    sw.Write(writeLineTitle, count, i, Microsoft.VisualBasic.Strings.StrConv((i+1).ToString(), VbStrConv.Wide));
                    if(count <= 0)
                    {
                        continue;
                    }
                    for (int roopCount = 0; roopCount < count; codeListIndex++,roopCount++ )
                    {
                        sw.Write(writeLineCodeText, codeListEntity[codeListIndex], "");
                    }
                }
            }                
        }
    }
}
