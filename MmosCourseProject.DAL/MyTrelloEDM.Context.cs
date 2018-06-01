﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MmosCourseProject.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MyTrelloContext : DbContext
    {
        public MyTrelloContext()
            : base("name=MyTrelloContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Channel> Channels { get; set; }
        public virtual DbSet<ChatMessage> ChatMessages { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserTeam> UserTeams { get; set; }
        public virtual DbSet<TaskInfoView> TaskInfoViews { get; set; }
        public virtual DbSet<TeamInfoView> TeamInfoViews { get; set; }
    
        [DbFunction("MyTrelloContext", "GetAllSubtaskIds")]
        public virtual IQueryable<Nullable<int>> GetAllSubtaskIds(Nullable<int> parentTaskId)
        {
            var parentTaskIdParameter = parentTaskId.HasValue ?
                new ObjectParameter("parentTaskId", parentTaskId) :
                new ObjectParameter("parentTaskId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Nullable<int>>("[MyTrelloContext].[GetAllSubtaskIds](@parentTaskId)", parentTaskIdParameter);
        }
    
        [DbFunction("MyTrelloContext", "GetAllSubtasks")]
        public virtual IQueryable<Task> GetAllSubtasks(Nullable<int> parentTaskId)
        {
            var parentTaskIdParameter = parentTaskId.HasValue ?
                new ObjectParameter("parentTaskId", parentTaskId) :
                new ObjectParameter("parentTaskId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Task>("[MyTrelloContext].[GetAllSubtasks](@parentTaskId)", parentTaskIdParameter);
        }
    
        [DbFunction("MyTrelloContext", "GetAllSubteams")]
        public virtual IQueryable<Team> GetAllSubteams(Nullable<int> parentTeamId)
        {
            var parentTeamIdParameter = parentTeamId.HasValue ?
                new ObjectParameter("parentTeamId", parentTeamId) :
                new ObjectParameter("parentTeamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Team>("[MyTrelloContext].[GetAllSubteams](@parentTeamId)", parentTeamIdParameter);
        }
    
        [DbFunction("MyTrelloContext", "GetAllSubteamsIds")]
        public virtual IQueryable<Nullable<int>> GetAllSubteamsIds(Nullable<int> parentTeamId)
        {
            var parentTeamIdParameter = parentTeamId.HasValue ?
                new ObjectParameter("parentTeamId", parentTeamId) :
                new ObjectParameter("parentTeamId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<Nullable<int>>("[MyTrelloContext].[GetAllSubteamsIds](@parentTeamId)", parentTeamIdParameter);
        }
    
        public virtual int DeleteTaskGraph(Nullable<int> taskId)
        {
            var taskIdParameter = taskId.HasValue ?
                new ObjectParameter("taskId", taskId) :
                new ObjectParameter("taskId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteTaskGraph", taskIdParameter);
        }
    
        public virtual int UpdateTaskGraphState(Nullable<int> parentTaskId, Nullable<TaskState> newState)
        {
            var parentTaskIdParameter = parentTaskId.HasValue ?
                new ObjectParameter("parentTaskId", parentTaskId) :
                new ObjectParameter("parentTaskId", typeof(int));
    
            var newStateParameter = newState.HasValue ?
                new ObjectParameter("newState", newState) :
                new ObjectParameter("newState", typeof(TaskState));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateTaskGraphState", parentTaskIdParameter, newStateParameter);
        }
    }
}
