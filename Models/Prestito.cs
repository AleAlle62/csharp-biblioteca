using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Models.Documenti;
//using csharp-biblioteca;

namespace Biblioteca.Models
{
    public class Prestito
    {
        public Prestito(Documento documento, Utente utente)
        {
            Documento = documento;
            Utente = utente;
        }

        public DateTime? DataPrestito { get; set; }
        public DateTime? DataRestituzione { get; set; }
        public Documento Documento { get; set; }
        public Utente Utente { get; set; }
    }
}