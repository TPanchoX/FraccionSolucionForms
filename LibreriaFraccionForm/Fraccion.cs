using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaFraccionForm
{
    public class Fraccion
    {
        private int num;
        private int den;
        public Fraccion(int vnum, int vden)
        {
            num = vnum;
            den = vden;
        }
        public Fraccion(int vnum)
        {
            num = vnum;
            den = 1;
        }
        public Fraccion()
        {
            num = 0;
            den = 1;
        }
        public int getNum()
        {
            return num;
        }
        public int getDen()
        {
            return den;
        }
        public void setNum(int vnum)
        {
            num = vnum;
        }
        public void setDen(int vden)
        {
            den = vden;
        }
        //Cálculo del máximo común divisor por el algoritmo de Euclides
        private int mcd()
        {
            int u = Math.Abs(num); //valor absoluto del numerador
            int v = Math.Abs(den); //valor absoluto del denominador
            if (v == 0)
            {
                return u;
            }
            int r;
            while (v != 0)
            {
                r = u % v;
                u = v;
                v = r;
            }
            return u;
        }
        public Fraccion sumar(Fraccion fr)
        {
            int vden = this.den * fr.den;
            int vnum = this.num * fr.den + this.den * fr.num;
            return simplificar(new Fraccion(vnum, vden));
        }
        private Fraccion simplificar(Fraccion fr)
        {
            int aux = mcd();
            fr.num = fr.num / aux;
            fr.den = fr.den / aux;
            return new Fraccion(fr.num, fr.den);
        }
        public Fraccion restar(Fraccion fr)
        {
            int vden = this.den * fr.den;
            int vnum = this.num * fr.den - this.den * fr.num;
            return simplificar(new Fraccion(vnum, vden));
        }
        public Fraccion multiplicar(Fraccion fr)
        {
            int vden = this.den * fr.den;
            int vnum = this.num * fr.num;
            return simplificar(new Fraccion(vnum, vden));
        }
        public Fraccion dividir(Fraccion fr)
        {
            int vden = this.den * fr.num;
            int vnum = this.num * fr.den;
            return simplificar(new Fraccion(vnum, vden));
        }
    }

}
