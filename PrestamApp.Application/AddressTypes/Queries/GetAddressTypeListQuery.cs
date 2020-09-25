using MediatR;
using PrestamApp.Application.AddressDatas.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrestamApp.Application.AddressTypes.Queries
{
    public class GetAddressTypeListQuery : IRequest<IEnumerable<AddressTypeDto>>
    {
    }
}
