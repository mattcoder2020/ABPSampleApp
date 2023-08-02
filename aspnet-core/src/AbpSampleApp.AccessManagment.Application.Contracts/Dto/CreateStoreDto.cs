using AbpSampleApp.AccessManagment.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace AbpSampleApp.AccessManagment.Dto
{
    public class CreateStoreDto
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(40)]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength (20)]
        public string Phone { get; set; }

        [Required]
        public StoreStatus Status { get; set; }

        public DateTime CreationDate { get; set; }
    }
}