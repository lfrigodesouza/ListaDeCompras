namespace ListaDeCompras.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public bool Comprado { get; set; }
        public int IdCategoria { get; set; }
    }
}
