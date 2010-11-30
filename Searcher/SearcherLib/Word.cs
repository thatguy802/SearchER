using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SearcherLib
{
    public class Word
    {
        Dictionary<DiskFile, List<int>> WordLocationMap = new Dictionary<DiskFile, List<int>>();
        
        public string Text { get; set; }

        public void Add(DiskFile df, int position)
        {
            if(!this.WordLocationMap.ContainsKey(df))
            {
                List<int> tmpPosList = new List<int>();
                tmpPosList.Add(position);
                this.WordLocationMap.Add(df, tmpPosList);
            }
            else
            {
                this.WordLocationMap[df].Add(position);
            }
        }


        public List<DiskFile> inFiles()
        {
            List<DiskFile> dfList= new List<DiskFile>();
            foreach(DiskFile d in this.WordLocationMap.Keys)
            {
                dfList.Add(d);
            }
            return dfList;
        }
    }
}
