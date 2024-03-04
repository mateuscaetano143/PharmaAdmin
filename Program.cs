using PharmaAdminDomain.Enum;
using PharmaTech.PharmaAdmin.Domain.Service;
using System;


namespace PharmaAdmin
{
    class Program
    {
        static void Main(string[] args)
        {    
            var medicamentoService = new MedicamentoService();

            //Implementando o cadastro dos medicamentos conforme as classes solicitadas nome, preço e tipo.

            long codigo1 = medicamentoService.CadastrarMedicamento("Dorflex", 6.59, TipoMedicamento.Original);
            long codigo2 = medicamentoService.CadastrarMedicamento("Aspirina", 5.99, TipoMedicamento.Similar);
            long codigo3 = medicamentoService.CadastrarMedicamento("Nimesulida", 15.99, TipoMedicamento.Original);
            

            //Imprimindo na tela

            medicamentoService.ImprimirMedicamento(codigo1);
            medicamentoService.ImprimirMedicamento(codigo2);
            medicamentoService.ImprimirMedicamento(codigo3);

            //Testando o método Buscando o codigo por nome e retornando ele na tela


            long codigo4 = medicamentoService.BuscarCodigoPorNome("Paracetamol");
            if (codigo4 != 0)
            {
                medicamentoService.ImprimirMedicamento(codigo4);
            }


            // Testando o método Imprimir medicamento por tipo e retornando o valor generico.

            medicamentoService.ImprimirMedicamentosPorTipo(TipoMedicamento.Generico);

            // Alterando um valor de medicamento de 15,99 para 12,59 e retornando na tela.

            medicamentoService.AlterarPreco(codigo3, 12.59);
            medicamentoService.ImprimirMedicamento(codigo3);

            Console.ReadLine();
        }
    }
}



