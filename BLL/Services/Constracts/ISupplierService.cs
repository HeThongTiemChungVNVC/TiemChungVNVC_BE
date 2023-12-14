using BLL.Common;
using BLL.Requests;
using BLL.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Constracts
{
    public interface ISupplierService
    {
        Task<ApiResponse<string>> CreateSupplier(CreateSupplierRequest createSupplierRequest);

        Task<ApiResponse<List<SupplierResponse>>> GetSuppliers();

        Task<ApiResponse<SupplierResponse>> GetSupplier(string idSupplier);

        Task<ApiResponse<string>> UpdateSupplier(UpdateSupplierRequest updateSupplierRequest);

        Task<ApiResponse<string>> DeleteSupplier(string idSupplier);
    }
}