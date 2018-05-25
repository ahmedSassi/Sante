namespace Exam.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        IDAdmin = c.Int(nullable: false, identity: true),
                        Nom = c.String(unicode: false),
                        Prenom = c.String(unicode: false),
                        Mail = c.String(unicode: false),
                        Num_Tel = c.Int(nullable: false),
                        Sexe = c.String(unicode: false),
                        Date_Inscription = c.DateTime(nullable: false, precision: 0),
                        Login = c.String(unicode: false),
                        MotDePasse = c.String(unicode: false),
                        Actif = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IDAdmin);
            
            CreateTable(
                "dbo.Formations",
                c => new
                    {
                        IDFormation = c.Int(nullable: false, identity: true),
                        NomFormation = c.String(unicode: false),
                        DatetFormation = c.DateTime(nullable: false, precision: 0),
                        Capacite = c.String(unicode: false),
                        AdresseLocal = c.String(unicode: false),
                        Admin_IDAdmin = c.Int(),
                        categorie_IDCategorieFormation = c.Int(),
                        Profil_Santé_IDProfilSanté = c.Int(),
                    })
                .PrimaryKey(t => t.IDFormation)
                .ForeignKey("dbo.Admins", t => t.Admin_IDAdmin)
                .ForeignKey("dbo.Categorie_Formation", t => t.categorie_IDCategorieFormation)
                .ForeignKey("dbo.Profil_Santé", t => t.Profil_Santé_IDProfilSanté)
                .Index(t => t.Admin_IDAdmin)
                .Index(t => t.categorie_IDCategorieFormation)
                .Index(t => t.Profil_Santé_IDProfilSanté);
            
            CreateTable(
                "dbo.Categorie_Formation",
                c => new
                    {
                        IDCategorieFormation = c.Int(nullable: false, identity: true),
                        NomCategorieFormation = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IDCategorieFormation);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        IDPatient = c.Int(nullable: false, identity: true),
                        Nom = c.String(unicode: false),
                        Prenom = c.String(unicode: false),
                        Mail = c.String(unicode: false),
                        Num_Tel = c.Int(nullable: false),
                        Sexe = c.String(unicode: false),
                        Date_Inscription = c.DateTime(nullable: false, precision: 0),
                        Login = c.String(unicode: false),
                        MotDePasse = c.String(unicode: false),
                        Actif = c.String(unicode: false),
                        Formation_IDFormation = c.Int(),
                    })
                .PrimaryKey(t => t.IDPatient)
                .ForeignKey("dbo.Formations", t => t.Formation_IDFormation)
                .Index(t => t.Formation_IDFormation);
            
            CreateTable(
                "dbo.Commentaires",
                c => new
                    {
                        IDPatient = c.Int(nullable: false),
                        IDProduit_Medicaux = c.Int(nullable: false),
                        Description = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        datecommentaire = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => new { t.IDPatient, t.IDProduit_Medicaux, t.Description })
                .ForeignKey("dbo.Patients", t => t.IDPatient, cascadeDelete: true)
                .ForeignKey("dbo.Produit_Medicaux", t => t.IDProduit_Medicaux, cascadeDelete: true)
                .Index(t => t.IDPatient)
                .Index(t => t.IDProduit_Medicaux);
            
            CreateTable(
                "dbo.Produit_Medicaux",
                c => new
                    {
                        IDProduit_Medicaux = c.Int(nullable: false, identity: true),
                        NomProduit_Medicaux = c.String(unicode: false),
                        Qantite = c.String(unicode: false),
                        Prix = c.Single(nullable: false),
                        IDAdmin = c.Int(nullable: false),
                        Categorie_Medicaments_IDCategorieMedicament = c.Int(),
                    })
                .PrimaryKey(t => t.IDProduit_Medicaux)
                .ForeignKey("dbo.Admins", t => t.IDAdmin, cascadeDelete: true)
                .ForeignKey("dbo.Categorie_Medicaments", t => t.Categorie_Medicaments_IDCategorieMedicament)
                .Index(t => t.IDAdmin)
                .Index(t => t.Categorie_Medicaments_IDCategorieMedicament);
            
            CreateTable(
                "dbo.Categorie_Medicaments",
                c => new
                    {
                        IDCategorieMedicament = c.Int(nullable: false, identity: true),
                        NomCategorieMedicament = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IDCategorieMedicament);
            
            CreateTable(
                "dbo.RDVs",
                c => new
                    {
                        DateRdv = c.DateTime(nullable: false, precision: 0),
                        IDProfilSanté = c.Int(nullable: false),
                        IDPatient = c.Int(nullable: false),
                        DatePriseRdv = c.DateTime(nullable: false, precision: 0),
                    })
                .PrimaryKey(t => new { t.DateRdv, t.IDProfilSanté, t.IDPatient })
                .ForeignKey("dbo.Patients", t => t.IDPatient, cascadeDelete: true)
                .ForeignKey("dbo.Profil_Santé", t => t.IDProfilSanté, cascadeDelete: true)
                .Index(t => t.IDProfilSanté)
                .Index(t => t.IDPatient);
            
            CreateTable(
                "dbo.Profil_Santé",
                c => new
                    {
                        IDProfilSanté = c.Int(nullable: false, identity: true),
                        Nom = c.String(unicode: false),
                        Prenom = c.String(unicode: false),
                        Mail = c.String(unicode: false),
                        Num_Tel = c.Int(nullable: false),
                        Sexe = c.String(unicode: false),
                        Date_Inscription = c.DateTime(nullable: false, precision: 0),
                        Login = c.String(unicode: false),
                        MotDePasse = c.String(unicode: false),
                        Actif = c.String(unicode: false),
                        Adresse = c.String(unicode: false),
                        categorie_IdCategorieProfilSante = c.Int(),
                    })
                .PrimaryKey(t => t.IDProfilSanté)
                .ForeignKey("dbo.Categorie_Profil_Santé", t => t.categorie_IdCategorieProfilSante)
                .Index(t => t.categorie_IdCategorieProfilSante);
            
            CreateTable(
                "dbo.Categorie_Profil_Santé",
                c => new
                    {
                        IdCategorieProfilSante = c.Int(nullable: false, identity: true),
                        NomCategorieProfilSante = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdCategorieProfilSante);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Formations", "Profil_Santé_IDProfilSanté", "dbo.Profil_Santé");
            DropForeignKey("dbo.Patients", "Formation_IDFormation", "dbo.Formations");
            DropForeignKey("dbo.RDVs", "IDProfilSanté", "dbo.Profil_Santé");
            DropForeignKey("dbo.Profil_Santé", "categorie_IdCategorieProfilSante", "dbo.Categorie_Profil_Santé");
            DropForeignKey("dbo.RDVs", "IDPatient", "dbo.Patients");
            DropForeignKey("dbo.Commentaires", "IDProduit_Medicaux", "dbo.Produit_Medicaux");
            DropForeignKey("dbo.Produit_Medicaux", "Categorie_Medicaments_IDCategorieMedicament", "dbo.Categorie_Medicaments");
            DropForeignKey("dbo.Produit_Medicaux", "IDAdmin", "dbo.Admins");
            DropForeignKey("dbo.Commentaires", "IDPatient", "dbo.Patients");
            DropForeignKey("dbo.Formations", "categorie_IDCategorieFormation", "dbo.Categorie_Formation");
            DropForeignKey("dbo.Formations", "Admin_IDAdmin", "dbo.Admins");
            DropIndex("dbo.Profil_Santé", new[] { "categorie_IdCategorieProfilSante" });
            DropIndex("dbo.RDVs", new[] { "IDPatient" });
            DropIndex("dbo.RDVs", new[] { "IDProfilSanté" });
            DropIndex("dbo.Produit_Medicaux", new[] { "Categorie_Medicaments_IDCategorieMedicament" });
            DropIndex("dbo.Produit_Medicaux", new[] { "IDAdmin" });
            DropIndex("dbo.Commentaires", new[] { "IDProduit_Medicaux" });
            DropIndex("dbo.Commentaires", new[] { "IDPatient" });
            DropIndex("dbo.Patients", new[] { "Formation_IDFormation" });
            DropIndex("dbo.Formations", new[] { "Profil_Santé_IDProfilSanté" });
            DropIndex("dbo.Formations", new[] { "categorie_IDCategorieFormation" });
            DropIndex("dbo.Formations", new[] { "Admin_IDAdmin" });
            DropTable("dbo.Categorie_Profil_Santé");
            DropTable("dbo.Profil_Santé");
            DropTable("dbo.RDVs");
            DropTable("dbo.Categorie_Medicaments");
            DropTable("dbo.Produit_Medicaux");
            DropTable("dbo.Commentaires");
            DropTable("dbo.Patients");
            DropTable("dbo.Categorie_Formation");
            DropTable("dbo.Formations");
            DropTable("dbo.Admins");
        }
    }
}
