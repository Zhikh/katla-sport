namespace KatlaSport.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    /// <summary>
    /// Adding column for dbo.catalogue_products
    /// </summary>
    public partial class AddProductDescription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.catalogue_products", "product_description", c => c.String(maxLength: 300));
        }

        public override void Down()
        {
            DropColumn("dbo.catalogue_products", "product_description");
        }
    }
}
