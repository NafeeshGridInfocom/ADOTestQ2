using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using da_layer;
using be_layer;

namespace ba_layer
{
    public class bal

    {
        dal dl = new dal();
        public void Insertta(ta t)
        {
            dl.InsertDeprtment(t);
        }
        public void Update_ta(ta t1)
        {
            dl.Updateta(t1);
        }
        public void Delete_ta(ta t2)
        {
            dl.Deleteta(t2);
        }
        public void Search_ta(ta t3)
        {
            dl.SearchRecord(t3);
        }
    }

}
