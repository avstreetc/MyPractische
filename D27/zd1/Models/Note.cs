using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd1.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string TitleIn { get; set; }
        public string Year { get; set; }
        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine($"------->Маршрут от: {Title}")
                .AppendLine($"\tдо: {TitleIn}")
                .AppendLine($"\tНомер автобуса: {Year}")
                .ToString();
        }
    }
}
