using Chnage.CustomAttributes;
using Chnage.Models;
using Chnage.ViewModel.ECR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chnage.Models
{
    public class ECR
    {
        public ECR()
        {

        }
        public ECR(ECRViewModel vm)
        {
            Description = vm.Description;
            BOMRequired = vm.BOMRequired;
            CustomerImpact = vm.CustomerImpact;
            Approvers = vm.Approvers;
            AffectedProducts = vm.AffectedProducts;
            ImplementationType = vm.ImplementationType;
            ReasonForChange = vm.ReasonForChange;
            ChangeType = vm.ChangeType;
            ChangeTypeId = vm.ChangeTypeId;
            OriginatorId = vm.OriginatorId;
            Originator = vm.Originator;
            PermanentChange = vm.PermanentChange;
            PlannedImplementationDate = vm.PlannedImplementationDate;
            PriorityLevel = vm.PriorityLevel;
            ProductValidationTestingRequired = vm.ProductValidationTestingRequired;
            LinkUrls = vm.LinkUrls;
            PreviousRevision = vm.PreviousRevision;
            NewRevision = vm.NewRevision;
            Status = vm.Status;
            DeviationSelected = vm.DeviationSelected;
            DeviationQuantity = vm.DeviationQuantity;
            DeviationDate = vm.DeviationDate;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [ExcludeFromStructuredJsonInfo]
        public int Id { get; set; }
        [Display(Name = "Permanent Change")]
        public bool PermanentChange { get; set; }

        [Display(Name = "Affected Products")]
        public virtual ICollection<ProductECR> AffectedProducts { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Reason For Change")]
        public string ReasonForChange { get; set; }

        [Display(Name = "Change Type")]
        public virtual RequestType ChangeType { get; set; }

        [ExcludeFromStructuredJsonInfo]
        public int ChangeTypeId { get; set; }

        [Display(Name = "Areas Affected by Change")]
        public virtual ICollection<RequestTypeECR> AreasAffected { get; set; }

        [Display(Name = "BOM Required")]
        public bool BOMRequired { get; set; }

        [Display(Name = "Product Validation Testing Required")]
        public bool ProductValidationTestingRequired { get; set; }

        [Display(Name = "Planned Implementation Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime PlannedImplementationDate { get; set; }

        [Display(Name = "Created Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Display(Name = "Closed Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd HH:mm:ss}")]
        public DateTime? ClosedDate { get; set; }

        [Display(Name = "Customers Impacted")]
        public bool CustomerImpact { get; set; }

        [Display(Name = "Priority Level")]
        public PriorityLevel PriorityLevel { get; set; }

        [Display(Name = "Related ECO Ids")]
        public virtual ICollection<ECRHasECO> RelatedECOs { get; set; }

        public virtual ICollection<UserRoleECR> Approvers { get; set; }
        public virtual User Originator { get; set; }

        [Display(Name = "Originator Id")]
        [ExcludeFromStructuredJsonInfo]
        public int OriginatorId { get; set; }

        [Display(Name = "Implementation Type")]
        public ImpType ImplementationType { get; set; }

        public StatusOptions Status { get; set; }
        [Display(Name = "All ECOs Approved")]
        public bool ECOsCompleted { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        [Display(Name = "Previous Revision")]
        public string PreviousRevision { get; set; }
        [Display(Name = "New Revision")]
        public string NewRevision { get; set; }
        [Display(Name = "Links")]
        public Dictionary<string, string> LinkUrls { get; set; }
        public List<AuditLog> AuditLogs { get; set; }
        public string RejectReason { get; set; }
        [NotMapped]
        [Display(Name = "Add user to notification list")]
        public List<int> UsersToBeAddedInNotification { get; set; }
        [NotMapped]
        public PartialViewAffectedProductsECR PartialViewAffectedProductsECR { get; set; }

        [Display(Name = "Deviation")]
        public bool DeviationSelected { get; set; }
        [Display(Name = "Deviation Quantity")]
        public int? DeviationQuantity { get; set; }
        [Display(Name = "Deviation End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime? DeviationDate { get; set; }
    }
    public class ECRHasECO
    {
        public int ECRId { get; set; }
        public virtual ECR ECR { get; set; }
        public int ECOId { get; set; }
        public virtual ECO ECO { get; set; }
    }
}
public enum PriorityLevel
{
    Routine = 0,
    Significant = 1,
    Emergency = 2
}

public enum StatusOptions
{
    [Display(Name = "Draft")]
    Draft,
    [Display(Name = "Rejected")]
    RejectedValidation,
    [Display(Name = "Rejected")]
    RejectedApproval,
    [Display(Name = "Awaiting Approval")]
    AwaitingApproval,
    [Display(Name = "Approved")]
    Approved,
    [Display(Name = "Templates")]
    Template,
    [Display(Name = "Delete")]
    Delete,
    [Display(Name = "Awaiting Validation")]
    AwaitingValidation
}
public enum ImpType
{
    [Display(Name = "New Production")]
    NewProduction = 0,
    [Display(Name = "Rework All")]
    ReworkAll = 1,
    [Display(Name = "Running Change")]
    RunningChange = 2
}
public class PartialViewAffectedProductsECR
{
    public PartialViewAffectedProductsECR()
    {
        AffectedProducts = new List<ProductECR>();
        NotAffectedProducts = new List<Product>();
        Print = false;
    }
    public virtual ICollection<ProductECR> AffectedProducts { get; set; }
    public virtual ICollection<Product> NotAffectedProducts { get; set; }
    public bool Print { get; set; }
}