using AutoMapper;
using Cadastro.Domain.Entities;
using Cadastro.Domain.Interfaces;

using Cadastro.Interfaces;
using Cadastro.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Services
{
    public class ProductViewModelService : IProductViewModelService
    {
        private readonly IProductRepository _clientRepository;
        private readonly IMapper _mapper;

        public ProductViewModelService(IProductRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }

        public ProductViewModel Get(int id)
        {
            var entity = _clientRepository.Get(id);
            if (entity == null)
                return null;

            return _mapper.Map<ProductViewModel>(entity);
        }

        public IEnumerable<ProductViewModel> GetAll()
        {
            var list = _clientRepository.GetAll();
            if (list == null)
                return new ProductViewModel[] { };

            return _mapper.Map<IEnumerable<ProductViewModel>>(list);
        }

        public void Insert(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _clientRepository.Insert(entity);
        }

        public void Update(ProductViewModel viewModel)
        {
            var entity = _mapper.Map<Product>(viewModel);

            _clientRepository.Update(entity);
        }
    }
}
