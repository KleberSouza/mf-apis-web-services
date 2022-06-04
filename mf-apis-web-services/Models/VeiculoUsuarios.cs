namespace mf_apis_web_services.Models
{
    public class VeiculoUsuarios
    {
        public int VeiculoId { get; set; }
        public Veiculo Veiculo { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
