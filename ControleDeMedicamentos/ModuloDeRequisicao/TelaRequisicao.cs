using ControleDeFuncionarios.ModuloDeFuncionarios;
using ControleDeMedicamentos.Compartilhado;
using ControleDeMedicamentos.ModuloDeFornecedor;
using ControleDeMedicamentos.ModuloDeFuncionarios;
using ControleDeMedicamentos.ModuloDeMedicamntos;
using ControleDeMedicamentos.ModuloDeRequisicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ModuloDeRequisicao
{
    public class TelaRequisicao
    {
        public class TelaRequisicaoEntrada : TelaBase
        {
            private RepositorioRequisicaoEntrada repositorioRequisicaoEntrada;

            private RepositorioFuncionario repositorioFuncionario;
            private RepositorioMedicamento repositorioMedicamento;

            private TelaFuncionario telaFuncionario;
            private TelaMedicamento telaMedicamento;

            public TelaRequisicaoEntrada(RepositorioRequisicaoEntrada repositorioRequisicaoEntrada,
                RepositorioFuncionario repositorioFuncionario, RepositorioMedicamento repositorioMedicamento,
                TelaFuncionario telaFuncionario, TelaMedicamento telaMedicamento)
            {
                this.repositorioBase = repositorioRequisicaoEntrada;

                this.repositorioRequisicaoEntrada = repositorioRequisicaoEntrada;
                this.repositorioFuncionario = repositorioFuncionario;
                this.repositorioMedicamento = repositorioMedicamento;
                this.telaFuncionario = telaFuncionario;
                this.telaMedicamento = telaMedicamento;

                nomeEntidade = "Requisições de Entrada";
            }

            protected override void MostrarTabela(ArrayList registros)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -20} | {3, -20}", "Id", "Data", "Medicamento", "Fonecedor", "Quantidade");

                Console.WriteLine("--------------------------------------------------------------------");

                foreach (RequisicaoEntrada requisicaoEntrada in registros)
                {
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -20} | {3, -20}",
                        requisicaoEntrada.id,
                        requisicaoEntrada.data.ToShortDateString(),
                        requisicaoEntrada.medicamento.nome,
                        requisicaoEntrada.medicamento.fornecedor.nome,
                        requisicaoEntrada.quantidade);
                }
            }

            protected override EntidadeBase ObterRegistro()
            {
                Medicamento medicamento = ObterMedicamento();

                Funcionario funcionario = ObterFuncionario();

                Console.Write("Digite a quantidade de caixas: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a data: ");
                DateTime data = Convert.ToDateTime(Console.ReadLine());

                return new RequisicaoEntrada(medicamento, quantidade, data, funcionario);
            }

            private Funcionario ObterFuncionario()
            {
              
                telaFuncionario.VisualizarRegistros(false);


                Console.Write("\nDigite o id do Funcionário: ");
                int idFuncionario = Convert.ToInt32(Console.ReadLine());

              
                Funcionario funcionario = repositorioFuncionario.SelecionarPorId(idFuncionario);

                Console.WriteLine();

                return funcionario;
            }

            private Medicamento ObterMedicamento()
            {

                telaMedicamento.VisualizarRegistros(false);


                Console.Write("\nDigite o id do Medicamento: ");
                int idMedicamento = Convert.ToInt32(Console.ReadLine());


                Medicamento medicamento = repositorioMedicamento.SelecionarPorId(idMedicamento);

                Console.WriteLine();



                return medicamento;
            }
            }
        }
}
