﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HepsiBurada.MODELS.Enums;
using HepsiBurada.MODELS.Enums.Notebook;

namespace HepsiBurada.MODELS.Entities
{
    [Table("Bilgisayar")]
    public class Notebook
    {
        [Key]

        [DisplayName("Notebook ID")]
        public Guid NotebookID { get; set; } = Guid.NewGuid();
        [DisplayName("Ürün Tipi")]
        public Elektronik Elektronik { get; set; }
        [DisplayName("Notebook Markası")]
        public NotebookMarka NotebookMarka { get; set; }
        [DisplayName("Notebook İşlemci")]
        public NotebookIslemci NotebookIslemci { get; set; }
        [DisplayName("Notebook Ram")]
        public NotebookRam NotebookRam { get; set; }
        [DisplayName("Notebook Ram Tipi")]
        public NotebookRamTipi NotebookRamTipi { get; set; }
        [DisplayName("Notebook Harddisk")]
        public NotebookHarddisk NotebookHarddisk { get; set; }
        [DisplayName("Notebook Ekran Kartı Markası")]
        public NotebookEkranKartiMarka NotebookEkranKartiMarka { get; set; }
        [DisplayName("Notebook Ekran Kartı Hafızası")]
        public NotebookEkranKartiHafiza NotebookEkranKartiHafiza { get; set; }
        [DisplayName("Notebook Klavyesi")]
        public NotebookKlavye NotebookKlavye { get; set; }
        [DisplayName("Notebook Ağırlık")]
        public NotebookAgirlik NotebookAgirlik { get; set; }
        [DisplayName("Notebook İşletim Sistemi")]
        public NotebookIsletimSistemi NotebookIsletimSistemi { get; set; }
        [DisplayName("Notebook Garanti Süresi")]
        public NotebookGarantiSuresi NotebookGarantiSuresi { get; set; }
        [StringLength(100, ErrorMessage = "Ürün Resmi Seçiniz", MinimumLength = 3)]
        [DisplayName("Notebook Resmi Ekleyiniz :")]
        public string NotebookResim1 { get; set; }
        [StringLength(100, ErrorMessage = "Ürün Resmi Seçiniz", MinimumLength = 3)]
        [DisplayName("Notebook Resmi Ekleyiniz :")]
        public string NotebookResim2 { get; set; }
        [StringLength(100, ErrorMessage = "Ürün Resmi Seçiniz", MinimumLength = 3)]
        [DisplayName("Notebook Resmi Ekleyiniz :")]
        public string NotebookResim3 { get; set; }
        
        [DisplayName("Notebook Fiyatı")]
        public decimal NotebookFiyat { get; set; }
        
        [DisplayName("Notebook Stok")]
        public int NotebookStok { get; set; }
        public string AdminID { get; set; }
        public DateTime EklenmeTarihi { get; set; } = DateTime.Now;
        public virtual ICollection<NotebookYorum> NotebookYorum { get; set; } = new HashSet<NotebookYorum>();

    }
}
