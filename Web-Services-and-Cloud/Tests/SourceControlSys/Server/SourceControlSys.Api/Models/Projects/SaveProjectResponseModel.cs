namespace SourceControlSys.Api.Models.Projects
{
    using SoureceControlSys.Common.Constants;
    using System.ComponentModel.DataAnnotations;

    public class SaveProjectResponseModel
    {
        [Required]
        [MaxLength(ValidationConstants.MaxProjectName)]
        public string Name { get; set; }

        [MaxLength(ValidationConstants.MaxProjectDescription)]
        public string Description { get; set; }

        public bool Private { get; set; }
    }
}