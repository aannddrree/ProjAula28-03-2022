﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula4
{
    public class Carro
    {
        #region Propriedades
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }
        public int Velocidade { get; set; }
        public bool StatusCarro { get; set; }
        public bool Buzinar { get; set; }
        public bool Ar { get; set; }
        #endregion

        #region Métodos
        //Acelera
        public void Acelear(int velocidade)
        {
            this.Velocidade += velocidade;
        }
        //Frear
        public void Frear(int velocidade)
        {
            this.Velocidade -= velocidade;
        }
        //Liga
        public void Ligar()
        {
            this.StatusCarro = true;
        }
        //Desliga
        public void Desligar()
        {
            this.StatusCarro = false;
        }
        //Buzina
        public void LigarBuzina()
        {
            this.Buzinar = true;
        }
        
        public void DesligarBuzina()
        {
            this.Buzinar = false;
        }
        //LigarAr
        public void LigarAr()
        {
            if (this.Ar == false)
            {
                if (this.StatusCarro == true)
                    this.Ar = true;
                else
                    Console.WriteLine("O carro está desligado!");
            }
            else
            {
                Console.WriteLine("O Ar já está ligado!");
            }
            
        }
        public void DesligarAr()
        {
            this.Ar = false;
        }

        public override string ToString()
        {
            return "Id: " + this.Id +
                   "\nModelo: " + this.Modelo +
                   "\nMarca: " + this.Marca +
                   "\nAno Modelo: " + this.AnoModelo +
                   "\nAno Fabricação: " + this.AnoFabricacao +
                   "\nCor: " + this.Cor +
                   "\nStatus Carro: " + this.StatusCarro +
                   "\nVelocidade: " + this.Velocidade +
                   "\nBuzina: " + this.Buzinar + 
                   "\nAr: " + this.Ar;
        }
        #endregion
    }
}
