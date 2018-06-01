using AutoMapper;
using MmosCourseProject.BLL.Exceptions;
using MmosCourseProject.BLL.Dto.General;
using MmosCourseProject.BLL.Services.Abstract;
using MmosCourseProject.DAL;
using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.BLL.Services
{
    public class ChannelSelectService : GenericService<ChannelDto, Channel>, IChannelSelectService
    {
        protected ChannelSelectService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        public List<UserDto> ChannelMembers(ChannelDto channel)
        {
            if (channel == null)
                throw new ArgumentNullException();
            if (channel.Id == 0)
                throw new IdNotSpecifiedException(channel);

            return ExecuteSelect<UserDto, User>(uow => uow.ChannelRepository.GetMembers(channel.Id));
        }        

        public List<ChannelDto> ChannelsByTeam(TeamDto team)
        {
            if (team == null)
                throw new ArgumentNullException();
            if (team.Id == 0)
                throw new IdNotSpecifiedException(team);

            return ExecuteSelect<ChannelDto, Channel>(uow => uow.ChannelRepository.GetChannelsByTeam(team.Id));
        }
    }
}
