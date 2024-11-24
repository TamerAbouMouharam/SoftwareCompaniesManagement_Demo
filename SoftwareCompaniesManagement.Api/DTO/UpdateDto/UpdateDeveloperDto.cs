using System.ComponentModel.DataAnnotations;

namespace SoftwareCompaniesManagement.Api.DTO.UpdateDto;

public record class UpdateDeveloperDto(
    [Required]
    [StringLength(30)]
    string FullName,
    
    [Required]
    [Range(0, double.MaxValue)]
    decimal Salary,

    DateOnly Birthdate,

    DateOnly HiringDate,

    [Required]
    int AccountId,

    [Required]
    int CompanyId
);
