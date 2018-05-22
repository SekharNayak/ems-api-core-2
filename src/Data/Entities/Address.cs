namespace ems.data.entities
{

    using System.ComponentModel.DataAnnotations;
    using ems.data.enums;

    public class Address
    {

        [Required]
        public int AddressId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }
        [Required] public string State { get; set; }

        [Required] public string Country { get; set; }

        [Required] public string PinCode { get; set; }

        public bool IsCurrentAddress { get; set; }


        [Required]
        public AddressType Type { get; set; }


    }
}