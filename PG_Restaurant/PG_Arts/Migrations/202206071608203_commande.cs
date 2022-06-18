namespace PG_Arts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class commande : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.affecter",
                c => new
                    {
                        num_srv = c.Int(nullable: false),
                        num_tab = c.Int(nullable: false),
                        date_affect = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.num_srv, t.num_tab });
            
            CreateTable(
                "public.article",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                        pu = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "public.commande",
                c => new
                    {
                        num_cmd = c.Int(nullable: false),
                        num_tab = c.Int(nullable: false),
                        date_com = c.DateTime(nullable: false),
                        nb_personnes = c.Int(nullable: false),
                        heure_paiement = c.String(),
                        mode_paiement = c.String(),
                    })
                .PrimaryKey(t => new { t.num_cmd, t.num_tab });
            
            CreateTable(
                "public.plat",
                c => new
                    {
                        code_plat = c.Int(nullable: false, identity: true),
                        libelle = c.String(),
                        type_plat = c.String(),
                        prix = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.code_plat);
            
            CreateTable(
                "public.serveur",
                c => new
                    {
                        num_srv = c.Int(nullable: false, identity: true),
                        nom = c.String(),
                        prenom = c.String(),
                    })
                .PrimaryKey(t => t.num_srv);
            
            CreateTable(
                "public.tabl",
                c => new
                    {
                        num_tab = c.Int(nullable: false, identity: true),
                        nb_place = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.num_tab);
            
        }
        
        public override void Down()
        {
            DropTable("public.tabl");
            DropTable("public.serveur");
            DropTable("public.plat");
            DropTable("public.commande");
            DropTable("public.article");
            DropTable("public.affecter");
        }
    }
}
