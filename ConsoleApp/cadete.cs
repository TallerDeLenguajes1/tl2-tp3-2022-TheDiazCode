public class Cadete : Persona{
    private static int cantCadetes = 0;
    private int idCadete;
    private List<Pedido> listaPedidos;

    public Cadete(string nombre, string direccion, string telefono):base(nombre,direccion,telefono){
        this.IdCadete = cantCadetes++;
        this.ListaPedidos = new List<Pedido>();
    }

    public int IdCadete { get => idCadete; set => idCadete = value; }
    public List<Pedido> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

    public void AgregarPedido(string obs, Cliente cliente,int pago){
        Pedido nuevo = new Pedido(obs,cliente,pago);
        ListaPedidos.Add(nuevo);
    }
}