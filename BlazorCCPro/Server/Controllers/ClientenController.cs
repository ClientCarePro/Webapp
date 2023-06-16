using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCCPro.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClientenController : ControllerBase
	{
		private static List<Clienten> clientens = new List<Clienten>
		{
			new Clienten
			{
				Id = 1,
				Voornaam = "MohammedA",
				Achternaam = "Bouhkari",
				Geboortedatum = "31-08-1988",
				Straatnaam = "Jan van Gentstraat",
				Huisnummer = "122F",
				Woonplaats = "Badhoevendorp",
				Begeleidwonen = true,
				AmbulanteBegeleiding = false,
				GeindiceerdeZZPRange = "ZZP1",
				Actief = true,
				Aanmelddatum = "01-06-2023",
				Afmelddatum = "",
				AantalRapportages = 0
			},
			new Clienten
			{
				Id = 2,
				Voornaam = "Klaasje",
				Achternaam = "van Bommel",
				Geboortedatum = "20-04-1999",
				Straatnaam = "Jan van Gentstraat",
				Huisnummer = "122-F",
				Woonplaats = "Badhoevendorp",
				Begeleidwonen = true,
				AmbulanteBegeleiding = false,
				GeindiceerdeZZPRange = "ZZP-1",
				Actief = true,
				Aanmelddatum = "01-06-2023",
				Afmelddatum = "",
				AantalRapportages = 1
			},
			new Clienten
			{
				Id = 3,
				Voornaam = "Johan",
				Achternaam = "Verstraten",
				Geboortedatum = "01-04-2003",
				Straatnaam = "Jan van Gentstraat",
				Huisnummer = "123-K",
				Woonplaats = "Badhoevendorp",
				Begeleidwonen = false,
				AmbulanteBegeleiding = false,
				GeindiceerdeZZPRange = "ZZP-3",
				Actief = true,
				Aanmelddatum = "01-06-2023",
				Afmelddatum = "",
				AantalRapportages = 3
			}
		};

		[HttpGet]
		public async Task<ActionResult<List<Clienten>>> GetClient()
		{
			return Ok(clientens);
		}

	}
}
