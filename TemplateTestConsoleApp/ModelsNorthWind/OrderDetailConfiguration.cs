#if NET8_0_OR_GREATER

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemplateTestConsoleApp.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace TemplateTestConsoleApp.ModelsNorthWind;

public partial class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<OrderDetail> builder);


    public void Configure(EntityTypeBuilder<OrderDetail> builder)
    {

#if EXT_PROP
        builder.OwnsOne(x => x.ExtProp, cb =>
        {
            
            cb.ToJson();
            
        });
#endif
        MoreBuilderCalls (builder) ;


    }
}


#if EXT_PROP

public partial class OrderDetail
{


#if MVVM
    [ObservableProperty]
    private ObservableDictionary<string, object>? _ExtPropDynamic = new ObservableDictionary<string, object>();
#else
    public ObservableDictionary<string, object>? ExtPropDynamic { get; set; } = new ObservableDictionary<string, object>();
#endif



#if MVVM
    [ObservableProperty]
    private OrderDetailExtProp? _ExtProp;
#else
    public OrderDetailExtProp? ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }

}




public partial class OrderDetailExtProp
{

}

#endif

#endif
