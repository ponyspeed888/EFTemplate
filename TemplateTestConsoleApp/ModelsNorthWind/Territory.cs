using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;



public partial class Territory
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
   [property:Column("TerritoryID")]
#else
   [Column("TerritoryID")]
#endif

#if MVVM
    [ObservableProperty]
    private string _TerritoryId  = null!; 
#else
    public string TerritoryId { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string _TerritoryDescription  = null!; 
#else
    public string TerritoryDescription { get; set; } = null!;
#endif

#if MVVM
   [property:Column("RegionID")]
#else
   [Column("RegionID")]
#endif

#if MVVM
    [ObservableProperty]
    private int _RegionId ; 
#else
    public int RegionId { get; set; }
#endif

    [ForeignKey("RegionId")]
    [InverseProperty("Territories")]
    public virtual Region Region { get; set; } = null!;

    [ForeignKey("TerritoryId")]
    [InverseProperty("Territories")]
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}



