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

        public ChannelService(IUnitOfWorkFactory unitOfWorkFactory) : base(unitOfWorkFactory) { }

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
            Execute.NonQuery(uow =>
            {
                //ValidateDbEntity(channel.MapToDbEntity(), uow, DomainModelValidation.ValidationType.OnCreate);
                uow.Repository<IChannelRepository>().Create(channel.MapToDbEntity());
            });
        }

        public void DeleteChannel(Selectional.ChannelDto channel)
        {
            ValidateDto(channel);

            Execute.NonQuery(uow => uow.Repository<IChannelRepository>().Delete(channel.MapToDbEntity()));
        }

        public void DeleteUserFromChannel(General.ChannelDto channel, General.UserDto user)
        {
            Execute.NonQuery(uow => uow.Repository<IChannelRepository>().RemoveUserFromChannel(channel.MapToDbEntity(), user.MapToDbEntity()));
        }

        public void InviteUserToChannel(General.ChannelDto channel, string userLogin)
        {
            Execute.NonQuery(uow => {
                var chnl = uow.Repository<IChannelRepository>().GetById(channel.Id);
                var user = uow.Repository<IUserRepository>().GetFirst(u => u.Email == userLogin);
                chnl.Users.Add(user);
            });
        }

        public void SendMessage(General.ChatMessageDto chatMessage)
        {
            Execute.NonQuery(uow => {
                var chnl = uow.Repository<IChannelRepository>().GetById(chatMessage.ChannelId);
                uow.Repository<IChatMessageRepository>().Create(chatMessage.MapToDbEntity());
            });
        }
    }
}
