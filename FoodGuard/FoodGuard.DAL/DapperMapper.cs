using DapperExtensions.Mapper;
using FoodGuard.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodGuard.DAL
{
    public sealed class ProductMapper: ClassMapper<Product>
    {
        public ProductMapper()
        {
            Schema("dbo");
            Table("Product");
            Map(f => f.ProductId).Column("Id").Key(KeyType.Identity);
            Map(f => f.ProductName).Column("Name");
            Map(f => f.Price).Column("Price");
            Map(f => f.ExpirationDate).Column("Expiration");
            Map(f => f.TypeId).Column("TypeID");
            Map(f => f.Photo).Column("Photo");
        }
    }

    public sealed class CharityMapper : ClassMapper<Charity>
    {
        public CharityMapper()
        {
            Schema("dbo");
            Table("Charity");
            Map(f => f.CharityId).Column("Id").Key(KeyType.Identity);
            Map(f => f.Email).Column("Email");
            Map(f => f.Name).Column("Name");
        }
    }

    public sealed class CharityProdTypeMapper : ClassMapper<CharityProdType>
    {
        public CharityProdTypeMapper()
        {
            Schema("dbo");
            Table("CharityProdType");
            Map(f => f.CharityId).Column("CharityID").Key(KeyType.Identity);
            Map(f => f.TypeId).Column("TypeID");
        }
    }

    public sealed class OfferMapper : ClassMapper<Offer>
    {
        public OfferMapper()
        {
            Schema("dbo");
            Table("Offer");
            Map(f => f.OfferId).Column("Id").Key(KeyType.Identity);
            Map(f => f.Percentage).Column("Percentage");
            Map(f => f.ExpirationDate).Column("ExpirationDateOffer");
            Map(f => f.TypeId).Column("TypeID");
        }
    }

    public sealed class ProductOfferMapper : ClassMapper<ProductOffer>
    {
        public ProductOfferMapper()
        {
            Schema("dbo");
            Table("ProductOffer");
            Map(f => f.ProductId).Column("ProductID").Key(KeyType.Identity);
            Map(f => f.OfferId).Column("OfferID");
        }
    }

    public sealed class ProductTypeMapper : ClassMapper<ProductType>
    {
        public ProductTypeMapper()
        {
            Schema("dbo");
            Table("ProductType");
            Map(f => f.ProductTypeId).Column("Id").Key(KeyType.Identity);
            Map(f => f.Name).Column("Name");
            Map(f => f.Code).Column("Code");
        }
    }
}
