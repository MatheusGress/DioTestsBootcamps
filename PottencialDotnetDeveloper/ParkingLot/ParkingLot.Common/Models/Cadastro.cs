using System;
using System.Collections.Generic;

public class Cadastro
{
    public void CadastroVeiculos()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();

        List<string> listaPlacas = new List<string>();

        listaPlacas.Add(placa);
    
        Console.WriteLine("Placas cadastradas:");
        foreach (string item in listaPlacas)
        {
            Console.WriteLine(item);
        }
    }
}
