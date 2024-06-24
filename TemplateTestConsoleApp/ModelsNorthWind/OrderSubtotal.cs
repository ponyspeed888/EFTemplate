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


public partial class OrderSubtotal
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
    [ObservableProperty]
    private double? _Subtotal ; 
#else
    public double? Subtotal { get; set; }
#endif
}



