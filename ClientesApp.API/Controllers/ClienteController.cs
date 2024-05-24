using ClienteApp.Domain.Interfaces.Repositories;
using ClienteApp.Domain.Interfaces.Services;
using ClientesApp.API.DTO.Request;
using ClientesApp.API.DTO.Response;
using ClientesApp.Infra.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClientesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IClienteDomainService _clienteDomainService;

        public ClienteController(IClienteRepository clienteRepository, IClienteDomainService clienteDomainService)
        {
            _clienteRepository = clienteRepository;
            _clienteDomainService = clienteDomainService;
        }

        [HttpPost]
        [Route("criar")]
        [ProducesResponseType(typeof(CriarUsuarioResponseDTO), 201)]
        public IActionResult Post(CriarUsuarioRequestDTO dto)
        {
            try
            {
                var cliente = new Cliente
                {
                    Id = Guid.NewGuid(),                    
                    Nome = dto.Nome,
                    Email = dto.Email,
                    Cpf = dto.Cpf,
                    DataHoraCadastro = DateTime.Now,
                };

                _clienteDomainService.CadastrarCliente(cliente);

                var response = new CriarUsuarioResponseDTO
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Email = cliente.Email,
                    Cpf = cliente.Cpf,
                    DataHoraCadastro = cliente.DataHoraCadastro
                };

                return StatusCode(201, new { message = "Cliente cadastrado com sucesso!", response });
            }
            catch (ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpPut]
        [Route("editar")]
        [ProducesResponseType(typeof(EditarUsuarioResponseDTO), 200)]
        public IActionResult Put(EditarUsuarioRequestDTO dto)
        {
            try
            {
                var cliente = new Cliente
                {
                    Id = dto.Id,
                    Nome = dto.Nome,
                    Email = dto.Email,
                };

                _clienteDomainService.EditarCliente(cliente);

                var response = new EditarUsuarioResponseDTO
                {
                    Id = cliente.Id,
                    Nome = cliente.Nome,
                    Email = cliente.Email,
                    Cpf = cliente.Cpf,
                };

                return Ok(new { message = "Cliente atualizado com sucesso!" });
            }
            catch(ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpDelete]
        [Route("excluir")]
        [ProducesResponseType(typeof(ExcluirUsuarioResponseDTO), 200)]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _clienteDomainService.ExcluirCliente(id);

                return Ok(new { message = "Cliente excluído com sucesso!" });
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpGet]
        [Route("consultar")]
        public IActionResult Get()
        {
            try
            {
                var model = _clienteDomainService.ConsultarClientes();

                return Ok(model);
            }
            catch(Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        [HttpGet]
        [Route("consultar-por-id")]
        [ProducesResponseType(typeof(ObterDadosUsuarioResponseDTO), 200)]
        public IActionResult GetById(Guid id)
        {
            try
            {
                var response = _clienteDomainService.GetById(id);

                return Ok(response);
            }
            catch (ApplicationException e)
            {
                return StatusCode(422, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }
    }
}
