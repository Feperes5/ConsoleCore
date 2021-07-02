using GameTOP.Interface;

namespace GameTOP.Lib
{
    public class Jogador2 : iJogador
    {
        public string Chuta()
        {
            return "Maradona está chutando algo\n";
        }

        public string Corre()
        {
            return "Maradona está correndo algo\n";
        }

        public string Passe()
        {
            return "Maradona está passando algo\n";
        }
    }
}