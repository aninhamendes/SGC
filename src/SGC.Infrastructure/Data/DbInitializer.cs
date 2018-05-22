using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SGC.ApplicationCore.Entity;

namespace SGC.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ClienteContext context)
        {
            if (context.Clientes.Any())
            {
                return;
            }

            var clientes = new Cliente[]
            {
                new Cliente
                {
                    Nome = "Ana Mendes",
                    CPF = 8789987
                     },

                new Cliente
                {
                    Nome = "Fernanda Lima",
                    CPF = 987654345
                }
            };
            context.AddRange(clientes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome = "Contato 1",
                    Telefone = "984928765",
                    Email = "contato1@gmail.com",
                    Cliente = clientes[0]
                },

                 new Contato
                {
                    Nome = "Contato 2",
                    Telefone = "992347898",
                    Email = "contato2@gmail.com",
                    Cliente = clientes[1]
                }

            };
            context.AddRange(contatos);

            context.SaveChanges();
        }
    }
}
