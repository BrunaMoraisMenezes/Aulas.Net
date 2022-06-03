using System;

namespace Aulas_Net
{
    class Atividade_Split
    {
        static void xMain(string[] args)
        {
            string texto1 = "desenvolvimento Visual utilizada";
            string texto2 = ".NET&O&é&para&aplicações";
            string texto3 = "Studio,a,IDE,de,o";

            string[] frase1 = texto1.Split(' ');
            string[] frase2 = texto2.Split('&');
            string[] frase3 = texto3.Split(',');

            Console.WriteLine(frase2[1] + " " +
                frase1[1] + " " +
                frase3[0] + " " +
                frase2[2] + " " +
                frase3[1] + " " +
                frase3[2] + " " +
                frase1[2] + " " +
                frase2[3] + " " +
                frase3[4] + " " +
                frase1[0] + " " +
                frase3[3] + " " +
                frase2[4] + " " +
                frase2[0]);

            Console.ReadKey();
        }
    }
}
