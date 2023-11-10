using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace BuscaCepWF
{
    internal interface IceApiService
    {
        [Get("/ws/{cep}/json")]

        Task<CepResponse> GetAddressAsync(string cep);

    }
}
