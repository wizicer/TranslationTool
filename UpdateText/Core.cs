using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var r = new Regex("^#+(?<name>.*)");
            var rr = new Regex(@"<!--\s#+(?<name>.*)");
            var ss = source.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
                .Aggregate(new List<string>(), (a, cur) =>
                {
                    if (r.Match(cur).Success)
                    {
                        a.Add(cur);
                        return a;
                    }

                    if (a.Count > 0) a[a.Count - 1] += Environment.NewLine + cur;
                    return a;
                })
                .Where(_ => !string.IsNullOrEmpty(_))
                .Select(_ => new Section(r.Match(_).Groups["name"].Value, _))
                .ToArray();

            var ts = currentTranslation.Split(new string[] { Environment.NewLine }, StringSplitOptions.None)
                .Aggregate(new List<string>(), (a, cur) =>
                {
                    if (cur == "<!--")
                    {
                        a.Add(cur);
                        return a;
                    }

                    if (a.Count > 0) a[a.Count - 1] += Environment.NewLine + cur;
                    return a;
                })
                .Where(_ => !string.IsNullOrEmpty(_))
                .Select(_ => new Section(r.Match(_).Groups["name"].Value, _))
                .ToArray();

            return string.Join("\r\n\r\n", ss.Select(_ => $"<!--\r\n{_.Content}\r\n-->"));

        }
        [DebuggerDisplay("{Title}")]
        private class Section
        {
            public string Title { get; set; }
            public string Content { get; set; }
            public Section(string title, string content)
            {
                this.Title = title;
                this.Content = content;
            }
        }
    }
}
