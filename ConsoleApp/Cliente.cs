public class Cliente:Persona{
    private static int clienteCreado=0;
    private int idCliente;

    public Cliente(string nombre, string direccion, string telefono):base( nombre,  direccion,  telefono)
    {
        this.idCliente = clienteCreado++;
    }
    public int IdCliente { get => idCliente;  }

    public void MostrarCliente(){
         System.Console.WriteLine("==============================");
        System.Console.WriteLine("\tCliente nro: " + this.idCliente);
        System.Console.WriteLine("\tNombre: " + this.Nombre);
        System.Console.WriteLine("\tDireccion: " + this.Direccion);
        System.Console.WriteLine("\tTelefono: " + this.Telefono);
    }
}