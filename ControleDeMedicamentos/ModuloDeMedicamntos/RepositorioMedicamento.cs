using ControleDeMedicamentos.Compartilhado;
using ControleDeMedicamentos.ModuloDeRequisicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ModuloDeMedicamntos
{
    public class RepositorioMedicamento : RepositorioBase
    {
        public RepositorioMedicamento(ArrayList listaMedicamento)
        {
            this.listaRegistros = listaMedicamento;
        }

        public override Medicamento SelecionarPorId(int id)
        {
            return (Medicamento)base.SelecionarPorId(id);
        }

        public ArrayList SelecionarMedicamentosMaisRetirados()
        {
          
            return listaRegistros;
        }

        internal ArrayList SelecionarMedicamentosEmFalta()
        {
          
            return listaRegistros;
        }

    }
}

