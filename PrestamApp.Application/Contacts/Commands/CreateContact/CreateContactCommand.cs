using MediatR;

namespace PrestamApp.Application.Contacts.Commands.CreateContact
{
    public class CreateContactCommand : IRequest
    {
        //public int Id { get; set; } Identity se encargara de esto
        //public string ContactNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public string UrlFile { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumberOne { get; set; }
        public string PhoneNumberTwo { get; set; }
        public int ZoneId { get; set; }
        public int AddressDataId { get; set; }
        public int AddressTypeId { get; set; }
        public string Street { get; set; }
    }
}