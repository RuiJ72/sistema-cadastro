using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Criação dos hóspedes
var hospedes = new List<Pessoa>
{
    new Pessoa(nome: "Hóspede 1"),
    new Pessoa(nome: "Hóspede 2")
};

// Criação da suíte
var suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Criação e configuração da reserva
var reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibição dos resultados
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");


