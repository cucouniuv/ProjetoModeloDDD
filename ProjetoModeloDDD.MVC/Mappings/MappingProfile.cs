using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}
