using System.ComponentModel.DataAnnotations;

namespace BEAUTIFY_PACKAGES.BEAUTIFY_PACKAGES.INFRASTRUCTURE.DependencyInjection.Options;

public record CloudinaryOptions
{
    [Required]public string CloudName { get; set; }
    [Required]public string ApiKey { get; set; }
    [Required]public string ApiSecret { get; set; }
}