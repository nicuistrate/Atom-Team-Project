using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atom
{
    public class Medicament
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdPharm { get; set; }
        public int IdProspect { get; set; }
        public string MedName { get; set; }
        public int MedPrice { get; set; }
        public int MedQuantity { get; set; }
    }
}
