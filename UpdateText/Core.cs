using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UpdateText
{
    public class Core
    {
        public static string Update(string source, string currentTranslation)
        {
            var ss = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
                .Aggregate(new List<string>(), (a, cur) =>
                {
                    var r = new Regex("^#+.*");
                    if (r.Match(cur).Success)
                    {
                        a.Add(cur);
                        return a;
                    }

                    var last = a.Count - 1;
                    a[last] = a[last] + Environment.NewLine + cur;
                    return a;
                })
                .Where(_ => !string.IsNullOrEmpty(_))
                .ToArray();

            return string.Join("\r\n\r\n", ss.Select(_=>$"<!--\r\n{_}\r\n-->"));
        }
    }
}
