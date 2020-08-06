namespace Lufthavn
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airplane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airplane()
        {
            this.Rutes = new HashSet<Rute>();
        }
    
        public int AirplaneSerialNumber { get; set; }
        public string OwnerOfAirplaneFK { get; set; }
        public int Passenger { get; set; }
    
        public virtual Airline Airline { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rute> Rutes { get; set; }
    }
}
