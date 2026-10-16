using PresseHMsoftware.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresseHMsoftware.Domain.Entités
{

    /// <summary>
    ///  Classe Titre 
    /// </summary>
    public class Titre
    {
        public int Id { get; set; } = Guid.NewGuid().GetHashCode();
        public string Nom { get; set; } = string.Empty;
        public string Issn { get; set; } = string.Empty;
        public Periodicite Periodicite { get; set; }
        public decimal PrixUnitaire { get; set; }
        public string Categorie { get; set; } = string.Empty;

        // Navigation property for the related Abonnement entities
        public ICollection<Abonnement> Abonnements { get; set; } = new List<Abonnement>();
        public ICollection<Parution> Parutions { get; set; } = new List<Parution>();
    }
}
