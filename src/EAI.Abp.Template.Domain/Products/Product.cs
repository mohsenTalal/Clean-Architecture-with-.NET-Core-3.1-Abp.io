using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities;

namespace $safeprojectname$.Products
{
    [Audited]
    public class Product : Entity
    {
        public string DisplayNameAr { get; set; }
        public string DisplayNameEn { get; set; }
        public bool IsActive { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }

        public override object[] GetKeys()
        {
            return new object[] { ProductId };
        }
    }
}