using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class onetomany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DoctorClassPatientClass",
                columns: table => new
                {
                    DoctorsId = table.Column<int>(type: "int", nullable: false),
                    PatientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorClassPatientClass", x => new { x.DoctorsId, x.PatientId });
                    table.ForeignKey(
                        name: "FK_DoctorClassPatientClass_Doctors_DoctorsId",
                        column: x => x.DoctorsId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorClassPatientClass_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_routes_DoctorId",
                table: "routes",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_routes_PatientId",
                table: "routes",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorClassPatientClass_PatientId",
                table: "DoctorClassPatientClass",
                column: "PatientId");

            migrationBuilder.AddForeignKey(
                name: "FK_routes_Doctors_DoctorId",
                table: "routes",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_routes_Patients_PatientId",
                table: "routes",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_routes_Doctors_DoctorId",
                table: "routes");

            migrationBuilder.DropForeignKey(
                name: "FK_routes_Patients_PatientId",
                table: "routes");

            migrationBuilder.DropTable(
                name: "DoctorClassPatientClass");

            migrationBuilder.DropIndex(
                name: "IX_routes_DoctorId",
                table: "routes");

            migrationBuilder.DropIndex(
                name: "IX_routes_PatientId",
                table: "routes");
        }
    }
}
