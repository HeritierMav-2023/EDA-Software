using PresseHMsoftware.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresseHMsoftware.Domain.Entités
{

    /// <summary>
    /// Représente un abonnement à un titre avec ses dates de début et de fin, le fournisseur, le nombre d'exemplaires
    /// et le statut.
    /// </summary>
    /// <remarks>L'identifiant Id est unique. TitreId référence l'entité liée Titre (propriété de navigation
    /// Titre). DateDebut et DateFin définissent la période d'abonnement. Statut utilise l'énumération StatutAbonnement
    /// pour indiquer l'état de l'abonnement.</remarks>
    public class Abonnement
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid TitreId { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public int NombreExemplaires { get; set; }
        public string Fournisseur { get; set; } = string.Empty;
        public StatutAbonnement Statut { get; set; } = StatutAbonnement.Actif;

        // Propriété de navigation
        public Titre Titre { get; set; } = null!;
    }
}
