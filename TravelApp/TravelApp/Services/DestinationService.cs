using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Models;

namespace TravelApp.Services
{
    public class DestinationService
    {
        static DestinationService _instance;

        public static DestinationService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DestinationService();

                return _instance;
            }
        }

        internal List<GalleryItem> Gallery
        {
            get
            {
                return new List<GalleryItem>
                {
                    new GalleryItem { Id = 1, Image = "destination1.jpg" },
                    new GalleryItem { Id = 2, Image = "destination2.jpg" },
                    new GalleryItem { Id = 3, Image = "destination3.jpeg" },
                    new GalleryItem { Id = 4, Image = "destination4.jpeg" }
                };
            }
        }

        public List<Destination> RecommendedDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Ferrara", Place = "I luoghi da visitare a Ferrara", Image = "destination1.jpg", Price = 120, About = "Situata nella pianura emiliana, la città sorge a pochi chilometri a sud del fiume Po, a circa 50 km dal mare.", Gallery = Gallery },
                    new Destination { Name = "Roma", Place = "I luoghi da visitare a Roma", Image = "destination2.jpg", Price = 90, About = "I monumenti di Roma\r\nColosseo. Originariamente conosciuto come Anfiteatro Flavio, il Colosseo è il più famoso anfiteatro romano al mondo.\r\n\r\n Per scoprire di più https://www.italia.it/it/lazio/roma.", Gallery = Gallery },
                    new Destination { Name = "Milano", Place = "I lougi da visitare a Milano", Image = "destination3.jpeg", Price = 60, About = "Milano è una città vivace e dinamica, in cui storia e modernità hanno trovato il loro perfetto equilibrio.", Gallery = Gallery },
                    new Destination { Name = "Venezia", Place = "I lougi da visitare a Venezia", Image = "destination4.jpeg", Price = 120, About = "Per molti, la città più bella del mondo. Venezia ha un fascino antico e struggente, e oggi è tra le capitali mondiali dell’arte contemporanea\r\n\r\n Per scoprire di più https://www.italia.it/it/veneto/venezia", Gallery = Gallery },
                };
            }
        }

        public List<Destination> TopDestinations
        {
            get
            {
                return new List<Destination>
                {
                    new Destination { Name = "Ferrara", Place = "Cosa vedere a", Image = "destination1.jpg", Price = 60, About = "Il Rinascimento italiano lascia un segno indelebile su un’altra bellissima città con tante cose da vedere: Ferrara. I mattoncini rossi, le antiche vie, i Palazzi e soprattutto l’antico Castello e l’imponente Cattedrale sono solo alcune delle cose che contraddistinguono questo caratteristico borgo emiliano, annoverato nella lista dell’UNESCO come Patrimonio dell’Umanità.", Gallery = Gallery },
                    new Destination { Name = "Roma", Place = "Cosa vedere a", Image = "destination2.jpg", Price = 120, About = "I monumenti di Roma\r\nColosseo. Originariamente conosciuto come Anfiteatro Flavio, il Colosseo è il più famoso anfiteatro romano al mondo. \r\n\r\n Per scoprire di più https://www.italia.it/it/lazio/roma.", Gallery = Gallery },
                    new Destination { Name = "Milano", Place = "Cosa vedere a", Image = "destination3.jpeg", Price = 120, About = "Milano è una città vivace e dinamica, in cui storia e modernità hanno trovato il loro perfetto equilibrio.\n\nA Milano si lavora, si corre e si fanno gli aperitivi, ma non cadete nel tranello di credere che sia tutto qui. Il capoluogo lombardo vanta importante patrimonio artistico, ospita il prestigioso Teatro alla Scala e un suggestivo skyline punteggiato di grattacieli. Non solo.", Gallery = Gallery },
                    new Destination { Name = "Venezia", Place = "Casa vedere a", Image = "destination4.jpeg", Price = 90, About = "Per molti, la città più bella del mondo. Venezia ha un fascino antico e struggente, e oggi è tra le capitali mondiali dell’arte contemporanea\r\n\r\n Per scoprire di più https://www.italia.it/it/veneto/venezia", Gallery = Gallery },
                };
            }
        }
    }
}
