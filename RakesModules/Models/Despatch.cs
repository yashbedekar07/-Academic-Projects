using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Despatch
{
    public int Id { get; set; }

    public int? DispatchNo { get; set; }

    public DateOnly? DespatchDate { get; set; }

    public int? TransporterId { get; set; }

    public string? DriverName { get; set; }

    public string? VehicleNo { get; set; }

    public int? DestinationId { get; set; }

    public int? DealerId { get; set; }

    public int? SubDealerId { get; set; }

    public decimal? Mtons { get; set; }

    public decimal? TotalBags { get; set; }

    public int? ProductId { get; set; }

    public int? Dcno { get; set; }

    public decimal? FreightAmt { get; set; }

    public decimal? AdvanceAmt { get; set; }

    public decimal? BalanceAmt { get; set; }

    public int? DistrictId { get; set; }

    public int? TalukaId { get; set; }

    public int? DespatchTypeId { get; set; }

    public int? RakeId { get; set; }

    public int? Lrno { get; set; }

    public DateOnly? Lrdate { get; set; }

    public int? Sonumber { get; set; }

    public DateOnly? Sodate { get; set; }

    public decimal? Distance { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Amount { get; set; }

    public virtual Dealer? Dealer { get; set; }

    public virtual DespatchType? DespatchType { get; set; }

    public virtual Destination? Destination { get; set; }

    public virtual District? District { get; set; }

    public virtual Product? Product { get; set; }

    public virtual Rake? Rake { get; set; }

    public virtual Subdealer? SubDealer { get; set; }

    public virtual Taluka? Taluka { get; set; }

    public virtual Transport? Transporter { get; set; }
}
