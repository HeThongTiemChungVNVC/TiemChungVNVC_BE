using AutoMapper;
using BLL.Requests;
using BLL.Responses;
using DAL.Dtos;

namespace BLL.Configurations
{
    public class ConfigureAutoMapper : Profile
    {
        public ConfigureAutoMapper()
        {
            // User
            CreateMap<DtoUser, UserResponse>();
            CreateMap<UserResponse, DtoUser>();
            CreateMap<RegisterRequest, DtoUser>();
            CreateMap<DtoUser, RegisterRequest>();
            // Information
            CreateMap<UserResponse, DtoEmployee>().ReverseMap();
            CreateMap<InformationResponse, DtoInformation>();
            CreateMap<DtoInformation, InformationResponse>();
            CreateMap<DtoInformation, UserResponse>();
            CreateMap<DtoInformation, RegisterRequest>().ReverseMap();
            // recovery token
            CreateMap<PasswordRecoveryTokenResponse, DtoPasswordRecoveryToken>();
            CreateMap<DtoPasswordRecoveryToken, PasswordRecoveryTokenResponse>();
            // Province
            CreateMap<CityResponse, DtoCity>();
            CreateMap<DistrictResponse, DtoDistrict>();
            CreateMap<WardResponse, DtoWard>();
            // Category Position
            CreateMap<CategoryPositionResponse, DtoCategoryPosition>().ReverseMap();
            CreateMap<CreateCategoryPositionRequest, DtoCategoryPosition>().ReverseMap();
            CreateMap<UpdateCategoryPositionRequest, DtoCategoryPosition>().ReverseMap();
            // Category Vaccine
            CreateMap<DtoCategoryVaccine, CategoryVaccineResponse>().ReverseMap();
            CreateMap<DtoCategoryVaccine, CreateCategoryVaccineRequest>().ReverseMap();
            CreateMap<DtoCategoryVaccine, UpdateCategoryVaccineRequest>().ReverseMap();
            // Customer response
            CreateMap<CustomerResponse, DtoCustomer>().ReverseMap();
            CreateMap<CreateCustomerRequest, DtoCustomer>().ReverseMap();
            CreateMap<UpdateCustomerRequest, DtoCustomer>().ReverseMap();
            // Detail vaccination registration
            CreateMap<DetailVaccinationRegistrationResponse, DtoDetailVaccinationRegistration>().ReverseMap();
            // Detail medical record
            CreateMap<DetailMedicalRecordResponse, DtoDetailMedicalRecord>().ReverseMap();
            CreateMap<CreateDetailMedicalRequest, DtoDetailMedicalRecord>().ReverseMap();
            CreateMap<UpdateDetailMedicalRequest, DtoDetailMedicalRecord>().ReverseMap();
            // Employee
            CreateMap<EmployeeResponse, DtoEmployee>().ReverseMap();
            CreateMap<CreateEmployeeRequest, DtoEmployee>().ReverseMap();
            CreateMap<UpdateEmployeeRequest, DtoEmployee>().ReverseMap();
            // Injection chart
            CreateMap<InjectionChartResponse, DtoInjectionChart>().ReverseMap();
            CreateMap<CreateInjectionChartRequest, DtoInjectionChart>().ReverseMap();
            CreateMap<UpdateInjectionChartRequest, DtoInjectionChart>().ReverseMap();
            // Medical record
            CreateMap<MedicalRecordResponse, DtoMedicalRecord>().ReverseMap();
            CreateMap<CreateMedicalRecordRequest, DtoMedicalRecord>().ReverseMap();
            // price vaccine
            CreateMap<PriceVaccineResponse, DtoPriceVaccine>().ReverseMap();
            CreateMap<CreatePriceVaccineRequest, DtoPriceVaccine>().ReverseMap();
            CreateMap<UpdatePriceVaccineRequest, DtoPriceVaccine>().ReverseMap();
            // Supplier
            CreateMap<DtoSupplier, SupplierResponse>().ReverseMap();
            CreateMap<DtoSupplier, CreateSupplierRequest>().ReverseMap();
            CreateMap<DtoSupplier, UpdateSupplierRequest>().ReverseMap();
            // Vaccination Center
            CreateMap<VaccinationCenterResponse, DtoVaccinationCenter>().ReverseMap();
            CreateMap<CreateVaccinationCenterRequest, DtoVaccinationCenter>().ReverseMap();
            CreateMap<UpdateVaccinationCenterRequest, DtoVaccinationCenter>().ReverseMap();
            //  Vaccination Registration
            CreateMap<VaccinationRegistrationResponse, DtoVaccinationRegistration>().ReverseMap();
            CreateMap<CreateVaccinationRegistrationRequest, DtoVaccinationRegistration>().ReverseMap();
            CreateMap<UpdateVaccinationRegistrationRequest, DtoVaccinationRegistration>().ReverseMap();
            // Vaccine Batch
            CreateMap<VaccineBatchResponse, DtoVaccineBatch>().ReverseMap();
            CreateMap<DtoVaccineBatch, CreateVaccineBatchRequest>().ReverseMap();
            CreateMap<DtoVaccineBatch, UpdateVaccineBatchRequest>().ReverseMap();
            // Vaccine
            CreateMap<VaccineResponse, DtoVaccine>().ReverseMap();
            CreateMap<CreateVaccineRequest, DtoVaccine>().ReverseMap();
            CreateMap<UpdateVaccineRequest, DtoVaccine>().ReverseMap();
        }
    }
}