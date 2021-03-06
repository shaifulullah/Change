﻿// <auto-generated />
using System;
using Chnage.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Chnage.Migrations
{
    [DbContext(typeof(MyECODBContext))]
    [Migration("20200428183755_UpdatedModels")]
    partial class UpdatedModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Chnage.Models.Admins", b =>
                {
                    b.Property<int>("iId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sEmail");

                    b.Property<string>("sName");

                    b.HasKey("iId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Chnage.Models.Audit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ChangedColumns")
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("EntityId")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NewData")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("OldData")
                        .HasColumnType("varchar(max)");

                    b.Property<string>("TableName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Audits");
                });

            modelBuilder.Entity("Chnage.Models.AuditLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AffectedProducts");

                    b.Property<string>("Approvers");

                    b.Property<string>("AreasAffected");

                    b.Property<bool?>("BOMRequired");

                    b.Property<DateTime>("ChangeDateTime");

                    b.Property<int?>("ChangeTypeId");

                    b.Property<int>("ChangeUserId");

                    b.Property<DateTime?>("ClosedDate");

                    b.Property<string>("CurrentFirmwareVersion");

                    b.Property<bool?>("CustomerApproval");

                    b.Property<bool?>("CustomerImpact");

                    b.Property<DateTime?>("DateOfNotice");

                    b.Property<string>("Description");

                    b.Property<int?>("ECNId");

                    b.Property<int?>("ECOId");

                    b.Property<int?>("ECRId");

                    b.Property<string>("ImpactMissingReqApprovalDate");

                    b.Property<int>("ImplementationType");

                    b.Property<string>("LinkUrls")
                        .HasMaxLength(4000);

                    b.Property<string>("ModelName");

                    b.Property<string>("ModelNumber");

                    b.Property<string>("NewFirmwareVersion");

                    b.Property<string>("NewRevision");

                    b.Property<string>("NotesForApprovers");

                    b.Property<string>("NotesForValidators");

                    b.Property<string>("Notifications");

                    b.Property<bool?>("PTCRBResubmissionRequired");

                    b.Property<bool?>("PermanentChange");

                    b.Property<DateTime?>("PlannedImplementationDate");

                    b.Property<string>("PreviousRevision");

                    b.Property<int>("PriorityLevel");

                    b.Property<bool?>("ProductValidationTestingRequired");

                    b.Property<string>("ReasonForChange");

                    b.Property<string>("RelatedECOs");

                    b.Property<string>("RelatedECRs");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ChangeTypeId");

                    b.HasIndex("ChangeUserId");

                    b.HasIndex("ECNId");

                    b.HasIndex("ECOId");

                    b.HasIndex("ECRId");

                    b.ToTable("AuditLogs");
                });

            modelBuilder.Entity("Chnage.Models.ECN", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChangeTypeId");

                    b.Property<DateTime?>("ClosedDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CurrentFirmwareVersion")
                        .IsRequired();

                    b.Property<DateTime>("DateOfNotice");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime?>("DeviationDate");

                    b.Property<int?>("DeviationQuantity");

                    b.Property<bool>("DeviationSelected");

                    b.Property<string>("ImpactMissingReqApprovalDate")
                        .IsRequired();

                    b.Property<string>("ModelName")
                        .IsRequired();

                    b.Property<string>("ModelNumber")
                        .IsRequired();

                    b.Property<string>("NewFirmwareVersion")
                        .IsRequired();

                    b.Property<int>("OriginatorId");

                    b.Property<bool>("PTCRBResubmissionRequired");

                    b.Property<string>("RejectReason");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ChangeTypeId");

                    b.HasIndex("OriginatorId");

                    b.ToTable("ECNs");
                });

            modelBuilder.Entity("Chnage.Models.ECNHasECO", b =>
                {
                    b.Property<int>("ECOId");

                    b.Property<int>("ECNId");

                    b.HasKey("ECOId", "ECNId");

                    b.HasIndex("ECNId");

                    b.ToTable("ECNHasECOs");
                });

            modelBuilder.Entity("Chnage.Models.ECO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BOMRequired");

                    b.Property<int>("ChangeTypeId");

                    b.Property<DateTime?>("ClosedDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("CustomerApproval");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DeviationDate");

                    b.Property<int?>("DeviationQuantity");

                    b.Property<bool>("DeviationSelected");

                    b.Property<int>("ImplementationType");

                    b.Property<string>("LinkUrls")
                        .HasMaxLength(4000);

                    b.Property<string>("NewRevision");

                    b.Property<string>("NotesForApprover")
                        .HasMaxLength(4000);

                    b.Property<string>("NotesForValidator")
                        .HasMaxLength(4000);

                    b.Property<int>("OriginatorId");

                    b.Property<bool>("PermanentChange");

                    b.Property<DateTime>("PlannedImplementationDate");

                    b.Property<string>("PreviousRevision");

                    b.Property<int>("PriorityLevel");

                    b.Property<bool>("ProductValidationTestingRequired");

                    b.Property<string>("ReasonForChange");

                    b.Property<string>("RejectReason");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ChangeTypeId");

                    b.HasIndex("OriginatorId");

                    b.ToTable("ECOs");
                });

            modelBuilder.Entity("Chnage.Models.ECR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("BOMRequired");

                    b.Property<int>("ChangeTypeId");

                    b.Property<DateTime?>("ClosedDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("CustomerImpact");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("DeviationDate");

                    b.Property<int?>("DeviationQuantity");

                    b.Property<bool>("DeviationSelected");

                    b.Property<bool>("ECOsCompleted");

                    b.Property<int>("ImplementationType");

                    b.Property<string>("LinkUrls")
                        .HasMaxLength(4000);

                    b.Property<string>("NewRevision");

                    b.Property<int>("OriginatorId");

                    b.Property<bool>("PermanentChange");

                    b.Property<DateTime>("PlannedImplementationDate");

                    b.Property<string>("PreviousRevision");

                    b.Property<int>("PriorityLevel");

                    b.Property<bool>("ProductValidationTestingRequired");

                    b.Property<string>("ReasonForChange");

                    b.Property<string>("RejectReason");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("ChangeTypeId");

                    b.HasIndex("OriginatorId");

                    b.ToTable("ECRs");
                });

            modelBuilder.Entity("Chnage.Models.ECRHasECO", b =>
                {
                    b.Property<int>("ECRId");

                    b.Property<int>("ECOId");

                    b.HasKey("ECRId", "ECOId");

                    b.HasIndex("ECOId");

                    b.ToTable("ECRHasECOs");
                });

            modelBuilder.Entity("Chnage.Models.Notifications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ECNId");

                    b.Property<int?>("ECOId");

                    b.Property<int?>("ECRId");

                    b.Property<int>("Option");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ECNId");

                    b.HasIndex("ECOId");

                    b.HasIndex("ECRId");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Chnage.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Chnage.Models.ProductECO", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("ECOId");

                    b.HasKey("ProductId", "ECOId");

                    b.HasIndex("ECOId");

                    b.ToTable("ProductECOs");
                });

            modelBuilder.Entity("Chnage.Models.ProductECR", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("ECRId");

                    b.HasKey("ProductId", "ECRId");

                    b.HasIndex("ECRId");

                    b.ToTable("ProductECRs");
                });

            modelBuilder.Entity("Chnage.Models.RequestType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("RequestTypes");
                });

            modelBuilder.Entity("Chnage.Models.RequestTypeECO", b =>
                {
                    b.Property<int>("RequestTypeId");

                    b.Property<int>("ECOId");

                    b.HasKey("RequestTypeId", "ECOId");

                    b.HasIndex("ECOId");

                    b.ToTable("RequestTypeECOs");
                });

            modelBuilder.Entity("Chnage.Models.RequestTypeECR", b =>
                {
                    b.Property<int>("RequestTypeId");

                    b.Property<int>("ECRId");

                    b.HasKey("RequestTypeId", "ECRId");

                    b.HasIndex("ECRId");

                    b.ToTable("RequestTypeECRs");
                });

            modelBuilder.Entity("Chnage.Models.UpdateWebAppLogs", b =>
                {
                    b.Property<int>("iId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("dtUploadDate");

                    b.Property<string>("sReason");

                    b.Property<string>("sUserEmail");

                    b.Property<string>("sWebAppversion");

                    b.HasKey("iId");

                    b.ToTable("UpdateWebAppLogs");
                });

            modelBuilder.Entity("Chnage.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<bool>("isActive");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Chnage.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestTypeId");

                    b.Property<int>("RoleInt");

                    b.Property<int>("UserId");

                    b.Property<bool>("isActive");

                    b.HasKey("Id");

                    b.HasIndex("RequestTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Chnage.Models.UserRoleECN", b =>
                {
                    b.Property<int>("UserRoleId");

                    b.Property<int>("ECNId");

                    b.Property<bool?>("Approval");

                    b.Property<string>("AprovedDate");

                    b.Property<string>("AproverNote");

                    b.HasKey("UserRoleId", "ECNId");

                    b.HasIndex("ECNId");

                    b.ToTable("UserRoleECNs");
                });

            modelBuilder.Entity("Chnage.Models.UserRoleECO", b =>
                {
                    b.Property<int>("UserRoleId");

                    b.Property<int>("ECOId");

                    b.Property<bool?>("Approval");

                    b.Property<string>("AprovedDate");

                    b.Property<string>("AproverNote");

                    b.HasKey("UserRoleId", "ECOId");

                    b.HasIndex("ECOId");

                    b.ToTable("UserRoleECOs");
                });

            modelBuilder.Entity("Chnage.Models.UserRoleECR", b =>
                {
                    b.Property<int>("UserRoleId");

                    b.Property<int>("ECRId");

                    b.Property<bool?>("Approval");

                    b.Property<string>("AprovedDate");

                    b.Property<string>("AproverNote");

                    b.HasKey("UserRoleId", "ECRId");

                    b.HasIndex("ECRId");

                    b.ToTable("UserRoleECRs");
                });

            modelBuilder.Entity("Chnage.Models.AuditLog", b =>
                {
                    b.HasOne("Chnage.Models.RequestType", "ChangeType")
                        .WithMany()
                        .HasForeignKey("ChangeTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.User", "ChangeUser")
                        .WithMany()
                        .HasForeignKey("ChangeUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECN", "ECN")
                        .WithMany("AuditLogs")
                        .HasForeignKey("ECNId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("AuditLogs")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECR", "ECR")
                        .WithMany("AuditLogs")
                        .HasForeignKey("ECRId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ECN", b =>
                {
                    b.HasOne("Chnage.Models.RequestType", "ChangeType")
                        .WithMany()
                        .HasForeignKey("ChangeTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.User", "Originator")
                        .WithMany("ECNs")
                        .HasForeignKey("OriginatorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ECNHasECO", b =>
                {
                    b.HasOne("Chnage.Models.ECN", "ECN")
                        .WithMany("RelatedECOs")
                        .HasForeignKey("ECNId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("RelatedECNs")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ECO", b =>
                {
                    b.HasOne("Chnage.Models.RequestType", "ChangeType")
                        .WithMany()
                        .HasForeignKey("ChangeTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.User", "Originator")
                        .WithMany("ECOs")
                        .HasForeignKey("OriginatorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ECR", b =>
                {
                    b.HasOne("Chnage.Models.RequestType", "ChangeType")
                        .WithMany()
                        .HasForeignKey("ChangeTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.User", "Originator")
                        .WithMany("ECRs")
                        .HasForeignKey("OriginatorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ECRHasECO", b =>
                {
                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("RelatedECRs")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECR", "ECR")
                        .WithMany("RelatedECOs")
                        .HasForeignKey("ECRId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.Notifications", b =>
                {
                    b.HasOne("Chnage.Models.ECN", "ECN")
                        .WithMany("Notifications")
                        .HasForeignKey("ECNId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("Notifications")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.ECR", "ECR")
                        .WithMany("Notifications")
                        .HasForeignKey("ECRId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ProductECO", b =>
                {
                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("AffectedProducts")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.Product", "Product")
                        .WithMany("ECOs")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.ProductECR", b =>
                {
                    b.HasOne("Chnage.Models.ECR", "ECR")
                        .WithMany("AffectedProducts")
                        .HasForeignKey("ECRId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.Product", "Product")
                        .WithMany("ECRs")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.RequestTypeECO", b =>
                {
                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("AreasAffected")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.RequestType", "RequestType")
                        .WithMany("RequestTypeECOs")
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.RequestTypeECR", b =>
                {
                    b.HasOne("Chnage.Models.ECR", "ECR")
                        .WithMany("AreasAffected")
                        .HasForeignKey("ECRId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.RequestType", "RequestType")
                        .WithMany("RequestTypeECRs")
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.UserRole", b =>
                {
                    b.HasOne("Chnage.Models.RequestType", "RequestType")
                        .WithMany()
                        .HasForeignKey("RequestTypeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Chnage.Models.UserRoleECN", b =>
                {
                    b.HasOne("Chnage.Models.ECN", "ECN")
                        .WithMany("Approvers")
                        .HasForeignKey("ECNId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.UserRole", "UserRole")
                        .WithMany("ECNs")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.UserRoleECO", b =>
                {
                    b.HasOne("Chnage.Models.ECO", "ECO")
                        .WithMany("Approvers")
                        .HasForeignKey("ECOId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.UserRole", "UserRole")
                        .WithMany("ECOs")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Chnage.Models.UserRoleECR", b =>
                {
                    b.HasOne("Chnage.Models.ECR", "ECR")
                        .WithMany("Approvers")
                        .HasForeignKey("ECRId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Chnage.Models.UserRole", "UserRole")
                        .WithMany("ECRs")
                        .HasForeignKey("UserRoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
