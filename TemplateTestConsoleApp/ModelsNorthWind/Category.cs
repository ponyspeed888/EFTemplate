using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;



public partial class Category
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
   [property:Column("CategoryID")]
#else
   [Column("CategoryID")]
#endif

#if MVVM
    [ObservableProperty]
    private int _CategoryId ; 
#else
    public int CategoryId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _CategoryName ; 
#else
    public string? CategoryName { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string? _Description ; 
#else
    public string? Description { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private byte[]? _Picture ; 
#else
    public byte[]? Picture { get; set; }
#endif

    [InverseProperty("Category")]
#if MVVM
    public virtual ICollection<Product> Products { get; set; } = new ObservableCollection<Product>();
#else
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
#endif

}



