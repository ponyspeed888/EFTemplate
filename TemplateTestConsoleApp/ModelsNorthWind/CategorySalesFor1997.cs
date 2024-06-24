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


public partial class CategorySalesFor1997
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
    private byte[]? _CategorySales ; 
#else
    public byte[]? CategorySales { get; set; }
#endif
}



