using System;
using System.Collections.Generic;
using System.Text;

namespace EntrevistaAmuchastegui
{
    class Caja
    {
        public int Largo { set; get; }
        public int Ancho { set; get; }
        public int Profundidad { set; get; }
        public int VolumenM3 { set; get; }


        public Caja(int largo, int ancho, int profundidad) {

            this.Largo = largo;
            this.Ancho = ancho;
            this.Profundidad = profundidad;
            this.VolumenM3 = largo * ancho * profundidad;

        
        }
        public string PrintCaja() {

            return "Dimensiones: " + " " + Largo + "x" + " " + Ancho + "x" + " " + Profundidad + " " + "Volumen: " + " " + VolumenM3;
        
        
        }
    }
}
