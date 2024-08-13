using MediatR;
using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Entities;
using PocAdmin.Core.Interfaces;
using PocAdmin.Core.Queries;

namespace PocAdmin.Api.Handlers
{
    public class GetFileEventsByReferenceIdHandler : IRequestHandler<GetFileEventsByReferenceIdQuery, IEnumerable<FileEvent>>
    {
        private readonly IQueryRepository<FileEvent> _queryRepository;

        public GetFileEventsByReferenceIdHandler(IQueryRepository<FileEvent> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<IEnumerable<FileEvent>> Handle(GetFileEventsByReferenceIdQuery request, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetAll()
                .Where(fe => fe.ReferenceId == request.ReferenceId)
                .ToListAsync(cancellationToken);
        }
    }
}
