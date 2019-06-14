using Microsoft.EntityFrameworkCore;

namespace MySql.Contexts
{
    class SGCMgnCtx : DbContext
    {
        public SGCMgnCtx()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseMySql(Properties
                .Resources.ResourceManager.GetString("NAME_STR_CONN"));
        }
    }
}
