using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;



public partial class CustomerDemographic
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
   [property:Column("CustomerTypeID")]
#else
   [Column("CustomerTypeID")]
#endif

#if MVVM
    [ObservableProperty]
    private string _CustomerTypeId  = null!; 
#else
    public string CustomerTypeId { get; set; } = null!;
#endif

#if MVVM
    [ObservableProperty]
    private string? _CustomerDesc ; 
#else
    public string? CustomerDesc { get; set; }
#endif

    [ForeignKey("CustomerTypeId")]
    [InverseProperty("CustomerTypes")]
    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}



