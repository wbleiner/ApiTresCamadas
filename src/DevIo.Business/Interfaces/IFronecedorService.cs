using DevIo.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIo.Business.Interfaces
{
    public interface IFornecedorService : IDisposable
    {
        Task Adcionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
       
    }
}
