using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Pedidos.Dominio.Interfaces.Repositories;
using Pedidos.Dominio.Interfaces.Services;
using Pedidos.Dominio.Models;
using Pedidos.Dominio.Validations;
using Pedidos.Dominio.Validations.Base;

namespace Pedidos.Dominio.Services
{
    public class ClienteService : IClientService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<Response> CreateAsync(Clientes cliente)
        {
            var resposta = new Response();
            var validacao = new ClienteValidation();
            var erros= validacao.Validate(cliente).GetErros();

            if (erros.Reports.Count > 0)
                return erros;
            await _clienteRepository.CreateAsync(cliente);
            return resposta;
        }

        public async Task<Response> DeleteAsync(string clienteId)
        {
            var resposta = new Response();

            var existe =  await _clienteRepository.ExistByIdAsync(clienteId);

            if (!existe)
            {
                resposta.Reports.Add(Report.Create($"Cliente {clienteId} não encontrado"));
                return resposta;
            }
            await _clienteRepository.DeleteAsync(clienteId);
            return resposta;
        }

        public async Task<Response<Clientes>> GetById(string clienteId)
        {
            var resposta = new Response<Clientes>();

            var existe =  await _clienteRepository.ExistByIdAsync(clienteId);

            if (!existe)
            {
                resposta.Reports.Add(Report.Create($"Cliente {clienteId} não encontrado"));
                return resposta;
            }
            var data = await _clienteRepository.GetById(clienteId);
            resposta.Data = data;
            return resposta;
        }

        public async Task<Response<List<Clientes>>> ListByFilterAsync(string clienteId = null, string clienteNome = null)
        {
            var resposta = new Response<List<Clientes>>();

            if (string.IsNullOrWhiteSpace(clienteId))
            {
                var existe =  await _clienteRepository.ExistByIdAsync(clienteId);

                if (!existe)
                {
                    resposta.Reports.Add(Report.Create($"Cliente {clienteId} não encontrado"));
                    return resposta;
                }    
            }
            
            var data = await _clienteRepository.ListByFilterAsync(clienteId, clienteNome);
            resposta.Data = data;
            return resposta;
        }

        public async Task<Response> UpdateAsync(Clientes cliente)
        {
            var resposta = new Response();
            
            var validacao = new ClienteValidation();
            var erros= validacao.Validate(cliente).GetErros();

            if (erros.Reports.Count > 0)
                return erros;

            var existe =  await _clienteRepository.ExistByIdAsync(cliente.Id);

            if (!existe)
            {
                resposta.Reports.Add(Report.Create($"Cliente {cliente.Id} não encontrado"));
                return resposta;
            }
            await _clienteRepository.UpdateAsync(cliente);
            
            return resposta;
        }
    }
}