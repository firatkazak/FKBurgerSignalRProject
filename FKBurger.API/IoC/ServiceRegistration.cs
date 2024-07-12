using FKBurger.DataAccess.Abstract;
using FKBurger.DataAccess.EntityFramework;
using FKBurger.Business.Abstract;
using FKBurger.Business.Concrete;

namespace FKBurger.API.IoC;
public static class ServiceRegistration
{
    public static void AddIoCServices(this IServiceCollection builder)
    {
        builder.AddScoped<IAboutDAL, EFAboutDAL>();
        builder.AddScoped<IAboutService, AboutManager>();

        builder.AddScoped<IBasketDAL, EFBasketDAL>();
        builder.AddScoped<IBasketService, BasketManager>();

        builder.AddScoped<IBookingDAL, EFBookingDAL>();
        builder.AddScoped<IBookingService, BookingManager>();

        builder.AddScoped<ICategoryDAL, EFCategoryDAL>();
        builder.AddScoped<ICategoryService, CategoryManager>();

        builder.AddScoped<IContactDAL, EFContactDAL>();
        builder.AddScoped<IContactService, ContactManager>();

        builder.AddScoped<IDiscountDAL, EFDiscountDAL>();
        builder.AddScoped<IDiscountService, DiscountManager>();

        builder.AddScoped<IFeatureDAL, EFFeatureDAL>();
        builder.AddScoped<IFeatureService, FeatureManager>();

        builder.AddScoped<IMenuTableDAL, EFMenuTableDAL>();
        builder.AddScoped<IMenuTableService, MenuTableManager>();

        builder.AddScoped<IMessageDAL, EFMessageDAL>();
        builder.AddScoped<IMessageService, MessageManager>();

        builder.AddScoped<IMoneyCaseDAL, EFMoneyCaseDAL>();
        builder.AddScoped<IMoneyCaseService, MoneyCaseManager>();

        builder.AddScoped<INotificationDAL, EFNotificationDAL>();
        builder.AddScoped<INotificationService, NotificationManager>();

        builder.AddScoped<IOrderDAL, EFOrderDAL>();
        builder.AddScoped<IOrderService, OrderManager>();

        builder.AddScoped<IOrderDetailDAL, EFOrderDetailDAL>();
        builder.AddScoped<IOrderDetailService, OrderDetailManager>();

        builder.AddScoped<IProductDAL, EFProductDAL>();
        builder.AddScoped<IProductService, ProductManager>();

        builder.AddScoped<ISliderDAL, EFSliderDAL>();
        builder.AddScoped<ISliderService, SliderManager>();

        builder.AddScoped<ISocialMediaDAL, EFSocialMediaDAL>();
        builder.AddScoped<ISocialMediaService, SocialMediaManager>();

        builder.AddScoped<ITestimonialDAL, EFTestimonialDAL>();
        builder.AddScoped<ITestimonialService, TestimonialManager>();
    }
}
