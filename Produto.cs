public class Produto {
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;
    public Produto(string nome, decimal preco, string descricao, string categoria){
        Nome = nome;
        Preco = preco;
        Descricao = descricao;
        Categoria = categoria;
    }
    public string Nome {
        get { return nome; }
        set { nome = value; }
    }
    public decimal Preco {
        get { return preco; }
        set { preco = value; }
    }
    public string Descricao {
        get { return descricao; }
        set { descricao = value; }
    }
    public string Categoria {
        get { return categoria; }
        set { categoria = value; }
    }
}