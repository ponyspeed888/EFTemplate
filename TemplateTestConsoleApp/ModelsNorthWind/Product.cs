using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.EntityFrameworkCore;

#nullable enable

namespace TemplateTestConsoleApp.ModelsNorthWind;



public partial class Product
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
   [property:Column("ProductID")]
#else
   [Column("ProductID")]
#endif

#if MVVM
    [ObservableProperty]
    private int _ProductId ; 
#else
    public int ProductId { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string _ProductName  = null!; 
#else
    public string ProductName { get; set; } = null!;
#endif

#if MVVM
   [property:Column("SupplierID")]
#else
   [Column("SupplierID")]
#endif

#if MVVM
    [ObservableProperty]
    private int? _SupplierId ; 
#else
    public int? SupplierId { get; set; }
#endif

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
    private string? _QuantityPerUnit ; 
#else
    public string? QuantityPerUnit { get; set; }
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

#if MVVM
    [ObservableProperty]
    private int? _UnitsInStock ; 
#else
    public int? UnitsInStock { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _UnitsOnOrder ; 
#else
    public int? UnitsOnOrder { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private int? _ReorderLevel ; 
#else
    public int? ReorderLevel { get; set; }
#endif

#if MVVM
    [ObservableProperty]
    private string _Discontinued  = null!; 
#else
    public string Discontinued { get; set; } = null!;
#endif

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual Category? Category { get; set; }

    [InverseProperty("Product")]
#if MVVM
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new ObservableCollection<OrderDetail>();
#else
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
#endif


    [ForeignKey("SupplierId")]
    [InverseProperty("Products")]
    public virtual Supplier? Supplier { get; set; }
}



