using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExamApp.Models
{
    [Table("TAccountRoleDtl")]
    public class TAccountRoleDtl
    {
        [Key]
        public int RoleID { get; set; }

        public string RoleDesc { get; set; }
    }
}
