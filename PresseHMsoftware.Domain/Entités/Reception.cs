using PresseHMsoftware.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PresseHMsoftware.Domain.Entités
{
    public class Reception
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ParutionId { get; set; }
        public DateTime DateReception { get; set; } = DateTime.UtcNow;
        public int QuantiteRecue { get; set; }
        public StatutReception Statut { get; set; } = StatutReception.Conforme;
        public string ControleurId { get; set; } = string.Empty;

        // Propriété de navigation
        public Parution Parution { get; set; } = null!;
    }
}
