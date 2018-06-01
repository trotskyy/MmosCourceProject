using MmosCourseProject.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmosCourseProject.DAL.EfProviders
{
    /// <summary>
    /// Entity Framework unit of work
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        MyTrelloContext _dbContext;

        IChannelRepository _channelRepository;
        IChatMessageRepository _chatMessageRepository;
        ICommentRepository _commentRepository;
        ITaskRepository _taskRepository;
        IUserRepository _userRepository;
        ITeamRepository _teamRepository;
        IUserTeamRepository _userTeamRepository;
        ITaskInfoViewRepository _taskInfoViewRepository;
        ITeamInfoViewRepository _teamInfoViewRepository;

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

        public ICommentRepository CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository(_dbContext);
                return _commentRepository;
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

        public ITeamRepository TeamRepository
        {
            get
            {
                if (_teamRepository == null)
                    _teamRepository = new TeamRepository(_dbContext);
                return _teamRepository;
            }
        }

        public IUserTeamRepository UserTeamRepository
        {
            get
            {
                if (_userTeamRepository == null)
                    _userTeamRepository = new UserTeamRepository(_dbContext);
                return _userTeamRepository;
            }
        }

        public ITaskInfoViewRepository TaskInfoViewRepository
        {
            get
            {
                if (_taskInfoViewRepository == null)
                    _taskInfoViewRepository = new TaskInfoViewRepository(_dbContext);
                return _taskInfoViewRepository;
            }
        }

        public ITeamInfoViewRepository TeamInfoViewRepository
        {
            get
            {
                if (_teamInfoViewRepository == null)
                    _teamInfoViewRepository = new TeamInfoViewRepository(_dbContext);
                return _teamInfoViewRepository;
            }
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }
    }
}
