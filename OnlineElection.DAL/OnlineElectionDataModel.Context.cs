﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineElection.DAL
{
    using Domain.ViewModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;


    public partial class OnlineElectionEntities : DbContext
    {
        public OnlineElectionEntities()
            : base("name=OnlineElectionEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Degree> Degrees { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<staff> staffs { get; set; }
        public virtual DbSet<student> students { get; set; }

        //public System.Data.Entity.DbSet<CandidateViewModel> CandidateViewModels { get; set; }
    }
}