using MediatR;
using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Entities;
using PocAdmin.Core.Interfaces;
using PocAdmin.Core.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PocAdmin.Api.Handlers
{
    public class GetFileEventsByReferenceIdHandler : IRequestHandler<GetFileEventsByReferenceIdQuery, IEnumerable<FileEvent>>
    {
        private readonly IQueryRepository<FileEvent> _queryFileEventRepository;
        private readonly IQueryRepository<RawEvent> _queryRawEventRepository;

        public GetFileEventsByReferenceIdHandler(IQueryRepository<FileEvent> queryRepository, IQueryRepository<RawEvent> queryRawEvent)
        {
            _queryFileEventRepository = queryRepository;
            _queryRawEventRepository = queryRawEvent;
        }

        public async Task<IEnumerable<FileEvent>> Handle(GetFileEventsByReferenceIdQuery request, CancellationToken cancellationToken)
        {
            var events = _queryRawEventRepository.GetAll().Where(e => e.ReferenceId == request.ReferenceId);

            var result = from e in events
                         join f in _queryFileEventRepository.GetAll()
                         on e.FileSourceId equals f.Id
                         orderby f.Created descending                         
                         select f;

            return (await result.ToListAsync(cancellationToken)).DistinctBy(e => e.Id);
        }
    }
}
