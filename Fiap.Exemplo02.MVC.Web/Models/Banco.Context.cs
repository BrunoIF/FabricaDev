﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Fiap.Exemplo02.MVC.Web.Models
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class PortalContext : DbContext
{
    public PortalContext()
        : base("name=PortalContext")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<Aluno> Aluno { get; set; }

    public virtual DbSet<Grupo> Grupo { get; set; }

    public virtual DbSet<Projeto> Projeto { get; set; }

}

}

