public class Produto {
    private string nome;
    private decimal preco;
    private string descricao;
    private string categoria;
    public Produto(string nome, decimal preco, string descricao, string categoria){
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
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
    private int propiedadeArmazenamento;

    public ConsoleGame(string nome; decimal preco; string descricao; string categoria; int propiedadeArmazenamento;) : base(nome, preco, descricao, categoria){
        PropiedadeArmazenamento = propiedadeArmazenamento;
    }

    public string PropiedadeArmazenamento{
        get { return propiedadeArmazenamento; }
        set { propiedadeArmazenamento = value; }
    }
}

public class Jogo: Produto{
    private string genero;

    public Jogo(string nome; decimal preco; string descricao; string categoria; string genero;) : base(nome, preco, descricao, categoria){
        Genero = genero;
    }

    public string Genero{
        get { return genero }
        set { genero = value }
    }
}

public class Acessorio: Produto{
    private string tipo;

    public Acessorio(string nome; decimal preco; string descricao; string categoria; string tipo;) : base(nome, preco, descricao, categoria){
        Tipo = tipo;
    }

    public string Tipo{
        get { return tipo; }
        set { tipo = value; }
    }
}

public class Colecionavel: Produto{
    private bool edicaoLimitada;

    public Colecionavel(string nome; decimal preco; string descricao; string categoria; bool edicaoLimitada;) : base(nome, preco, descricao, categoria){
        EdicaoLimitada = edicaoLimitada;
    }

    public string EdicaoLimitada{
        get { return edicaoLimitada; }
        set { edicaoLimitada = value; }
    }
}

pubic class Program {
    public static void main (string[] args) {

        Produto produto;
        produto = new ConsoleGame("XboxSeriesS", 2.800, "Console de Vídeo Game XboxSeries S com 500gb de armazenamento.", "Console", 500000);

        Jogo jogo = new Jogo("Sekiro: Shadow Die Twice", 199.99, "Jogo completo Sekiro: Shadow Die Twice para Xbox Series X/S.", "Jogo", "Souls Like")

        Acessorio acessorio = new Acessorio("Controle XboxSeries X/S", 410.00, "Controle XboxSeries X/S sem fio", "Controle", "Periférico")

        Acessorio acessorio = new Acessorio("SEKIRO: SHADOWS DIE TWICE - Figure", 3999.99, "SEKIRO SHADOWS DIE TWICE 隻狼 狼 1/6スケール スタチュー", "Action Figure", "true")
    }
}
