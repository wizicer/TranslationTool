﻿using System;
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
            source = source.Replace("\r\n", "\n");
            currentTranslation = currentTranslation.Replace("\r\n", "\n");
            var r = new Regex("^#+(?<name>.*)");
            var rr = new Regex(@"<!--\s+#+(?<name>.*)");
            var rc = new Regex(@"-->\s+(?<content>.*)", RegexOptions.Singleline);
            var ss = source.Split(new string[] { "\n" }, StringSplitOptions.None)
                .Aggregate(new List<string>(), (a, cur) =>
                {
                    if (r.Match(cur).Success)
                    {
                        a.Add(cur);
                        return a;
                    }

                    if (a.Count > 0) a[a.Count - 1] += "\n" + cur;
                    return a;
                })
                .Where(_ => !string.IsNullOrEmpty(_))
                .Select(_ => new Section(r.Match(_).Groups["name"].Value.Trim(), _))
                .ToArray();

            var ts = currentTranslation.Split(new string[] { "\n" }, StringSplitOptions.None)
                .Aggregate(new List<string>(), (a, cur) =>
                {
                    if (cur == "<!--")
                    {
                        a.Add(cur);
                        return a;
                    }

                    if (a.Count > 0) a[a.Count - 1] += "\n" + cur;
                    return a;
                })
                .Where(_ => !string.IsNullOrEmpty(_))
                .Select(_ => new Section(rr.Match(_).Groups["name"].Value.Trim(), rc.Match(_).Groups["content"].Value.Trim()))
                .ToArray();

            var result = ss
                .Select(_ => new { src = _, tran = ts.FirstOrDefault(o => o.Title == _.Title) })
                .Select(_ => new { src = _.src, tran = _.tran, tranrn = _.tran == null ? "" : "\n" })
                .Select(_ => $"<!--\n{_.src.Content}\n-->\n{_.tranrn}{_.tran?.Content}{_.tranrn}");

            return string.Join("\n", result).Replace("\n", "\r\n");

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
