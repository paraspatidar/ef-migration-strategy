//using Conga.Platform.CustomerManagement.Core.Models.Provisioning;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerManagement.Data.DBEntities
{
    public class CustomerDetail
    {
        [Key]
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public bool IsActive { get; set; }
    }
}
