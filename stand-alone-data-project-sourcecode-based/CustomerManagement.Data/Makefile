init:
	@dotnet ef migrations add InitialDbMigration -c CustomerManagementDbContext -o Migrations

add:
	@dotnet ef migrations add -c CustomerManagementDbContext -o ./Migrations $$name

update:
	@dotnet ef database update -c CustomerManagementDbContext
	@tail -f /dev/null