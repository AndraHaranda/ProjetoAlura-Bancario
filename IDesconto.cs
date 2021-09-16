public interface IDesconto 
{
    double Desconta(Orcamento orcamento);
    Desconto Proximo { private get; set; }
}

public class DescontoPorCincoItens : IDesconto 
{
    public Desconto Proximo { get; set; }

    public double Desconta(Orcamento orcamento) 
    {
        if(orcamento.Itens.Count > 5)
        {
            return orcamento.Valor * 0.1;
        }
        else 
        {
            return Proximo.Desconta(orcamento);
        }
    }
}