//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projekt_Sklep
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produkty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produkty()
        {
            this.Sprzedaż = new HashSet<Sprzedaż>();
        }
    
        public long Id_produktu { get; set; }
        public string Nazwa { get; set; }
        public int Id_kategorii { get; set; }
        public string Opis { get; set; }
        public int Ilość { get; set; }
        public double Cena_netto { get; set; }
        public int Id_vatu { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Kategorie Kategorie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaż> Sprzedaż { get; set; }
        public virtual Vat Vat { get; set; }
    }
}