using AutoMapper;
using Pedidos.Aplicacao.DataContract.Request.Ciente;
using Pedidos.Aplicacao.DataContract.Response.Cliente;
using Pedidos.Dominio.Models;

namespace Pedidos.Aplicacao.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
            CleinteMap();
        }

        private void CleinteMap()
        {
            CreateMap<CreateClienteRequest, Clientes>(); //Mapeamentop do request para o modelo
            CreateMap<Clientes, ClienteResponse>(); //Mapeamento do modelo para o response
        }
    }
}