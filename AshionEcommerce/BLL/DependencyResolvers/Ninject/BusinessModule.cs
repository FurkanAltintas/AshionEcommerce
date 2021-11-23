using BLL.Abstract;
using BLL.Concrete;
using DAL.Abstract;
using DAL.Concrete;
using DAL.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBrandService>().To<BrandManager>().InSingletonScope();
            Bind<IBrandDal>().To<EfBrandRepository>();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<EfCategoryRepository>();

            Bind<ICollectionService>().To<CollectionManager>().InSingletonScope();
            Bind<ICollectionDal>().To<EfCollectionRepository>();

            Bind<IColorService>().To<ColorManager>().InSingletonScope();
            Bind<IColorDal>().To<EfColorRepository>();

            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
            Bind<ICommentDal>().To<EfCommentRepository>();

            Bind<IGenderService>().To<GenderManager>().InSingletonScope();
            Bind<IGenderDal>().To<EfGenderRepository>();

            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductRepository>();

            Bind<IProductSizeService>().To<ProductSizeManager>().InSingletonScope();
            Bind<IProductSizeDal>().To<EfProductSizeRepository>();

            Bind<IServiceService>().To<ServiceManager>().InSingletonScope();
            Bind<IServiceDal>().To<EfServiceRepository>();

            Bind<ISizeService>().To<SizeManager>().InSingletonScope();
            Bind<ISizeDal>().To<EfSizeRepository>();

            Bind<IUserService>().To<UserManager>().InSingletonScope();
            Bind<IUserDal>().To<EfUserRepository>();



            Bind(typeof(IQueryable<>)).To<EfQueryable>();
            Bind<DbContext>().To<Context>();
        }
    }
}
