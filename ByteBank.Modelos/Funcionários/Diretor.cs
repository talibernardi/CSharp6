﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionários
    {
        public class Diretor : FuncionarioAutenticavel
        {
            public Diretor(string cpf) : base(5000, cpf)
            {
                Console.WriteLine("Criando DIRETOR");
            }

            public override void AumentarSalario()
            {
                Salario *= 1.15;
            }

            internal protected override double GetBonificacao()
            {
                return Salario * 0.5;
            }
        }
    }

