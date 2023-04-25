using ControleDeMedicamentos.Compartilhado;
using ControleDeMedicamentos.ModuloDeRequisicao;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ModuloDeFornecedor
{


    
    public class RepositorioFornecedor : RepositorioBase
    {
        public RepositorioFornecedor(ArrayList listaForcedor)
        {
            this.listaRegistros = listaForcedor;
        }

        public override Fornecedor SelecionarPorId(int id)
        {
            return (Fornecedor)base.SelecionarPorId(id);
        }
    }

}
 

