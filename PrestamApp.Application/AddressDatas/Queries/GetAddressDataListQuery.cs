using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.AddressDatas.Queries
{
    public class GetAddressDataListQuery : IRequest<IEnumerable<AddressDataDto>>
    {
        public int? ParentId { get; set; }
    }
}
