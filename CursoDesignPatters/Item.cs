﻿using System;
namespace CursoDesignPatters
{
    public class Item
    {
        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public string Nome { get; set; }
        public double Valor { get; set; }

    }
}
