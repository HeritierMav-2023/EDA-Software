using System;
using System.Collections.Generic;
using System.Text;

namespace PresseHMsoftware.Domain.Enums
{
    
    /// <summary>
    /// Spécifie la périodicité d'une occurrence ou d'une opération : Quotidien, Hebdomadaire ou Mensuel.
    /// </summary>
    /// <remarks>Les valeurs numériques sont 1 (Quotidien), 2 (Hebdomadaire) et 3 (Mensuel).</remarks>
    public enum Periodicite
    {
        Quotidien = 1,
        Hebdomadaire = 2,
        Mensuel = 3
    }

    public enum StatutAbonnement
    {
        Actif = 1,
        Expire = 2
    }

    public enum StatutReception
    {
        Conforme = 1,
        Manquant = 2,
        Endommage = 3
    }
}
