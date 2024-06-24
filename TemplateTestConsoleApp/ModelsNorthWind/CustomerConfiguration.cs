#if NET8_0_OR_GREATER

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TemplateTestConsoleApp.ModelsNorthWind;

#if MVVM
using CommunityToolkit.Mvvm.ComponentModel;
#endif



namespace TemplateTestConsoleApp.ModelsNorthWind;

public partial class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Customer> builder);


    public void Configure(EntityTypeBuilder<Customer> builder)
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

public partial class Customer
{


#if MVVM
    [ObservableProperty]
    private ObservableDictionary<string, object>? _ExtPropDynamic = new ObservableDictionary<string, object>();
#else
    public ObservableDictionary<string, object>? ExtPropDynamic { get; set; } = new ObservableDictionary<string, object>();
#endif



#if MVVM
    [ObservableProperty]
    private CustomerExtProp? _ExtProp;
#else
    public CustomerExtProp? ExtProp { get; set; }
#endif

 
    public string? ExtPropAsString { get { if (ExtProp != null) return System.Text.Json.JsonSerializer.Serialize (ExtProp)  ;  else return null; }  }

}




public partial class CustomerExtProp
{

}

#endif

#endif
