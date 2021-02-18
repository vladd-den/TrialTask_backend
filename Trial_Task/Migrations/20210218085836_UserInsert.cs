using Microsoft.EntityFrameworkCore.Migrations;

namespace Trial_Task.Migrations
{
    public partial class UserInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Neil', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('John', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Thomas', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Angela', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Mary', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Ian', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Iana', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Kelly', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Sasha', 0)");
            migrationBuilder.Sql("INSERT INTO Users(Name, Active) VALUES ('Dimitry', 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
