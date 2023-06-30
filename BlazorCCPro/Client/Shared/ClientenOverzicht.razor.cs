using BlazorCCPro.Shared;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Net.Http.Json;


namespace BlazorCCPro.Client.Shared
{
	public partial class ClientenOverzicht

	{

		private static List<Clienten> clientens = new List<Clienten>();
		
			protected override async Task OnInitializedAsync()
		{
			var result = await Http.GetFromJsonAsync<List<Clienten>>("api/Clienten");
			if (result != null)
			{
				clientens = result;
			}
		}

		
	}
}
