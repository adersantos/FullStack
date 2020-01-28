
using GameTOP;

public class Jogador1 : IJogador
{
    public string _nome;

    public Jogador1(string nome)
    {
        _nome = nome;
    }

    public string Chuta() => $"{_nome} está chutando";

    public string Corre() => $"{_nome} está correndo";

    public string Passe() => $"{_nome} está passando";
}