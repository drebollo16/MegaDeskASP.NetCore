using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskASP.NetCore.Models
{
    public class Desk
    {
        public int Id { get; set; }
        [Display(Name = "Customer Name")]
        public string? CustomerName { get; set; }
        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        [Display(Name = "Desk Width")]
        public decimal DeskWidth { get; set; }
        [Display(Name = "Desk Depth")]
        public decimal DeskDepth { get; set; }
        [Display(Name = "Number of Drawers")]
        public int NumberOfDrawers { get; set; }
        [Display(Name = "Surface Material")]
        public string? SurfaceMaterial { get; set; }
        [Display(Name = "Delivery Choice")]
        public string? DeliveryChoice { get; set; }
        [Display(Name = "Quote Total")]
        public float QuoteTotal { get; set; }

    }
}
