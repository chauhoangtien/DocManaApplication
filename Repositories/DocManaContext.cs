using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Model;
using Microsoft.Extensions.Configuration;

namespace Repositories;

public partial class DocManaContext : DbContext
{
    public DocManaContext()
    {
    }

    public DocManaContext(DbContextOptions<DocManaDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessPermission> AccessPermissions { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupEmail> GroupEmails { get; set; }

    public virtual DbSet<ProfileRepository> Profiles { get; set; }

    public virtual DbSet<ProfileDocument> ProfileDocuments { get; set; }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectDepartment> ProjectDepartments { get; set; }

    public virtual DbSet<ProjectGroup> ProjectGroups { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserDepartment> UserDepartments { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(getConnectionString());

    public string getConnectionString()
    {
        //IConfiguration configuration = new ConfigurationBuilder()
        //    .SetBasePath("C:\\Users\\ADMIN\\OneDrive\\Desktop\\Hoc Tap\\2024-2025\\HK1-2024-2025\\Cong Nghe Phan Mem\\CK\\DocMana\\View")
        //    .AddJsonFile("appsettings.json", true, true)
        //    .Build();
        //return configuration["ConnectionStrings:DBDefault"];
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=DocManaDatabase;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        return connectionString;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccessPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId).HasName("PermissionID_PK");

            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.AccessLevel).HasMaxLength(255);
            entity.Property(e => e.ProfileId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProfileID");
            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UserID");

            entity.HasOne(d => d.Profile).WithMany(p => p.AccessPermissions)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("ProfileID_AccessPermissions_FK");

            entity.HasOne(d => d.User).WithMany(p => p.AccessPermissions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("UserID_AccessPermissions_FK");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DepartmentId).HasName("DepartmentID_PK");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentName).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.ManagerId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ManagerID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("ManagerID_Departments_FK");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.DocumentId).HasName("DocumentID_PK");

            entity.Property(e => e.DocumentId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DocumentID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocumentName).HasMaxLength(200);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProjectID");
            entity.Property(e => e.Status).HasMaxLength(100);
            entity.Property(e => e.SubmittedBy)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Version)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Version");
            entity.Property(e => e.FilePath)
                .HasMaxLength(500)
                .IsUnicode(true)
                .HasColumnName("FilePath");

            entity.HasOne(d => d.Project).WithMany(p => p.Documents)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("ProjectID_Documents_FK");

            entity.HasOne(d => d.SubmittedByNavigation).WithMany(p => p.Documents)
                .HasForeignKey(d => d.SubmittedBy)
                .HasConstraintName("SubmittedBy_Documents_FK");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("Groups_PK");

            entity.Property(e => e.GroupId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GroupID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.GroupName).HasMaxLength(150);
            entity.Property(e => e.LeaderId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("LeaderID");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Department).WithMany(p => p.Groups)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("DepartmentID_Groups_FK");

            entity.HasOne(d => d.Leader).WithMany(p => p.Groups)
                .HasForeignKey(d => d.LeaderId)
                .HasConstraintName("LeaderID_Departments_FK");
        });

        modelBuilder.Entity<GroupEmail>(entity =>
        {
            entity.HasKey(e => e.EmailId).HasName("EmailID_PK");

            entity.Property(e => e.EmailId)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("EmailID");
            entity.Property(e => e.Cclist)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CCList");
            entity.Property(e => e.ProfileId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProfileID");
            entity.Property(e => e.Recipients)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SendDate).HasColumnType("datetime");
            entity.Property(e => e.SenderId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("SenderID");
            entity.Property(e => e.Subject).IsUnicode(false);

            entity.HasOne(d => d.Profile).WithMany(p => p.GroupEmails)
                .HasForeignKey(d => d.ProfileId)
                .HasConstraintName("ProfileID_GroupEmails_FK");

            entity.HasOne(d => d.Sender).WithMany(p => p.GroupEmails)
                .HasForeignKey(d => d.SenderId)
                .HasConstraintName("SenderID_GroupEmails_FK");
        });

        modelBuilder.Entity<Profile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("ProfileID_PK");

            entity.Property(e => e.ProfileId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProfileID");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProfileName).HasMaxLength(100);
            entity.Property(e => e.ProjectId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProjectID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Project).WithMany(p => p.Profiles)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("ProjectID_Profiles_FK");
        });

        modelBuilder.Entity<ProfileDocument>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.DocumentId }).HasName("ProfileDocument_PK");

            entity.ToTable("Profile_Documents");

            entity.Property(e => e.ProfileId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProfileID");
            entity.Property(e => e.DocumentId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DocumentID");

            entity.HasOne(d => d.Profile).WithMany(p => p.ProfileDocuments)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ProfileID_ProfileDocumen_FK");

            entity.HasOne(d => d.Document).WithMany(p => p.ProfileDocuments)
                .HasForeignKey(d => d.DocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DocumentID_ProfileDocument_FK");
        });

        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("ProjectID_PK");

            entity.Property(e => e.ProjectId)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ProjectID");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.ProjectName).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(50);

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Projects)
                .HasForeignKey(d => d.CreatedBy)
                .HasConstraintName("CreatedBy_Projects_FK");
        });

        modelBuilder.Entity<ProjectDepartment>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.DepartmentId }).HasName("ProjectDepartments_PK");

            entity.ToTable("Project_Departments");

            entity.Property(e => e.ProjectId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProjectID");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DepartmentID");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectDepartments)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ProjectID_ProjectDepartments_FK");

            entity.HasOne(d => d.Department).WithMany(p => p.ProjectDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DepartmentID_ProjectDepartments_FK");
        });

        modelBuilder.Entity<ProjectGroup>(entity =>
        {
            entity.HasKey(e => new { e.ProjectId, e.GroupId }).HasName("ProjectGroups_PK");

            entity.ToTable("Project_Departments");

            entity.Property(e => e.ProjectId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ProjectID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("GroupID");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectGroups)
                .HasForeignKey(d => d.ProjectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ProjectID_ProjectDepartments_FK");

            entity.HasOne(d => d.Group).WithMany(p => p.ProjectGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DepartmentID_ProjectDepartments_FK");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("UserID_PK");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.Gender).HasMaxLength(10);
            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Role).HasMaxLength(100);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<UserDepartment>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.DepartmentId }).HasName("UserDepartments_PK");

            entity.ToTable("User_Departments");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.JoinedDate).HasColumnType("datetime");
            entity.Property(e => e.Role).HasMaxLength(100);

            entity.HasOne(d => d.Department).WithMany(p => p.UserDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("DepartmentID_UserDepartments_FK");

            entity.HasOne(d => d.User).WithMany(p => p.UserDepartments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserID_UserDepartments_FK");
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.GroupId }).HasName("UserGroup_PK");

            entity.ToTable("User_Groups");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("UserID");
            entity.Property(e => e.GroupId)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GroupID");
            entity.Property(e => e.JoinedDate).HasColumnType("datetime");
            entity.Property(e => e.Role).HasMaxLength(100);

            entity.HasOne(d => d.Group).WithMany(p => p.UserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("GroupID_UserGroups_FK");

            entity.HasOne(d => d.User).WithMany(p => p.UserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("UserID_UserGroups_FK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
