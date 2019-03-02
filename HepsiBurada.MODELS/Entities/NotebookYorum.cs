using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiBurada.MODELS.Entities
{
    [Table("BilgisayarYorum")]
    public class NotebookYorum
    {
        [Key]
        [DisplayName("Notebook Yorum ID")]
        public Guid NotebookYorumID { get; set; } = Guid.NewGuid();

        public Guid NotebookID { get; set; }
        [ForeignKey("NotebookID")]
        public virtual Notebook Notebook { get; set; }

        public DateTime YorumTarihi { get; set; } = DateTime.Now;
        public string UyeID { get; set; }
        public string UyeAdi { get; set; }
        public string UyeSoyadi { get; set; }
        public string UyeFotografi { get; set; }
        
    }
}
