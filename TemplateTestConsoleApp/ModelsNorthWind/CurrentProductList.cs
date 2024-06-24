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


public partial class CurrentProductList
#if MVVM
                : ObservableValidator
#else
#endif
{
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
}



