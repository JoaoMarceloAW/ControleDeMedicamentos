﻿using ControleDeFornecedors.ModuloDeFornecedor;
using ControleDeFuncionarios.ModuloDeFuncionarios;
using ControleDeMedicamentos.ModuloDeFornecedor;
using ControleDeMedicamentos.ModuloDeFuncionarios;
using ControleDeMedicamentos.ModuloDeMedicamntos;
using ControleDeMedicamentos.ModuloDePaciente;

using ControleDeMedicamentos.ModuloDeRequisicao;
using static ControleDeMedicamentos.ModuloDeRequisicao.TelaRequisicao;
using System.Collections;

namespace ControleDeMedicamentos
{

    internal class Program
    {
        static void Main(string[] args)
        {
             RepositorioFornecedor repositorioFornecedor = new RepositorioFornecedor(new ArrayList());
            RepositorioPaciente repositorioPaciente = new RepositorioPaciente(new ArrayList());
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario(new ArrayList());
            RepositorioMedicamento repositorioMedicamento = new RepositorioMedicamento(new ArrayList());

            RepositorioRequisicaoEntrada repositorioRequisicaoEntrada = new RepositorioRequisicaoEntrada(new ArrayList());

        

            TelaFornecedor telaFornecedor = new TelaFornecedor(repositorioFornecedor);
            TelaFuncionario telaFuncionario = new TelaFuncionario(repositorioFuncionario);
            TelaPaciente telaPaciente = new TelaPaciente(repositorioPaciente);            

            TelaMedicamento telaMedicamento = new TelaMedicamento(repositorioMedicamento, telaFornecedor, repositorioFornecedor);


            TelaRequisicaoEntrada telaRequisicaoEntrada = new TelaRequisicaoEntrada(repositorioRequisicaoEntrada,
                repositorioFuncionario, repositorioMedicamento, telaFuncionario, telaMedicamento);

            TelaPrincipal principal = new TelaPrincipal();

            while (true)
            {
                string opcao = principal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaFornecedor.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaFornecedor.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaFornecedor.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaFornecedor.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaFornecedor.ExcluirRegistro();
                    }
                }
                else if (opcao == "2")
                {
                    string subMenu = telaFuncionario.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaFuncionario.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaFuncionario.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaFuncionario.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaFuncionario.ExcluirRegistro();
                    }
                }
                else if (opcao == "3")
                {
                    string subMenu = telaPaciente.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaPaciente.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaPaciente.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaPaciente.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaPaciente.ExcluirRegistro();
                    }
                }
                else if (opcao == "4")
                {
                    string subMenu = telaMedicamento.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMedicamento.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMedicamento.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMedicamento.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMedicamento.ExcluirRegistro();
                    }
                    else if (subMenu == "5")
                    {
                        telaMedicamento.VisualizarMedicamentosMaisRetirados();
                    }
                    else if (subMenu == "6")
                    {
                        telaMedicamento.VisulizarMedicamentosEmFalta();
                    }
                }
                else if (opcao == "5")
                {
                    string subMenu = telaRequisicaoEntrada.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaRequisicaoEntrada.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaRequisicaoEntrada.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaRequisicaoEntrada.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaRequisicaoEntrada.ExcluirRegistro();
                    }
                }
            }
        }


       
          
        


        }
    }

                   









