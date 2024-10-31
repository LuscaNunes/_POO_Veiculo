public class VeiculoDAO
{
    public List<Veiculo> listaVeiculos = new List<Veiculo>();

    public void Cadastrar(Veiculo v)
    {
        listaVeiculos.Add(v);
    }

    public List<Veiculo> ListarTodos()
    {
        return listaVeiculos;
    }

    public void Remover(string placa)
    {
        Veiculo vExcluir = listaVeiculos.First(p => p._Placa == placa);
        listaVeiculos.Remove(vExcluir);
    }

    public Veiculo Pesquisa(string placa)
    {
        Veiculo vPesquisa = listaVeiculos.First(p => p._Placa == placa);
        return vPesquisa;
    }
}