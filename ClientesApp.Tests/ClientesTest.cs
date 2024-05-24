using Bogus;
using ClientesApp.API.DTO.Request;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp.Tests
{
    public class ClientesTest
    {
        [Fact]
        public void Cadastrar_Cliente_Com_Sucesso_Test()
        {
            #region Gerar os dados do cliente

            var faker = new Faker("pt_BR");

            var request = new CriarUsuarioRequestDTO
            {
                Nome = faker.Person.FullName,
                Email = faker.Internet.Email(),
                Cpf = faker.Random.Replace("###########")
            };

            var json = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            #endregion

            #region Enviando a requisição para a API

            var client = new WebApplicationFactory<Program>().CreateClient();
            var result = client.PostAsync("/api/cliente/criar", json).Result;

            #endregion

            #region Verificando a resposta

            result.StatusCode.Should().Be(HttpStatusCode.Created);
            result.Content.ReadAsStringAsync().Result.Should().Contain("Cliente cadastrado com sucesso!");

            #endregion
        }
    }
}
