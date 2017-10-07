﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using bc.cores.repositories.Enums;

namespace bc.cores.repositories.Models.Exams
{
    public class Exam
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public int Visibility { get; set; }

        public int? MaxQuestionsToPlay { get; set; }

        [NotMapped]
        public Visibility VisibilityEnum => (Visibility)Visibility;
    }
}
