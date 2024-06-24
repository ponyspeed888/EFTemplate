using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;

[Table("ExtPropDef")]
[Index("TableName", "KeyName", Name = "UniqueTableNameKeyName", IsUnique = true)]


public partial class ExtPropDef
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
   [property:Column("ExtPropDictID")]
#else
   [Column("ExtPropDictID")]
#endif

#if MVVM
    [ObservableProperty]
    private int _ExtPropDictId ; 
#else
    public int ExtPropDictId { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "NVARCHAR(128)")]
#else
   [Column(TypeName = "NVARCHAR(128)")]
#endif

#if MVVM
    [ObservableProperty]
    private string _TableName  = null!; 
#else
    public string TableName { get; set; } = null!;
#endif

#if MVVM
   [property:Column(TypeName = "NVARCHAR(128)")]
#else
   [Column(TypeName = "NVARCHAR(128)")]
#endif

#if MVVM
    [ObservableProperty]
    private string _KeyName  = null!; 
#else
    public string KeyName { get; set; } = null!;
#endif

#if MVVM
   [property:Column(TypeName = "NVARCHAR(128)")]
#else
   [Column(TypeName = "NVARCHAR(128)")]
#endif

#if MVVM
    [ObservableProperty]
    private string? _Category ; 
#else
    public string? Category { get; set; }
#endif

#if MVVM
   [property:Column(TypeName = "NVARCHAR(128)")]
#else
   [Column(TypeName = "NVARCHAR(128)")]
#endif

#if MVVM
    [ObservableProperty]
    private string? _DataType ; 
#else
    public string? DataType { get; set; }
#endif
}



