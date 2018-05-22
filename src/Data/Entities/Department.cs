namespace ems.data.entities
{
    using System.ComponentModel.DataAnnotations;
    public class Department
    {
        [Required]
        public int DepartmentId { get; set; }

        [Required]
        public string DepartmentName { get; set; }

        public string Description { get; set; }
    }
}