
public class Pedido{

    enum estado{Procesando,Despachado,Viejando,Entregado}
    private static int nroPedido = 0;

    private int nro;
    private string obs;
    private Cliente cliente;
    private string estadoPedido;
    private int pago;

    public Pedido(string obs, Cliente cliente,int pago)
    {
        this.nro = nroPedido++;
        this.obs = obs;
        this.cliente = cliente;
        this.estadoPedido = Convert.ToString(estado.Procesando);
        this.Pago = pago;
    }

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public string EstadoPedido { get => estadoPedido; set => estadoPedido = value; }
    public int Pago { get => pago; set => pago = value; }


    #region metodos
    public void MostrarPedido(){
        System.Console.WriteLine("==============================");
        System.Console.WriteLine("\tPedido nro: " + this.Nro);
        System.Console.WriteLine("\tObservacion: " + this.Obs);
        System.Console.WriteLine("\tCliente: " + this.Cliente.Nombre);
        System.Console.WriteLine("\tDireccuin: " + this.Cliente.Direccion);
        System.Console.WriteLine("\tEstado: " + this.EstadoPedido);
        System.Console.WriteLine("\tMonto: $" + this.Pago);
    }
    #endregion
}