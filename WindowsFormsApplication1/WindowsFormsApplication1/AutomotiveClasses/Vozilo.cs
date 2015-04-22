using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.AutomotiveClasses
{
    class Vozilo
    {
        private List<Dio> montiraniDjelovi; 
        public VIN idAutomobila; 
        public String naziv { get; set; }
        public int status { get; set; } 
        public int tezina { get; set; } 
        public int visina { get; set; } 
        public int duzina { get; set; } 
        public int meduosovinskiRazmak { get; set; } 
        public String gume { get; set; }
        public int co2 { get; set; } 
        public Vozilo() {
            montiraniDjelovi = new List<Dio>();
            idAutomobila = new VIN(10, 15, 54); 
        } 
        public bool addDio(Dio noviDio) {
            montiraniDjelovi.Add(noviDio); return true; 
        } 
        public void updateStatus() { 
            status = status++; 
        } 
        public List<Dio> getDjelovi() { 
            return montiraniDjelovi; 
        }


    }
}
