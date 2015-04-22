using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.AutomotiveClasses
{
    class Motor:Dio
    {
        public int brojCilindara { get; set; } 
        public int ccm { get; set; } 
        public int konjskeSnage { get; set; } 
        public EnumHelper.Gorivo gorivo { get; set; } 
       
        public Motor(int brojCilindara, int ccm, int konjskeSnage, EnumHelper.Gorivo gorivo) { 
            this.brojCilindara = brojCilindara; 
            this.ccm = ccm; 
            this.konjskeSnage = konjskeSnage; 
            this.gorivo = gorivo; 
        } 
        public string naziv { get; set; } 
        public int sifra { get; set; } 
        public string printAttributes() {
            String attributes = "Broj cilindara: " + brojCilindara.ToString();
            attributes += "CCM: " + ccm.ToString();
            attributes += "KS: " + konjskeSnage.ToString();
            attributes += "Gorivo: " + gorivo.ToString(); 
                return attributes; }
    }
}
