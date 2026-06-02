using DevIo.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIo.Business.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adcionar(Produto fornecedor);
        Task Atualizar(Produto fornecedor);
        Task Remover(Guid id);

    }
}
