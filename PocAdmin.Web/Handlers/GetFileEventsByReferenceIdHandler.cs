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
        private readonly IQueryRepository<InvalidData> _queryInvalidDataRepository;

        public GetFileEventsByReferenceIdHandler(IQueryRepository<FileEvent> queryRepository, IQueryRepository<InvalidData> queryInvalidDataRepository)
        {
            _queryFileEventRepository = queryRepository;
            _queryInvalidDataRepository = queryInvalidDataRepository;
        }

        public async Task<IEnumerable<FileEvent>> Handle(GetFileEventsByReferenceIdQuery request, CancellationToken cancellationToken)
        {
            var data = _queryInvalidDataRepository.GetAll().Where(e => e.CA_RefId == request.ReferenceId);

            var result = from e in data
                         join f in _queryFileEventRepository.GetAll()
                         on e.Event_FileId equals f.Id
                         select f;
                        
            return await result.ToListAsync(cancellationToken);
        }
    }
}
