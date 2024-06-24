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


public partial class ProductsByCategory
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private string? _CategoryName ; 
#else
    public string? CategoryName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ProductName ; 
#else
    public string? ProductName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _QuantityPerUnit ; 
#else
    public string? QuantityPerUnit { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _UnitsInStock ; 
#else
    public int? UnitsInStock { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Discontinued ; 
#else
    public string? Discontinued { get; set; }
#endif
}



