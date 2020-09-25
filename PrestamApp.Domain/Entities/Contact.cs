using System.Collections.Generic;


namespace PrestamApp.Domain.Entities
{
    public class Contact : IAuditable
    {
        public Contact()
        {
           Loans = new HashSet<Loan>();
           PersonalRefferences = new HashSet<PersonalRefference>();
        }
        public int Id { get; set; }
        public string ContactNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public string UrlFile { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public int ZoneId { get; set; }
        public  Zone Zone { get; set; }
        public Address Address { get; set; }
        public ICollection<Loan> Loans { get; private set; }
        public ICollection<PersonalRefference> PersonalRefferences { get; private set; }

        //Agregar Campo para Cargar Cedula/Pasaportes del Contacto
    }
}
