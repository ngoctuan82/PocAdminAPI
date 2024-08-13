using MediatR;
using PocAdmin.Core.Entities;

namespace PocAdmin.Core.Queries
{
    public record GetFileEventsByReferenceIdQuery(int ReferenceId) : IRequest<IEnumerable<FileEvent>>;
}
