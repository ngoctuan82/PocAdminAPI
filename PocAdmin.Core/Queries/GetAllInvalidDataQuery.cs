using MediatR;
using PocAdmin.Core.Entities;

namespace PocAdmin.Core.Queries
{
    public record GetAllInvalidDataQuery : IRequest<IEnumerable<InvalidData>>;

}
