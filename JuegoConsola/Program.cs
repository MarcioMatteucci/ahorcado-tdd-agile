using Ahorcado.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PalabraAdivinar = "probandooo";
            game.jugar();
        }
    }
}
