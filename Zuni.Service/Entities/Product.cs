using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuni.Service.Entities
{
    public class Product
    {
        public System.Int32 ProductId { get; set; }

        public System.Guid ProductGuid { get; set; }

        public System.String Name { get; set; }

        public System.String Summary { get; set; }

        public System.String Description { get; set; }

        public System.String SeKeywords { get; set; }

        public System.String SeDescription { get; set; }

        public System.String SpecTitle { get; set; }

        public System.String MiscText { get; set; }

        public System.String SwatchImageMap { get; set; }

        public System.String IsFeaturedTeaser { get; set; }

        public System.String FroogleDescription { get; set; }

        public System.String SeTitle { get; set; }

        public System.String SeNoScript { get; set; }

        public System.String SeAltText { get; set; }

        public System.String SizeOptionPrompt { get; set; }

        public System.String ColorOptionPrompt { get; set; }

        public System.String TextOptionPrompt { get; set; }

        public System.Int32 ProductTypeId { get; set; }

        public System.Int32 TaxClassId { get; set; }

        public System.String Sku { get; set; }

        public System.String ManufacturerPartNumber { get; set; }

        public System.Int32 SalesPromptId { get; set; }

        public System.String SpecCall { get; set; }

        public System.Byte SpecsInline { get; set; }

        public System.Byte IsFeatured { get; set; }

        public System.String XmlPackage { get; set; }

        public System.Int32 ColWidth { get; set; }

        public System.Byte Published { get; set; }

        public System.Byte Wholesale { get; set; }

        public System.Byte RequiresRegistration { get; set; }

        public System.Int32 Looks { get; set; }

        public System.String Notes { get; set; }

        public System.Int32? QuantityDiscountId { get; set; }

        public System.String RelatedProducts { get; set; }

        public System.String UpsellProducts { get; set; }

        public System.Decimal UpsellProductDiscountPercentage { get; set; }

        public System.String RelatedDocuments { get; set; }

        public System.Byte TrackInventoryBySizeAndColor { get; set; }

        public System.Byte TrackInventoryBySize { get; set; }

        public System.Byte TrackInventoryByColor { get; set; }

        public System.Byte IsAkit { get; set; }

        public System.Int32 ShowInProductBrowser { get; set; }

        public System.Int32 IsApack { get; set; }

        public System.Int32 PackSize { get; set; }

        public System.Int32 ShowBuyButton { get; set; }

        public System.String RequiresProducts { get; set; }

        public System.Byte HidePriceUntilCart { get; set; }

        public System.Byte IsCalltoOrder { get; set; }

        public System.Byte ExcludeFromPriceFeeds { get; set; }

        public System.Byte RequiresTextOption { get; set; }

        public System.Int32? TextOptionMaxLength { get; set; }

        public System.String SeName { get; set; }

        public System.String ExtensionData { get; set; }

        public System.String ExtensionData2 { get; set; }

        public System.String ExtensionData3 { get; set; }

        public System.String ExtensionData4 { get; set; }

        public System.String ExtensionData5 { get; set; }

        public System.String ContentsBgColor { get; set; }

        public System.String PageBgColor { get; set; }

        public System.String GraphicsColor { get; set; }

        public System.String ImageFilenameOverride { get; set; }

        public System.Byte IsImport { get; set; }

        public System.Byte IsSystem { get; set; }

        public System.Byte Deleted { get; set; }

        public System.DateTime CreatedOn { get; set; }

        public System.Int32 PageSize { get; set; }

        public System.String WarehouseLocation { get; set; }

        public System.DateTime AvailableStartDate { get; set; }

        public System.DateTime? AvailableStopDate { get; set; }

        public System.Byte GoogleCheckoutAllowed { get; set; }

        public System.Int32 SkinId { get; set; }

        public System.String TemplateName { get; set; }

        public System.Decimal? StichedPrice { get; set; }

        public System.Decimal? Costinrupee { get; set; }

        public System.Decimal? Costindollar { get; set; }

        public System.Decimal? Profitpriceinrupee { get; set; }

        public System.Decimal? Profitpriceindollar { get; set; }

        public System.Decimal? Profit { get; set; }

        public bool InStock { get; set; }
    }
}
