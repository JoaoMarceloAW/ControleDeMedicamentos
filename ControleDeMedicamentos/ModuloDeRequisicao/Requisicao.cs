using ControleDeMedicamentos.Compartilhado;
using ControleDeMedicamentos.ModuloDeFuncionarios;
using ControleDeMedicamentos.ModuloDeMedicamntos;
using ControleDeMedicamentos.ModuloDePaciente;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ModuloDeRequisicao
{
    public class RequisicaoEntrada : EntidadeBase
    {
        public Medicamento medicamento;
        public int quantidade;
        public DateTime data;
        public Funcionario funcionario;

        public RequisicaoEntrada(Medicamento medicamento, int quantidade, DateTime data, Funcionario funcionario)
        {
            this.medicamento = medicamento;
            this.quantidade = quantidade;
            this.data = data;
            this.funcionario = funcionario;

            this.medicamento.RegistrarEntrada(quantidade);
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            RequisicaoEntrada requisicaoEntradaAtualizada = (RequisicaoEntrada)registroAtualizado;

            this.medicamento = requisicaoEntradaAtualizada.medicamento;
            this.quantidade = requisicaoEntradaAtualizada.quantidade;
            this.data = requisicaoEntradaAtualizada.data;
            this.funcionario = requisicaoEntradaAtualizada.funcionario;
        }
    }
}
