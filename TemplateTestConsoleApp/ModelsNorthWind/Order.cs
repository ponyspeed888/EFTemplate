using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;


#if NET8_0_OR_GREATER
[EntityTypeConfiguration(typeof(OrderConfiguration))]
#endif

public partial class Order
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
   [property:Key]
#else
   [Key]
#endif

#if MVVM
   [property:Column("OrderID")]
#else
   [Column("OrderID")]
#endif

#if MVVM
    [ObservableProperty]
    private int _OrderId ; 
#else
    public int OrderId { get; set; }
#endif

#if MVVM
   [property:Column("CustomerID")]
#else
   [Column("CustomerID")]
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerId ; 
#else
    public string? CustomerId { get; set; }
#endif

#if MVVM
   [property:Column("EmployeeID")]
#else
   [Column("EmployeeID")]
#endif

#if MVVM
    [ObservableProperty]
    private int? _EmployeeId ; 
#else
    public int? EmployeeId { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "DATETIME")]
#else
   [Column(TypeName = "DATETIME")]
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _OrderDate ; 
#else
    public DateTime? OrderDate { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "DATETIME")]
#else
   [Column(TypeName = "DATETIME")]
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _RequiredDate ; 
#else
    public DateTime? RequiredDate { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "DATETIME")]
#else
   [Column(TypeName = "DATETIME")]
#endif

#if MVVM
    [ObservableProperty]
    private DateTime? _ShippedDate ; 
#else
    public DateTime? ShippedDate { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _ShipVia ; 
#else
    public int? ShipVia { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "NUMERIC")]
#else
   [Column(TypeName = "NUMERIC")]
#endif

#if MVVM
    [ObservableProperty]
    private int? _Freight ; 
#else
    public int? Freight { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipName ; 
#else
    public string? ShipName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipAddress ; 
#else
    public string? ShipAddress { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipCity ; 
#else
    public string? ShipCity { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipRegion ; 
#else
    public string? ShipRegion { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipPostalCode ; 
#else
    public string? ShipPostalCode { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ShipCountry ; 
#else
    public string? ShipCountry { get; set; }
#endif

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer? Customer { get; set; }

    [ForeignKey("EmployeeId")]
    [InverseProperty("Orders")]
    public virtual Employee? Employee { get; set; }

    [InverseProperty("Order")]
#if MVVM
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new ObservableCollection<OrderDetail>();
#else
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
#endif


    [ForeignKey("ShipVia")]
    [InverseProperty("Orders")]
    public virtual Shipper? ShipViaNavigation { get; set; }
}



