using Microsoft.EntityFrameworkCore;
using PrestamApp.Domain.Entities;
using System;

namespace PrestamApp.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RelationShipType>()
                .HasData(
                new RelationShipType { Id = 1, Description = "Familiar" },
                new RelationShipType { Id = 2, Description = "Vecino" },
                new RelationShipType { Id = 3, Description = "Comapañero de Trabajo" },
                new RelationShipType { Id = 4, Description = "Comapañero de Estudio" }
                );

            modelBuilder.Entity<AddressType>()
                .HasData(
                new AddressType { Id = 1, Description = "Casa" },
                new AddressType { Id = 2, Description = "Oficina" },
                new AddressType { Id = 3, Description = "Otros" }
                );

            modelBuilder.Entity<Zone>()
                .HasData(
                new Zone { Id = 1, Description = "Pradera Verde" },
                new Zone { Id = 2, Description = "Intec" }
                );

            modelBuilder.Entity<Collector>()
                .HasData(
                new Collector
                {
                    Id = 1,
                    UserId = 2,
                    Name = "Francis",
                    Address = "Maimón, Bonao, Calle Principal No. 5",
                    Email = "Francis@test.com",
                    PhoneNumberOne = "8095555555"
                },
                new Collector
                {
                    Id = 2,
                    UserId = 3,
                    Name = "Ruddy",
                    Address = "Hacienda Estrella No. 5",
                    Email = "Ruddy@test.com",
                    PhoneNumberOne = "8095555555"
                }
                );
            modelBuilder.Entity<Address>()
                .HasData(
                new Address
                {
                    Id = 1,
                    AddressTypeId = 1,
                    Street = "El Tamarindo"
                },
                new Address
                {
                    Id = 2,
                    AddressTypeId = 1,
                    Street = "El Tamarindo",
                    Refference = "Villa Tropical"
                },
                new Address
                {
                    Id = 3,
                    AddressTypeId = 1,
                    Street = "El Tamarindo"
                },
                new Address
                {
                    Id = 4,
                    AddressTypeId = 1,
                    Street = "El Tamarindo, Calle La Ciencia No. 2"
                },
                new Address
                {
                    Id = 5,
                    AddressTypeId = 1,
                    Street = "El Tamarindo"
                },
                 new Address
                 {
                     Id = 6,
                     AddressTypeId = 1,
                     Street = "El Tamarindo"
                 },
                 new Address
                 {
                     Id = 7,
                     AddressTypeId = 1,
                     Street = "El Tamarindo"
                 },
                 new Address
                 {
                     Id = 8,
                     AddressTypeId = 1,
                     Street = "El Tamarindo"
                 },
                 new Address
                 {
                     Id = 9,
                     AddressTypeId = 1,
                     Street = "El Tamarindo"
                 },
                 new Address
                 {
                     Id = 10,
                     AddressTypeId = 1,
                     Street = "El Tamarindo",
                     Refference = "La Gallera"
                 }
                );
            modelBuilder.Entity<Contact>()
                .HasData(
                new Contact
                {
                    Id = 1,
                    AddressId = 1,
                    ContactNumber = "C-001",
                    IdentificationNumber = "001-0349060-3",
                    Name = "Alba",
                    LastName = "Cuevas Cabrera",
                    Gender = false,
                    PhoneNumberOne = "829-592-2920",
                    ZoneId = 2
                },
                new Contact
                {
                    Id = 2,
                    AddressId = 2,
                    ContactNumber = "C-002",
                    IdentificationNumber = "223-0005438-2",
                    Name = "Mery Elizabeth",
                    LastName = "Zapata",
                    Gender = false,
                    PhoneNumberOne = "555-555-5555",
                    ZoneId = 1
                },
                new Contact
                {
                    Id = 3,
                    AddressId = 3,
                    ContactNumber = "C-003",
                    IdentificationNumber = "076-0010914-9",
                    Name = "Erasmo",
                    LastName = "Nova Florian",
                    Gender = true,
                    PhoneNumberOne = "809-509-1947",
                    ZoneId = 1
                },
                new Contact
                {
                    Id = 4,
                    AddressId = 4,
                    ContactNumber = "C-004",
                    IdentificationNumber = "024-0016983-4",
                    Name = "Adela",
                    LastName = "Hernandez",
                    Gender = false,
                    PhoneNumberOne = "829-260-2377",
                    ZoneId = 1
                },
                new Contact
                {
                    Id = 5,
                    AddressId = 5,
                    ContactNumber = "C-005",
                    IdentificationNumber = "402-2321927-6",
                    Name = "Janser Michael",
                    LastName = "Aguas Vivas",
                    Gender = true,
                    PhoneNumberOne = "555-555-5555",
                    ZoneId = 1
                },
                new Contact
                {
                    Id = 6,
                    AddressId = 6,
                    ContactNumber = "C-006",
                    IdentificationNumber = "013-0023998-3",
                    Name = "Rikelvin Alberto",
                    LastName = "Rodríguez",
                    Gender = true,
                    PhoneNumberOne = "849-252-2039",
                    ZoneId = 2
                },
                new Contact
                {
                    Id = 7,
                    AddressId = 7,
                    ContactNumber = "C-007",
                    IdentificationNumber = "108-0001178-4",
                    Name = "Castulo",
                    LastName = "Mora Montero",
                    Gender = true,
                    PhoneNumberOne = "829-905-9263",
                    ZoneId = 1
                },
                new Contact
                {
                    Id = 8,
                    AddressId = 8,
                    ContactNumber = "C-008",
                    IdentificationNumber = "001-1419722-1",
                    Name = "Daniel",
                    LastName = "Ferjuste",
                    Gender = true,
                    PhoneNumberOne = "555-555-5555",
                    ZoneId = 2
                },
                new Contact
                {
                    Id = 9,
                    AddressId = 9,
                    ContactNumber = "C-009",
                    IdentificationNumber = "001-1527870-7",
                    Name = "Franklin",
                    LastName = "Montero Montero",
                    Gender = true,
                    PhoneNumberOne = "829-298-4775",
                    ZoneId = 1
                },
                new Contact
                {
                    Id = 10,
                    AddressId = 10,
                    ContactNumber = "C-010",
                    IdentificationNumber = "001-0229497-2",
                    Name = "Nestor",
                    LastName = "Casamora Montero",
                    Gender = true,
                    PhoneNumberOne = "809-861-9080",
                    ZoneId = 2
                }
                );

            modelBuilder.Entity<TimeFrame>()
                .HasData(
                new TimeFrame { Id = 1, Description = "Diario", CountDay = 1 },
                new TimeFrame { Id = 2, Description = "Interdiario", CountDay = 2 },
                new TimeFrame { Id = 3, Description = "Semanal", CountDay = 7 },
                new TimeFrame { Id = 4, Description = "Quincenal", CountDay = 14 },
                new TimeFrame { Id = 5, Description = "Mensual", CountDay = 30 },
                new TimeFrame { Id = 6, Description = "Anual", CountDay = 365 }

                );

            modelBuilder.Entity<Loan>()
                    .HasData(
                new Loan
                {
                    Id = 1,
                    Code = "L-001",
                    ContactId = 1,
                    SimpleInterest = true,
                    LoanDate = DateTime.Parse("2018-11-30"),
                    EndDate = DateTime.Parse("2019-03-01"),
                    NumberOfDue = 13,
                    NumberOfDuesPaid = 4,
                    TimeFrameId = 3,
                    Interest = 6000.00M,
                    InterestRate = 2.50M,
                    LoanAmount = 20000.00M,
                    TotalCapitalAmount = 13846.16M,
                    TotalBalance = 18000.00M,
                    IsActive = true,
                    UpToDate = false,
                },
                new Loan
                {
                    Id = 2,
                    Code = "L-002",
                    ContactId = 2,
                    SimpleInterest = true,
                    LoanDate = DateTime.Parse("2018-11-23"),
                    EndDate = DateTime.Parse("2019-03-08"),
                    NumberOfDue = 15,
                    NumberOfDuesPaid = 5,
                    TimeFrameId = 3,
                    Interest = 3500.00M,
                    InterestRate = 2.50M,
                    LoanAmount = 10000.00M,
                    TotalCapitalAmount = 6666.65M,
                    TotalBalance = 9000.00M,
                    IsActive = true,
                    UpToDate = false,
                },
                new Loan
                {
                    Id = 3,
                    Code = "L-003",
                    ContactId = 3,
                    SimpleInterest = true,
                    LoanDate = DateTime.Parse("2018-11-09"),
                    EndDate = DateTime.Parse("2019-03-08"),
                    NumberOfDue = 15,
                    NumberOfDuesPaid = 7,
                    TimeFrameId = 3,
                    Interest = 3500.00M,
                    InterestRate = 2.50M,
                    LoanAmount = 10000.00M,
                    TotalCapitalAmount = 5333.31M,
                    TotalBalance = 7200.00M,
                    IsActive = true,
                    UpToDate = false,
                },
                 new Loan
                 {
                     Id = 4,
                     Code = "L-004",
                     ContactId = 4,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2017-07-31"),
                     EndDate = DateTime.Parse("2017-10-30"),
                     NumberOfDue = 13,
                     NumberOfDuesPaid = 7,
                     TimeFrameId = 3,
                     Interest = 3000.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 10000.00M,
                     TotalCapitalAmount = 4913.39M,
                     TotalBalance = 6298.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                 new Loan
                 {
                     Id = 5,
                     Code = "L-005",
                     ContactId = 5,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2017-09-11"),
                     EndDate = DateTime.Parse("2017-12-11"),
                     NumberOfDue = 13,
                     NumberOfDuesPaid = 0,
                     TimeFrameId = 3,
                     Interest = 600.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 2000.00M,
                     TotalCapitalAmount = 2000.00M,
                     TotalBalance = 2600.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                 new Loan
                 {
                     Id = 6,
                     Code = "L-006",
                     ContactId = 5,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2017-12-11"),
                     EndDate = DateTime.Parse("2018-03-12"),
                     NumberOfDue = 13,
                     NumberOfDuesPaid = 5,
                     TimeFrameId = 3,
                     Interest = 900.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 3000.00M,
                     TotalCapitalAmount = 1740.38M,
                     TotalBalance = 2225.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                 new Loan
                 {
                     Id = 7,
                     Code = "L-007",
                     ContactId = 6,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2018-05-07"),
                     EndDate = DateTime.Parse("2018-08-20"),
                     NumberOfDue = 15,
                     NumberOfDuesPaid = 6,
                     TimeFrameId = 3,
                     Interest = 23450.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 67000.00M,
                     TotalCapitalAmount = 36853.31M,
                     TotalBalance = 49360.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                 new Loan
                 {
                     Id = 8,
                     Code = "L-008",
                     ContactId = 7,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2018-12-17"),
                     EndDate = DateTime.Parse("2019-03-18"),
                     NumberOfDue = 13,
                     NumberOfDuesPaid = 1,
                     TimeFrameId = 3,
                     Interest = 1500.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 5000.00M,
                     TotalCapitalAmount = 4615.38M,
                     TotalBalance = 6000.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                 new Loan
                 {
                     Id = 9,
                     Code = "L-009",
                     ContactId = 8,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2018-12-21"),
                     EndDate = DateTime.Parse("2019-03-05"),
                     NumberOfDue = 15,
                     NumberOfDuesPaid = 1,
                     TimeFrameId = 3,
                     Interest = 5250.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 15000.00M,
                     TotalCapitalAmount = 14000.00M,
                     TotalBalance = 18900.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                 new Loan
                 {
                     Id = 10,
                     Code = "L-010",
                     ContactId = 9,
                     SimpleInterest = true,
                     LoanDate = DateTime.Parse("2018-10-19"),
                     EndDate = DateTime.Parse("2019-03-08"),
                     NumberOfDue = 20,
                     NumberOfDuesPaid = 8,
                     TimeFrameId = 3,
                     Interest = 8000.00M,
                     InterestRate = 2.50M,
                     LoanAmount = 20000.00M,
                     TotalCapitalAmount = 12000.00M,
                     TotalBalance = 16800.00M,
                     IsActive = true,
                     UpToDate = false,
                 },
                  new Loan
                  {
                      Id = 11,
                      Code = "L-011",
                      ContactId = 9,
                      SimpleInterest = true,
                      LoanDate = DateTime.Parse("2018-12-21"),
                      EndDate = DateTime.Parse("2019-05-05"),
                      NumberOfDue = 15,
                      NumberOfDuesPaid = 0,
                      TimeFrameId = 3,
                      Interest = 7000.00M,
                      InterestRate = 2.50M,
                      LoanAmount = 20000.00M,
                      TotalCapitalAmount = 20000.00M,
                      TotalBalance = 27000.00M,
                      IsActive = true,
                      UpToDate = false,
                  },
                  new Loan
                  {
                      Id = 12,
                      Code = "L-012",
                      ContactId = 10,
                      SimpleInterest = true,
                      LoanDate = DateTime.Parse("2018-11-23"),
                      EndDate = DateTime.Parse("2019-02-22"),
                      NumberOfDue = 13,
                      NumberOfDuesPaid = 3,
                      TimeFrameId = 3,
                      Interest = 1500.00M,
                      InterestRate = 2.50M,
                      LoanAmount = 5000.00M,
                      TotalCapitalAmount = 3846.14M,
                      TotalBalance = 4000.00M,
                      IsActive = true,
                      UpToDate = false,
                  }
                );
            modelBuilder.Entity<Due>()
                .HasData(
                new Due
                {
                    LoanID = 1,
                    DueID = 1,
                    DueNumber = 1,
                    Date = DateTime.Parse("2018-11-30").AddDays(7),
                    InterestAmount = 0.00M,
                    CapitalAmount = 0.00M,
                    LateFee = 0.00M,
                    PendingBalance = 0.00M,
                    PaymentAmount = 0.00M,
                    DueIsPaidOff = true
                },
                new Due
                {
                    LoanID = 1,
                    DueID = 2,
                    DueNumber = 2,
                    Date = DateTime.Parse("2018-11-30").AddDays(14),
                    InterestAmount = 0.00M,
                    CapitalAmount = 0.00M,
                    LateFee = 0.00M,
                    PendingBalance = 0.00M,
                    PaymentAmount = 0.00M,
                },
                new Due
                {
                    LoanID = 1,
                    DueID = 3,
                    DueNumber = 3,
                    Date = DateTime.Parse("2018-11-30").AddDays(21),
                    InterestAmount = 0.00M,
                    CapitalAmount = 0.00M,
                    LateFee = 0.00M,
                    PendingBalance = 0.00M,
                    PaymentAmount = 0.00M,
                    DueIsPaidOff = true
                },
                new Due
                {
                    LoanID = 1,
                    DueID = 4,
                    DueNumber = 4,
                    Date = DateTime.Parse("2018-11-30").AddDays(28),
                    InterestAmount = 0.00M,
                    CapitalAmount = 0.00M,
                    LateFee = 0,
                    PendingBalance = 0.00M,
                    PaymentAmount = 0.00M,
                    DueIsPaidOff = true
                },
                new Due
                {
                    LoanID = 1,
                    DueID = 5,
                    DueNumber = 5,
                    Date = DateTime.Parse("2018-11-30").AddDays(35),
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendingBalance = 0.00M,
                    PaymentAmount = 2000.00M,
                    DueIsPaidOff = false
                },
                new Due
                {
                    LoanID = 1,
                    DueID = 6,
                    DueNumber = 6,
                    Date = DateTime.Parse("2018-11-30").AddDays((7 * 6)),
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendingBalance = 0.00M,
                    PaymentAmount = 2000.00M,
                    DueIsPaidOff = false
                },
                new Due
                {
                    LoanID = 1,
                    DueID = 7,
                    DueNumber = 7,
                    Date = DateTime.Parse("2018-11-30").AddDays((7 * 7)),
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendingBalance = 0.00M,
                    PaymentAmount = 2000.00M,
                    DueIsPaidOff = false
                },
                 new Due
                 {
                     LoanID = 1,
                     DueID = 8,
                     DueNumber = 8,
                     Date = DateTime.Parse("2018-11-30").AddDays((7 * 8)),
                     InterestAmount = 461.54M,
                     CapitalAmount = 1538.46M,
                     LateFee = 0.00M,
                     PendingBalance = 0.00M,
                     PaymentAmount = 2000.00M,
                     DueIsPaidOff = false
                 },
                  new Due
                  {
                      LoanID = 1,
                      DueID = 9,
                      DueNumber = 9,
                      Date = DateTime.Parse("2018-11-30").AddDays((7 * 9)),
                      InterestAmount = 461.54M,
                      CapitalAmount = 1538.46M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 2000.00M,
                      DueIsPaidOff = false
                  },
                  new Due
                  {
                      LoanID = 1,
                      DueID = 10,
                      DueNumber = 10,
                      Date = DateTime.Parse("2018-11-30").AddDays((7 * 10)),
                      InterestAmount = 461.54M,
                      CapitalAmount = 1538.46M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 2000.00M,
                      DueIsPaidOff = false
                  },
                  new Due
                  {
                      LoanID = 1,
                      DueID = 11,
                      DueNumber = 11,
                      Date = DateTime.Parse("2018-11-30").AddDays((7 * 11)),
                      InterestAmount = 461.54M,
                      CapitalAmount = 1538.46M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 2000.00M,
                      DueIsPaidOff = false
                  },
                  new Due
                  {
                      LoanID = 1,
                      DueID = 12,
                      DueNumber = 12,
                      Date = DateTime.Parse("2018-11-30").AddDays((7 * 12)),
                      InterestAmount = 461.54M,
                      CapitalAmount = 1538.46M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 2000.00M,
                      DueIsPaidOff = false
                  },
                  new Due
                  {
                      LoanID = 1,
                      DueID = 13,
                      DueNumber = 13,
                      Date = DateTime.Parse("2018-11-30").AddDays((7 * 13)),
                      InterestAmount = 461.54M,
                      CapitalAmount = 1538.46M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 2000.00M,
                      DueIsPaidOff = false
                  },
                  new Due
                  {
                      LoanID = 2,
                      DueID = 14,
                      DueNumber = 1,
                      Date = DateTime.Parse("2018-11-23").AddDays(7),
                      InterestAmount = 0.00M,
                      CapitalAmount = 0.00M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 0.00M,
                      DueIsPaidOff = true
                  },
                  new Due
                  {
                      LoanID = 2,
                      DueID = 15,
                      DueNumber = 2,
                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 2)),
                      InterestAmount = 0.00M,
                      CapitalAmount = 0.00M,
                      LateFee = 0.00M,
                      PendingBalance = 0.00M,
                      PaymentAmount = 0.00M,
                      DueIsPaidOff = true
                  },
                   new Due
                   {
                       LoanID = 2,
                       DueID = 16,
                       DueNumber = 3,
                       Date = DateTime.Parse("2018-11-23").AddDays((7 * 3)),
                       InterestAmount = 0.00M,
                       CapitalAmount = 0.00M,
                       LateFee = 0.00M,
                       PendingBalance = 0.00M,
                       PaymentAmount = 0.00M,
                       DueIsPaidOff = true
                   },
                    new Due
                    {
                        LoanID = 2,
                        DueID = 17,
                        DueNumber = 4,
                        Date = DateTime.Parse("2018-11-23").AddDays((7 * 4)),
                        InterestAmount = 0.00M,
                        CapitalAmount = 0.00M,
                        LateFee = 0.00M,
                        PendingBalance = 0.00M,
                        PaymentAmount = 0.00M,
                        DueIsPaidOff = true
                    },
                     new Due
                     {
                         LoanID = 2,
                         DueID = 18,
                         DueNumber = 5,
                         Date = DateTime.Parse("2018-11-23").AddDays((7 * 5)),
                         InterestAmount = 0.00M,
                         CapitalAmount = 0.00M,
                         LateFee = 0.00M,
                         PendingBalance = 0.00M,
                         PaymentAmount = 0.00M,
                         DueIsPaidOff = true
                     },
                     new Due
                     {
                         LoanID = 2,
                         DueID = 19,
                         DueNumber = 6,
                         Date = DateTime.Parse("2018-11-23").AddDays((7 * 6)),
                         InterestAmount = 233.33M,
                         CapitalAmount = 666.67M,
                         LateFee = 0.00M,
                         PendingBalance = 0.00M,
                         PaymentAmount = 900.00M,
                         DueIsPaidOff = false
                     },
                     new Due
                     {
                         LoanID = 2,
                         DueID = 20,
                         DueNumber = 7,
                         Date = DateTime.Parse("2018-11-23").AddDays((7 * 7)),
                         InterestAmount = 233.33M,
                         CapitalAmount = 666.67M,
                         LateFee = 0.00M,
                         PendingBalance = 0.00M,
                         PaymentAmount = 900.00M,
                         DueIsPaidOff = false
                     },
                      new Due
                      {
                          LoanID = 2,
                          DueID = 21,
                          DueNumber = 8,
                          Date = DateTime.Parse("2018-11-23").AddDays((7 * 8)),
                          InterestAmount = 233.33M,
                          CapitalAmount = 666.67M,
                          LateFee = 0.00M,
                          PendingBalance = 0.00M,
                          PaymentAmount = 900.00M,
                          DueIsPaidOff = false
                      },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 22,
                           DueNumber = 9,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 9)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 23,
                           DueNumber = 10,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 10)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 24,
                           DueNumber = 11,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 11)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 25,
                           DueNumber = 12,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 12)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 26,
                           DueNumber = 13,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 13)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 27,
                           DueNumber = 14,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 14)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 2,
                           DueID = 28,
                           DueNumber = 15,
                           Date = DateTime.Parse("2018-11-23").AddDays((7 * 15)),
                           InterestAmount = 233.33M,
                           CapitalAmount = 666.67M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 900.00M,
                           DueIsPaidOff = false
                       },
                       new Due
                       {
                           LoanID = 3,
                           DueID = 29,
                           DueNumber = 1,
                           Date = DateTime.Parse("2018-11-09").AddDays(7),
                           InterestAmount = 0.00M,
                           CapitalAmount = 0.00M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 0.00M,
                           DueIsPaidOff = true
                       },
                       new Due
                       {
                           LoanID = 3,
                           DueID = 30,
                           DueNumber = 2,
                           Date = DateTime.Parse("2018-11-09").AddDays((7 * 2)),
                           InterestAmount = 0.00M,
                           CapitalAmount = 0.00M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 0.00M,
                           DueIsPaidOff = true
                       },
                       new Due
                       {
                           LoanID = 3,
                           DueID = 31,
                           DueNumber = 3,
                           Date = DateTime.Parse("2018-11-09").AddDays((7 * 3)),
                           InterestAmount = 0.00M,
                           CapitalAmount = 0.00M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 0.00M,
                           DueIsPaidOff = true
                       },
                       new Due
                       {
                           LoanID = 3,
                           DueID = 32,
                           DueNumber = 4,
                           Date = DateTime.Parse("2018-11-09").AddDays((7 * 4)),
                           InterestAmount = 0.00M,
                           CapitalAmount = 0.00M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 0.00M,
                           DueIsPaidOff = true
                       },
                       new Due
                       {
                           LoanID = 3,
                           DueID = 33,
                           DueNumber = 5,
                           Date = DateTime.Parse("2018-11-09").AddDays((7 * 5)),
                           InterestAmount = 0.00M,
                           CapitalAmount = 0.00M,
                           LateFee = 0.00M,
                           PendingBalance = 0.00M,
                           PaymentAmount = 0.00M,
                           DueIsPaidOff = true
                       },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 34,
                            DueNumber = 6,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 6)),
                            InterestAmount = 0.00M,
                            CapitalAmount = 0.00M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 0.00M,
                            DueIsPaidOff = true
                        },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 35,
                            DueNumber = 7,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 7)),
                            InterestAmount = 0.00M,
                            CapitalAmount = 0.00M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 0.00M,
                            DueIsPaidOff = true
                        },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 36,
                            DueNumber = 8,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 8)),
                            InterestAmount = 233.33M,
                            CapitalAmount = 666.67M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 900.00M,
                            DueIsPaidOff = false
                        },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 37,
                            DueNumber = 9,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 9)),
                            InterestAmount = 233.33M,
                            CapitalAmount = 666.67M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 900.00M,
                            DueIsPaidOff = false
                        },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 38,
                            DueNumber = 10,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 10)),
                            InterestAmount = 233.33M,
                            CapitalAmount = 666.67M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 900.00M,
                            DueIsPaidOff = false
                        },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 39,
                            DueNumber = 11,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 11)),
                            InterestAmount = 233.33M,
                            CapitalAmount = 666.67M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 900.00M,
                            DueIsPaidOff = false
                        },
                        new Due
                        {
                            LoanID = 3,
                            DueID = 40,
                            DueNumber = 12,
                            Date = DateTime.Parse("2018-11-09").AddDays((7 * 12)),
                            InterestAmount = 233.33M,
                            CapitalAmount = 666.67M,
                            LateFee = 0.00M,
                            PendingBalance = 0.00M,
                            PaymentAmount = 900.00M,
                            DueIsPaidOff = false
                        },
                         new Due
                         {
                             LoanID = 3,
                             DueID = 41,
                             DueNumber = 13,
                             Date = DateTime.Parse("2018-11-09").AddDays((7 * 13)),
                             InterestAmount = 233.33M,
                             CapitalAmount = 666.67M,
                             LateFee = 0.00M,
                             PendingBalance = 0.00M,
                             PaymentAmount = 900.00M,
                             DueIsPaidOff = false
                         },
                          new Due
                          {
                              LoanID = 3,
                              DueID = 42,
                              DueNumber = 14,
                              Date = DateTime.Parse("2018-11-09").AddDays((7 * 14)),
                              InterestAmount = 233.33M,
                              CapitalAmount = 666.67M,
                              LateFee = 0.00M,
                              PendingBalance = 0.00M,
                              PaymentAmount = 900.00M,
                              DueIsPaidOff = false
                          },
                           new Due
                           {
                               LoanID = 3,
                               DueID = 43,
                               DueNumber = 15,
                               Date = DateTime.Parse("2018-11-09").AddDays((7 * 15)),
                               InterestAmount = 233.33M,
                               CapitalAmount = 666.67M,
                               LateFee = 0.00M,
                               PendingBalance = 0.00M,
                               PaymentAmount = 900.00M,
                               DueIsPaidOff = false
                           },
                            new Due
                            {
                                LoanID = 4,
                                DueID = 44,
                                DueNumber = 1,
                                Date = DateTime.Parse("2017-07-31").AddDays(7),
                                InterestAmount = 0.00M,
                                CapitalAmount = 0.00M,
                                LateFee = 0.00M,
                                PendingBalance = 0.00M,
                                PaymentAmount = 0.00M,
                                DueIsPaidOff = true
                            },
                            new Due
                            {
                                LoanID = 4,
                                DueID = 45,
                                DueNumber = 2,
                                Date = DateTime.Parse("2017-07-31").AddDays((7 * 2)),
                                InterestAmount = 0.00M,
                                CapitalAmount = 0.00M,
                                LateFee = 0.00M,
                                PendingBalance = 0.00M,
                                PaymentAmount = 0.00M,
                                DueIsPaidOff = true
                            },
                            new Due
                            {
                                LoanID = 4,
                                DueID = 46,
                                DueNumber = 3,
                                Date = DateTime.Parse("2017-07-31").AddDays((7 * 3)),
                                InterestAmount = 0.00M,
                                CapitalAmount = 0.00M,
                                LateFee = 0.00M,
                                PendingBalance = 0.00M,
                                PaymentAmount = 0.00M,
                                DueIsPaidOff = true
                            },
                            new Due
                            {
                                LoanID = 4,
                                DueID = 47,
                                DueNumber = 4,
                                Date = DateTime.Parse("2017-07-31").AddDays((7 * 4)),
                                InterestAmount = 0.00M,
                                CapitalAmount = 0.00M,
                                LateFee = 0.00M,
                                PendingBalance = 0.00M,
                                PaymentAmount = 0.00M,
                                DueIsPaidOff = true
                            },
                            new Due
                            {
                                LoanID = 4,
                                DueID = 48,
                                DueNumber = 5,
                                Date = DateTime.Parse("2017-07-31").AddDays((7 * 5)),
                                InterestAmount = 0.00M,
                                CapitalAmount = 0.00M,
                                LateFee = 0.00M,
                                PendingBalance = 0.00M,
                                PaymentAmount = 0.00M,
                                DueIsPaidOff = true
                            },
                             new Due
                             {
                                 LoanID = 4,
                                 DueID = 49,
                                 DueNumber = 6,
                                 Date = DateTime.Parse("2017-07-31").AddDays((7 * 6)),
                                 InterestAmount = 0.00M,
                                 CapitalAmount = 0.00M,
                                 LateFee = 0.00M,
                                 PendingBalance = 0.00M,
                                 PaymentAmount = 0.00M,
                                 DueIsPaidOff = true
                             },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 50,
                                  DueNumber = 7,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 7)),
                                  InterestAmount = 0.00M,
                                  CapitalAmount = 0.00M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 0.00M,
                                  DueIsPaidOff = true
                              },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 51,
                                  DueNumber = 8,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 8)),
                                  InterestAmount = 230.77M,
                                  CapitalAmount = 769.23M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 1000.00M,
                                  DueIsPaidOff = false
                              },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 52,
                                  DueNumber = 9,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 9)),
                                  InterestAmount = 230.77M,
                                  CapitalAmount = 769.23M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 1000.00M,
                                  DueIsPaidOff = false
                              },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 53,
                                  DueNumber = 10,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 10)),
                                  InterestAmount = 230.77M,
                                  CapitalAmount = 769.23M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 1000.00M,
                                  DueIsPaidOff = false
                              },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 54,
                                  DueNumber = 11,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 11)),
                                  InterestAmount = 230.77M,
                                  CapitalAmount = 769.23M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 1000.00M,
                                  DueIsPaidOff = false
                              },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 55,
                                  DueNumber = 11,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 11)),
                                  InterestAmount = 230.77M,
                                  CapitalAmount = 769.23M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 1000.00M,
                                  DueIsPaidOff = false
                              },
                              new Due
                              {
                                  LoanID = 4,
                                  DueID = 56,
                                  DueNumber = 12,
                                  Date = DateTime.Parse("2017-07-31").AddDays((7 * 12)),
                                  InterestAmount = 230.77M,
                                  CapitalAmount = 769.23M,
                                  LateFee = 0.00M,
                                  PendingBalance = 0.00M,
                                  PaymentAmount = 1000.00M,
                                  DueIsPaidOff = false
                              },
                               new Due
                               {
                                   LoanID = 4,
                                   DueID = 57,
                                   DueNumber = 13,
                                   Date = DateTime.Parse("2017-07-31").AddDays((7 * 13)),
                                   InterestAmount = 230.77M,
                                   CapitalAmount = 769.23M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 1000.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 58,
                                   DueNumber = 1,
                                   Date = DateTime.Parse("2017-09-11").AddDays(7),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 59,
                                   DueNumber = 2,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 2)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 60,
                                   DueNumber = 3,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 3)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 61,
                                   DueNumber = 4,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 4)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 62,
                                   DueNumber = 5,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 5)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 63,
                                   DueNumber = 6,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 6)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 64,
                                   DueNumber = 7,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 7)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 65,
                                   DueNumber = 8,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 8)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 66,
                                   DueNumber = 9,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 9)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 67,
                                   DueNumber = 10,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 10)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 68,
                                   DueNumber = 11,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 11)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 69,
                                   DueNumber = 12,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 12)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 5,
                                   DueID = 70,
                                   DueNumber = 13,
                                   Date = DateTime.Parse("2017-09-11").AddDays((7 * 13)),
                                   InterestAmount = 46.15M,
                                   CapitalAmount = 153.85M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 200.00M,
                                   DueIsPaidOff = false
                               },
                               new Due
                               {
                                   LoanID = 6,
                                   DueID = 71,
                                   DueNumber = 1,
                                   Date = DateTime.Parse("2017-12-11").AddDays(7),
                                   InterestAmount = 0.00M,
                                   CapitalAmount = 0.00M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 0.00M,
                                   DueIsPaidOff = true
                               },
                               new Due
                               {
                                   LoanID = 6,
                                   DueID = 72,
                                   DueNumber = 2,
                                   Date = DateTime.Parse("2017-12-11").AddDays((7 * 2)),
                                   InterestAmount = 0.00M,
                                   CapitalAmount = 0.00M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 0.00M,
                                   DueIsPaidOff = true
                               },
                               new Due
                               {
                                   LoanID = 6,
                                   DueID = 73,
                                   DueNumber = 3,
                                   Date = DateTime.Parse("2017-12-11").AddDays((7 * 3)),
                                   InterestAmount = 0.00M,
                                   CapitalAmount = 0.00M,
                                   LateFee = 0.00M,
                                   PendingBalance = 0.00M,
                                   PaymentAmount = 0.00M,
                                   DueIsPaidOff = true
                               },
                                new Due
                                {
                                    LoanID = 6,
                                    DueID = 74,
                                    DueNumber = 4,
                                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 4)),
                                    InterestAmount = 0.00M,
                                    CapitalAmount = 0.00M,
                                    LateFee = 0.00M,
                                    PendingBalance = 0.00M,
                                    PaymentAmount = 0.00M,
                                    DueIsPaidOff = true
                                },
                                new Due
                                {
                                    LoanID = 6,
                                    DueID = 75,
                                    DueNumber = 5,
                                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 5)),
                                    InterestAmount = 0.00M,
                                    CapitalAmount = 0.00M,
                                    LateFee = 0.00M,
                                    PendingBalance = 0.00M,
                                    PaymentAmount = 0.00M,
                                    DueIsPaidOff = true
                                },
                                new Due
                                {
                                    LoanID = 6,
                                    DueID = 76,
                                    DueNumber = 6,
                                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 6)),
                                    InterestAmount = 0.00M,
                                    CapitalAmount = 125.00M,
                                    LateFee = 0.00M,
                                    PendingBalance = 125.00M,
                                    PaymentAmount = 175.00M,
                                    DueIsPaidOff = false
                                },
                                new Due
                                {
                                    LoanID = 6,
                                    DueID = 77,
                                    DueNumber = 7,
                                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 7)),
                                    InterestAmount = 69.23M,
                                    CapitalAmount = 230.77M,
                                    LateFee = 0.00M,
                                    PendingBalance = 0.00M,
                                    PaymentAmount = 300.00M,
                                    DueIsPaidOff = false
                                },
                                new Due
                                {
                                    LoanID = 6,
                                    DueID = 78,
                                    DueNumber = 8,
                                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 8)),
                                    InterestAmount = 69.23M,
                                    CapitalAmount = 230.77M,
                                    LateFee = 0.00M,
                                    PendingBalance = 0.00M,
                                    PaymentAmount = 300.00M,
                                    DueIsPaidOff = false
                                },
                                 new Due
                                 {
                                     LoanID = 6,
                                     DueID = 79,
                                     DueNumber = 9,
                                     Date = DateTime.Parse("2017-12-11").AddDays((7 * 9)),
                                     InterestAmount = 69.23M,
                                     CapitalAmount = 230.77M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 300.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 6,
                                     DueID = 80,
                                     DueNumber = 10,
                                     Date = DateTime.Parse("2017-12-11").AddDays((7 * 10)),
                                     InterestAmount = 69.23M,
                                     CapitalAmount = 230.77M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 300.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 6,
                                     DueID = 81,
                                     DueNumber = 11,
                                     Date = DateTime.Parse("2017-12-11").AddDays((7 * 11)),
                                     InterestAmount = 69.23M,
                                     CapitalAmount = 230.77M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 300.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 6,
                                     DueID = 82,
                                     DueNumber = 12,
                                     Date = DateTime.Parse("2017-12-11").AddDays((7 * 12)),
                                     InterestAmount = 69.23M,
                                     CapitalAmount = 230.77M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 300.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 6,
                                     DueID = 83,
                                     DueNumber = 13,
                                     Date = DateTime.Parse("2017-12-11").AddDays((7 * 13)),
                                     InterestAmount = 69.23M,
                                     CapitalAmount = 230.77M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 300.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 84,
                                     DueNumber = 1,
                                     Date = DateTime.Parse("2018-05-07").AddDays(7),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 85,
                                     DueNumber = 2,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 2)),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 86,
                                     DueNumber = 3,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 3)),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 87,
                                     DueNumber = 4,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 4)),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 88,
                                     DueNumber = 5,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 5)),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 89,
                                     DueNumber = 6,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 6)),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 90,
                                     DueNumber = 7,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 7)),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 1120.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 1120.00M,
                                     PaymentAmount = 4910.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 91,
                                     DueNumber = 8,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 8)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 92,
                                     DueNumber = 9,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 9)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 93,
                                     DueNumber = 10,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 10)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 94,
                                     DueNumber = 11,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 11)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 95,
                                     DueNumber = 11,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 11)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 96,
                                     DueNumber = 12,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 12)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 97,
                                     DueNumber = 13,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 13)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 98,
                                     DueNumber = 14,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 14)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 7,
                                     DueID = 99,
                                     DueNumber = 15,
                                     Date = DateTime.Parse("2018-05-07").AddDays((7 * 15)),
                                     InterestAmount = 1563.33M,
                                     CapitalAmount = 4466.67M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 6030.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 100,
                                     DueNumber = 1,
                                     Date = DateTime.Parse("2018-12-17").AddDays(7),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 101,
                                     DueNumber = 2,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 2)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 102,
                                     DueNumber = 3,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 3)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 103,
                                     DueNumber = 4,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 4)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 104,
                                     DueNumber = 5,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 5)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 105,
                                     DueNumber = 6,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 6)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 106,
                                     DueNumber = 7,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 7)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 107,
                                     DueNumber = 8,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 8)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 108,
                                     DueNumber = 9,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 9)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 109,
                                     DueNumber = 10,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 10)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 110,
                                     DueNumber = 11,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 11)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 111,
                                     DueNumber = 12,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 12)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 8,
                                     DueID = 112,
                                     DueNumber = 13,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 13)),
                                     InterestAmount = 115.38M,
                                     CapitalAmount = 384.62M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 500.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 113,
                                     DueNumber = 1,
                                     Date = DateTime.Parse("2018-12-17").AddDays(7),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 114,
                                     DueNumber = 2,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 2)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 115,
                                     DueNumber = 3,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 3)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 116,
                                     DueNumber = 4,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 4)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 117,
                                     DueNumber = 5,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 5)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 118,
                                     DueNumber = 6,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 6)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 119,
                                     DueNumber = 7,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 7)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 120,
                                     DueNumber = 8,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 8)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 121,
                                     DueNumber = 9,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 9)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 122,
                                     DueNumber = 10,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 10)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 123,
                                     DueNumber = 11,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 11)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 124,
                                     DueNumber = 12,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 12)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 125,
                                     DueNumber = 13,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 13)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 126,
                                     DueNumber = 14,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 14)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 9,
                                     DueID = 127,
                                     DueNumber = 15,
                                     Date = DateTime.Parse("2018-12-17").AddDays((7 * 15)),
                                     InterestAmount = 350.00M,
                                     CapitalAmount = 1000.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 1350.00M,
                                     DueIsPaidOff = false
                                 },
                                 new Due
                                 {
                                     LoanID = 10,
                                     DueID = 128,
                                     DueNumber = 1,
                                     Date = DateTime.Parse("2018-10-19").AddDays(7),
                                     InterestAmount = 0.00M,
                                     CapitalAmount = 0.00M,
                                     LateFee = 0.00M,
                                     PendingBalance = 0.00M,
                                     PaymentAmount = 0.00M,
                                     DueIsPaidOff = true
                                 },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 129,
                                      DueNumber = 2,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 2)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 130,
                                      DueNumber = 3,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 3)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 131,
                                      DueNumber = 4,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 4)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 132,
                                      DueNumber = 5,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 5)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 133,
                                      DueNumber = 6,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 6)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 134,
                                      DueNumber = 7,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 7)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 135,
                                      DueNumber = 8,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 8)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 136,
                                      DueNumber = 9,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 9)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 137,
                                      DueNumber = 10,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 10)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 138,
                                      DueNumber = 11,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 11)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 139,
                                      DueNumber = 12,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 12)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 140,
                                      DueNumber = 13,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 13)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 141,
                                      DueNumber = 14,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 14)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 142,
                                      DueNumber = 15,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 15)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 143,
                                      DueNumber = 16,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 16)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 144,
                                      DueNumber = 17,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 17)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 145,
                                      DueNumber = 18,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 18)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 10,
                                      DueID = 146,
                                      DueNumber = 19,
                                      Date = DateTime.Parse("2018-10-19").AddDays((7 * 19)),
                                      InterestAmount = 400.00M,
                                      CapitalAmount = 1000.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1400.00M,
                                      DueIsPaidOff = false
                                  },
               new Due
               {
                   LoanID = 10,
                   DueID = 147,
                   DueNumber = 20,
                   Date = DateTime.Parse("2018-10-19").AddDays((7 * 20)),
                   InterestAmount = 400.00M,
                   CapitalAmount = 1000.00M,
                   LateFee = 0.00M,
                   PendingBalance = 0.00M,
                   PaymentAmount = 1400.00M,
                   DueIsPaidOff = false
               },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 148,
                                      DueNumber = 1,
                                      Date = DateTime.Parse("2018-12-21").AddDays(7),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 149,
                                      DueNumber = 2,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 2)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 150,
                                      DueNumber = 3,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 3)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 151,
                                      DueNumber = 4,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 4)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 152,
                                      DueNumber = 5,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 5)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 153,
                                      DueNumber = 6,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 6)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 154,
                                      DueNumber = 7,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 7)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 155,
                                      DueNumber = 8,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 8)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 156,
                                      DueNumber = 9,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 9)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 157,
                                      DueNumber = 10,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 10)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 158,
                                      DueNumber = 11,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 11)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 159,
                                      DueNumber = 12,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 12)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 160,
                                      DueNumber = 13,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 13)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 161,
                                      DueNumber = 14,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 14)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 11,
                                      DueID = 162,
                                      DueNumber = 15,
                                      Date = DateTime.Parse("2018-12-21").AddDays((7 * 15)),
                                      InterestAmount = 466.67M,
                                      CapitalAmount = 1333.33M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 1800.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 163,
                                      DueNumber = 1,
                                      Date = DateTime.Parse("2018-11-23").AddDays(7),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 164,
                                      DueNumber = 2,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 2)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 165,
                                      DueNumber = 3,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 3)),
                                      InterestAmount = 0.00M,
                                      CapitalAmount = 0.00M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 0.00M,
                                      DueIsPaidOff = true
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 166,
                                      DueNumber = 4,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 4)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 167,
                                      DueNumber = 5,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 5)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 168,
                                      DueNumber = 6,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 6)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 169,
                                      DueNumber = 7,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 7)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 170,
                                      DueNumber = 8,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 8)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 171,
                                      DueNumber = 9,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 9)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 172,
                                      DueNumber = 10,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 10)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 173,
                                      DueNumber = 11,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 11)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 174,
                                      DueNumber = 12,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 12)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  },
                                  new Due
                                  {
                                      LoanID = 12,
                                      DueID = 175,
                                      DueNumber = 13,
                                      Date = DateTime.Parse("2018-11-23").AddDays((7 * 13)),
                                      InterestAmount = 115.38M,
                                      CapitalAmount = 384.62M,
                                      LateFee = 0.00M,
                                      PendingBalance = 0.00M,
                                      PaymentAmount = 500.00M,
                                      DueIsPaidOff = false
                                  }
                                  );
            modelBuilder.Entity<Payment>()
                .HasData(
                new Payment
                {
                    PaymentID = 1,
                    Code = "P-001",
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 2000.00M,
                    Date = DateTime.Parse("2018-11-30").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 2,
                    Code = "P-002",
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 2000.00M,
                    Date = DateTime.Parse("2018-11-30").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 3,
                    Code = "P-003",
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 2000.00M,
                    Date = DateTime.Parse("2018-11-30").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 4,
                    Code = "P-004",
                    InterestAmount = 461.54M,
                    CapitalAmount = 1538.46M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 2000.00M,
                    Date = DateTime.Parse("2018-11-30").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 5,
                    Code = "P-005",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-23").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 6,
                    Code = "P-006",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-23").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 7,
                    Code = "P-007",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-23").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 8,
                    Code = "P-008",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-23").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 9,
                    Code = "P-009",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-23").AddDays((7 * 5))
                },
                new Payment
                {
                    PaymentID = 10,
                    Code = "P-010",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 11,
                    Code = "P-011",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 12,
                    Code = "P-012",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 13,
                    Code = "P-013",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 14,
                    Code = "P-014",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays((7 * 5))
                },
                new Payment
                {
                    PaymentID = 15,
                    Code = "P-015",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays((7 * 6))
                },
                new Payment
                {
                    PaymentID = 16,
                    Code = "P-016",
                    InterestAmount = 233.33M,
                    CapitalAmount = 666.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 900.00M,
                    Date = DateTime.Parse("2018-11-09").AddDays((7 * 7))
                },
                new Payment
                {
                    PaymentID = 17,
                    Code = "P-017",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 18,
                    Code = "P-018",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 19,
                    Code = "P-019",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 20,
                    Code = "P-020",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 21,
                    Code = "P-021",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays((7 * 5))
                },
                new Payment
                {
                    PaymentID = 22,
                    Code = "P-022",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays((7 * 6))
                },
                new Payment
                {
                    PaymentID = 23,
                    Code = "P-023",
                    InterestAmount = 230.77M,
                    CapitalAmount = 769.23M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1000.00M,
                    Date = DateTime.Parse("2017-07-31").AddDays((7 * 7))
                },
                new Payment
                {
                    PaymentID = 24,
                    Code = "P-024",
                    InterestAmount = 69.23M,
                    CapitalAmount = 230.77M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 300.00M,
                    Date = DateTime.Parse("2017-12-11").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 25,
                    Code = "P-025",
                    InterestAmount = 69.23M,
                    CapitalAmount = 230.77M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 300.00M,
                    Date = DateTime.Parse("2017-12-11").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 26,
                    Code = "P-026",
                    InterestAmount = 69.23M,
                    CapitalAmount = 230.77M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 300.00M,
                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 27,
                    Code = "P-027",
                    InterestAmount = 69.23M,
                    CapitalAmount = 230.77M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 300.00M,
                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 28,
                    Code = "P-028",
                    InterestAmount = 69.23M,
                    CapitalAmount = 230.77M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 300.00M,
                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 5))
                },
                new Payment
                {
                    PaymentID = 29,
                    Code = "P-029",
                    InterestAmount = 69.23M,
                    CapitalAmount = 105.77M,
                    LateFee = 0.00M,
                    PendigBalance = 125.00M,
                    TotalBalance = 175.00M,
                    Date = DateTime.Parse("2017-12-11").AddDays((7 * 6))
                },
                new Payment
                {
                    PaymentID = 30,
                    Code = "P-030",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 4466.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 6030.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 31,
                    Code = "P-031",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 4466.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 6030.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 32,
                    Code = "P-032",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 4466.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 6030.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 33,
                    Code = "P-033",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 4466.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 6030.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 34,
                    Code = "P-034",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 4466.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 6030.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays((7 * 5))
                },
                new Payment
                {
                    PaymentID = 35,
                    Code = "P-035",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 4466.67M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 6030.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays((7 * 6))
                },
                new Payment
                {
                    PaymentID = 36,
                    Code = "P-036",
                    InterestAmount = 1563.33M,
                    CapitalAmount = 3790.00M,
                    LateFee = 0.00M,
                    PendigBalance = 1120.00M,
                    TotalBalance = 4910.00M,
                    Date = DateTime.Parse("2018-05-07").AddDays((7 * 7))
                },
                new Payment
                {
                    PaymentID = 37,
                    Code = "P-037",
                    InterestAmount = 115.38M,
                    CapitalAmount = 384.62M,
                    LateFee = 0.00M,
                    PendigBalance =0.00M,
                    TotalBalance = 500.00M,
                    Date = DateTime.Parse("2018-12-17").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 38,
                    Code = "P-038",
                    InterestAmount = 350.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1350.00M,
                    Date = DateTime.Parse("2018-12-21").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 39,
                    Code = "P-039",
                    InterestAmount = 400.00M, //Frankling montero
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 40,
                    Code = "P-040",
                    InterestAmount = 400.00M, 
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 41,
                    Code = "P-041",
                    InterestAmount = 400.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7 * 3))
                },
                new Payment
                {
                    PaymentID = 42,
                    Code = "P-042",
                    InterestAmount = 400.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7 * 4))
                },
                new Payment
                {
                    PaymentID = 43,
                    Code = "P-043",
                    InterestAmount = 400.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7 * 5))
                },
                new Payment
                {
                    PaymentID = 44,
                    Code = "P-044",
                    InterestAmount = 400.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7 * 6))
                },
                new Payment
                {
                    PaymentID = 45,
                    Code = "P-045",
                    InterestAmount = 400.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7 * 7))
                },
                new Payment
                {
                    PaymentID = 46,
                    Code = "P-046",
                    InterestAmount = 400.00M,
                    CapitalAmount = 1000.00M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 1400.00M,
                    Date = DateTime.Parse("2018-10-19").AddDays((7 * 8))
                },
                new Payment
                {
                    PaymentID = 47,
                    Code = "P-047",
                    InterestAmount = 115.38M,
                    CapitalAmount = 384.62M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 500M,
                    Date = DateTime.Parse("2018-11-23").AddDays(7)
                },
                new Payment
                {
                    PaymentID = 48,
                    Code = "P-048",
                    InterestAmount = 115.38M,
                    CapitalAmount = 384.62M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 500M,
                    Date = DateTime.Parse("2018-11-23").AddDays((7*2))
                },
                new Payment
                {
                    PaymentID = 49,
                    Code = "P-049",
                    InterestAmount = 115.38M,
                    CapitalAmount = 384.62M,
                    LateFee = 0.00M,
                    PendigBalance = 0.00M,
                    TotalBalance = 500M,
                    Date = DateTime.Parse("2018-11-23").AddDays((7 * 3))
                }
                );
            modelBuilder.Entity<DuePayment>()
                .HasData(
                new DuePayment { DueID = 1, PaymentID = 1 },
                new DuePayment { DueID = 2, PaymentID = 2 },
                new DuePayment { DueID = 3, PaymentID = 3 },
                new DuePayment { DueID = 4, PaymentID = 4 },
                new DuePayment { DueID = 14, PaymentID = 5 },
                new DuePayment { DueID = 15, PaymentID = 6 },
                new DuePayment { DueID = 16, PaymentID = 7 },
                new DuePayment { DueID = 17, PaymentID = 8 },
                new DuePayment { DueID = 18, PaymentID = 9 },
                new DuePayment { DueID = 29, PaymentID = 10 },
                new DuePayment { DueID = 30, PaymentID = 11 },
                new DuePayment { DueID = 31, PaymentID = 12 },
                new DuePayment { DueID = 32, PaymentID = 13 },
                new DuePayment { DueID = 33, PaymentID = 14 },
                new DuePayment { DueID = 34, PaymentID = 15 },
                new DuePayment { DueID = 35, PaymentID = 16 },
                new DuePayment { DueID = 44, PaymentID = 17 },
                new DuePayment { DueID = 45, PaymentID = 18 },
                new DuePayment { DueID = 46, PaymentID = 19 },
                new DuePayment { DueID = 47, PaymentID = 20 },
                new DuePayment { DueID = 48, PaymentID = 21 },
                new DuePayment { DueID = 49, PaymentID = 22 },
                new DuePayment { DueID = 50, PaymentID = 23 },
                new DuePayment { DueID = 71, PaymentID = 24 },
                new DuePayment { DueID = 72, PaymentID = 25 },
                new DuePayment { DueID = 73, PaymentID = 26 },
                new DuePayment { DueID = 74, PaymentID = 27 },
                new DuePayment { DueID = 75, PaymentID = 28 },
                new DuePayment { DueID = 76, PaymentID = 29 },
                new DuePayment { DueID = 84, PaymentID = 30 },
                new DuePayment { DueID = 85, PaymentID = 31 },
                new DuePayment { DueID = 86, PaymentID = 32 },
                new DuePayment { DueID = 87, PaymentID = 33 },
                new DuePayment { DueID = 88, PaymentID = 34 },
                new DuePayment { DueID = 89, PaymentID = 35 },
                new DuePayment { DueID = 90, PaymentID = 36 },
                new DuePayment { DueID = 100, PaymentID = 37 },
                new DuePayment { DueID = 113, PaymentID = 38 },
                new DuePayment { DueID = 128, PaymentID = 39 },
                new DuePayment { DueID = 129, PaymentID = 40 },
                new DuePayment { DueID = 130, PaymentID = 41 },
                new DuePayment { DueID = 131, PaymentID = 42 },
                new DuePayment { DueID = 132, PaymentID = 43 },
                new DuePayment { DueID = 133, PaymentID = 44 },
                new DuePayment { DueID = 134, PaymentID = 45 },
                new DuePayment { DueID = 135, PaymentID = 46 },
                new DuePayment { DueID = 163, PaymentID = 47 },
                new DuePayment { DueID = 164, PaymentID = 48 },
                new DuePayment { DueID = 165, PaymentID = 49 }
                );
        }
    }
}
