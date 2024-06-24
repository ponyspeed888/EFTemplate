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


public partial class CustomerAndSuppliersByCity
#if MVVM
                : ObservableValidator
#else
#endif
{
#if MVVM
    [ObservableProperty]
    private string? _City ; 
#else
    public string? City { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CompanyName ; 
#else
    public string? CompanyName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _ContactName ; 
#else
    public string? ContactName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Relationship ; 
#else
    public string? Relationship { get; set; }
#endif
}



