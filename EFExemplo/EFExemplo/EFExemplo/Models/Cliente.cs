namespace EFExemplo.Models
{
    public class Cliente
    {
        public Guid CLienteId { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public DateOnly DataNascimento { get; set; }
    }
}
