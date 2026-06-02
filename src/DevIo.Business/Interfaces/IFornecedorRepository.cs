using DevIo.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIo.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

        Task RemoverEnderecoFornecedor(Endereco endereco);
    }
}
