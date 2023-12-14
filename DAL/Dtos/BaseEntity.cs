using Swashbuckle.AspNetCore.Annotations;

namespace DAL.Dtos
{
    public class BaseEntity
    {
        [SwaggerSchema(ReadOnly = true)]
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 15).Replace('+', '_').Replace('-', '_').Replace('*', '_').Replace('/', '_');

        public bool IsDeleted { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string? CreatedBy { get; set; }

        public DateTime UpdatedTime { get; set; } = DateTime.Now;
        public string? UpdatedBy { get; set; }
    }
}