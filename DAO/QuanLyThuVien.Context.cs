﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QuanLyThuVienEntities : DbContext
    {
        public QuanLyThuVienEntities()
            : base("name=QuanLyThuVienEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CTMuonSach> CTMuonSaches { get; set; }
        public virtual DbSet<CTNhapSach> CTNhapSaches { get; set; }
        public virtual DbSet<CTTraSach> CTTraSaches { get; set; }
        public virtual DbSet<DauSach> DauSaches { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<MuonSach> MuonSaches { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NhapSach> NhapSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<TheThuVien> TheThuViens { get; set; }
        public virtual DbSet<TraSach> TraSaches { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
