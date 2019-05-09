using System;

namespace trab1_LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            Renderer render = new Renderer();

            Player J1 = new Player();
            Player J2 = new Player();

            render.Render(board);

            Console.ReadKey();
        }
    }
}
