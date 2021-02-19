using System;
using System.Collections.Generic;
using System.Text;

namespace Csharquarium.models
{
    public class EtreVivants
    {
      
        private int pv;

        private int age;
        public int PV
        {
            get { return pv; }
            set { pv = 10; }
        }

        public int Age
        {
            get { return age; }
            set {
                if (value <= 20 || value >= 0)
                    age = value;

                    }
            
            
        }
        public EtreVivants()
        {
            pv = 10;
           
        }

      


    }
}

