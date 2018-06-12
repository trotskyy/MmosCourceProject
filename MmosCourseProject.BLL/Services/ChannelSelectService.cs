using AutoMapper;
using MmosCourseProject.BLL.Exceptions;
using MmosCourseProject.BLL.Dto;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using General = MmosCourseProject.BLL.Dto.General;
using Selectional = MmosCourseProject.BLL.Dto.Parameters.Selectional;
using MmosCourseProject.BLL.Utils;
using MmosCourseProject.BLL.Dto.Parameters.Selectional;

namespace MmosCourseProject.BLL.Services
{
    public class ChannelSelectService : GenericService<ChannelDto, Channel>, IChannelSelectService
    {
        public ChannelSelectService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        public IEnumerable<General.UserDto> ChannelMembers(ChannelDto channel)
        {
            ValidateDto(channel);

            return Execute.Select<General.UserDto, User>(uow => uow.Repository<IChannelRepository>().GetMembers(channel.MapToDbEntity()));
        }

        public IEnumerable<General.ChannelDto> ChannelsByTeam(TeamDto team)
        {
            ValidateDto(team);

            return Execute.Select<General.ChannelDto, Channel>(uow => uow.Repository<IChannelRepository>().GetChannelsByTeam(team.Id));
        }
    }
}
