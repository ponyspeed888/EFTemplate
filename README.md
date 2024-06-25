[![Hits](https://hits.seeyoufarm.com/api/count/incr/badge.svg?url=https%3A%2F%2Fgithub.com%2Fponyspeed888%2FMVC8ProjectTemplate&count_bg=%2379C83D&title_bg=%23555555&icon=&icon_color=%23E7E7E7&title=hits&edge_flat=false)](https://hits.seeyoufarm.com)

This project is a drop in replacement of Microsoft.EntityFrameworkCore.Templates
It has the following changes :

* Add debug support, so that you can debug using Debugger.Launch
* Allow you to specify which entity want to use EntityTypeConfiguration file
* MVVM toolkit support
* Generate dynamic properties per entity, using EF Core 8 Json column or dictionary (To be added)
* 



To specify which entity to generate config file look for this line

    string [] UseConfigure = new string [] { "Order", "OrderDetail"} ;

and fill with the entity names you want to generate config file.  The generate config file is like :


public partial class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    partial void MoreBuilderCalls (EntityTypeBuilder<Order> builder);


    public void Configure(EntityTypeBuilder<Order> builder)
    {

        MoreBuilderCalls (builder) ;


    }
}

So just implement the partial method MoreBuilderCalls in another manually created class, so that it won't be overwritten when regenerating




