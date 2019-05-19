namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelDBContext : DbContext
    {
       
        public ModelDBContext()
            : base("name=ModelDB")
        {
        }
        public virtual DbSet<MobileDataObject> Mobiles { get; set; }
       
    }
}