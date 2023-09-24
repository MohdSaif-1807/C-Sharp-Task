using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Collections.Generic;
using System.Security.Policy;

namespace webapi.Models
{
    public class ExperienceHelper
    {
        public bool? Mandatory { get; set; }
        public bool? Hide { get; set; }
        public List<ExperienceTab>? ExperienceSection { get; set; }
    }
    public class ExperienceTab
    {
        public string? CompanyName { get; set; }
        public string? Title { get; set; }
        public string? WorkLocation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public class EducationHelper
    {
        public bool? Mandatory { get; set; }
        public bool? Hide { get; set; }

        public List<EducationTab>? EducationSection { get; set; }

    }
    public class EducationTab
    {
        public string? School { get; set; }
        public string? Degree { get; set; }
        public string? CourseName { get; set; }
        public string? StudyLocation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? CurrentStudyStatus { get; set; }

    }
    public class PersonalInfoQuestion
    {
        public string? Type { get; set; }
        public string? Question { get; set; }
        public List<string>? Choice { get; set; }
        public bool? EnableOption { get; set; }
        public int? NumberOfChoices { get; set; }
    }
    public class AdditionalQuestionsTab
    {
        public string? Type { get; set; }
        public string? Question { get; set; }
    }
    public class AdditionalQuestionsHelper
    {
        [StringLength(250, ErrorMessage = "Paragraph can't be longer than 500 words")]
        public string? Paragraph { get; set; }
        public int? YearOfGraduation { get; set; }
        public string? Question { get; set; }
        public List<string>? Choice { get; set; }
        public AdditionalQuestionsTab? RejectedByUK { get; set; }

    }
    public class Option
    {
        public bool? Internal { get; set; }
        public bool? Hide { get; set; }
    }
    public class ResumeHelper
    {
        public bool? Mandatory { get; set; }
        public bool? Hide { get; set; }
    }
    public class ApplicationFormModel
    {
        [Required(ErrorMessage = "Image is required.")]
        public string? Image { get; set; }
        public Option? FirstName { get; set; }
        public Option? LastName { get; set; }
        public Option? Email { get; set; }
        public Option? PhoneNumber { get; set; }
        public Option? Nationality { get; set; }
        public Option? CurrentResidence { get; set; }
        public Option? IDNumber { get; set; }
        public Option? DateOfBirth { get; set; }
        public Option? Gender { get; set; }
        public PersonalInfoQuestion? PersonalQuestion { get; set; }
        public EducationHelper? Education { get; set; }
        public ExperienceHelper? Experience { get; set; }
        public ResumeHelper? Resume { get; set; }
        public ProfileInfoQuestion? ProfileQuestion { get; set; }
        public AdditionalQuestionsHelper? AdditionalQuestion { get; set; }

    };
    public class ProfileInfoQuestion
    {
        public string? Type { get; set; }
        public string? Question { get; set; }
        public List<string>? Choice { get; set; }
    }
}