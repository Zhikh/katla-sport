namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Adding column for dbo.catalogue_products
    /// </summary>
    public partial class AddProductPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.catalogue_products", "product_price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }

        public override void Down()
        {
            DropColumn("dbo.catalogue_products", "product_price");
        }
    }
}
