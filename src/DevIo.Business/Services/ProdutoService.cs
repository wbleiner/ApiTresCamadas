using DevIo.Business.Interfaces;
using DevIo.Business.Models;
using DevIo.Business.Models.Validations;


namespace DevIo.Business.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService(IProdutoRepository produtoRepository, INotificador notificador) : base(notificador)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task Adicionar(Produto fornecedor)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), fornecedor)) return;
            await _produtoRepository.Adicionar(fornecedor);
        }

        public async Task Atualizar(Produto fornecedor)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), fornecedor)) return;
            await _produtoRepository.Atualizar(fornecedor);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.Remover(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
