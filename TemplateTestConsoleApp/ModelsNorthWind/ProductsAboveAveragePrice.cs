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


public partial class ProductsAboveAveragePrice
#if MVVM
                : ObservableValidator
#else
#endif
{
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
}



