using RentalProperties.Data;
using RentalProperties.Data.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RentalProperties.Models.Property
{
    using static DataConstants.PropertyConstants;

    public class AddNewPropertyInputModel
    {
        [Required(AllowEmptyStrings =false, ErrorMessage ="There are only two options, for Rent or for Sale")]
        [Display(Name = "Property Type")]
        public PropertyType PropertyType { get; set; }

        [Required]
        public string Location { get; set; }

        //[Url]
        //[Required]
        //[Display(Name = "Image")]
        //public string ImageUrl { get; set; }

        [Range(0, PropertyMaxPrice)]
        [Required]
        public double Price { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(DescriptionMaxLength,ErrorMessage ="The description is to long" )]
        public string Description { get; set; }

        public IEnumerable<IFormFile> Images { get; set; }
    }
}
