using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MmosCourseProject.DAL.Abstract;

namespace MmosCourseProject.DAL
{
    public class ChatMessageRepository : GenericRepository<ChatMessage, int>, IChatMessageRepository
    {
        public ChatMessageRepository(MyTrelloContext dbContext) : base(dbContext)
        {
        }
    }
}
