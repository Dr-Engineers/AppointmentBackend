namespace Appointment.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        AppointmentDate = c.DateTime(nullable: false),
                        AppointmentStatus = c.Int(nullable: false),
                        PetId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        Prescription_PrescriptionId = c.Int(),
                        Recommendation_RecommendationId = c.Int(),
                        Symptom_SymptomId = c.Int(),
                        Test_TestId = c.Int(),
                        Vital_VitalId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.Prescriptions", t => t.Prescription_PrescriptionId)
                .ForeignKey("dbo.Recommendations", t => t.Recommendation_RecommendationId)
                .ForeignKey("dbo.Symptoms", t => t.Symptom_SymptomId)
                .ForeignKey("dbo.Tests", t => t.Test_TestId)
                .ForeignKey("dbo.Vitals", t => t.Vital_VitalId)
                .Index(t => t.Prescription_PrescriptionId)
                .Index(t => t.Recommendation_RecommendationId)
                .Index(t => t.Symptom_SymptomId)
                .Index(t => t.Test_TestId)
                .Index(t => t.Vital_VitalId);
            
            CreateTable(
                "dbo.PetIssueAssociations",
                c => new
                    {
                        PetIssueAssociationID = c.Int(nullable: false, identity: true),
                        PredefinedPetIssueID = c.Int(nullable: false),
                        Appointment_AppointmentId = c.Int(),
                    })
                .PrimaryKey(t => t.PetIssueAssociationID)
                .ForeignKey("dbo.Appointments", t => t.Appointment_AppointmentId)
                .Index(t => t.Appointment_AppointmentId);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.PrescriptionId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        MedicineID = c.Int(nullable: false, identity: true),
                        MedID = c.Int(nullable: false),
                        Days = c.Int(nullable: false),
                        Morning = c.Boolean(nullable: false),
                        Afternoon = c.Boolean(nullable: false),
                        Night = c.Boolean(nullable: false),
                        BeforeFood = c.Boolean(nullable: false),
                        Comments = c.String(),
                        Prescription_PrescriptionId = c.Int(),
                    })
                .PrimaryKey(t => t.MedicineID)
                .ForeignKey("dbo.Prescriptions", t => t.Prescription_PrescriptionId)
                .Index(t => t.Prescription_PrescriptionId);
            
            CreateTable(
                "dbo.Recommendations",
                c => new
                    {
                        RecommendationId = c.Int(nullable: false, identity: true),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.RecommendationId);
            
            CreateTable(
                "dbo.RecommendedClinics",
                c => new
                    {
                        RecommendedClinicID = c.Int(nullable: false, identity: true),
                        ClinicID = c.Int(nullable: false),
                        Recommendation_RecommendationId = c.Int(),
                    })
                .PrimaryKey(t => t.RecommendedClinicID)
                .ForeignKey("dbo.Recommendations", t => t.Recommendation_RecommendationId)
                .Index(t => t.Recommendation_RecommendationId);
            
            CreateTable(
                "dbo.RecommendedDoctors",
                c => new
                    {
                        RecommendedDoctorsID = c.Int(nullable: false, identity: true),
                        DoctorID = c.Int(nullable: false),
                        Recommendation_RecommendationId = c.Int(),
                    })
                .PrimaryKey(t => t.RecommendedDoctorsID)
                .ForeignKey("dbo.Recommendations", t => t.Recommendation_RecommendationId)
                .Index(t => t.Recommendation_RecommendationId);
            
            CreateTable(
                "dbo.Symptoms",
                c => new
                    {
                        SymptomId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.SymptomId);
            
            CreateTable(
                "dbo.SymptomAssociations",
                c => new
                    {
                        SymptomAssociationID = c.Int(nullable: false, identity: true),
                        PredefinedSymptom = c.Int(nullable: false),
                        Symptom_SymptomId = c.Int(),
                    })
                .PrimaryKey(t => t.SymptomAssociationID)
                .ForeignKey("dbo.Symptoms", t => t.Symptom_SymptomId)
                .Index(t => t.Symptom_SymptomId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        TestId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TestId);
            
            CreateTable(
                "dbo.TestAssociations",
                c => new
                    {
                        TestAssociationID = c.Int(nullable: false, identity: true),
                        PredefinedTestID = c.Int(nullable: false),
                        Test_TestId = c.Int(),
                    })
                .PrimaryKey(t => t.TestAssociationID)
                .ForeignKey("dbo.Tests", t => t.Test_TestId)
                .Index(t => t.Test_TestId);
            
            CreateTable(
                "dbo.Vitals",
                c => new
                    {
                        VitalId = c.Int(nullable: false, identity: true),
                        BPM = c.Int(nullable: false),
                        Temp = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VitalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Vital_VitalId", "dbo.Vitals");
            DropForeignKey("dbo.Appointments", "Test_TestId", "dbo.Tests");
            DropForeignKey("dbo.TestAssociations", "Test_TestId", "dbo.Tests");
            DropForeignKey("dbo.Appointments", "Symptom_SymptomId", "dbo.Symptoms");
            DropForeignKey("dbo.SymptomAssociations", "Symptom_SymptomId", "dbo.Symptoms");
            DropForeignKey("dbo.Appointments", "Recommendation_RecommendationId", "dbo.Recommendations");
            DropForeignKey("dbo.RecommendedDoctors", "Recommendation_RecommendationId", "dbo.Recommendations");
            DropForeignKey("dbo.RecommendedClinics", "Recommendation_RecommendationId", "dbo.Recommendations");
            DropForeignKey("dbo.Appointments", "Prescription_PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Medicines", "Prescription_PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.PetIssueAssociations", "Appointment_AppointmentId", "dbo.Appointments");
            DropIndex("dbo.TestAssociations", new[] { "Test_TestId" });
            DropIndex("dbo.SymptomAssociations", new[] { "Symptom_SymptomId" });
            DropIndex("dbo.RecommendedDoctors", new[] { "Recommendation_RecommendationId" });
            DropIndex("dbo.RecommendedClinics", new[] { "Recommendation_RecommendationId" });
            DropIndex("dbo.Medicines", new[] { "Prescription_PrescriptionId" });
            DropIndex("dbo.PetIssueAssociations", new[] { "Appointment_AppointmentId" });
            DropIndex("dbo.Appointments", new[] { "Vital_VitalId" });
            DropIndex("dbo.Appointments", new[] { "Test_TestId" });
            DropIndex("dbo.Appointments", new[] { "Symptom_SymptomId" });
            DropIndex("dbo.Appointments", new[] { "Recommendation_RecommendationId" });
            DropIndex("dbo.Appointments", new[] { "Prescription_PrescriptionId" });
            DropTable("dbo.Vitals");
            DropTable("dbo.TestAssociations");
            DropTable("dbo.Tests");
            DropTable("dbo.SymptomAssociations");
            DropTable("dbo.Symptoms");
            DropTable("dbo.RecommendedDoctors");
            DropTable("dbo.RecommendedClinics");
            DropTable("dbo.Recommendations");
            DropTable("dbo.Medicines");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.PetIssueAssociations");
            DropTable("dbo.Appointments");
        }
    }
}
