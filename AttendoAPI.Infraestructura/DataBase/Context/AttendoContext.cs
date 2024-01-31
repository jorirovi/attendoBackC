using AttendoAPI.Infraestructura.DataBase.Entity;
using Microsoft.EntityFrameworkCore;

namespace AttendoAPI.Infraestructura.DataBase.Context
{
	public class AttendoContext : DbContext
	{
		public AttendoContext(DbContextOptions<AttendoContext> options) : base(options)
		{
			
		}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
        #region [DBSets]
        public virtual DbSet<ClientsEntity> Clients { get; set; }
        public virtual DbSet<ContactEntity> Contact { get; set; }
        #endregion
    }
}

