﻿using Ahorcado.App;

namespace JuegoConsola
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.PalabraAdivinar = "probandooooo";
            game.jugar();
        }
    }
}
