using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordData
{
    public class DianMingRecord
    {
        public string[] recordData = new string[100];
        int i = 0;

        public void DMrecord(string stuName) 
        {
            recordData[i] = stuName;
            i++;
        }

        public string ShowRecord()
        {
            string data = null;
            for(int j = 0 ;j <= i; j++)
            {
                data += recordData[j];
                data += "\r";
            }
            return data;
        }
    }
}
