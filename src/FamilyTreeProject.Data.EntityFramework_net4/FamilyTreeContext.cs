//******************************************
//  Copyright (C) 2014-2015 Charles Nurse  *
//                                         *
//  Licensed under MIT License             *
//  (see included LICENSE)                 *
//                                         *
// *****************************************

using System.Data.Entity;
using FamilyTreeProject.Data.EntityFramework.Common;

namespace FamilyTreeProject.Data.EntityFramework
{
    public class FamilyTreeContext : DbContext
    {
        public FamilyTreeContext() { }

        public FamilyTreeContext(string nameOrConnectionString) : base(nameOrConnectionString) { }

        public DbSet<TreeEntity> Trees { get; set; }

        public DbSet<IndividualEntity> Individuals { get; set; }

        public DbSet<FamilyEntity> Familys { get; set; }

        public DbSet<CitationEntity> Citations { get; set; }

        public DbSet<FactEntity> Facts { get; set; }

        public DbSet<MultimediaLinkEntity> MultimediaLinks { get; set; }

        public DbSet<NoteEntity> Note { get; set; }

        public DbSet<SourceEntity> Sources { get; set; }

        public DbSet<RepositoryEntity> Repositorys { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new TreeConfiguration());
            //modelBuilder.Configurations.Add(new FamilyConfiguration());
            //modelBuilder.Configurations.Add(new IndividualConfiguration());
            //modelBuilder.Configurations.Add(new CitationConfiguration());
            //modelBuilder.Configurations.Add(new FactConfiguration());
            //modelBuilder.Configurations.Add(new MultimediaLinkConfiguration());
            //modelBuilder.Configurations.Add(new NoteConfiguration());
            //modelBuilder.Configurations.Add(new RepositoryConfiguration());
            //modelBuilder.Configurations.Add(new SourceConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}