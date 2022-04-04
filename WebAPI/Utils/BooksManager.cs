using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Utils
{
    public static class BooksManager
    {
        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Noumenoir",
                Author = "Flavius Ardelean",
                Description = "România anului 2085 este împărțită aproape în totalitate în cei care fac literatură și cei care o judecă. În fosta mânăstire de maici transformată în hotel pentru scriitorii exilați care nu mai pot scrie, „A nus Dei”, fostul scriitor Radu Lenea își duce traiul prin crâșmele de la ultimul etaj, chinuit de insomnie și dependent de droguri distilate din figuri de stil. Pacea îi este tulburată într-o seară în care Lizaveta Markov, una dintre femeile fatale ale hotelului, îi dă în grijă un manuscris secret care poate schimba radical cursul istoriei. Prizonier în vâltoarea tragediilor, prins în bătaia focurilor și hăituit de înspăimântătorii Kritikos, gangsteri ai Secretariatului de Critica al lui M. Namolescu și mâna sa dreaptă, Khan Kristos Kanacke, Radu Lenea se hotărăște să scoată manuscrisul din hotel, chiar cu prețul identității sale. Manuscrise secrete, organizații clandestine, urmăriri și crime, sex si umbrele unor iubiri sunt ingredientele acestui delir literar în care nimic nu este ceea ce pare.",
                PublicationDate = new DateTime(2000, 10, 5)
            },
            new Book
            {
                Id = 2,
                Title = "Good Omens",
                Author = "Terry Pratchett",
                Description = "There is a hint of Armageddon in the air. According to the Nice and Accurate Prophecies of Agnes Nutter, Witch (recorded, thankfully, in 1655, before she blew up her entire village and all its inhabitants, who had gathered to watch her burn), the world will end on a Saturday. Next Saturday, in fact. So the Armies of Good and Evil are massing, the four Bikers of the Apocalypse are revving up their mighty hogs and hitting the road, and the world's last two remaining witchfinders are getting ready to Fight the Good Fight. Atlantis is rising. Frogs are falling. Tempers are flaring, and everything appears to be going to Divine Plan. Except that a somewhat fussy angel and a fast-living demon are not particularly looking forward to the coming Rapture. They've lived amongst Humanity for millennia, and have grown rather fond of the lifestyle. So if Crowley and Aziraphale are going to stop it from happening, they've got to find and kill the AntiChrist (which is a shame, really, as he's a nice kid). There's just one glitch: someone seems to have misplaced him. Terry Pratchett and Neil Gaiman's brilliantly dark and funny take on mankind's final judgment is back, in a new hardcover edition which includes an introduction by the authors.",
                PublicationDate = new DateTime(2005, 12, 3),
            },
            new Book
            {
                Id = 3,
                Title = "Carmilla",
                Author = "J. Sheridan Le Fanu",
                Description = "Carmilla is an 1872 Gothic novella by Irish author Joseph Sheridan Le Fanu and one of the early works of vampire fiction, predating Bram Stoker's Dracula by 26 years. First published as a serial in The Dark Blue the story is narrated by a young woman preyed upon by a female vampire named Carmilla, later revealed to be Mircalla, Countess Karnstein (Carmilla is an anagram of Mircalla).",
                PublicationDate = new DateTime(2010, 5, 20)
            },
            new Book
            {   
                Id = 4,
                Title = "Lantul de aur",
                Author = "Cassandra Clare",
                Description = "Cordelia Carstairs este vânătoare de umbre, o războinică plină de curaj, antrenată încă din fragedă pruncie să le vină de hac demonilor. Atunci când tatăl îi este acuzat de crimă, tânăra și fratele ei pornesc spre Londra, unde speră să găsească ajutor printre membrii Enclavei, împiedicând în același timp ruinarea familiei. În vreme ce mama Cordeliei nu dorește decât să își vadă fiica măritată mai repede, fata pare mai degrabă hotărâtă să devină eroină, decât mireasă. Curând, Cordelia îi reîntâlnește pe Lucie și James Herondale, prietenii săi din copilărie, și, alături de ei, pășește în lumea fastuoasă a balurilor și a reuniunilor cu vampiri, vârcolaci și sirene. În tot acest timp, tânăra trebuie să-și tăinuiască dragostea pentru James, care este îndrăgostit de altcineva.",
                PublicationDate = new DateTime(2012, 9, 15)
            }
        };
    }
}
