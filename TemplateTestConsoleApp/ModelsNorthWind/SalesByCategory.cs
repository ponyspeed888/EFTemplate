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


public partial class SalesByCategory
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
   [property:Column("CategoryID")]
#else
   [Column("CategoryID")]
#endif

#if MVVM
    [ObservableProperty]
    private int? _CategoryId ; 
#else
    public int? CategoryId { get; set; }
#endif

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
    private byte[]? _ProductSales ; 
#else
    public byte[]? ProductSales { get; set; }
#endif
}



