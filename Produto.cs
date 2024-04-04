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

public class ConsoleGame: Produto{
    private int propiedadearmazenamento;

    public Estudante(string nome; decimal preco; string descricao; string categoria; int propiedadearmazenamento;) : base(nome, preco, descricao, categoria){
        PropiedadeArmazenamento = propiedadearmazenamento;
    }

    public string PropiedadeArmazenamento{
        get { return propiedadearmazenamento; }
        set { propiedadearmazenamento = value; }
    }
}

public class Jogo: Produto{
    private string genero;

    public Jogo(string nome; decimal preco; string descricao; string categoria; int genero;) : base(nome, preco, descricao, categoria){
        Genero = genero;
    }

    public string Genero{
        get { return genero }
        set { genero = value }
    }
}

public class Acessorio: Produto{
    private string tipo;

    public Tipo(string nome; decimal preco; string descricao; string categoria; string tipo;) : base(nome, preco, descricao, categoria){
        Tipo = tipo;
    }

    public string Tipo{
        get { return tipo; }
        set { tipo = value; }
    }
}
