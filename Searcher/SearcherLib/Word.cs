using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearcherLib
{
    class Word
    {
        Dictionary<DiskFile, int> WordLocationMap = new Dictionary<DiskFile, int>();
        
        public string Text { get; set; }


    }
}
