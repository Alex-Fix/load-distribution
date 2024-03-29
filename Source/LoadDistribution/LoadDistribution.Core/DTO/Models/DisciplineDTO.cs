﻿namespace LoadDistribution.Core.DTO.Models;

public class DisciplineDTO : BaseProjectRelatedDTO
{
      public string Name { get; set; } = string.Empty;
      public string? Type { get; set; }
      public int Term { get; set; }
      public string? EducationLevel { get; set; }
      public string EducationForm { get; set; } = string.Empty;
      public string PlanIndex { get; set; } = string.Empty;
      public string Speciality { get; set; } = string.Empty;
      public string GroupAbbreviation { get; set; } = string.Empty;
      public string Specialization { get; set; } = string.Empty;
      public string? Institute { get; set; }
      public int Course { get; set; }
      public int StudentCount { get; set; }
      public int BudgetStudentCount { get; set; }
      public int ComercialStudentCount { get; set; }
      public int GroupCount { get; set; }
      public int SubgroupCount { get; set; }
      public int ThreadCount { get; set; }
      public int UniversityId { get; set; }
      public UniversityDTO? University { get; set; }
}
