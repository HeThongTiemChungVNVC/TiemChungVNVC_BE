using DAL.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Responses
{
    public class CategoryPositionResponse : BaseEntity
    {
        public string Title { get; set; }
        public List<EmployeeResponse> Employees { get; set; }

        public CategoryPositionResponse()
        {
            Employees = new List<EmployeeResponse>();
        }
    }
}