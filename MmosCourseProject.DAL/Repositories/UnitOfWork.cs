using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        MyTrelloContext _dbContext;
        IChannelRepository _channelRepository;
        IChatMessageRepository _chatMessageRepository;
        ICommentRepository _taskCommentRepository;
        ITaskRepository _taskRepository;
        IUserRepository _userRepository;
        IViewTeamRepository _viewTeamRepository;
        IViewTopLevelTeamLeadRepository _viewTopLevelTeamLeadRepository;

        public UnitOfWork()
        {
            _dbContext = new MyTrelloContext();
        }

        public IChannelRepository ChannelRepository
        { 
            get
            {
                if (_channelRepository == null)
                    _channelRepository = new ChannelRepository(_dbContext);
                return _channelRepository;
            }
        }

        public IChatMessageRepository ChatMessageRepository
        {
            get
            {
                if (_chatMessageRepository == null)
                    _chatMessageRepository = new ChatMessageRepository(_dbContext);
                return _chatMessageRepository;
            }
        }

        public ICommentRepository TaskCommentRepository
        {
            get
            {
                if (_taskCommentRepository == null)
                    _taskCommentRepository = new TaskCommentRepository(_dbContext);
                return _taskCommentRepository;
            }
        }

        public ITaskRepository TaskRepository
        {
            get
            {
                if (_taskRepository == null)
                    _taskRepository = new TaskRepository(_dbContext);
                return _taskRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_dbContext);
                return _userRepository;
            }
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
