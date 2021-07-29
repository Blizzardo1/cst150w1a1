using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Milestone
{
    public record StudentId(int Id)
    {
        public static bool FormatCardAsGCU { get; set; } = true;
        public static bool IncludeName { get; set; } = false;
        public string FullName { get; set; }

        public override string ToString()
        {
            return FormatCardAsGCU ? $"{FullName}\nStudent Number {Id}" : IncludeName ? $"{FullName}: {Id}": $"{Id}";
        }
    }
}
