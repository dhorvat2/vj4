using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.AutomotiveClasses
{
    class VIN
    {
        private int wmi;
        private int vds;
        private int vis;
        public VIN(int wmi, int vds, int vis) {
            this.wmi = wmi;
            this.vds = vds;
            this.vis = vis; 
        } 
        public string getVin() {
            return wmi + "" + vds + "" + vis; 
        }
    }
}
