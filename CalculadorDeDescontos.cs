public class CalculadorDeDescontos {
    public double Calcula(Orcamento orcamento) 
    {
        IDesconto d1 = new DescontoPorCincoItens();
        IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();

        d1.Proximo = d2;

        return d1.Desconta(orcamento);
    }
}
