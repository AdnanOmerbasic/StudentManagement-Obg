# StudentManagement-Obg
I anledning af den første obligatoriske opgave i Database for Developer, har jeg oprettet et repository som viser to database tilgange
Først og fremmest - Change based, hvor jeg har anvendt Entity framework
Dernæst - State based, hvor jeg har anvendt sql scripts der viser det desired state per version

# Changed based med Entity framework
I changed based migrations har jeg primært gjort brug af tre forskellige commands - Bruger et eksempel forneden:

1. dotnet ef migrations add AddMiddleName
2. dotnet ef migrations script InitialSchema AddMiddleName -o artifacts-db/ef/v2_AddMiddleName.sql
3. dotnet ef database update

For at komme igang med Entity framework har jeg først og fremmest oprettet en Console App
Dernæst har jeg installeret to NuGet packages:

1. Entity framework SqlServer
2. Entity framework Design

# Ikke destruktiv valg
Begrundelse for mit valg af gå den ikke destruktive vej er primært:
For at kunne bevare data, og ikke miste data ved ændring så eksisterende rækker ikke bliver påvirket
Udover det kan jeg bedst lide at ikke lave noget destruktivt eftersom det kan skabe flere problemer
Føler også ikke destruktivt er mere fremtidssikkert

Den måde jeg har gjort det ikke destruktivt er ved at lave nullable felter og rename attributter frem for at droppe

# State based med sql scripts
I state based så har jeg valgt at lave sql scripts per version der viser den desired state i hver version
Dog har jeg lavet dem meget simple, så hvis man skal køre mine sql scripts, så skal man kører den sidste version mod en helt tom database

# Ikke destruktiv valg
Begrundelse for valg af at ikke gå den destruktive vej med State based er stort set den samme årsag foroven
Dog er min måde måske en lille smule destruktiv hvis man ikke køre mod en helt tom database, hvilket ikke er helt så godt

# Alternativer jeg kunne have kørt med state based
Jeg overvejede kraftigt at bruge Supabase, da man både kan køre state based og change based, hvis jeg ikke tager helt fejl.
Og man vil måske normalt også bruge et database framework eller værktøj til state based, men endte med at skrive sql scripts for at holde det simpelt

# Branches
Jeg har lavet branches for hver version i change based og state based, hvor hver branch blev merged til master ved brug af squash and merge
Lille eksempel på, hvordan min branches ser ud for både change based og state based:

feat/initial-schema-ef
feat/initial-schema-state 

# artifacts-db
Herinde ligger både mine change based scripts og mine state based scripts

Change based under ef mappen

State based under state mappen

