using MmosCourseProject.BLL.Dto.Parameters.Creational;
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
    public class ChannelService : GenericService<General.ChannelDto, Channel>, IChannelService
    {
        IChannelSelectService _channelSelectService;

        public ChannelService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory)
        {
        }

        public IChannelSelectService Get
        {
            get
            {
                if (_channelSelectService == null)
                    _channelSelectService = new ChannelSelectService(_unitOfWorkFactory);
                return _channelSelectService;
            }
        }

        public void CreateChannel(ChannelDto channel)
        {
            ValidateDto(channel);

            //TODO в одной тиме не должно быть двух каналов с одинаковым названием
            ExecuteNonQuery(uow => uow.ChannelRepository.Create(channel.MapToDbEntity()));
        }

        public void DeleteChannel(Selectional.ChannelDto channel)
        {
            ValidateDto(channel);

            ExecuteNonQuery(uow => uow.ChannelRepository.Delete(channel.MapToDbEntity()));
        }

        public void DeleteUserFromChannel(General.ChannelDto channel, General.UserDto user)
        {
            throw new NotImplementedException();
        }

        public void InviteUserToChannel(General.ChannelDto channel, string userLogin)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(General.ChatMessageDto chatMessage)
        {
            throw new NotImplementedException();
        }
    }
}
