//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PM01
{
    using System;
    using System.Collections.Generic;
    
    public partial class Units
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Units()
        {
            this.Employees = new HashSet<Employees>();
            this.UnitLeaders = new HashSet<UnitLeaders>();
        }
    
        public int ID { get; set; }
        public string Unit_name { get; set; }
        public string City { get; set; }
        public int EmployeesCount { get; set; }

        public override string ToString()
        {
            return Unit_name + " ( г. " + City + " )";
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employees> Employees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UnitLeaders> UnitLeaders { get; set; }
    }
}
