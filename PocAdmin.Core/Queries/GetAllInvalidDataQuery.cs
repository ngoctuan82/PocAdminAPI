using MediatR;
using PocAdmin.Core.Entities;
using System.Collections.Generic;

namespace PocAdmin.Core.Queries
{
    public record GetAllInvalidDataQuery : IRequest<IEnumerable<InvalidData>>;

}
