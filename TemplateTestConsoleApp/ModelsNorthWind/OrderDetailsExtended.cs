using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;

[Keyless]


public partial class OrderDetailsExtended
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
   [property:Column("OrderID")]
#else
   [Column("OrderID")]
#endif

#if MVVM
    [ObservableProperty]
    private int? _OrderId ; 
#else
    public int? OrderId { get; set; }
#endif

#if MVVM
   [property:Column("ProductID")]
#else
   [Column("ProductID")]
#endif

#if MVVM
    [ObservableProperty]
    private int? _ProductId ; 
#else
    public int? ProductId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ProductName ; 
#else
    public string? ProductName { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "NUMERIC")]
#else
   [Column(TypeName = "NUMERIC")]
#endif

#if MVVM
    [ObservableProperty]
    private double? _UnitPrice ; 
#else
    public double? UnitPrice { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _Quantity ; 
#else
    public int? Quantity { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double? _Discount ; 
#else
    public double? Discount { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private double? _ExtendedPrice ; 
#else
    public double? ExtendedPrice { get; set; }
#endif
}



