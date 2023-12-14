using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Dtos
{
    public class DtoCategoryPosition : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<DtoEmployee> Employees { get; set; }

        public DtoCategoryPosition()
        {
            Employees = new HashSet<DtoEmployee>();
        }
    }
}