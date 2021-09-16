interface Resposta 
{
    void Responde(Requisicao req, Conta conta);
    Resposta OutraResposta { get; set; }
}

class RespostaEmXml : Resposta 
{
    public Resposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta) 
    {
        if(req.Formato == Formato.XML) 
        {
            Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
        }
        else 
        {
            OutraResposta.Responde(req, conta);
        }
    }  
}

class RespostaEmCsv : Resposta 
{
    public Resposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta) 
    {
        if(req.Formato == Formato.CSV) 
        {
            Console.WriteLine(conta.Titular + ";" + conta.Saldo);
        }
        else 
        {
            OutraResposta.Responde(req, conta);
        }
    }
}

class RespostaEmPorcento : Resposta 
{
    private Resposta OutraResposta { get; set; }

    public void Responde(Requisicao req, Conta conta) 
    {
        if(req.Formato == Formato.PORCENTO) 
        {
            Console.WriteLine(conta.Titular + "%" + conta.Saldo);
        }
        else 
        {
            OutraResposta.Responde(req, conta);
        }
    }
}