using System.ComponentModel.DataAnnotations;

namespace webapi.DataTransferObjects
{
    public class ProductDetailsDTO
    {
        public string? id { get; set; }

        [Required(ErrorMessage = "Product Name Required!!")]
        public string? ProgramName { get; set; }

        [StringLength(250, ErrorMessage = "Program Summary can't be longer than Program Summary")]
        public string? ProgramSummary { get; set; }
        [Required(ErrorMessage = "Program Description is Required!!")]
        public string? ProgramDescription { get; set; }
        public List<string>? ProgramKeySkills { get; set; }
        public string? ProgramBenefits { get; set; }
        public string? ApplicationCriteria { get; set; }

        [Required(ErrorMessage = "Program Type Required!!")]
        public string? ProgramType { get; set; }
        public DateTime? ProgramStart 
        {
            get; set;
        }

        [Required(ErrorMessage = "Program start date Required!!")]
        public DateTime? ApplicationOpen {
            get;set;
        }

        [Required(ErrorMessage = "Program close date Required!!")]
        public DateTime? ApplicationClose {
            get; set;
        }

        public string? Duration { get; set; }
        [Required(ErrorMessage = "Program Location Required!!")]
        public string? ProgramLocation { get; set; }
        public bool? IsRemote { get; set; }
        public string? MinQualification { get; set; }
        public int? MaxNumberOfApplicants { get; set; }

    }
}
