﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Model
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [Required]
        [MaxLength(50)]
        public string Mobile { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public string Yahoo { get; set; }

        [MaxLength(50)]
        public string Facebook { get; set; }

        public bool Status { get; set; }

        public int? DisplayOrder { get; set; }
    }
}