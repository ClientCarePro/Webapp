using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCCPro.Shared
{
    public class Clienten
    {
        public int Id { get; set; }
                    
        public string Voornaam { get; set; } = string.Empty;

        public string Achternaam { get; set; } = string.Empty;

        public string Geboortedatum { get; set; } = string.Empty;

        public string Straatnaam { get; set; } = string.Empty;

        public string Huisnummer { get; set; } = string.Empty;

        public string Woonplaats { get; set; } = string.Empty;

        public bool Begeleidwonen { get; set; } = false;
        
        public bool AmbulanteBegeleiding { get; set; } = false;

        public string GeindiceerdeZZPRange { get; set; } = string.Empty;

        public string Aanmelddatum { get; set; } = string.Empty;

        public bool Actief { get; set; } = false;

        public string Afmelddatum { get; set ; } = string.Empty;    

        public int AantalRapportages { get; set; } = 0; 

        


    }
}

