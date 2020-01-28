namespace GameTOP
{
    public class jogador2 : IJogador
    {
        public string _nome;

        public jogador2(string nome)
        {
            _nome = nome;
        }

        public string Chuta()
        {
            return$"{_nome} está chutando";
        }

        public string Corre()
        {
            return$"{_nome} está correndo";
        }

        public string Passe()
        {
            return$"{_nome} está passando";
        }
    }
}