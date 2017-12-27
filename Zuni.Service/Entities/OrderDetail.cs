using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuni.Service.Entities
{
    public class OrderDetail
    {
        public System.Int32 OrderNumber { get; set; }

        public System.Int32 ShoppingCartRecId { get; set; }

        public System.Int32 CustomerId { get; set; }

        public System.Int32 ProductId { get; set; }

        public System.Int32 VariantId { get; set; }

        public System.Int32 Quantity { get; set; }

        public System.String ChosenColor { get; set; }

        public System.String ChosenColorSkuModifier { get; set; }

        public System.String ChosenSize { get; set; }

        public System.String ChosenSizeSkuModifier { get; set; }

        public System.String OrderedProductName { get; set; }

        public System.String OrderedProductVariantName { get; set; }

        public System.String OrderedProductSku { get; set; }

        public System.String OrderedProductManufacturerPartNumber { get; set; }

        public System.Decimal? OrderedProductWeight { get; set; }

        public System.Decimal? OrderedProductPrice { get; set; }

        public System.Decimal? OrderedProductRegularPrice { get; set; }

        public System.Decimal? OrderedProductSalePrice { get; set; }

        public System.Decimal? OrderedProductExtendedPrice { get; set; }

        public System.String OrderedProductQuantityDiscountName { get; set; }

        public System.Int32? OrderedProductQuantityDiscountId { get; set; }

        public System.Decimal? OrderedProductQuantityDiscountPercent { get; set; }

        public System.Byte IsTaxable { get; set; }

        public System.Byte IsShipSeparately { get; set; }

        public System.Byte IsDownload { get; set; }

        public System.String DownloadLocation { get; set; }

        public System.Byte FreeShipping { get; set; }

        public System.Byte IsSecureAttachment { get; set; }

        public System.String TextOption { get; set; }

        public System.Int32 CartType { get; set; }

        public System.Int32? SubscriptionInterval { get; set; }

        public System.Int32 ShippingAddressId { get; set; }

        public System.String ShippingDetail { get; set; }

        public System.Int32? ShippingMethodId { get; set; }

        public System.String ShippingMethod { get; set; }

        public System.Int32? DistributorId { get; set; }

        public System.Int32? GiftRegistryForCustomerId { get; set; }

        public System.String Notes { get; set; }

        public System.DateTime? DistributorEmailSentOn { get; set; }

        public System.String ExtensionData { get; set; }

        public System.String SizeOptionPrompt { get; set; }

        public System.String ColorOptionPrompt { get; set; }

        public System.String TextOptionPrompt { get; set; }

        public System.DateTime CreatedOn { get; set; }

        public System.Int32 SubscriptionIntervalType { get; set; }

        public System.Byte CustomerEntersPrice { get; set; }

        public System.String CustomerEntersPricePrompt { get; set; }

        public System.Byte? IsAkit { get; set; }

        public System.Byte? IsApack { get; set; }

        public System.Byte? IsSystem { get; set; }

        public System.Int32 TaxClassId { get; set; }

        public System.Decimal TaxRate { get; set; }

    }
}
