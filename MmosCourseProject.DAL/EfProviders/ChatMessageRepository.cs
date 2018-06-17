using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL.EfProviders
{
    public class ChatMessageRepository : EfGenericRepository<ChatMessage, int>, IChatMessageRepository
    {
        public ChatMessageRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
