using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;

namespace Database8.Models;

public partial class Prod1 : ObservableObject
{
    public string ProdId { get; set; } = null!;

    public string CatId { get; set; } = null!;
    //public DateTime HireDate { get; set => field = value.Date; }

    [ObservableProperty]
    private string _CatId1;


   // public virtual Cat Cat { get; set; } = null!;
}
