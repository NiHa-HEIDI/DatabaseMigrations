using FluentMigrator;

namespace DatabaseMigrations.Migrations
{
    [Migration(20240806065115365)]
    public class ChangeContainerTableNames: Migration
    {
        public override void Up()
        {
            string sql =
               @"
               RENAME TABLE shops TO containers,
                shop_owners TO container_owners,
                sellers TO container_sellers,
                store_categories TO container_categories,
                store_sub_categories TO container_sub_categories,
                products TO container_products,
                shelves TO container_shelves,
                productimages TO container_product_images,
                cart TO container_cart,
                cartitems TO container_cart_items,
                paymentstatus TO container_payment_status,
                payments TO container_payments,
                orders TO container_orders,
                sellrequests TO container_seller_requests,
                shopcheckins TO container_checkins,
                product_requests TO container_product_requests,
                report_product TO container_report_product,
                card_account TO container_card_account,
                store_card TO container_card,
                store_card_transaction TO container_card_transaction,
                store_store_categories_mapping TO container_container_categories_mapping,
                store_store_sub_categories_mapping TO container_container_sub_categories_mapping,
                shops_secret_keys TO container_secret_keys,
                product_request_images TO container_product_request_images;
               ";
            Execute.Sql(sql);
        }

        public override void Down()
        {
            string sql =
               @"
                RENAME TABLE containers TO shops,
                    container_owners TO shop_owners,
                    container_sellers TO sellers,
                    container_categories TO store_categories,
                    container_sub_categories TO store_sub_categories,
                    container_products TO products,
                    container_shelves TO shelves,
                    container_product_images TO productimages,
                    container_cart TO cart,
                    container_cart_items TO cartitems,
                    container_payment_status TO paymentstatus,
                    container_payments TO payments,
                    container_orders TO orders,
                    container_seller_requests TO sellrequests,
                    container_checkins TO shopcheckins,
                    container_product_requests TO product_requests,
                    container_report_product TO report_product,
                    container_card_account TO card_account,
                    container_card TO store_card,
                    container_card_transaction TO store_card_transaction,
                    container_container_categories_mapping TO store_store_categories_mapping,
                    container_container_sub_categories_mapping TO store_store_sub_categories_mapping,
                    container_secret_keys TO shops_secret_keys,
                    container_product_request_images TO product_request_images;
               ";

            Execute.Sql(sql);
        }
    }
}
