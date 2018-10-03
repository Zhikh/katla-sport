namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Adding column for dbo.catalogue_products
    /// </summary>
    public partial class AddProductManCode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.catalogue_products", "product_manufacturer_code", c => c.String(maxLength: 10));
        }

        public override void Down()
        {
            DropColumn("dbo.catalogue_products", "product_manufacturer_code");
        }
    }
}
