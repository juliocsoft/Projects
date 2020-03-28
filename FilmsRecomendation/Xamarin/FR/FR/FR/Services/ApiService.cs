using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using FR.Interfaces;
using FR.Models;

namespace FR.Services
{
	public class ApiService : IApi
	{
		private static ApiService _instance;
		public static ApiService Instance = _instance ?? (_instance = new ApiService());

		private readonly IApi _api;

		private ApiService()
		{
			_api = RestService.For<IApi>("https://localhost:5001");
		}

		public async Task<IList<Movie>> Get()
		{
			return await _api.Get();
		}
    }
}
