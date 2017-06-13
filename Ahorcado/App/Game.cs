using System;
using System.Linq;

namespace Ahorcado.App
{
    public class Game
    {
        public int IntentosMax { get; set;}

        public string PalabraAdivinar { get; set; }

        public string PalabraMostrada { get; set; }

        public int Intentos { get; set; }

        public Game()
        {
        }    
        
        public void setPalabraAdivinar(string palabraAdivinar)
        {
            PalabraAdivinar = palabraAdivinar;
        }    

        public void setIntentosMaximos(int intentosMaximos)
        {
            IntentosMax = intentosMaximos;
        }

        public void initIntentos()
        {
            Intentos = 0;
        }

        public void inicializar()
        {
            initIntentos();
            initPalabraMostrada();
        }

        public bool arriegaPalabra(string palabra)
        {
            if (PalabraAdivinar.Equals(palabra))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void initPalabraMostrada()
        {
            char[] palabraMostrada = PalabraAdivinar.ToCharArray();

            for (int i = 0; i < PalabraAdivinar.Length; i++)
            {
                palabraMostrada[i] = '*';
            }

            PalabraMostrada = new string(palabraMostrada);
        }

        public bool contieneLetra (char letra)
        {                   
            if (PalabraAdivinar.Contains(letra))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void actualizaPalabraMostrada (char letra)
        {
            char[] palabraActualizada = PalabraMostrada.ToCharArray();

            for(int i = 0; i < PalabraMostrada.Length; i++)
            {
                if (PalabraAdivinar[i] == letra)
                {
                    palabraActualizada[i] = letra;
                }
            }

            PalabraMostrada = new string(palabraActualizada);
        }

        public void ingresaLetra(char letra)
        {
            if (contieneLetra(letra))
            {
                actualizaPalabraMostrada(letra);
            } else
            {
                Intentos++;
            }
        }

        public bool quedanIntentos()
        {
            if (Intentos <= IntentosMax)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool juegoGanado()
        {
            if (PalabraAdivinar.Equals(PalabraMostrada))
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void jugar()
        {
            inicializar();
            setIntentosMaximos(7);
            do
            {
                Console.WriteLine("\nIntentos: " + Intentos);
                Console.WriteLine(PalabraMostrada);
                Console.Write("Ingrese Letra: ");
                char letra = Console.ReadKey().KeyChar;
                ingresaLetra(letra);
            } while (!juegoGanado() && quedanIntentos());

            Console.Clear();

            if (juegoGanado())
            {
                Console.WriteLine("GANASTE !!!\n\n");
            } else
            {
                Console.WriteLine("PERDISTE !!!");
                Console.WriteLine("La palabra era: " + PalabraAdivinar);
            }

            Console.WriteLine("Pulse una tecla para salir...");
            Console.ReadKey();     
        }
    }
}
