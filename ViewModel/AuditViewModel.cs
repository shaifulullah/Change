using Chnage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chnage.ViewModel
{
    public class AuditViewModel
    {
        public AuditViewModel()
        {
            AuditLogs = new List<AuditLog>();
            Audits = new List<Audit>();
        }
        public List<AuditLog> AuditLogs { get; set; }
        public List<Audit> Audits { get; set; }
    }
}
