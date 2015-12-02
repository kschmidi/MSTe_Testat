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
    
    public partial class LuxusklasseAuto : Auto
    {
        public double Basistarif { get; set; }
        public override Auto Clone()
        {
            return new LuxusklasseAuto {
                Id = Id,
                Marke = Marke,
                Tagestarif = Tagestarif,
                Basistarif = Basistarif
            };
        }
        public override string Validate()
        {
            StringBuilder error = new StringBuilder(base.Validate());

            if (Basistarif <= 0)
            {
                error.AppendLine("- Basistarif eines Luxusautos muss gr�sser als 0 sein.");
            }

            if (error.Length == 0) { return null; }

            return error.ToString();
        }
    }
}
