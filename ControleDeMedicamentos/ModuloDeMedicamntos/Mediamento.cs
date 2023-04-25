using ControleDeMedicamentos.Compartilhado;
using ControleDeMedicamentos.ModuloDeFornecedor;
using ControleDeMedicamentos.ModuloDeRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ModuloDeMedicamntos
{
    public class Medicamento : EntidadeBase
    {
        public string nome;
        public string descricaco;
        public string lote;
        public DateTime validade;
        public int quantidade;
        public Fornecedor fornecedor;

        public Medicamento(string nome, string descricaco, string lote, DateTime validade, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.descricaco = descricaco;
            this.lote = lote;
            this.validade = validade;
            this.fornecedor = fornecedor;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Medicamento medicamentoAtualizado = (Medicamento)registroAtualizado;

            this.nome = medicamentoAtualizado.nome;
            this.descricaco = medicamentoAtualizado.descricaco;
            this.lote = medicamentoAtualizado.lote;
            this.validade = medicamentoAtualizado.validade;
            this.fornecedor = medicamentoAtualizado.fornecedor;
        }

        public void RegistrarEntrada(int qtd)
        {
            this.quantidade += qtd;
        }
    }
}
