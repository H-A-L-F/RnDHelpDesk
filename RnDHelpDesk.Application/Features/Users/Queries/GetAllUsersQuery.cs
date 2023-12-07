using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RnDHelpDesk.Application.Interfaces.Repositories;
using RnDHelpDesk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnDHelpDesk.Application.Features.Users.Queries
{
    public record GetAllUsersQuery : IRequest<List<GetAllUsersDTO>>;
    internal class GetAllUsersQueryHandler : IRequest<List<GetAllUsersDTO>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllUsersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllUsersDTO>> Handle(GetAllUsersQuery query, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<User>().Entities.ProjectTo<GetAllUsersDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }
    }
}
