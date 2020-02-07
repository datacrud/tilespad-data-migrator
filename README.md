# TilesPad Data Migrator
A migration tools to migrate the standalone application data to SaaS platform


### Model Reverse Engineering Command
Scaffold-DbContext "Server=.\SQLExpress;Database=YourDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
