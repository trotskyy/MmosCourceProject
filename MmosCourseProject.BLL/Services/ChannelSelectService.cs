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

namespace MmosCourseProject.BLL.Services
{
    public class ChannelSelectService : GenericService<General.ChannelDto, Channel>, IChannelSelectService
    {
        public ChannelSelectService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        public List<General.UserDto> ChannelMembers(Selectional.ChannelDto channel)
        {
            ValidateDto(channel);

            return ExecuteSelect<General.UserDto, User>(uow => uow.ChannelRepository.GetMembers(channel.Id));
        }

        public List<General.ChannelDto> ChannelsByTeam(Selectional.TeamDto team)
        {
            ValidateDto(team);

            return ExecuteSelect<General.ChannelDto, Channel>(uow => uow.ChannelRepository.GetChannelsByTeam(team.Id));
        }
    }
}
