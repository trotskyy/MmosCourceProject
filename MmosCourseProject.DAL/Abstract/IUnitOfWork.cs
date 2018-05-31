using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL;

namespace MmosCourseProject.DAL.Abstract
{
    public interface IUnitOfWork
    {
        IChannelRepository ChannelRepository { get; }
        IChatMessageRepository ChatMessageRepository { get; }
        ICommentRepository CommentRepository { get; }
        ITaskRepository TaskRepository { get; }
        ITeamRepository TeamRepository { get; }
        IUserRepository UserRepository { get; }
        IUserTeamRepository UserTeamRepository { get; }

        ITaskInfoViewRepository TaskInfoViewRepository { get; }
        ITeamInfoViewRepository TeamInfoViewRepository { get; }

        int SaveChanges();
    }
}
