//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoReservation.Dal
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    
    public abstract partial class Auto
    {
        public Auto()
        {
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int Id { get; set; }
        public string Marke { get; set; }
        public double Tagestarif { get; set; }
    
        public virtual ICollection<Reservation> Reservations { get; set; }

        public virtual string Validate()
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrEmpty(Marke))
            {
                error.AppendLine("- Marke ist nicht gesetzt.");
            }
            if (Tagestarif <= 0)
            {
                error.AppendLine("- Tagestarif muss gr�sser als 0 sein.");
            }

            if (error.Length == 0) { return null; }

            return error.ToString();
        }
        public abstract Auto Clone();
    }
}
