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
    
    public partial class Użytkownicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Użytkownicy()
        {
            this.Sprzedaż = new HashSet<Sprzedaż>();
        }
    
        public long Id_użytkownika { get; set; }
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Płeć { get; set; }
        public string E_mail { get; set; }
        public Nullable<int> Telefon { get; set; }
        public string Login { get; set; }
        public string Hasło { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sprzedaż> Sprzedaż { get; set; }
    }
}
