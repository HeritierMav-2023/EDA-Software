using System;
using System.Collections.Generic;
using System.Text;

namespace PresseHMsoftware.Domain.Entités
{

    /// <summary>
    /// Représente une parution d'un titre, incluant l'identifiant, le numéro, la date de parution prévue, le
    /// code-barres et les relations vers le titre et les réceptions
    /// </summary>
    /// <remarks>Entité destinée à la persistance : l'identifiant est généré par défaut et la collection
    /// Receptions est initialisée pour éviter les valeurs nulles.</remarks>
    public class Parution
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid TitreId { get; set; }
        public string Numero { get; set; } = string.Empty;
        public DateTime DateParutionPrevue { get; set; }
        public string CodeBarres { get; set; } = string.Empty;

        // Propriétés de navigation
        public Titre Titre { get; set; } = null!;
        public ICollection<Reception> Receptions { get; set; } = new List<Reception>();
    }
}
