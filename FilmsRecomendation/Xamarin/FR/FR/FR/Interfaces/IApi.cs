using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using FR.Models;

namespace FR.Interfaces
{
	public interface IApi
	{	

		[Get("/v1/movies")]
		Task<IList<Movie>> Get();
	}
}
