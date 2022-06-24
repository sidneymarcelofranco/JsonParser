using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace JsonParser
{
    internal class jsonPersonComplex : jsonPersonSimple
    {    
        /*
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        */

        public addr address { get; set; }
    
    public class addr {
            public string street { get; set; }
            public string suite { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }

            
        } 
    
    }
}

