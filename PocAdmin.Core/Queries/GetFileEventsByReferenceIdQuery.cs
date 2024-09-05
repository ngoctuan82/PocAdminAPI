using MediatR;
using PocAdmin.Core.Entities;

namespace PocAdmin.Core.Queries
{
    public record GetFileEventsByReferenceIdQuery(string ReferenceId) : IRequest<IEnumerable<FileEvent>>;
}
