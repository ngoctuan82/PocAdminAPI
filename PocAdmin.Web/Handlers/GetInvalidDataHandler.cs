using MediatR;
using Microsoft.EntityFrameworkCore;
using PocAdmin.Core.Entities;
using PocAdmin.Core.Interfaces;
using PocAdmin.Core.Queries;

namespace PocAdmin.Api.Handlers
{
    public class GetAllInvalidDataHandler : IRequestHandler<GetAllInvalidDataQuery, IEnumerable<InvalidData>>
    {
        private readonly IQueryRepository<InvalidData> _queryRepository;

        public GetAllInvalidDataHandler(IQueryRepository<InvalidData> queryRepository)
        {
            _queryRepository = queryRepository;
        }

        public async Task<IEnumerable<InvalidData>> Handle(GetAllInvalidDataQuery request, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetAll().ToListAsync(cancellationToken);
        }
    }
}
