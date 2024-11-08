using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RakesModules.Models;

public partial class Rake
{
    [Key]
    [DisplayName("Rake ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Rake Number")]
    [Display(Name = "Rake Number")]
    public int? Rrno { get; set; }

    [Required(ErrorMessage = "Rake Date is required")]
    [Display(Name = "Rake Date")]
    [DataType(DataType.Date, ErrorMessage = "Invalid date format.")]
    public DateOnly? Rrdate { get; set; }

    [Required(ErrorMessage = "Rakes Fnr is required")]
    [Display(Name = "Rakes FNR Number")]
    public int? Fnr { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    [Display(Name = "Product Name")]
    public int? ProductId { get; set; }

    [Required(ErrorMessage = "Wagons is required")]
    [Display(Name = "Wagnons")]
    public int? NoOfWagons { get; set; }

    [Required(ErrorMessage = "Total weight is required")]
    [Display(Name = "Total Weight")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalWeight { get; set; }

    [Required(ErrorMessage = "Rates is required")]
    [Display(Name = "Rates")]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Rate { get; set; }

    [Required(ErrorMessage = "Sender weight is required")]
    [Display(Name = "Sender Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? SenderWeight { get; set; }

    [Required(ErrorMessage = "Total charges weight is required")]
    [Display(Name = "Total Charges Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalChargableWeight { get; set; }

    [Required(ErrorMessage = "Total Articles is required")]
    [Display(Name = "Total Articles")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalArticles { get; set; }

    [Required(ErrorMessage = "Freight Amount is required")]
    [Display(Name = "Freight Amount")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal FreightAmt { get; set; }

    [Required(ErrorMessage = "Rakes types is required")]
    [Display(Name = "Rakes Types")]
    
    public string? TypeOfRake { get; set; }

    [Required(ErrorMessage = "Spilages bags is required")]
    [Display(Name = "Spilages Bags")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal SpilageBags { get; set; }

    [Required(ErrorMessage = "Defective bags is required")]
    [Display(Name = "Defective Bags")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal CutAndTornBags { get; set; }

    [Required(ErrorMessage = "Bag1 is required")]
    [DisplayName("Bag 1 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag1Weight { get; set; }

    [Required(ErrorMessage = "Bag2 Weight is required")]
    [DisplayName("Bag 2 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag2Weight { get; set; }

    [Required(ErrorMessage = "Bag3 Weight is required")]
    [DisplayName("Bag 3 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag3Weight { get; set; }

    [Required(ErrorMessage = "Bag4 Weight is required")]
    [DisplayName("Bag 4 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag4Weight { get; set; }

    [Required(ErrorMessage = "Bag5 Weight is required")]
    [DisplayName("Bag 5 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag5Weight { get; set; }

    [Required(ErrorMessage = "Bag6 Weight is required")]
    [DisplayName("Bag 6 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag6Weight { get; set; }

    [Required(ErrorMessage = "Bag7 Weight is required")]
    [DisplayName("Bag 7 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag7Weight { get; set; }

    [Required(ErrorMessage = "Bag8 Weight is required")]
    [DisplayName("Bag 8 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag8Weight { get; set; }

    [Required(ErrorMessage = "Bag9 Weight is required")]
    [DisplayName("Bag 9 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag9Weight { get; set; }

    [Required(ErrorMessage = "Bag10 Weight is required")]
    [DisplayName("Bag 10 Weight")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Bag10Weight { get; set; }

    [Required(ErrorMessage = "MRP1 is required")]
    [DisplayName("MRP 1")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Mrp1 { get; set; }

    [DisplayName("MRP 2")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Mrp2 { get; set; }

    [DisplayName("MRP 3")]
    
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Mrp3 { get; set; }

    [Required(ErrorMessage = "CompletionDate is required")]
    [DisplayName("Completion Date")]
    [DataType(DataType.Date, ErrorMessage = "Completion Date must be a valid date.")]
    public DateOnly CompletionDate { get; set; }

    [Required(ErrorMessage = "Arrival Date is required")]
    [DataType(DataType.Date, ErrorMessage = "Arrival Date must be a valid date.")]
    [DisplayName("Arrival Date")]
    public DateOnly ArrivalDate { get; set; }

    [Required(ErrorMessage = "Consignors Name is required")]
    [DisplayName("Consignor Name")]
    
    public int ConsignorId { get; set; }

    public virtual Consignor? Consignor { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();

    public virtual Product? Product { get; set; }

    public virtual ICollection<Wagon> Wagons { get; set; } = new List<Wagon>();
}
