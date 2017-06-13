using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado.App
{
    public class Game
    {
        public const int IntentosMax = 7;

        public string PalabraAdivinar { get; set; }

        public string PalabraMostrada { get; set; }

        public int Intentos { get; set; }

        public Game()
        {
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

        public void jugar()
        {
            Intentos = 0;
            initPalabraMostrada();
            do
            {
                Console.WriteLine("\nIntentos: " + Intentos);
                Console.WriteLine(PalabraMostrada);
                Console.Write("Ingrese Letra: ");
                char letra = Console.ReadKey().KeyChar;
                ingresaLetra(letra);
            } while (Intentos <= IntentosMax);
        }
    }
}
