using ControleDeMedicamentos.Compartilhado;
using ControleDeMedicamentos.ModuloDeMedicamntos;
using ControleDeMedicamentos.ModuloDeRequisicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ModuloDePaciente
{
    public class RepositorioPaciente : RepositorioBase
    {
        public RepositorioPaciente(ArrayList listaPaciente)
        {
            this.listaRegistros = listaPaciente;
        }

        public override Paciente SelecionarPorId(int id)
        {
            return (Paciente)base.SelecionarPorId(id);
        }
    }
}
