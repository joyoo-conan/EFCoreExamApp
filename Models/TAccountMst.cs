using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreExamApp.Models
{
    [Table("TAccountMst")]
    public class TAccountMst
    {
        /// <summary>
        /// Table identity (PK)
        /// </summary>
        [Key]
        public Int64 Id { get; set; }

        public string UserID { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public int RoleID { get; set; }

        public int State { get; set; }

        public DateTime RegDTM { get; set; }

        public DateTime ModDTM { get; set; }
    }
}
