using System.ComponentModel.DataAnnotations;

namespace MedicineApp.Entities
{
    public class Medicine
    {
        public int MedicineId { get; set; }

        [Required(ErrorMessage = "Medicine type is required.")]
        [MaxLength(50)]
        public string MedicineType { get; set; }

        [Required(ErrorMessage = "Medicine name is required.")]
        [MaxLength(100)]
        public string MedicineName { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Range(20, 200, ErrorMessage = "Stock quantity must be between 20 and 200.")]
        public int StockQuantity { get; set; }

        public string DisplayText
        {
            get
            {
                if (MedicineType.Length <= 4)
                {
                    return MedicineType;
                }
                else
                {
                    return MedicineType.Substring(0, 4) + "...";
                }
            }
        }
    }
}
