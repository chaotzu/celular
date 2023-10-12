using System;

public class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string NumeroTelefono { get; set; }
    public double Saldo { get; private set; }

    public Celular(string marca, string modelo, string numeroTelefono, double saldoInicial)
    {
        Marca = marca;
        Modelo = modelo;
        NumeroTelefono = numeroTelefono;
        Saldo = saldoInicial;
    }

    public void RealizarRecarga(double monto)
    {
        if (monto > 0)
        {
            Saldo += monto;
            Console.WriteLine($"Recarga exitosa. Nuevo saldo: ${Saldo:F2}");
        }
        else
        {
            Console.WriteLine("El monto de recarga debe ser mayor que cero.");
        }
    }

    public void RealizarLlamada(string numeroDestino, int duracionMinutos)
    {
        double costoPorMinuto = 0.10; // Costo ficticio por minuto
        double costoLlamada = costoPorMinuto * duracionMinutos;

        if (Saldo >= costoLlamada)
        {
            Saldo -= costoLlamada;
            Console.WriteLine($"Llamada a {numeroDestino} de {duracionMinutos} minutos realizada. Costo: ${costoLlamada:F2}. Saldo restante: ${Saldo:F2}");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar la llamada.");
        }
    }

    public override string ToString()
    {
        return $"{Marca} {Modelo} - Número: {NumeroTelefono} - Saldo: ${Saldo:F2}";
    }


}

class Program
{
    static void Main(string[] args)
    {
        Celular miCelular = new Celular("Samsung", "Galaxy S20", "555-123-4567", 50.0);

        Console.WriteLine("Información del celular:");
        Console.WriteLine(miCelular);

        miCelular.RealizarRecarga(20.0);
        miCelular.RealizarLlamada("555-987-6543", 5);

        Console.WriteLine("Información actualizada del celular:");
        Console.WriteLine(miCelular);
    }
}