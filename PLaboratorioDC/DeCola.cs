using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLaboratorioDC
{
    public class DeCola
    {

        public string[] decoladatos = new string[100];
        public int primero = 0;
        public int ultimo = -1;
        public int MaxCola = 5;
        public string valor = "";

        public DeCola()
        {
            primero = 0;
            ultimo = -1;
        }


        public bool Vacia()
        {

            if (ultimo < primero) return true;
            return false;

        }


        public bool Llena()
        {

            if(ultimo == MaxCola-1) return true;
            else return false;

        }

        public void InsertarDelante(string insert)
        {

            if (Llena()) MessageBox.Show("Error: La decola esta LLENA");
            else
            {

                for(int i = ultimo+1; i > 0 ; i--)
                {
                    decoladatos[i] = decoladatos[i - 1];
                }
                ultimo++;
                decoladatos[primero] = insert;

            }

        }

        public void InsertarDetras(string insert)
        {

            if (Llena()) MessageBox.Show("Error: La decola esta LLENA");
            else
            {
                ultimo++;
                decoladatos[ultimo] = insert;
            }

        }

        public string EliminarDelante()
        {
            string valor = "";
            if (Vacia()) MessageBox.Show("Error: La decola esta VACIA");
            else
            {

                valor = decoladatos[primero];
                
                for(int i = 0; i < ultimo; i++)
                {

                    decoladatos[i] = decoladatos[i+1];

                }

                ultimo--;

            }

        return valor;
        }


        public string EliminarDetras()
        {
            string valor = "";
            if (Vacia()) MessageBox.Show("Error: La decola esta VACIA");
            else
            {
                valor= decoladatos[ultimo];
                ultimo--;
            }
            return valor;
        }
    }
}
