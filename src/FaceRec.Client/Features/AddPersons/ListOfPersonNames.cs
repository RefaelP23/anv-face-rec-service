﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceRec.Client.Features.AddPersons
{
    public static class ListOfPersonNames
    {
        private static readonly List<string> _names = new List<string> {
            "Consuelo Penson",
            "Nina Lockamy",
            "Lisette Strayhorn",
            "Wendy Bevers",
            "Phung Creger",
            "Toni Keasey",
            "Irving Pecor",
            "Wendie Digennaro",
            "Tatum Diep",
            "Sunshine Herz",
            "Valencia Saiz",
            "Gretta Wiechmann",
            "Arnette Thierry",
            "Eldon Christy",
            "Carmen Scribner",
            "Lien Eubank",
            "Sunday Learned",
            "Rubi Brinkerhoff",
            "Starr Perrella",
            "Nikia Montelongo",
            "Petronila Dentler",
            "Rossana Hunsinger",
            "Laila Tullos",
            "Ricarda Garret",
            "Johnie Releford",
            "Nicki Kirchner",
            "Antonietta Marc",
            "Terina Pickerel",
            "Odis Studebaker",
            "Anitra Hutchins",
            "Teisha Kamm",
            "Lanita Dunavant",
            "Jenine Seymore",
            "Chelsey Grooms",
            "Sadie Clauson",
            "Bernie Dougal",
            "Clayton Dittman",
            "Lourdes Stowell",
            "Abbey Volkert",
            "Darrel Danielson",
            "Lashay Deaver",
            "Gary Torain",
            "Nichole Totten",
            "Caryn Gisi",
            "Pricilla Lass",
            "Jacquelyn Duckworth",
            "Marla Healy",
            "Shameka Fan",
            "Riva Asbell",
            "Dawn Croll",
            "Carli Cerniglia",
            "Deann Chance",
            "Tomas Broadhead",
            "Benita Bunn",
            "Chrissy Brenner",
            "Lorie Clink",
            "Kamala Costigan",
            "Ute Lockett",
            "Honey Pettway",
            "Raymonde Lindley",
            "Shenna Funes",
            "William Oberman",
            "Tricia Stimpson",
            "Valarie Veiga",
            "Miesha Box",
            "Henriette Caddy",
            "Lynnette Deibel",
            "Scot Sanroman",
            "Flor Keep",
            "Blaine Stricklin",
            "Preston Brehm",
            "Rachael Inniss",
            "Wynona Teller",
            "Yoshiko Fagen",
            "Burl Waggener",
            "Katelynn Artist",
            "Christeen Malick",
            "Noble Sprowl",
            "Ardelia Shirey",
            "Carlita Keltz",
            "Valeri Burbridge",
            "Louisa Winans",
            "Verlie Rossiter",
            "Yadira Arce",
            "Shante Searcy",
            "Jeane Irwin",
            "Marquitta Bakken",
            "Ila Twomey",
            "Chaya Casale",
            "Arturo Bruton",
            "Sarita Lundell",
            "Conchita Fernandez",
            "Sherwood Aubert",
            "Lilian Givens",
            "Vernetta Fitzsimons",
            "Rhett Virgen",
            "Johanna Silversmith",
            "Patience Wargo",
            "Marni Derrickson",
            "Joella Fritsch",
            };
        private static readonly Random _random = new Random();

        public static string GetName()
        {
            var index = _random.Next(0, _names.Count);
            return _names[index];
        }
    }
}